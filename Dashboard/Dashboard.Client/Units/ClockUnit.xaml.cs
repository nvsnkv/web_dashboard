using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Dashboard.Client.ViewModels;

namespace Dashboard.Client.Units
{
    public partial class ClockUnit : Unit
    {
        public ClockUnit()
        {
            InitializeComponent();
        }

        protected override void DoInitialize()
        {
            DataContext = new ViewModel();
        }

        public class ViewModel:ViewModelBase
        {
            private readonly DispatcherTimer _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(332)
            };

            private string _currentTime;

            public string CurrentTime
            {
                get { return _currentTime; }
                private set
                {
                    if (value == _currentTime) return;
                    _currentTime = value;
                    NotifyPropertyChanged("CurrentTime");
                }
            }

            public ViewModel()
            {
                _timer.Tick += (sender, args) =>
                {
                    CurrentTime = DateTime.Now.ToShortTimeString();
                };

                _timer.Start();
            }
        }
    }
}
