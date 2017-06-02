using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.Platform;
using UIKit;
using Xamarin.Forms;
using HelloMvx5Forms.Core;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.iOS.Presenters;

namespace HelloMvx5Forms.Touch
{
    public class Setup : MvxIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }
        
        public Setup(IMvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new HelloMvx5Forms.Core.App();
        }
        
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

		protected override IMvxIosViewPresenter CreatePresenter()
		{
			Forms.Init();

			var xamarinFormsApp = new MvxFormsApplication();
			return new MvxFormsIosPagePresenter(Window, xamarinFormsApp);
		}
    }
}
