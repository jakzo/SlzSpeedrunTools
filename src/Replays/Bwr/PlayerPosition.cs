// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Bwr
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct PlayerPosition : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p = new Struct(_i, _bb); }
  public PlayerPosition __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  /// Position/rotation of player at their base (feet)
  public Bwr.TransformRotY Root { get { return (new Bwr.TransformRotY()).__assign(__p.bb_pos + 0, __p.bb); } }
  /// Amount crouched where X is on toes, X is fully crouched, X is standing normally
  public float FeetOffset { get { return __p.bb.GetFloat(__p.bb_pos + 16); } }
  /// Position of hand (can be different to controller position)
  public Bwr.Transform LeftHand { get { return (new Bwr.Transform()).__assign(__p.bb_pos + 20, __p.bb); } }
  /// Position of hand (can be different to controller position)
  public Bwr.Transform RightHand { get { return (new Bwr.Transform()).__assign(__p.bb_pos + 44, __p.bb); } }

  public static Offset<Bwr.PlayerPosition> CreatePlayerPosition(FlatBufferBuilder builder, float root_position_X, float root_position_Y, float root_position_Z, float root_RotationY, float FeetOffset, float left_hand_position_X, float left_hand_position_Y, float left_hand_position_Z, float left_hand_rotation_euler_X, float left_hand_rotation_euler_Y, float left_hand_rotation_euler_Z, float right_hand_position_X, float right_hand_position_Y, float right_hand_position_Z, float right_hand_rotation_euler_X, float right_hand_rotation_euler_Y, float right_hand_rotation_euler_Z) {
    builder.Prep(4, 68);
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
    builder.PutFloat(FeetOffset);
    builder.Prep(4, 16);
    builder.PutFloat(root_RotationY);
    builder.Prep(4, 12);
    builder.PutFloat(root_position_Z);
    builder.PutFloat(root_position_Y);
    builder.PutFloat(root_position_X);
    return new Offset<Bwr.PlayerPosition>(builder.Offset);
  }
};


}
