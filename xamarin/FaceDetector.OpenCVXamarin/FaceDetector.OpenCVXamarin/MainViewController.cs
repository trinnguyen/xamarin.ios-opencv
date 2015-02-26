using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;
using CoreGraphics;

namespace FaceDetector.OpenCVXamarin
{
	partial class MainViewController : UIViewController
	{
        private FaceDetector.OpenCVXamarin.Binding.FaceDetector _faceDetector;
		public MainViewController (IntPtr handle) : base (handle)
		{
			string filePath = NSBundle.MainBundle.PathForResource ("haarcascade_frontalface_alt", "xml");
			_faceDetector = new FaceDetector.OpenCVXamarin.Binding.FaceDetector (filePath);
		}

		partial void btnDetect_TouchUpInside (UIButton sender)
		{
			UIImage srcImage = UIImage.FromBundle("lena1");
			NSArray arrFaces = _faceDetector.DetectFaces(srcImage);

			//debug
			Console.WriteLine ("faces count: {0}", arrFaces.Count);
			for (nuint i=0; i<arrFaces.Count; i++ )	{
				NSValue valRect = arrFaces.GetItem<NSValue>(i);
				Console.WriteLine ("face: {0}", valRect.CGRectValue);
			}

			//redraw image
			UIImage resultImage = this.DrawFaces(srcImage, arrFaces);
			this.imageView.Image = resultImage;
		}

		UIImage DrawFaces (UIImage srcImage, NSArray arrFaces)
		{
			UIGraphics.BeginImageContext (srcImage.Size);
			CGContext context = UIGraphics.GetCurrentContext();

			//draw src image
			srcImage.Draw (new CGRect (0, 0, srcImage.Size.Width, srcImage.Size.Height));

			//draw faces
            for (nuint i=0; i<arrFaces.Count; i++ )	{
				NSValue valRect = arrFaces.GetItem<NSValue>(i);
				CGRect rect = valRect.CGRectValue;

				//draw
				context.SetStrokeColor (UIColor.Red.CGColor);
				context.SetLineWidth (2);
				context.StrokeRect (rect);
			}

			UIImage dstImage = UIGraphics.GetImageFromCurrentImageContext ();
			UIGraphics.EndImageContext ();
			return dstImage;
		}
	}
}
