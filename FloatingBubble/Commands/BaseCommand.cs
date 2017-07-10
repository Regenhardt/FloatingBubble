using System;
using System.Windows.Input;

namespace FloatingBubble.Commands
{
	/// <summary>
	/// Base class for Commands
	/// </summary>
	internal abstract class BaseCommand : ICommand
	{
		/// <summary>
		/// The viewmodel containing buisnesslogic for this command
		/// </summary>
		protected internal object Viewmodel;

		/// <summary>
		/// Baseconstructor for the Commands
		/// </summary>
		/// <param name="viewModel">The viewmodel containing buisnesslogic for this command</param>
		protected BaseCommand(object viewModel)
		{
			this.Viewmodel = viewModel;
		}

		#region [ ICommand Members ]

		/// <summary>
		/// Wire up command to CommandManager
		/// </summary>
		public event EventHandler CanExecuteChanged
		{
			//This is done to wire up to the WPF command center
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}

		/// <summary>
		/// Method to determin wether command can be executed or not.
		/// Usually references the viewmodel to decide this or not.
		/// </summary>
		/// <param name="parameter">Parameters passed to the command</param>
		/// <returns>If the command can be executed or not</returns>
		/// <example>{  return _viewmodel.CanExecuteBasecommand; }</example>
		public abstract bool CanExecute(object parameter);

		/// <summary>
		/// The execution logic for this command.
		/// Usually references the viewmodel to decide this or not.
		/// </summary>
		/// <param name="parameter">Parameters passed to the command</param>
		/// <example>{  _viewmodel.ExecuteBasecommand(parameter); }</example>
		public abstract void Execute(object parameter);

		#endregion
	}
}
