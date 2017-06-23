using System;
using System.ComponentModel;
using System.Diagnostics;

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

		/// <summary>
		/// Call with (null) to update all properties.
		/// </summary>
		/// <param name="propertyName">Name of the Property to update.</param>
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		/// <summary>
		/// Call from a property setter to notify about that property.
		/// </summary>
		protected void RaisePropertyChanged()
		{
			var methodName = new StackFrame(1).GetMethod().Name;
			if (!methodName.StartsWith("set_"))
				throw new Exception("This must be called from a property setter.");
			RaisePropertyChanged(methodName.Substring("set_".Length));
		}

		#endregion
	}
}
