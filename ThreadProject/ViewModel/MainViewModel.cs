using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ThreadProject.Commands;

namespace ThreadProject.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public RelayCommand StopCommand { get; set; }
        public RelayCommand PlayCommand { get; set; }
        public RelayCommand PauseCommand { get; set; }
        public RelayCommand ResumeCommand { get; set; }
        public RelayCommand AddItemCommand { get; set; }

        private ObservableCollection<string> unencryptedItems = new ObservableCollection<string>();
        public ObservableCollection<string> UnencryptedItems
        {
            get { return unencryptedItems; }
            set { unencryptedItems = value; OnPropertyChanged(); }
        }

        private ObservableCollection<string> encryptedItems = new ObservableCollection<string>();
        public ObservableCollection<string> EncryptedItems
        {
            get { return encryptedItems; }
            set { encryptedItems = value; OnPropertyChanged(); }
        }

        private bool isEncryptionInProgress = false;
        private bool isPaused = false;

        private string addItem;
        public string AddItem
        {
            get { return addItem; }
            set { addItem = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            StopCommand = new RelayCommand((obj) =>
            {

            });

            PlayCommand = new RelayCommand((obj) =>
            {

            });

            PauseCommand = new RelayCommand((obj) =>
            {

            });

            ResumeCommand = new RelayCommand((obj) =>
            {

            });

            AddItemCommand = new RelayCommand((obj) =>
            {
                if (!string.IsNullOrEmpty(AddItem))
                {
                    UnencryptedItems.Add(AddItem);
                    AddItem = String.Empty;
                }
            });
        }
    }
}
