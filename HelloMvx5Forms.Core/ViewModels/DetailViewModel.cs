using System;
using MvvmCross.Core.ViewModels;

namespace HelloMvx5Forms.Core.ViewModels
{
    public class DetailViewModel :MvxViewModel
    {
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

        private string parmValue = "NULL";
        public string ParmValue
        {
            get { return parmValue; }
            set 
            {
                //parmValue = value;
                //RaisePropertyChanged(() => ParmValue);
                SetProperty(ref parmValue, value);
            }
        }

		
        public DetailViewModel()
        {            
            InstanceCount++;
        }


    }
}
