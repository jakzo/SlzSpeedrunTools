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

  /// Position of game world skeleton rig (base of feet)
  public Bwr.Vector3 BodyPosition { get { return (new Bwr.Vector3()).__assign(__p.bb_pos + 0, __p.bb); } }
  /// Rotation in degrees of VR root (thumbstick rotation not HMD)
  public float RootRotation { get { return __p.bb.GetFloat(__p.bb_pos + 12); } }
  /// Virtual crouch amount, 0 = standing normally, -0.9 = min, 0.15 = max
  public float FeetOffset { get { return __p.bb.GetFloat(__p.bb_pos + 16); } }
  /// Position of head in game world
  public Bwr.Vector3 HeadPosition { get { return (new Bwr.Vector3()).__assign(__p.bb_pos + 20, __p.bb); } }
  /// Position of hand in game world
  public Bwr.Transform LeftHand { get { return (new Bwr.Transform()).__assign(__p.bb_pos + 32, __p.bb); } }
  /// Position of hand in game world
  public Bwr.Transform RightHand { get { return (new Bwr.Transform()).__assign(__p.bb_pos + 56, __p.bb); } }

  public static Offset<Bwr.PlayerState> CreatePlayerState(FlatBufferBuilder builder, float body_position_X, float body_position_Y, float body_position_Z, float RootRotation, float FeetOffset, float head_position_X, float head_position_Y, float head_position_Z, float left_hand_position_X, float left_hand_position_Y, float left_hand_position_Z, float left_hand_rotation_euler_X, float left_hand_rotation_euler_Y, float left_hand_rotation_euler_Z, float right_hand_position_X, float right_hand_position_Y, float right_hand_position_Z, float right_hand_rotation_euler_X, float right_hand_rotation_euler_Y, float right_hand_rotation_euler_Z) {
    builder.Prep(4, 80);
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
    builder.Prep(4, 12);
    builder.PutFloat(head_position_Z);
    builder.PutFloat(head_position_Y);
    builder.PutFloat(head_position_X);
    builder.PutFloat(FeetOffset);
    builder.PutFloat(RootRotation);
    builder.Prep(4, 12);
    builder.PutFloat(body_position_Z);
    builder.PutFloat(body_position_Y);
    builder.PutFloat(body_position_X);
    return new Offset<Bwr.PlayerState>(builder.Offset);
  }
}


}
