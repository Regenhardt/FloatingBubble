using System.Windows;
using System.Windows.Input;

namespace FloatingBubble.Views
{
	/// <summary>
	/// Interaction logic for Bubble.xaml
	/// </summary>
	public partial class Bubble : Window
	{
		public Bubble()
		{
			InitializeComponent();

			this.DataContext = new Viewmodels.BubbleViewmodel();
		}

		/// <summary>
		/// Breaking MVVM for simplicity!
		/// Enabling to move the bubble.
		/// Taken from: https://stackoverflow.com/a/7418629/5757162
		/// </summary>
		private void Move_Bubble(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
				this.DragMove();
		}
	}
}
