// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Bwr
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct HeadsetInput : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p = new Struct(_i, _bb); }
  public HeadsetInput __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  /// Relative to VR root (play space)
  public Bwr.Transform Transform { get { return (new Bwr.Transform()).__assign(__p.bb_pos + 0, __p.bb); } }

  public static Offset<Bwr.HeadsetInput> CreateHeadsetInput(FlatBufferBuilder builder, float transform_position_X, float transform_position_Y, float transform_position_Z, float transform_rotation_euler_X, float transform_rotation_euler_Y, float transform_rotation_euler_Z) {
    builder.Prep(4, 24);
    builder.Prep(4, 24);
    builder.Prep(4, 12);
    builder.PutFloat(transform_rotation_euler_Z);
    builder.PutFloat(transform_rotation_euler_Y);
    builder.PutFloat(transform_rotation_euler_X);
    builder.Prep(4, 12);
    builder.PutFloat(transform_position_Z);
    builder.PutFloat(transform_position_Y);
    builder.PutFloat(transform_position_X);
    return new Offset<Bwr.HeadsetInput>(builder.Offset);
  }
}


}