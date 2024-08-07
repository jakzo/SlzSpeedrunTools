using System;
using System.Collections.Generic;
using HarmonyLib;
using SLZ.Bonelab;
using SLZ.SaveData;
using SLZ.Marrow.Warehouse;

namespace Sst.Common.Bonelab.HundredPercent {
static class CapsuleTracker {
  public static event Action<string, string> OnUnlock;

  public static HashSet<string> Unlocked;
  public static int NumTotalUnlocks = 0;

  public static void Initialize() {
    InitUnlocks(null);
    Utilities.LevelHooks.OnLevelStart += InitUnlocks;
  }

  public static void Deinitialize() {
    Utilities.LevelHooks.OnLevelStart -= InitUnlocks;
  }

  private static void InitUnlocks(LevelCrate level) {
    Unlocked = new HashSet<string>();
    var activeSave = DataManager.ActiveSave;
    if (activeSave != null) {
      foreach (var unlock in activeSave.Unlocks.Unlocks)
        Unlocked.Add(unlock.key);
    }

    if (AssetWarehouse.Instance != null) {
      var filter = new CrateFilters.UnlockableAndNotRedactedCrateFilter()
                       .Cast<ICrateFilter<Crate>>();
      NumTotalUnlocks = AssetWarehouseExtensions
                            .Filter(AssetWarehouse.Instance.GetCrates(), filter)
                            .Count;
    }
  }

  private static void Unlock(string id) {
    if (Unlocked.Contains(id))
      return;

    Unlocked.Add(id);
    OnUnlock?.Invoke(
        id, AssetWarehouse.Instance.GetCrate(new Barcode(id))?.Title
    );
  }

  [HarmonyPatch(
      typeof(PlayerUnlocks), nameof(PlayerUnlocks.IncrementUnlockForBarcode)
  )]
  class PlayerUnlocks_IncrementUnlockForBarcode_Patch {
    [HarmonyPostfix()]
    internal static void Postfix(string barcode) {
      Dbg.Log($"PlayerUnlocks_IncrementUnlockForBarcode_Patch: {barcode}");
      Unlock(barcode);
    }
  }
}
}
