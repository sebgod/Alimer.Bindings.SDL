// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

#pragma warning disable CS0649
namespace SDL;

public partial struct SDL_PenCapabilityInfo
{
	public float max_tilt;
	public uint wacom_id;
	public sbyte num_buttons;
}

public partial struct SDL_IOStreamInterface
{
	public unsafe delegate* unmanaged<nint, long> size;
	public unsafe delegate* unmanaged<nint, long, int, long> seek;
	public unsafe delegate* unmanaged<nint, nint, nuint, SDL_IOStatus*, nuint> read;
	public unsafe delegate* unmanaged<nint, void*, nuint, SDL_IOStatus*, nuint> write;
	public unsafe delegate* unmanaged<nint, int> close;
}

public partial struct SDL_Keysym
{
	public SDL_Scancode scancode;
	public SDL_KeyCode sym;
	public ushort mod;
	public uint unused;
}

public partial struct SDL_MessageBoxButtonData
{
	public uint flags;
	public int buttonID;
	public unsafe byte* text;
}

public partial struct SDL_MessageBoxColor
{
	public byte r;
	public byte g;
	public byte b;
}

public partial struct SDL_MessageBoxColorScheme
{
	public colors__FixedBuffer colors;

	public unsafe struct colors__FixedBuffer
	{
		public SDL_MessageBoxColor e0;
		public SDL_MessageBoxColor e1;
		public SDL_MessageBoxColor e2;
		public SDL_MessageBoxColor e3;
		public SDL_MessageBoxColor e4;

		[UnscopedRef]
		public ref SDL_MessageBoxColor this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return ref AsSpan()[index];
			}
		}

		[UnscopedRef]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span<SDL_MessageBoxColor> AsSpan()
		{
			return MemoryMarshal.CreateSpan(ref e0, 5);
		}
	}
}

public partial struct SDL_MessageBoxData
{
	public uint flags;
	public SDL_Window window;
	public unsafe byte* title;
	public unsafe byte* message;
	public int numbuttons;
	public unsafe SDL_MessageBoxButtonData* buttons;
	public unsafe SDL_MessageBoxColorScheme* colorScheme;
}

public partial struct SDL_VirtualJoystickDesc
{
	public ushort version;
	public ushort type;
	public ushort naxes;
	public ushort nbuttons;
	public ushort nhats;
	public ushort vendor_id;
	public ushort product_id;
	public ushort padding;
	public uint button_mask;
	public uint axis_mask;
	public unsafe byte* name;
	public nint userdata;
	public unsafe delegate* unmanaged<nint, void> Update;
	public unsafe delegate* unmanaged<nint, int, void> SetPlayerIndex;
	public unsafe delegate* unmanaged<nint, ushort, ushort, int> Rumble;
	public unsafe delegate* unmanaged<nint, ushort, ushort, int> RumbleTriggers;
	public unsafe delegate* unmanaged<nint, byte, byte, byte, int> SetLED;
	public unsafe delegate* unmanaged<nint, void*, int, int> SendEffect;
}

public partial struct SDL_GamepadBinding
{
	public SDL_GamepadBindingType input_type;
	public SDL_GamepadBinding_input input;
	
	[StructLayout(LayoutKind.Explicit)]
	public partial struct SDL_GamepadBinding_input
	{
		[FieldOffset(0)]
		public int button;
		[FieldOffset(0)]
		public SDL_GamepadBinding_axis axis;
		
		public partial struct SDL_GamepadBinding_axis
		{
			public int axis;
			public int axis_min;
			public int axis_max;
		}
		[FieldOffset(0)]
		public SDL_GamepadBinding_hat hat;
		
		public partial struct SDL_GamepadBinding_hat
		{
			public int hat;
			public int hat_mask;
		}
	}
	public SDL_GamepadBindingType output_type;
	public SDL_GamepadBinding_output output;
	
	[StructLayout(LayoutKind.Explicit)]
	public partial struct SDL_GamepadBinding_output
	{
		[FieldOffset(0)]
		public SDL_GamepadButton button;
		[FieldOffset(0)]
		public SDL_GamepadBinding_axis axis;
		
		public partial struct SDL_GamepadBinding_axis
		{
			public SDL_GamepadAxis axis;
			public int axis_min;
			public int axis_max;
		}
	}
}

public partial struct SDL_Finger
{
	public SDL_FingerID id;
	public float x;
	public float y;
	public float pressure;
}

public partial struct SDL_DisplayMode
{
	public SDL_DisplayID displayID;
	public SDL_PixelFormatEnum format;
	public int w;
	public int h;
	public float pixel_density;
	public float refresh_rate;
	public nint driverdata;
}

public partial struct SDL_AudioSpec
{
	public SDL_AudioFormat format;
	public int channels;
	public int freq;
}

public partial struct SDL_CommonEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
}

public partial struct SDL_DisplayEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_DisplayID displayID;
	public int data1;
}

public partial struct SDL_WindowEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_WindowID windowID;
	public int data1;
	public int data2;
}

public partial struct SDL_KeyboardDeviceEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_KeyboardID which;
}

public partial struct SDL_KeyboardEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_WindowID windowID;
	public SDL_KeyboardID which;
	public byte state;
	public byte repeat;
	public byte padding2;
	public byte padding3;
	public SDL_Keysym keysym;
}

public partial struct SDL_TextEditingEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_WindowID windowID;
	public unsafe byte* text;
	public int start;
	public int length;
}

public partial struct SDL_TextInputEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_WindowID windowID;
	public unsafe byte* text;
}

public partial struct SDL_MouseDeviceEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_MouseID which;
}

public partial struct SDL_MouseMotionEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_WindowID windowID;
	public SDL_MouseID which;
	public uint state;
	public float x;
	public float y;
	public float xrel;
	public float yrel;
}

public partial struct SDL_MouseButtonEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_WindowID windowID;
	public SDL_MouseID which;
	public byte button;
	public byte state;
	public byte clicks;
	public byte padding;
	public float x;
	public float y;
}

public partial struct SDL_MouseWheelEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_WindowID windowID;
	public SDL_MouseID which;
	public float x;
	public float y;
	public SDL_MouseWheelDirection direction;
	public float mouse_x;
	public float mouse_y;
}

public partial struct SDL_JoyAxisEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_JoystickID which;
	public byte axis;
	public byte padding1;
	public byte padding2;
	public byte padding3;
	public short value;
	public ushort padding4;
}

public partial struct SDL_JoyBallEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_JoystickID which;
	public byte ball;
	public byte padding1;
	public byte padding2;
	public byte padding3;
	public short xrel;
	public short yrel;
}

public partial struct SDL_JoyHatEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_JoystickID which;
	public byte hat;
	public byte value;
	public byte padding1;
	public byte padding2;
}

public partial struct SDL_JoyButtonEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_JoystickID which;
	public byte button;
	public byte state;
	public byte padding1;
	public byte padding2;
}

public partial struct SDL_JoyDeviceEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_JoystickID which;
}

public partial struct SDL_JoyBatteryEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_JoystickID which;
	public SDL_PowerState state;
	public int percent;
}

public partial struct SDL_GamepadAxisEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_JoystickID which;
	public byte axis;
	public byte padding1;
	public byte padding2;
	public byte padding3;
	public short value;
	public ushort padding4;
}

public partial struct SDL_GamepadButtonEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_JoystickID which;
	public byte button;
	public byte state;
	public byte padding1;
	public byte padding2;
}

public partial struct SDL_GamepadDeviceEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_JoystickID which;
}

public partial struct SDL_GamepadTouchpadEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_JoystickID which;
	public int touchpad;
	public int finger;
	public float x;
	public float y;
	public float pressure;
}

public partial struct SDL_GamepadSensorEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_JoystickID which;
	public int sensor;
	public unsafe fixed float data[3];
	public ulong sensor_timestamp;
}

public partial struct SDL_AudioDeviceEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_AudioDeviceID which;
	public byte iscapture;
	public byte padding1;
	public byte padding2;
	public byte padding3;
}

public partial struct SDL_CameraDeviceEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_CameraDeviceID which;
	public byte padding1;
	public byte padding2;
	public byte padding3;
}

public partial struct SDL_TouchFingerEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_TouchID touchID;
	public SDL_FingerID fingerID;
	public float x;
	public float y;
	public float dx;
	public float dy;
	public float pressure;
	public SDL_WindowID windowID;
}

public partial struct SDL_PenTipEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_WindowID windowID;
	public SDL_PenID which;
	public byte tip;
	public byte state;
	public ushort pen_state;
	public float x;
	public float y;
	public unsafe fixed float axes[6];
}

public partial struct SDL_PenMotionEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_WindowID windowID;
	public SDL_PenID which;
	public byte padding1;
	public byte padding2;
	public ushort pen_state;
	public float x;
	public float y;
	public unsafe fixed float axes[6];
}

public partial struct SDL_PenButtonEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_WindowID windowID;
	public SDL_PenID which;
	public byte button;
	public byte state;
	public ushort pen_state;
	public float x;
	public float y;
	public unsafe fixed float axes[6];
}

public partial struct SDL_DropEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_WindowID windowID;
	public float x;
	public float y;
	public unsafe byte* source;
	public unsafe byte* data;
}

public partial struct SDL_ClipboardEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
}

public partial struct SDL_SensorEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_SensorID which;
	public unsafe fixed float data[6];
	public ulong sensor_timestamp;
}

public partial struct SDL_QuitEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
}

public partial struct SDL_UserEvent
{
	public SDL_EventType type;
	public uint reserved;
	public ulong timestamp;
	public SDL_WindowID windowID;
	public int code;
	public nint data1;
	public nint data2;
}

[StructLayout(LayoutKind.Explicit)]
public partial struct SDL_Event
{
	[FieldOffset(0)]
	public SDL_EventType type;
	[FieldOffset(0)]
	public SDL_CommonEvent common;
	[FieldOffset(0)]
	public SDL_DisplayEvent display;
	[FieldOffset(0)]
	public SDL_WindowEvent window;
	[FieldOffset(0)]
	public SDL_KeyboardDeviceEvent kdevice;
	[FieldOffset(0)]
	public SDL_KeyboardEvent key;
	[FieldOffset(0)]
	public SDL_TextEditingEvent edit;
	[FieldOffset(0)]
	public SDL_TextInputEvent text;
	[FieldOffset(0)]
	public SDL_MouseDeviceEvent mdevice;
	[FieldOffset(0)]
	public SDL_MouseMotionEvent motion;
	[FieldOffset(0)]
	public SDL_MouseButtonEvent button;
	[FieldOffset(0)]
	public SDL_MouseWheelEvent wheel;
	[FieldOffset(0)]
	public SDL_JoyDeviceEvent jdevice;
	[FieldOffset(0)]
	public SDL_JoyAxisEvent jaxis;
	[FieldOffset(0)]
	public SDL_JoyBallEvent jball;
	[FieldOffset(0)]
	public SDL_JoyHatEvent jhat;
	[FieldOffset(0)]
	public SDL_JoyButtonEvent jbutton;
	[FieldOffset(0)]
	public SDL_JoyBatteryEvent jbattery;
	[FieldOffset(0)]
	public SDL_GamepadDeviceEvent gdevice;
	[FieldOffset(0)]
	public SDL_GamepadAxisEvent gaxis;
	[FieldOffset(0)]
	public SDL_GamepadButtonEvent gbutton;
	[FieldOffset(0)]
	public SDL_GamepadTouchpadEvent gtouchpad;
	[FieldOffset(0)]
	public SDL_GamepadSensorEvent gsensor;
	[FieldOffset(0)]
	public SDL_AudioDeviceEvent adevice;
	[FieldOffset(0)]
	public SDL_CameraDeviceEvent cdevice;
	[FieldOffset(0)]
	public SDL_SensorEvent sensor;
	[FieldOffset(0)]
	public SDL_QuitEvent quit;
	[FieldOffset(0)]
	public SDL_UserEvent user;
	[FieldOffset(0)]
	public SDL_TouchFingerEvent tfinger;
	[FieldOffset(0)]
	public SDL_PenTipEvent ptip;
	[FieldOffset(0)]
	public SDL_PenMotionEvent pmotion;
	[FieldOffset(0)]
	public SDL_PenButtonEvent pbutton;
	[FieldOffset(0)]
	public SDL_DropEvent drop;
	[FieldOffset(0)]
	public SDL_ClipboardEvent clipboard;
	[FieldOffset(0)]
	public unsafe fixed byte padding[128];
}

public partial struct SDL_HapticDirection
{
	public SDL_HapticDirectionType type;
	public unsafe fixed int dir[3];
}

public partial struct SDL_HapticConstant
{
	public ushort type;
	public SDL_HapticDirection direction;
	public uint length;
	public ushort delay;
	public ushort button;
	public ushort interval;
	public short level;
	public ushort attack_length;
	public ushort attack_level;
	public ushort fade_length;
	public ushort fade_level;
}

public partial struct SDL_HapticPeriodic
{
	public ushort type;
	public SDL_HapticDirection direction;
	public uint length;
	public ushort delay;
	public ushort button;
	public ushort interval;
	public ushort period;
	public short magnitude;
	public short offset;
	public ushort phase;
	public ushort attack_length;
	public ushort attack_level;
	public ushort fade_length;
	public ushort fade_level;
}

public partial struct SDL_HapticCondition
{
	public ushort type;
	public SDL_HapticDirection direction;
	public uint length;
	public ushort delay;
	public ushort button;
	public ushort interval;
	public unsafe fixed ushort right_sat[3];
	public unsafe fixed ushort left_sat[3];
	public unsafe fixed short right_coeff[3];
	public unsafe fixed short left_coeff[3];
	public unsafe fixed ushort deadband[3];
	public unsafe fixed short center[3];
}

public partial struct SDL_HapticRamp
{
	public ushort type;
	public SDL_HapticDirection direction;
	public uint length;
	public ushort delay;
	public ushort button;
	public ushort interval;
	public short start;
	public short end;
	public ushort attack_length;
	public ushort attack_level;
	public ushort fade_length;
	public ushort fade_level;
}

public partial struct SDL_HapticLeftRight
{
	public ushort type;
	public uint length;
	public ushort large_magnitude;
	public ushort small_magnitude;
}

public partial struct SDL_HapticCustom
{
	public ushort type;
	public SDL_HapticDirection direction;
	public uint length;
	public ushort delay;
	public ushort button;
	public ushort interval;
	public byte channels;
	public ushort period;
	public ushort samples;
	public unsafe ushort* data;
	public ushort attack_length;
	public ushort attack_level;
	public ushort fade_length;
	public ushort fade_level;
}

[StructLayout(LayoutKind.Explicit)]
public partial struct SDL_HapticEffect
{
	[FieldOffset(0)]
	public SDL_HapticEffectType type;
	[FieldOffset(0)]
	public SDL_HapticConstant constant;
	[FieldOffset(0)]
	public SDL_HapticPeriodic periodic;
	[FieldOffset(0)]
	public SDL_HapticCondition condition;
	[FieldOffset(0)]
	public SDL_HapticRamp ramp;
	[FieldOffset(0)]
	public SDL_HapticLeftRight leftright;
	[FieldOffset(0)]
	public SDL_HapticCustom custom;
}

public partial struct SDL_Color
{
	public byte r;
	public byte g;
	public byte b;
	public byte a;
}

public partial struct SDL_FColor
{
	public float r;
	public float g;
	public float b;
	public float a;
}

public partial struct SDL_Palette
{
	public int ncolors;
	public unsafe SDL_Color* colors;
	public uint version;
	public int refcount;
}

public partial struct SDL_PixelFormat
{
	public SDL_PixelFormatEnum format;
	public unsafe SDL_Palette* palette;
	public byte bits_per_pixel;
	public byte bytes_per_pixel;
	public unsafe fixed byte padding[2];
	public uint Rmask;
	public uint Gmask;
	public uint Bmask;
	public uint Amask;
	public byte Rloss;
	public byte Gloss;
	public byte Bloss;
	public byte Aloss;
	public byte Rshift;
	public byte Gshift;
	public byte Bshift;
	public byte Ashift;
	public int refcount;
	public unsafe SDL_PixelFormat* next;
}

public partial struct SDL_Surface
{
	public uint flags;
	public unsafe SDL_PixelFormat* format;
	public int w;
	public int h;
	public int pitch;
	public nint pixels;
	public nint reserved;
	public int locked;
	public nint list_blitmap;
	public Rectangle clip_rect;
	public unsafe nint* map;
	public int refcount;
}

public partial struct SDL_CameraSpec
{
	public SDL_PixelFormatEnum format;
	public int width;
	public int height;
	public int interval_numerator;
	public int interval_denominator;
}

public partial struct SDL_DateTime
{
	public int year;
	public int month;
	public int day;
	public int hour;
	public int minute;
	public int second;
	public int nanosecond;
	public int day_of_week;
	public int utc_offset;
}

