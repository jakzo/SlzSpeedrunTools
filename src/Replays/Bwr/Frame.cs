// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Bwr
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct Frame : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static Frame GetRootAsFrame(ByteBuffer _bb) { return GetRootAsFrame(_bb, new Frame()); }
  public static Frame GetRootAsFrame(ByteBuffer _bb, Frame obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Frame __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  /// In seconds since start_time not including loads
  public float Time { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  /// Number of game frames that occurred between this frame and the last
  public byte SkippedFrames { get { int o = __p.__offset(6); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  /// Player settings which changed since the last frame (may be null if none)
  public Bwr.ChangedSetting? ChangedSettings(int j) { int o = __p.__offset(8); return o != 0 ? (Bwr.ChangedSetting?)(new Bwr.ChangedSetting()).__assign(__p.__vector(o) + j * 8, __p.bb) : null; }
  public int ChangedSettingsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  /// Controller inputs
  public Bwr.VrInput? VrInput { get { int o = __p.__offset(10); return o != 0 ? (Bwr.VrInput?)(new Bwr.VrInput()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  /// Player state within the game world
  public Bwr.PlayerPosition? PlayerState { get { int o = __p.__offset(12); return o != 0 ? (Bwr.PlayerPosition?)(new Bwr.PlayerPosition()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  /// Items carried by the player (may be null if none)
  public Bwr.ItemInSlot? Inventory(int j) { int o = __p.__offset(14); return o != 0 ? (Bwr.ItemInSlot?)(new Bwr.ItemInSlot()).__assign(__p.__vector(o) + j * 2, __p.bb) : null; }
  public int InventoryLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static void StartFrame(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddTime(FlatBufferBuilder builder, float time) { builder.AddFloat(0, time, 0.0f); }
  public static void AddSkippedFrames(FlatBufferBuilder builder, byte skippedFrames) { builder.AddByte(1, skippedFrames, 0); }
  public static void AddChangedSettings(FlatBufferBuilder builder, VectorOffset changedSettingsOffset) { builder.AddOffset(2, changedSettingsOffset.Value, 0); }
  public static void StartChangedSettingsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 4); }
  public static void AddVrInput(FlatBufferBuilder builder, Offset<Bwr.VrInput> vrInputOffset) { builder.AddStruct(3, vrInputOffset.Value, 0); }
  public static void AddPlayerState(FlatBufferBuilder builder, Offset<Bwr.PlayerPosition> playerStateOffset) { builder.AddStruct(4, playerStateOffset.Value, 0); }
  public static void AddInventory(FlatBufferBuilder builder, VectorOffset inventoryOffset) { builder.AddOffset(5, inventoryOffset.Value, 0); }
  public static void StartInventoryVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(2, numElems, 1); }
  public static Offset<Bwr.Frame> EndFrame(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Bwr.Frame>(o);
  }
};


}
