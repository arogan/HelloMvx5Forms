using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.Platform;
using Foundation;
using UIKit;
using MvvmCross.Forms.iOS;

namespace HelloMvx5Forms.Touch
{
	[Register("AppDelegate")]
	public partial class AppDelegate : MvxFormsApplicationDelegate
	{
		public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)		
		{
			Window = new UIWindow(UIScreen.MainScreen.Bounds);

			var setup = new Setup(this, Window);
			setup.Initialize();

			var startup = Mvx.Resolve<IMvxAppStart>();
			startup.Start();

			Window.MakeKeyAndVisible();

			return true;
		}
	}
}
