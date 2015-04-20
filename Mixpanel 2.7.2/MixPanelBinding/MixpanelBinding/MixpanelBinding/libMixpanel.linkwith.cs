using System;
using ObjCRuntime;

[assembly: LinkWith (
    "libMixpanel.a",
    LinkTarget = LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator | LinkTarget.Simulator64,
    Frameworks = "MapKit ImageIO Accelerate Security CFNetwork AdSupport CoreGraphics CoreTelephony Foundation QuartzCore SystemConfiguration UIKit",
    LinkerFlags = "-ObjC -licucore",
    SmartLink = true,
    ForceLoad = true
)]