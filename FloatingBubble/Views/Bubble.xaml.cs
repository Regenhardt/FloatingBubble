using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FloatingBubble.Viewmodels;

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
		}

		public Bubble(UIElement inlay):this()
		{
			Holder.Children.Add(inlay);
		}

		/// <summary>
		/// Breaking MVVM for simplicity!
		/// Enabling to move the bubble.
		/// Taken from: https://stackoverflow.com/a/7418629/5757162
		/// </summary>
		private void Move_Bubble(object sender, MouseButtonEventArgs e)
		{
			this.DragMove();
			e.Handled = true;
		}

		private void EnBubble(object sender, EventArgs e)
		{
			((BubbleViewmodel)DataContext).EnBubbleCommand.Execute(null);
		}
	}
}
