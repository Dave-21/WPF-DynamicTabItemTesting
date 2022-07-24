using System.ComponentModel;
using DynamicTestingWPF.Models;
using System.Collections.ObjectModel;
using System.Collections.Generic;

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

        public ListBoxTestWindowViewModel(List<string> buttonContents)
        {
            TextBlocks = new ObservableCollection<TextBlockTemplate>();

            foreach (string content in buttonContents)
            {
                TextBlocks.Add(new TextBlockTemplate() { TextBlockContent = content });
            }
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
