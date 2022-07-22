using System.ComponentModel;
using DynamicTestingWPF.Models;
using System.Collections.ObjectModel;

namespace DynamicTestingWPF.ViewModels
{
    public class ListBoxTestWindowViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TextBlockTemplate> _textBlocks;
        private int _selectedTxtBlockIndex;

        public ListBoxTestWindowViewModel()
        {
            TextBlocks = new ObservableCollection<TextBlockTemplate>();
        }

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

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
