//using System;
//using ObjCRuntime;
//
//[assembly: LinkWith ("libUserVoice.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]

using System;
using ObjCRuntime;

[assembly: LinkWith (
    "libUserVoice.a",
    LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.Simulator64,
    ForceLoad = true
)]
