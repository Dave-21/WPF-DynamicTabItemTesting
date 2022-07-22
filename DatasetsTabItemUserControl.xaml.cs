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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DynamicTestingWPF.ViewModels;
using DynamicTestingWPF.Models;
using System.Collections.ObjectModel;

namespace DynamicTestingWPF
{
    /// <summary>
    /// Interaction logic for DatasetsTabItemUserControl.xaml
    /// </summary>
    public partial class DatasetsTabItemUserControl : UserControl
    {
        public DatasetsTabItemUserControl()
        {
            InitializeComponent();

            ((MainWindowViewModel)this.DataContext).TextBlocks.Add(new TextBlockTemplate {
                TextBlockContent = "yeeters"
            });
            ((MainWindowViewModel)this.DataContext).TextBlocks.Add(new TextBlockTemplate
            {
                TextBlockContent = "333ters"
            });
            ((MainWindowViewModel)this.DataContext).TextBlocks.Add(new TextBlockTemplate
            {
                TextBlockContent = "skeeters"
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((MainWindowViewModel)this.DataContext).TextBoxContent);
        }
    }
}
