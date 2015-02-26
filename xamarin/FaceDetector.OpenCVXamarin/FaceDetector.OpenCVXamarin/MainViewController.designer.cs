// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace FaceDetector.OpenCVXamarin
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnDetect { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imageView { get; set; }

		[Action ("btnDetect_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnDetect_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnDetect != null) {
				btnDetect.Dispose ();
				btnDetect = null;
			}
			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}
		}
	}
}
