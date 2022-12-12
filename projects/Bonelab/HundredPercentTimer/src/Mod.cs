using System;
using MelonLoader;
using UnityEngine;
using SLZ.Bonelab;
using SLZ.Marrow.Warehouse;
using Sst.Common.Bonelab.HundredPercent;

namespace Sst.HundredPercentTimer {
public class Mod : MelonMod {
  private const float UPDATE_FREQUENCY = 1f;

  private Server _server;

  public override void OnInitializeMelon() {
    Dbg.Init(BuildInfo.NAME);

    AchievementTracker.Initialize();
    CapsuleTracker.Initialize();

    Utilities.LevelHooks.OnLoad += level => ServerSendIfNecessary();
    Utilities.LevelHooks.OnLevelStart += level => ServerSendIfNecessary();
    Utilities.LevelHooks.OnLevelStart += SendStateOnArenaCompletion;
  }

  private void ServerSendIfNecessary() {
    if (Utilities.AntiCheat.CheckRunLegitimacy<Mod>()) {
      if (_server == null)
        _server = new Server();
      else
        _server.SendStateIfChanged();
    } else if (_server != null) {
      _server.Dispose();
      _server = null;
    }
  }

  private void SendStateOnArenaCompletion(LevelCrate level) {
    if (level.Barcode.ID != Utilities.Levels.Barcodes.FANTASY_ARENA)
      return;

    var controller = GameObject.FindObjectOfType<Arena_GameController>();
    controller.onModeWin.AddListener(new Action(() => {
      var state = _server.BuildGameState();
      state.arenaJustCompleted = controller.profileTitle;
      _server.SendState(state);
    }));
  }

  public override void OnDeinitializeMelon() {
    CapsuleTracker.Deinitialize();
    _server?.Dispose();
    _server = null;
  }
}
}
