using System;
using MvvmCross.Core.ViewModels;

namespace HelloMvx5Forms.Core.ViewModels
{
    public class MasterViewModel: MvxViewModel
    {
        
        
        private static int instanceCount = 0;
        public int InstanceCount
        {
            get { return instanceCount; }
            set
            {
                instanceCount = value;
                RaisePropertyChanged(() => InstanceCount);
            }
        }
        public MasterViewModel()
        {
            InstanceCount++;
        }
    }
}
