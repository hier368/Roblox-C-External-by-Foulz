using System;

// imtheo.lol/Offsets/Offsets.hpp
// though use chatgpt to just replace offsets or something so u don't gotta do it manually, atleast its what I do
// oh amd i dumped NextGenReplicatorEnabledWrite4(for desync) and added it myself bc theo don't dumb that, sooo you gotta dump it yourself or find it
namespace Offsets
{
    public static class Info
    {
        public static string ClientVersion = "version-80c7b8e578f241ff";
    }

    public static class AnimationTrack
    {
        public const long Animation = 0xd0;
        public const long Animator = 0x118;
        public const long IsPlaying = 0x5a8;
        public const long Looped = 0xf5;
        public const long Speed = 0xe4;
    }

    public static class Atmosphere
    {
        public const long Color = 0xd0;
        public const long Density = 0xe8;
        public const long Glare = 0xec;
        public const long Haze = 0xf0;
        public const long Offset = 0xf4;
    }

    public static class BasePart
    {
        public const long AssemblyAngularVelocity = 0xfc;
        public const long AssemblyLinearVelocity = 0xf0;
        public const long Color3 = 0x194;
        public const long Material = 0x0;
        public const long Position = 0xe4;
        public const long Primitive = 0x148;
        public const long PrimitiveFlags = 0x1ae;
        public const long PrimitiveOwner = 0x210;
        public const long Rotation = 0xc0;
        public const long Shape = 0x1b1;
        public const long Size = 0x1b0;
        public const long Transparency = 0xf0;
        public const long ValidatePrimitive = 0x6;
    }

    public static class BloomEffect
    {
        public const long Enabled = 0xc8;
        public const long Intensity = 0xd0;
        public const long Size = 0xd4;
        public const long Threshold = 0xd8;
    }

    public static class ByteCode
    {
        public const long Pointer = 0x10;
        public const long Size = 0x20;
    }

    public static class Camera
    {
        public const long CameraSubject = 0xe8;
        public const long CameraType = 0x158;
        public const long FieldOfView = 0x160;
        public const long Position = 0x11c;
        public const long Rotation = 0xf8;
        public const long Viewport = 0x2ac;
    }

    public static class ClickDetector
    {
        public const long MaxActivationDistance = 0x100;
        public const long MouseIcon = 0xe0;
    }

    public static class DataModel
    {
        public const long CreatorId = 0x188;
        public const long GameId = 0x190;
        public const long GameLoaded = 0x5f8;
        public const long JobId = 0x138;
        public const long PlaceId = 0x198;
        public const long PlaceVersion = 0x1b4;
        public const long PrimitiveCount = 0x438;
        public const long ScriptContext = 0x3f0;
        public const long ServerIP = 0x5e0;
        public const long Workspace = 0x178;
    }

    public static class DepthOfFieldEffect
    {
        public const long Enabled = 0xc8;
        public const long FarIntensity = 0xd0;
        public const long FocusDistance = 0xd4;
        public const long InFocusRadius = 0xd8;
        public const long NearIntensity = 0xdc;
    }

    public static class FFlag
    {
        public const long FLogSetGet = 0x20;
        public const long Value = 0xc8;
    }

    public static class FFlags
    {
        public const long DebugDisableTimeoutDisconnect = 0x6898e08;
        public const long EnableLoadModule = 0x688de60;
        public const long PartyPlayerInactivityTimeoutInSeconds = 0x684892c;
        public const long NextGenReplicatorEnabledWrite4 = 0x68DB690;
        public const long PhysicsSenderMaxBandwidthBps = 0x6848e04;
        public const long PhysicsSenderMaxBandwidthBpsScaling = 0x6848e04;
        public const long TaskSchedulerLimitTargetFpsTo2402 = 0x0;
        public const long TaskSchedulerTargetFps = 0x75a7c64;
        public const long WebSocketServiceEnableClientCreation = 0x68a5bf8;
        public const long WorldStepMax = 0x684ca74;
        public const long WorldStepsOffsetAdjustRate = 0x684ca70;
    }

    public static class FakeDataModel
    {
        public const long Pointer = 0x7c75728;
        public const long RealDataModel = 0x1c0;
    }

    public static class GuiObject
    {
        public const long BackgroundColor3 = 0x548;
        public const long BorderColor3 = 0x554;
        public const long Image = 0xa00;
        public const long LayoutOrder = 0x584;
        public const long Position = 0x518;
        public const long RichText = 0xaa8;
        public const long Rotation = 0x188;
        public const long ScreenGui_Enabled = 0x4cc;
        public const long Size = 0x538;
        public const long Text = 0xe08;
        public const long TextColor3 = 0xeb8;
        public const long Visible = 0x5b1;
    }

    public static class Humanoid
    {
        public const long AutoRotate = 0x1d9;
        public const long FloorMaterial = 0x190;
        public const long Health = 0x194;
        public const long HipHeight = 0x1a0;
        public const long HumanoidState = 0x8d8;
        public const long HumanoidStateID = 0x20;
        public const long Jump = 0x1dd;
        public const long JumpHeight = 0x1ac;
        public const long JumpPower = 0x1b0;
        public const long MaxHealth = 0x1b4;
        public const long MaxSlopeAngle = 0x1b8;
        public const long MoveDirection = 0x0;
        public const long RigType = 0x1C8;
        public const long Walkspeed = 0x1d4;
        public const long WalkspeedCheck = 0x3c0;
    }

    public static class Instance
    {
        public const long AttributeContainer = 0x48;
        public const long AttributeList = 0x18;
        public const long AttributeToNext = 0x58;
        public const long AttributeToValue = 0x18;
        public const long ChildrenEnd = 0x8;
        public const long ChildrenStart = 0x70;
        public const long ClassBase = 0xcf0;
        public const long ClassDescriptor = 0x18;
        public const long ClassName = 0x8;
        public const long Name = 0xb0;
        public const long Parent = 0x68;
    }

    public static class Lighting
    {
        public const long Ambient = 0xd8;
        public const long Brightness = 0x120;
        public const long ClockTime = 0x1b8;
        public const long ColorShift_Bottom = 0xf0;
        public const long ColorShift_Top = 0xe4;
        public const long ExposureCompensation = 0x12c;
        public const long FogColor = 0xfc;
        public const long FogEnd = 0x134;
        public const long FogStart = 0x138;
        public const long GeographicLatitude = 0x190;
        public const long OutdoorAmbient = 0x108;
    }

    public static class LocalScript
    {
        public const long ByteCode = 0x1a8;
    }

    public static class MeshPart
    {
        public const long MeshId = 0x2e8;
        public const long Texture = 0x318;
    }

    public static class Misc
    {
        public const long Adornee = 0x108;
        public const long AnimationId = 0xd0;
        public const long RequireLock = 0x0;
        public const long StringLength = 0x10;
        public const long Value = 0xd0;
    }

    public static class Model
    {
        public const long PrimaryPart = 0x278;
        public const long Scale = 0x164;
    }

    public static class ModuleScript
    {
        public const long ByteCode = 0x150;
    }

    public static class MouseService
    {
        public const long InputObject = 0x100;
        public const long MousePosition = 0xec;
        public const long SensitivityPointer = 0x7cfd200;
    }

    public static class Player
    {
        public const long CameraMode = 0x318;
        public const long Country = 0x110;
        public const long DisplayName = 0x130;
        public const long Gender = 0xeb8;
        public const long LocalPlayer = 0x130;
        public const long MaxZoomDistance = 0x310;
        public const long MinZoomDistance = 0x314;
        public const long ModelInstance = 0x380;
        public const long Mouse = 0xd28;
        public const long Team = 0x290;
        public const long UserId = 0x2b8;
    }

    public static class PlayerConfigurer
    {
        public const long OverrideDuration = 0x3b8;
        public const long Pointer = 0x7c53948;
    }

    public static class PlayerMouse
    {
        public const long Icon = 0xe0;
        public const long Workspace = 0x168;
    }

    public static class PrimitiveFlags
    {
        public const long Anchored = 0x2;
        public const long CanCollide = 0x8;
        public const long CanTouch = 0x10;
    }

    public static class ProximityPrompt
    {
        public const long ActionText = 0xd0;
        public const long Enabled = 0x156;
        public const long GamepadKeyCode = 0x13c;
        public const long HoldDuration = 0x140;
        public const long KeyCode = 0x144;
        public const long MaxActivationDistance = 0x148;
        public const long ObjectText = 0xf0;
        public const long RequiresLineOfSight = 0x157;
    }

    public static class RenderView
    {
        public const long DeviceD3D11 = 0x8;
        public const long LightingValid = 0x148;
        public const long VisualEngine = 0x10;
    }

    public static class RunService
    {
        public const long HeartbeatFPS = 0xc0;
        public const long HeartbeatTask = 0xe8;
    }

    public static class Sky
    {
        public const long MoonAngularSize = 0x25c;
        public const long MoonTextureId = 0xe0;
        public const long SkyboxBk = 0x110;
        public const long SkyboxDn = 0x140;
        public const long SkyboxFt = 0x170;
        public const long SkyboxLf = 0x1a0;
        public const long SkyboxOrientation = 0x250;
        public const long SkyboxRt = 0x1d0;
        public const long SkyboxUp = 0x200;
        public const long StarCount = 0x260;
        public const long SunAngularSize = 0x254;
        public const long SunTextureId = 0x230;
    }

    public static class SpecialMesh
    {
        public const long MeshId = 0x108;
        public const long Scale = 0x164;
    }

    public static class StatsItem
    {
        public const long Value = 0x1c8;
        public const long Ping = 0xC8;
    }

    public static class SunRaysEffect
    {
        public const long Enabled = 0xd0;
        public const long Intensity = 0xd0;
        public const long Spread = 0xd4;
    }

    public static class TaskScheduler
    {
        public const long FakeDataModelToDataModel = 0x1b0;
        public const long JobEnd = 0x1d8;
        public const long JobName = 0x18;
        public const long JobStart = 0x1d0;
        public const long MaxFPS = 0x1b0;
        public const long Pointer = 0x7d33708;
        public const long RenderJobToFakeDataModel = 0x38;
        public const long RenderJobToRenderView = 0x218;
    }

    public static class Team
    {
        public const long BrickColor = 0xd0;
    }

    public static class Terrain
    {
        public const long GrassLength = 0x1f8;
        public const long WaterColor = 0x1e8;
        public const long WaterReflectance = 0x200;
        public const long WaterTransparency = 0x1ec;
        public const long WaterWaveSize = 0x208;
        public const long WaterWaveSpeed = 0x20c;
    }

    public static class Textures
    {
        public const long Decal_Texture = 0x198;
        public const long Texture_Texture = 0x198;
    }

    public static class VisualEngine
    {
        public const long Dimensions = 0x720;
        public const long Pointer = 0x775e8d0;
        public const long ToDataModel1 = 0x700;
        public const long ToDataModel2 = 0x1c0;
        public const long ViewMatrix = 0x120;
    }

    public static class Workspace
    {
        public const long CurrentCamera = 0x460;
        public const long DistributedGameTime = 0x480;
        public const long Gravity = 0x1d0;
        public const long GravityContainer = 0x3d8;
        public const long PrimitivesPointer1 = 0x3d8;
        public const long PrimitivesPointer2 = 0x240;
        public const long ReadOnlyGravity = 0x940;
    }
}