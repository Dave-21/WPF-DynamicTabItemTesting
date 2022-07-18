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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DynamicTestingWPF.ViewModels;

namespace DynamicTestingWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //global variables
        //readonly MainWindowViewModel mainWindowViewModel;

        public MainWindow()
        {
            InitializeComponent();

            //setting DataContext of UserControls to the window's dataContext so that they can interface
            datasetsUserControl.DataContext = this.DataContext;
            graphsUserControl.DataContext = this.DataContext;

            //initializing view model
            //mainWindowViewModel = new MainWindowViewModel();

            //setting datacontext
            //this.DataContext = mainWindowViewModel;
        }
    }
}
