using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ProiectM42
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Sensor colors
        private Brush _b10Color = Brushes.Green;
        private Brush _b6Color = Brushes.Red;
        private Brush _b7Color = Brushes.Red;
        private Brush _b8Color = Brushes.Red;
        private Brush _b9Color = Brushes.Red;
        private Brush _b11Color = Brushes.Red;

        // Sensor color properties
        public Brush B10Color
        {
            get => _b10Color;
            set { _b10Color = value; OnPropertyChanged(nameof(B10Color)); }
        }
        public Brush B6Color
        {
            get => _b6Color;
            set { _b6Color = value; OnPropertyChanged(nameof(B6Color)); }
        }
        public Brush B7Color
        {
            get => _b7Color;
            set { _b7Color = value; OnPropertyChanged(nameof(B7Color)); }
        }
        public Brush B8Color
        {
            get => _b8Color;
            set { _b8Color = value; OnPropertyChanged(nameof(B8Color)); }
        }
        public Brush B9Color
        {
            get => _b9Color;
            set { _b9Color = value; OnPropertyChanged(nameof(B9Color)); }
        }
        public Brush B11Color
        {
            get => _b11Color;
            set { _b11Color = value; OnPropertyChanged(nameof(B11Color)); }
        }

        private int _currentFloor = 0;

        // Simulate elevator movement
        public async Task MoveElevatorToFloor(int targetFloor)
        {
            if (_currentFloor == targetFloor) return;

            ResetSensorColors();
            int delay = Math.Abs(targetFloor - _currentFloor) * 1000;
            await Task.Delay(delay);

            switch (targetFloor)
            {
                case 0: B10Color = Brushes.Green; break;
                case 1: B6Color = Brushes.Green; break;
                case 2: B7Color = Brushes.Green; break;
                case 3: B8Color = Brushes.Green; break;
                case 4: B9Color = Brushes.Green; break;
            }

            _currentFloor = targetFloor;
        }

        public async Task EmergencyStop()
        {
            B11Color = Brushes.Green;
            await Task.Delay(5000);
            B11Color = Brushes.Red;
            await MoveElevatorToFloor(0);
        }

        private void ResetSensorColors()
        {
            B10Color = Brushes.Red;
            B6Color = Brushes.Red;
            B7Color = Brushes.Red;
            B8Color = Brushes.Red;
            B9Color = Brushes.Red;
        }
    }
}