using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DynamicTestingWPF.Models;
using DynamicTestingWPF.ViewModels;

namespace DynamicTestingWPF
{
    /// <summary>
    /// Interaction logic for ListBoxTestWindow.xaml
    /// </summary>
    public partial class ListBoxTestWindow : Window
    {
/*        private static List<string> things = new List<string>();
        private ListBoxTestWindowViewModel windowViewModel = new ListBoxTestWindowViewModel(things);*/

        public ListBoxTestWindow()
        {
            InitializeComponent();
            
            ListBoxTestWindowViewModel windowViewModel = null;

            this.DataContext = windowViewModel;
            List<string> things = new List<string>();

            things.Add("crep");
            things.Add("sheep");
            things.Add("beep");

            windowViewModel = new ListBoxTestWindowViewModel(things);

        }
    }
}
