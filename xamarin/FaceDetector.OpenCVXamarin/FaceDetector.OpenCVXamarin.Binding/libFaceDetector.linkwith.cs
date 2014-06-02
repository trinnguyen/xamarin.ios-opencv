using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libFaceDetector.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]
