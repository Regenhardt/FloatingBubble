using FloatingBubble.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FloatingBubble.Viewmodels
{
	public class BubbleViewmodel : BaseNotify
	{

		#region [ Fields ]

		#endregion

		#region [ Properties ]

		public bool BubbleVisible
		{
			get => bubbleVisible;
			set
			{
				bubbleVisible = value;
				RaisePropertyChanged(nameof(BubbleVisible));
			}
		}
		private bool bubbleVisible;

		#endregion

		#region [ Commands ]

		#region [ SwitchViewsCommand ]


		public ICommand SwitchViews
		{
			get { return switchViews ?? (switchViews = new RelayCommand((o) => BubbleVisible = !BubbleVisible)); }
			set => switchViews = value;
		}
		private ICommand switchViews;


		#endregion

		#endregion

		#region [ Constructors ]

		public BubbleViewmodel()
		{
		
			//bind to the application
			((App)System.Windows.Application.Current).PropertyChanged += (s, e) =>
		   {
			   if (e.PropertyName == "ShowBubble")
				   RaisePropertyChanged("IsVisibile");
		   };
		}

		#endregion






	}
}
