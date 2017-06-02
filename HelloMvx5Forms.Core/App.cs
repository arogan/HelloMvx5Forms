using MvvmCross.Platform.IoC;
using HelloMvx5Forms.Core.ViewModels;

namespace HelloMvx5Forms.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.MasterViewModel>();
        }
    }
}
