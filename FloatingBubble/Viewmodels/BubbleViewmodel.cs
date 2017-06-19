using FloatingBubble.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingBubble.Viewmodels
{
    class BubbleViewmodel : BaseNotify
    {
        public BubbleViewmodel()
        {

            this.SwitchViews = new SwitchViewsCommand(this);
            CanExecuteSwitchViewsCommand = true;

            //bind to the application
            ((App) System.Windows.Application.Current).PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "ShowBubble")
                    RaisePropertyChanged("IsVisibile");
            };
        }

		
		public bool IsVisibile
		{
			get
			{                
				return ((App) System.Windows.Application.Current).ShowBubble;
			}            
            set
            {
                /*
                    Binding to visibilitiy requiers a two way mode
                    Thats why i've added a setter wich does not do anything
                    Because where i am binding to this property, iw ould never set, only read.
                */
            }
        }




		#region [ SwitchViewsCommand ]

		public SwitchViewsCommand SwitchViews { get; private set; }
			
        public bool CanExecuteSwitchViewsCommand { get; internal set; }

        public void ExecuteSwitchViewsCommand(object parameter)
        {
            ((App)System.Windows.Application.Current).ShowBubble = !((App)System.Windows.Application.Current).ShowBubble;
        }

        #endregion


    }
}
