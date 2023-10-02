// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Runtime.InteropServices;

namespace SDL;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void* SDL_ClipboardDataCallback(nint userdata, sbyte* mime_type, nuint* size);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void SDL_ClipboardCleanupCallback(nint userdata);

public unsafe partial class SDL
{
	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Init")]
	public static extern int SDL_Init(SDL_InitFlags flags);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InitSubSystem")]
	public static extern int SDL_InitSubSystem(SDL_InitFlags flags);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_QuitSubSystem")]
	public static extern void SDL_QuitSubSystem(SDL_InitFlags flags);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WasInit")]
	public static extern uint SDL_WasInit(SDL_InitFlags flags);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Quit")]
	public static extern void SDL_Quit();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardText")]
	public static extern int SDL_SetClipboardText(sbyte* text);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardText")]
	public static extern sbyte* SDL_GetClipboardText();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardText")]
	public static extern SDL_bool SDL_HasClipboardText();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPrimarySelectionText")]
	public static extern int SDL_SetPrimarySelectionText(sbyte* text);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrimarySelectionText")]
	public static extern sbyte* SDL_GetPrimarySelectionText();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasPrimarySelectionText")]
	public static extern SDL_bool SDL_HasPrimarySelectionText();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardData")]
	public static extern int SDL_SetClipboardData(SDL_ClipboardDataCallback callback, SDL_ClipboardCleanupCallback cleanup, nint userdata, sbyte* mime_types, nuint num_mime_types);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearClipboardData")]
	public static extern int SDL_ClearClipboardData();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardData")]
	public static extern nint SDL_GetClipboardData(sbyte* mime_type, nuint* size);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardData")]
	public static extern SDL_bool SDL_HasClipboardData(sbyte* mime_type);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadObject")]
	public static extern nint SDL_LoadObject(sbyte* sofile);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFunction")]
	public static extern delegate* unmanaged<void> SDL_LoadFunction(nint handle, sbyte* name);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnloadObject")]
	public static extern void SDL_UnloadObject(nint handle);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPlatform")]
	public static extern sbyte* SDL_GetPlatform();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCPUCount")]
	public static extern int SDL_GetCPUCount();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCPUCacheLineSize")]
	public static extern int SDL_GetCPUCacheLineSize();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAltiVec")]
	public static extern SDL_bool SDL_HasAltiVec();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasMMX")]
	public static extern SDL_bool SDL_HasMMX();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE")]
	public static extern SDL_bool SDL_HasSSE();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE2")]
	public static extern SDL_bool SDL_HasSSE2();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE3")]
	public static extern SDL_bool SDL_HasSSE3();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE41")]
	public static extern SDL_bool SDL_HasSSE41();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE42")]
	public static extern SDL_bool SDL_HasSSE42();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX")]
	public static extern SDL_bool SDL_HasAVX();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX2")]
	public static extern SDL_bool SDL_HasAVX2();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX512F")]
	public static extern SDL_bool SDL_HasAVX512F();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasARMSIMD")]
	public static extern SDL_bool SDL_HasARMSIMD();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasNEON")]
	public static extern SDL_bool SDL_HasNEON();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasLSX")]
	public static extern SDL_bool SDL_HasLSX();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasLASX")]
	public static extern SDL_bool SDL_HasLASX();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSystemRAM")]
	public static extern int SDL_GetSystemRAM();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SIMDGetAlignment")]
	public static extern nuint SDL_SIMDGetAlignment();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddGamepadMapping")]
	public static extern int SDL_AddGamepadMapping(sbyte* mapping);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddGamepadMappingsFromRW")]
	public static extern int SDL_AddGamepadMappingsFromRW(nint src, SDL_bool freesrc);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddGamepadMappingsFromFile")]
	public static extern int SDL_AddGamepadMappingsFromFile(sbyte* file);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReloadGamepadMappings")]
	public static extern int SDL_ReloadGamepadMappings();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumGamepadMappings")]
	public static extern int SDL_GetNumGamepadMappings();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappingForIndex")]
	public static extern sbyte* SDL_GetGamepadMappingForIndex(int mapping_index);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappingForGUID")]
	public static extern sbyte* SDL_GetGamepadMappingForGUID(Guid guid);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMapping")]
	public static extern sbyte* SDL_GetGamepadMapping(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadMapping")]
	public static extern int SDL_SetGamepadMapping(SDL_JoystickID instance_id, sbyte* mapping);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepads")]
	public static extern SDL_JoystickID* SDL_GetGamepads(int* count);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsGamepad")]
	public static extern SDL_bool SDL_IsGamepad(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadInstanceName")]
	public static extern sbyte* SDL_GetGamepadInstanceName(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadInstancePath")]
	public static extern sbyte* SDL_GetGamepadInstancePath(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadInstancePlayerIndex")]
	public static extern int SDL_GetGamepadInstancePlayerIndex(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadInstanceGUID")]
	public static extern Guid SDL_GetGamepadInstanceGUID(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadInstanceVendor")]
	public static extern ushort SDL_GetGamepadInstanceVendor(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadInstanceProduct")]
	public static extern ushort SDL_GetGamepadInstanceProduct(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadInstanceProductVersion")]
	public static extern ushort SDL_GetGamepadInstanceProductVersion(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadInstanceType")]
	public static extern SDL_GamepadType SDL_GetGamepadInstanceType(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRealGamepadInstanceType")]
	public static extern SDL_GamepadType SDL_GetRealGamepadInstanceType(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadInstanceMapping")]
	public static extern sbyte* SDL_GetGamepadInstanceMapping(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenGamepad")]
	public static extern SDL_Gamepad SDL_OpenGamepad(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFromInstanceID")]
	public static extern SDL_Gamepad SDL_GetGamepadFromInstanceID(SDL_JoystickID instance_id);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFromPlayerIndex")]
	public static extern SDL_Gamepad SDL_GetGamepadFromPlayerIndex(int player_index);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadInstanceID")]
	public static extern SDL_JoystickID SDL_GetGamepadInstanceID(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadName")]
	public static extern sbyte* SDL_GetGamepadName(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPath")]
	public static extern sbyte* SDL_GetGamepadPath(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadType")]
	public static extern SDL_GamepadType SDL_GetGamepadType(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRealGamepadType")]
	public static extern SDL_GamepadType SDL_GetRealGamepadType(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPlayerIndex")]
	public static extern int SDL_GetGamepadPlayerIndex(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadPlayerIndex")]
	public static extern int SDL_SetGamepadPlayerIndex(SDL_Gamepad gamepad, int player_index);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadVendor")]
	public static extern ushort SDL_GetGamepadVendor(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProduct")]
	public static extern ushort SDL_GetGamepadProduct(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProductVersion")]
	public static extern ushort SDL_GetGamepadProductVersion(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFirmwareVersion")]
	public static extern ushort SDL_GetGamepadFirmwareVersion(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSerial")]
	public static extern sbyte* SDL_GetGamepadSerial(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPowerLevel")]
	public static extern SDL_JoystickPowerLevel SDL_GetGamepadPowerLevel(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadConnected")]
	public static extern SDL_bool SDL_GamepadConnected(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadJoystick")]
	public static extern SDL_Joystick* SDL_GetGamepadJoystick(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadEventsEnabled")]
	public static extern void SDL_SetGamepadEventsEnabled(SDL_bool enabled);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadEventsEnabled")]
	public static extern SDL_bool SDL_GamepadEventsEnabled();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadBindings")]
	public static extern SDL_GamepadBinding* SDL_GetGamepadBindings(SDL_Gamepad gamepad, int* count);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateGamepads")]
	public static extern void SDL_UpdateGamepads();

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadTypeFromString")]
	public static extern SDL_GamepadType SDL_GetGamepadTypeFromString(sbyte* str);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForType")]
	public static extern sbyte* SDL_GetGamepadStringForType(SDL_GamepadType type);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAxisFromString")]
	public static extern SDL_GamepadAxis SDL_GetGamepadAxisFromString(sbyte* str);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForAxis")]
	public static extern sbyte* SDL_GetGamepadStringForAxis(SDL_GamepadAxis axis);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasAxis")]
	public static extern SDL_bool SDL_GamepadHasAxis(SDL_Gamepad gamepad, SDL_GamepadAxis axis);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAxis")]
	public static extern short SDL_GetGamepadAxis(SDL_Gamepad gamepad, SDL_GamepadAxis axis);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButtonFromString")]
	public static extern SDL_GamepadButton SDL_GetGamepadButtonFromString(sbyte* str);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForButton")]
	public static extern sbyte* SDL_GetGamepadStringForButton(SDL_GamepadButton button);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasButton")]
	public static extern SDL_bool SDL_GamepadHasButton(SDL_Gamepad gamepad, SDL_GamepadButton button);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButton")]
	public static extern byte SDL_GetGamepadButton(SDL_Gamepad gamepad, SDL_GamepadButton button);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumGamepadTouchpads")]
	public static extern int SDL_GetNumGamepadTouchpads(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumGamepadTouchpadFingers")]
	public static extern int SDL_GetNumGamepadTouchpadFingers(SDL_Gamepad gamepad, int touchpad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadTouchpadFinger")]
	public static extern int SDL_GetGamepadTouchpadFinger(SDL_Gamepad gamepad, int touchpad, int finger, byte* state, float* x, float* y, float* pressure);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasSensor")]
	public static extern SDL_bool SDL_GamepadHasSensor(SDL_Gamepad gamepad, SDL_SensorType type);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadSensorEnabled")]
	public static extern int SDL_SetGamepadSensorEnabled(SDL_Gamepad gamepad, SDL_SensorType type, SDL_bool enabled);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadSensorEnabled")]
	public static extern SDL_bool SDL_GamepadSensorEnabled(SDL_Gamepad gamepad, SDL_SensorType type);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSensorDataRate")]
	public static extern float SDL_GetGamepadSensorDataRate(SDL_Gamepad gamepad, SDL_SensorType type);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSensorData")]
	public static extern int SDL_GetGamepadSensorData(SDL_Gamepad gamepad, SDL_SensorType type, float* data, int num_values);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleGamepad")]
	public static extern int SDL_RumbleGamepad(SDL_Gamepad gamepad, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleGamepadTriggers")]
	public static extern int SDL_RumbleGamepadTriggers(SDL_Gamepad gamepad, ushort left_rumble, ushort right_rumble, uint duration_ms);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasLED")]
	public static extern SDL_bool SDL_GamepadHasLED(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasRumble")]
	public static extern SDL_bool SDL_GamepadHasRumble(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasRumbleTriggers")]
	public static extern SDL_bool SDL_GamepadHasRumbleTriggers(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadLED")]
	public static extern int SDL_SetGamepadLED(SDL_Gamepad gamepad, byte red, byte green, byte blue);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendGamepadEffect")]
	public static extern int SDL_SendGamepadEffect(SDL_Gamepad gamepad, void* data, int size);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseGamepad")]
	public static extern void SDL_CloseGamepad(SDL_Gamepad gamepad);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton")]
	public static extern sbyte* SDL_GetGamepadAppleSFSymbolsNameForButton(SDL_Gamepad gamepad, SDL_GamepadButton button);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis")]
	public static extern sbyte* SDL_GetGamepadAppleSFSymbolsNameForAxis(SDL_Gamepad gamepad, SDL_GamepadAxis axis);

}
