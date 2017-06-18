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
        }

		
		public bool IsVisibile
		{
			get
			{
				return App.ShowBubble;
			}
		}




		#region [ SwitchViewsCommand ]

		public SwitchViewsCommand SwitchViews { get; private set; }
			
        public bool CanExecuteSwitchViewsCommand { get; internal set; }

        public void ExecuteSwitchViewsCommand(object parameter)
        {
            var args = (Interfaces.IHideShowAndCloseable[])parameter;

            args[0].Hide();
            args[1].Show();
        }

        #endregion


    }
}
