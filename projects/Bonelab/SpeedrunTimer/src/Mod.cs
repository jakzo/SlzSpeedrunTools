﻿using MelonLoader;
using Sst.Utilities;
using System.Linq;

namespace Sst.SpeedrunTimer {
public class Mod : MelonMod {
  public const string PREF_CATEGORY_ID = BuildInfo.Name;

  private static SplitsTimer _timer = new SplitsTimer();
  private bool _isDisabled = false;

  public MelonPreferences_Category PrefCategory;

  public static Mod Instance;
  public Mod() { Instance = this; }

  public override void OnInitializeMelon() {
    Dbg.Init(PREF_CATEGORY_ID);
    PrefCategory = MelonPreferences.CreateCategory(PREF_CATEGORY_ID);
    _timer.OnInitialize();

    LevelHooks.OnLoad += level => {
      if (CheckIfAllowed())
        _timer.OnLoadingScreen(level);
    };

    LevelHooks.OnLevelStart += level => {
      if (CheckIfAllowed())
        _timer.OnLevelStart(level);
    };
  }

  public override void OnUpdate() {
    if (!_isDisabled)
      _timer.OnUpdate();
  }

  private bool CheckIfAllowed() {
    var illegitimacyReasons = AntiCheat.ComputeRunLegitimacy();
    if (illegitimacyReasons.Count == 0) {
      _isDisabled = false;
      return true;
    }

    if (!_isDisabled) {
      _timer.Reset();
      _isDisabled = true;
      var reasonMessages = string.Join(
          "", illegitimacyReasons.Select(reason => $"\n» {reason.Value}"));
      MelonLogger.Msg(
          $"Cannot show timer due to run being illegitimate because:{reasonMessages}");
    }
    return false;
  }
}
}
