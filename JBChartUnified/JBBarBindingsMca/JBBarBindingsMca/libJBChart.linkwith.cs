using System;
using ObjCRuntime;

[assembly: LinkWith ("libJBChart.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator64,
	ForceLoad = true,
	Frameworks = "UIKit Foundation CoreGraphics",
	LinkerFlags = "-ObjC")]