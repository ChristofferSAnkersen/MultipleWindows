using System;
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
using MultipleWindows.ViewModels;

namespace MultipleWindows.Views
{
    /// <summary>
    /// Interaction logic for PersonEditView.xaml
    /// </summary>
    public partial class PersonEditView : Window
    {

        public PersonEditView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
