using System.Windows;

namespace ProiectM42
{
    public partial class MainWindow : Window
    {
        private ViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new ViewModel();
            DataContext = _viewModel;
        }

        private async void Button_Click_0(object sender, RoutedEventArgs e)
        {
            await _viewModel.MoveElevatorToFloor(0);
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            await _viewModel.MoveElevatorToFloor(1);
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            await _viewModel.MoveElevatorToFloor(2);
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            await _viewModel.MoveElevatorToFloor(3);
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            await _viewModel.MoveElevatorToFloor(4);
        }

        private async void Button_Click_5(object sender, RoutedEventArgs e)
        {
            await _viewModel.EmergencyStop();
        }
    }
}