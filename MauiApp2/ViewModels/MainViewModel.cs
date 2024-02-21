using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MauiApp2.ViewModels;

namespace MauiApp2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private int size;
        public int Size
        {
            get { return size; }
            set { size = value; OnPropertyChanged(); }
        }

        private string robotType;
        public string RobotType
        {
            get { return robotType; }
            set { robotType = value; OnPropertyChanged(); }
        }

        public List<string> Types { get; set; } = new List<string>()
        {
            "Droïde de protocole",
            "Droïde astromécano",
        };

        public ObservableCollection<Robot> Robots { get; set; } = new ObservableCollection<Robot>() {
            new Robot(){
                Name = "ZAHR",
                RobotType = "Droïde astromécano", 
                Size = 10
            }
        };

        public MainViewModel()
        {
            AddRobotCommand = new Command(AddRobot);
        }

        public ICommand AddRobotCommand { get; private set; }

        public void AddRobot(object obj)
        {
            Robots.Add(new Robot { Name = this.Name, RobotType = this.RobotType, Size = this.Size });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
