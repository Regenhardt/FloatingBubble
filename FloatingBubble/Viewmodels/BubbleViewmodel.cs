using FloatingBubble.Commands;
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
		
		public ICommand SwitchViews => switchViews ?? (switchViews = new RelayCommand((o) => BubbleVisible = !BubbleVisible));

		private ICommand switchViews;

		#endregion

		#region [ EnBubbleCommand ]

		/// <summary>
		/// Closes the window into the bubble.
		/// </summary>
		public ICommand EnBubbleCommand => enBubbleCommand ?? (enBubbleCommand = new RelayCommand(param => BubbleVisible = true));

		private ICommand enBubbleCommand;

		#endregion


		#endregion

		#region [ Constructors ]

		public BubbleViewmodel()
		{
		}

		#endregion
		
	}
}
