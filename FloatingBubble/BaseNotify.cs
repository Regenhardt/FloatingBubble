using System.ComponentModel;

namespace FloatingBubble
{
    /// <summary>
    /// Base class implementing the INotifyPropertyChanged interface.
    /// Used for Viewmodels and Models.
    /// </summary>
    abstract class BaseNotify : INotifyPropertyChanged
    {
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
