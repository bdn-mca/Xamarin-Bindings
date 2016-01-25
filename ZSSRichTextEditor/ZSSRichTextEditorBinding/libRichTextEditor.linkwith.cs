using System;
using ObjCRuntime;

[assembly: LinkWith (
    "libRichTextEditor.a",
    LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64,
    Frameworks = "CoreGraphics CoreText",
    LinkerFlags = "-ObjC",
    SmartLink = true,
    ForceLoad = true)]
