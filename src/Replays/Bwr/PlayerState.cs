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

  /// Head position within game world
  public Bwr.Vector3 Head { get { return (new Bwr.Vector3()).__assign(__p.bb_pos + 0, __p.bb); } }
  /// Body rotation within game world
  public float BodyRotation { get { return __p.bb.GetFloat(__p.bb_pos + 12); } }
  /// Position of hand in game world (can differ from controller position)
  public Bwr.Transform LeftHand { get { return (new Bwr.Transform()).__assign(__p.bb_pos + 16, __p.bb); } }
  /// Position of hand in game world (can differ from controller position)
  public Bwr.Transform RightHand { get { return (new Bwr.Transform()).__assign(__p.bb_pos + 40, __p.bb); } }
  /// Position of feet in game world
  public Bwr.Vector3 Feet { get { return (new Bwr.Vector3()).__assign(__p.bb_pos + 64, __p.bb); } }
  /// Virtual crouch amount, 0 = standing normally, -0.9 = min, 0.15 = max
  public float FeetOffset { get { return __p.bb.GetFloat(__p.bb_pos + 76); } }

  public static Offset<Bwr.PlayerState> CreatePlayerState(FlatBufferBuilder builder, float head_X, float head_Y, float head_Z, float BodyRotation, float left_hand_position_X, float left_hand_position_Y, float left_hand_position_Z, float left_hand_rotation_euler_X, float left_hand_rotation_euler_Y, float left_hand_rotation_euler_Z, float right_hand_position_X, float right_hand_position_Y, float right_hand_position_Z, float right_hand_rotation_euler_X, float right_hand_rotation_euler_Y, float right_hand_rotation_euler_Z, float feet_X, float feet_Y, float feet_Z, float FeetOffset) {
    builder.Prep(4, 80);
    builder.PutFloat(FeetOffset);
    builder.Prep(4, 12);
    builder.PutFloat(feet_Z);
    builder.PutFloat(feet_Y);
    builder.PutFloat(feet_X);
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
    builder.PutFloat(BodyRotation);
    builder.Prep(4, 12);
    builder.PutFloat(head_Z);
    builder.PutFloat(head_Y);
    builder.PutFloat(head_X);
    return new Offset<Bwr.PlayerState>(builder.Offset);
  }
}


}
