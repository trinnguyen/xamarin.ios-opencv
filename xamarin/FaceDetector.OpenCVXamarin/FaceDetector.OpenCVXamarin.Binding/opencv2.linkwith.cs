using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("opencv2.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, LinkerFlags="-lc++", Frameworks="Accelerate AssetsLibrary AVFoundation CoreGraphics CoreImage CoreMedia CoreVideo QuartzCore UIKit Foundation")]
