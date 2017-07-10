using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingBubble.Commands
{
	/// <summary>
	/// 
	/// </summary>
	class SwitchViewsCommand : BaseCommand
	{
		/// <summary>
		/// Command to switch between the button and the "chat overlay"
		/// </summary>
		/// <param name="viewModel">The viewmodel containing buisnesslogic for this command</param>
		public SwitchViewsCommand(object viewModel) : base(viewModel)
		{
		}

		public override bool CanExecute(object parameter)
		{
			return true;
		}

		public override void Execute(object parameter)
		{
			return;
		}
	}
}
