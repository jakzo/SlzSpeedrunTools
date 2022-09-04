// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Bwr
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct PlayerState : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p = new Struct(_i, _bb); }
  public PlayerState __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Bwr.TransformRotY Feet { get { return (new Bwr.TransformRotY()).__assign(__p.bb_pos + 0, __p.bb); } }
  public Bwr.Transform LeftHand { get { return (new Bwr.Transform()).__assign(__p.bb_pos + 16, __p.bb); } }
  public Bwr.Transform RightHand { get { return (new Bwr.Transform()).__assign(__p.bb_pos + 40, __p.bb); } }

  public static Offset<Bwr.PlayerState> CreatePlayerState(FlatBufferBuilder builder, float feet_position_X, float feet_position_Y, float feet_position_Z, float feet_RotationY, float left_hand_position_X, float left_hand_position_Y, float left_hand_position_Z, float left_hand_rotation_euler_X, float left_hand_rotation_euler_Y, float left_hand_rotation_euler_Z, float right_hand_position_X, float right_hand_position_Y, float right_hand_position_Z, float right_hand_rotation_euler_X, float right_hand_rotation_euler_Y, float right_hand_rotation_euler_Z) {
    builder.Prep(4, 64);
    builder.Prep(4, 24);
    builder.Prep(4, 12);
    builder.PutFloat(right_hand_rotation_euler_Z);
    builder.PutFloat(right_hand_rotation_euler_Y);
    builder.PutFloat(right_hand_rotation_euler_X);
    builder.Prep(4, 12);
    builder.PutFloat(right_hand_position_Z);
    builder.PutFloat(right_hand_position_Y);
    builder.PutFloat(right_hand_position_X);
    builder.Prep(4, 24);
    builder.Prep(4, 12);
    builder.PutFloat(left_hand_rotation_euler_Z);
    builder.PutFloat(left_hand_rotation_euler_Y);
    builder.PutFloat(left_hand_rotation_euler_X);
    builder.Prep(4, 12);
    builder.PutFloat(left_hand_position_Z);
    builder.PutFloat(left_hand_position_Y);
    builder.PutFloat(left_hand_position_X);
    builder.Prep(4, 16);
    builder.PutFloat(feet_RotationY);
    builder.Prep(4, 12);
    builder.PutFloat(feet_position_Z);
    builder.PutFloat(feet_position_Y);
    builder.PutFloat(feet_position_X);
    return new Offset<Bwr.PlayerState>(builder.Offset);
  }
};


}
