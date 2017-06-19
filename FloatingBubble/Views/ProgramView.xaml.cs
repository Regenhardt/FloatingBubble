using System.Windows;

namespace FloatingBubble.Views
{
    /// <summary>
    /// Interaction logic for ProgramView.xaml
    /// </summary>
    public partial class ProgramView : Window
    {
        public ProgramView()
        {
            InitializeComponent();
            this.DataContext = new Viewmodels.ProgramViewmodel();
        }
    }
}
