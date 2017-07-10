using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingBubble.Viewmodels
{
	public class ProgramViewmodel : BaseNotify
	{
		public ProgramViewmodel()
		{

			//bind to the application
			((App)System.Windows.Application.Current).PropertyChanged += (s, e) =>
			{
				if (e.PropertyName == "ShowBubble")
					RaisePropertyChanged("IsVisibile");
			};
		}


		public bool IsVisibile
		{
			get
			{
				return !((App)System.Windows.Application.Current).ShowBubble;
			}
			set
			{
				/*
					Binding to visibilitiy requiers a two way mode
					Thats why i've added a setter wich does not do anything
					Because where i am binding to this property, i would never set, only read.
				*/
			}
		}
	}
}
