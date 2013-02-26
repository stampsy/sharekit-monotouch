using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libShareKit.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true, Frameworks = "Social Accounts AdSupport CFNetwork Twitter CoreLocation CoreGraphics MessageUI Security SystemConfiguration CoreFoundation", LinkerFlags = "-sqlite3.0")]
