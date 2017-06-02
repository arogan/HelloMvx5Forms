using System;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace HelloMvx5Forms.Core.ViewModels
{
    public class MasterViewModel: MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        
        private static int instanceCount = 0;
        public int InstanceCount
        {
            get { return instanceCount; }
            set
            {
                //instanceCount = value;
                //RaisePropertyChanged(() => InstanceCount);
                SetProperty(ref instanceCount, value);
            }
        }

		private IMvxAsyncCommand _navigateCommand;
		public IMvxAsyncCommand NavigateCommand
		{
			get
			{
				_navigateCommand = _navigateCommand ?? new MvxAsyncCommand(() => _navigationService.Navigate<DetailViewModel>());
				return _navigateCommand;
			}
		}
        		
        public MasterViewModel(IMvxNavigationService nav)
        {
            _navigationService = nav;
            InstanceCount++;
        }
    }
}
