using System;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using HelloMvx5Forms.Core.Models;

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
                NavModel navData = new NavModel();
                navData.Message = $"[{System.DateTime.Now}] Message from master: {Guid.NewGuid()}";
				_navigateCommand = _navigateCommand ?? new MvxAsyncCommand(() => _navigationService.Navigate<DetailViewModel, NavModel>(navData));
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
