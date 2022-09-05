// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Bwr
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct VrInput : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p = new Struct(_i, _bb); }
  public VrInput __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Bwr.HeadsetInput Headset { get { return (new Bwr.HeadsetInput()).__assign(__p.bb_pos + 0, __p.bb); } }
  public Bwr.ControllerInput LeftController { get { return (new Bwr.ControllerInput()).__assign(__p.bb_pos + 24, __p.bb); } }
  public Bwr.ControllerInput RightController { get { return (new Bwr.ControllerInput()).__assign(__p.bb_pos + 60, __p.bb); } }

  public static Offset<Bwr.VrInput> CreateVrInput(FlatBufferBuilder builder, float headset_transform_position_X, float headset_transform_position_Y, float headset_transform_position_Z, float headset_transform_rotation_euler_X, float headset_transform_rotation_euler_Y, float headset_transform_rotation_euler_Z, byte left_controller_Buttons, float left_controller_thumbstick_X, float left_controller_thumbstick_Y, float left_controller_transform_position_X, float left_controller_transform_position_Y, float left_controller_transform_position_Z, float left_controller_transform_rotation_euler_X, float left_controller_transform_rotation_euler_Y, float left_controller_transform_rotation_euler_Z, byte right_controller_Buttons, float right_controller_thumbstick_X, float right_controller_thumbstick_Y, float right_controller_transform_position_X, float right_controller_transform_position_Y, float right_controller_transform_position_Z, float right_controller_transform_rotation_euler_X, float right_controller_transform_rotation_euler_Y, float right_controller_transform_rotation_euler_Z) {
    builder.Prep(4, 96);
    builder.Prep(4, 36);
    builder.Prep(4, 24);
    builder.Prep(4, 12);
    builder.PutFloat(right_controller_transform_rotation_euler_Z);
    builder.PutFloat(right_controller_transform_rotation_euler_Y);
    builder.PutFloat(right_controller_transform_rotation_euler_X);
    builder.Prep(4, 12);
    builder.PutFloat(right_controller_transform_position_Z);
    builder.PutFloat(right_controller_transform_position_Y);
    builder.PutFloat(right_controller_transform_position_X);
    builder.Prep(4, 8);
    builder.PutFloat(right_controller_thumbstick_Y);
    builder.PutFloat(right_controller_thumbstick_X);
    builder.Pad(3);
    builder.PutByte(right_controller_Buttons);
    builder.Prep(4, 36);
    builder.Prep(4, 24);
    builder.Prep(4, 12);
    builder.PutFloat(left_controller_transform_rotation_euler_Z);
    builder.PutFloat(left_controller_transform_rotation_euler_Y);
    builder.PutFloat(left_controller_transform_rotation_euler_X);
    builder.Prep(4, 12);
    builder.PutFloat(left_controller_transform_position_Z);
    builder.PutFloat(left_controller_transform_position_Y);
    builder.PutFloat(left_controller_transform_position_X);
    builder.Prep(4, 8);
    builder.PutFloat(left_controller_thumbstick_Y);
    builder.PutFloat(left_controller_thumbstick_X);
    builder.Pad(3);
    builder.PutByte(left_controller_Buttons);
    builder.Prep(4, 24);
    builder.Prep(4, 24);
    builder.Prep(4, 12);
    builder.PutFloat(headset_transform_rotation_euler_Z);
    builder.PutFloat(headset_transform_rotation_euler_Y);
    builder.PutFloat(headset_transform_rotation_euler_X);
    builder.Prep(4, 12);
    builder.PutFloat(headset_transform_position_Z);
    builder.PutFloat(headset_transform_position_Y);
    builder.PutFloat(headset_transform_position_X);
    return new Offset<Bwr.VrInput>(builder.Offset);
  }
}


}
