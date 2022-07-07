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

  public float Time { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public Bwr.Player? Player { get { int o = __p.__offset(6); return o != 0 ? (Bwr.Player?)(new Bwr.Player()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<Bwr.Frame> CreateFrame(FlatBufferBuilder builder,
      float time = 0.0f,
      Offset<Bwr.Player> playerOffset = default(Offset<Bwr.Player>)) {
    builder.StartTable(2);
    Frame.AddPlayer(builder, playerOffset);
    Frame.AddTime(builder, time);
    return Frame.EndFrame(builder);
  }

  public static void StartFrame(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddTime(FlatBufferBuilder builder, float time) { builder.AddFloat(0, time, 0.0f); }
  public static void AddPlayer(FlatBufferBuilder builder, Offset<Bwr.Player> playerOffset) { builder.AddOffset(1, playerOffset.Value, 0); }
  public static Offset<Bwr.Frame> EndFrame(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 6);  // player
    return new Offset<Bwr.Frame>(o);
  }
}


}
