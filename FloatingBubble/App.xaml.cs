using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Threading;

namespace FloatingBubble
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application, INotifyPropertyChanged
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

        //show bubble by default
        bool showBubble = true;

        /// <summary>
        /// boolean value to determin wether to show the bubble or sth else
        /// </summary>
        public bool ShowBubble
        {
            get
            {
                return showBubble;
            }
            set
            {
                if (showBubble != value)
                {
                    showBubble = value;
                    RaisePropertyChanged("ShowBubble");
                }
            }
        }


        #region [ INotifyPropertyChanged Members ]

        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
