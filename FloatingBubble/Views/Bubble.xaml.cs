﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FloatingBubble
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

        /// <summary>
        /// Breaking MVVM for simplicity!
        /// Enabling to move the bubble.
        /// </summary>
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
