using System;
using System.Windows.Threading;
using Dashboard.Client.ViewModels;

namespace Dashboard.Client.Units
{
    public partial class ClockUnit : Unit
    {
        public ClockUnit() : base(0,0)
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
                protected set
                {
                    if (value == _currentTime) return;
                    _currentTime = value;
                    NotifyPropertyChanged("CurrentTime");
                }
            }

            public ViewModel()
            {
                _timer.Tick += OnTimerTick;

                _timer.Start();
            }

            protected virtual void OnTimerTick(object sender, EventArgs e)
            {
                CurrentTime = DateTime.Now.ToShortTimeString();
            }
        }
    }
}
