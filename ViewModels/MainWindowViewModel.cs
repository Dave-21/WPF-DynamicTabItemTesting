using DynamicTestingWPF.Commands;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using DynamicTestingWPF.Models;
using System.Collections.ObjectModel;

namespace DynamicTestingWPF.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private bool _isPanelVisible;
        private ICommand _showPanelCommand;
        private ICommand _hidePanelCommand;

        //for image in graph tabitem. In TG, it will be a list of BitmapImages. So, List<BitmapImage> _graphChartBitmapImages;
        private BitmapImage _bitmapImageSource;

        //for TextBox and Label
        private string _textBoxContent = string.Empty;
        //string labelContent = string.Empty;

        //for ListBox
        private ObservableCollection<TextBlockTemplate> _textBlocks;
        private int _selectedTxtBlockIndex;

        public MainWindowViewModel()
        {
            //default to not visible
            IsPanelVisible = false;
            TextBlocks = new ObservableCollection<TextBlockTemplate>();
        }

        //for ListBox
        public ObservableCollection<TextBlockTemplate> TextBlocks
        {
            get
            {
                return _textBlocks;
            }
            set
            {
                _textBlocks = value;
                OnPropertyChanged("TextBlocks");
            }
        }
        public int SelectedTxtBlockIndex
        {
            get
            {
                return _selectedTxtBlockIndex;
            }
            set
            {
                _selectedTxtBlockIndex = value;
                OnPropertyChanged("SelectedTxtBlockIndex");
            }
        }

        public BitmapImage BitmapImageSource
        {
            get
            {
                return _bitmapImageSource;
            }
            set
            {
                _bitmapImageSource = value;
                OnPropertyChanged("BitmapImageSource");
            }
        }

        public string TextBoxContent
        {
            get
            {
                return _textBoxContent;
            }
            set
            {
                _textBoxContent = value;
                //LabelContent = value;
                OnPropertyChanged("TextBoxContent");
            }
        }
/*        public string LabelContent
        {
            get
            {
                return labelContent;
            }
            set
            {
                labelContent = value;
                OnPropertyChanged("LabelContent");
            }
        }*/

        public bool IsPanelVisible
        {
            get
            {
                return _isPanelVisible;
            }
            set
            {
                _isPanelVisible = value;
                OnPropertyChanged("IsPanelVisible");
            }
        }

        public void ShowPanel()
        {
            IsPanelVisible = true;
        }
        public ICommand ShowPanelCommand
        {
            get
            {
                if (_showPanelCommand == null)
                {
                    _showPanelCommand = new RelayCommand(p => ShowPanel());
                }

                return _showPanelCommand;
            }
        }

        public void HidePanel()
        {
            IsPanelVisible = false;
        }
        public ICommand HidePanelCommand
        {
            get
            {
                if (_hidePanelCommand == null)
                {
                    _hidePanelCommand = new RelayCommand(p => HidePanel());
                }

                return _hidePanelCommand;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
