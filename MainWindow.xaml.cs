using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Hosting;
using System.Windows.Media.Imaging;
using DynamicTestingWPF.ViewModels;
using System.Collections.Generic;
using System.Windows.Navigation;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows.Data;
using Microsoft.Win32;
using System.Windows;
using System.Linq;
using System.Text;
using System;

using System.IO;

namespace DynamicTestingWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //global variables
        //readonly MainWindowViewModel mainWindowViewModel;
        //objects for caching
        //IHost host = Host.CreateDefaultBuilder().ConfigureServices(services => services.AddMemoryCache()).Build();

        IMemoryCache memoryCache = Host.CreateDefaultBuilder().ConfigureServices(services => services.AddMemoryCache()).Build().Services.GetRequiredService<IMemoryCache>();
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

        //cache image
        private void openFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            string filePath = string.Empty;

            Nullable<bool> dialogResult = fileDialog.ShowDialog();

            if(dialogResult == true)
            {
                filePath = fileDialog.FileName;
            }



            ImageCacher imageCacher = new ImageCacher(memoryCache);

            try
            {
                imageCacher.CacheImageNoModel(filePath);


                /*                //first pass
                                System.Diagnostics.Debug.WriteLine(imageCacher.GetImage(filePath));

                                //second pass
                                System.Diagnostics.Debug.WriteLine(imageCacher.GetImage(filePath));*/
            }
            catch(Exception)
            {
                //
            }


        }

        //get cached image
        private void getCachedImage_Click(object sender, RoutedEventArgs e)
        {
            string fileName = selectGetFileTextBox.Text;
            ImageCacher imageCacher = new ImageCacher(memoryCache);

            //ImageModel imageModel = imageCacher.GetImageFromCache(fileName);
            //BitmapImage bitmapImage = imageCacher.ConvertByteArrayToImage(imageModel.Content);

            ((MainWindowViewModel)this.DataContext).BitmapImageSource = imageCacher.GetImageFromCacheNoModel(fileName);
            //imageHolder.Source = bitmapImage;
        }
    }
}
