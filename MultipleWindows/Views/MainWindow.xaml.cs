using MultipleWindows.ViewModels;
using System.Windows;

namespace MultipleWindows.Views
{
    public partial class MainWindow : Window
    {
        private MainViewModel mvm = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = mvm;
        }
    }
}
