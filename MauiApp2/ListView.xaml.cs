using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace MauiApp2
{
    public partial class ListView : ContentPage
    {
        public ObservableCollection<Robot> Robots { get; set; } = new ObservableCollection<Robot>();

        public ListView()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public void AddRobot(Robot robot)
        {
            Robots.Add(robot);
        }
    }
}