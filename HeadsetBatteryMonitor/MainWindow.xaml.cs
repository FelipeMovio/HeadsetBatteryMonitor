using HeadsetBatteryMonitor.ViewModels;
using System.Windows;

namespace HeadsetBatteryMonitor;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}