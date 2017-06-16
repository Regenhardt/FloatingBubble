using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace FloatingBubble
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
    {
        /// <summary>
        /// Any exection that isn't caught by the application will be handled here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {            
            //if the exception is caused due to missing implementation.
            if (e.Exception is NotImplementedException)
            {
                string msg = "This area is still under construction!\r\nCheck back again later!";
                MessageBox.Show(msg, "Under construction", MessageBoxButton.OK, MessageBoxImage.Warning);
                //TODO: log it
                
                e.Handled = true;
            }
            else
            {
                MessageBox.Show("Unexpected error occured.");
                //TODO: LOG it and think of a good way to handle it
            }
        }
    }
}
