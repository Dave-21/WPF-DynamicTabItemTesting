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
        public ListBoxTestWindowViewModel windowViewModel = new ListBoxTestWindowViewModel();

        public ListBoxTestWindow()
        {
            InitializeComponent();

            this.DataContext = windowViewModel;

            windowViewModel.TextBlocks.Add(new TextBlockTemplate() { TextBlockContent = "skeeters" });
            windowViewModel.TextBlocks.Add(new TextBlockTemplate() { TextBlockContent = "skeeters" });
            windowViewModel.TextBlocks.Add(new TextBlockTemplate() { TextBlockContent = "skeeters" });
        }
    }
}
