using System;
using System.ComponentModel;
using System.Windows.Threading;
using Dashboard.Client.ViewModels;

namespace Dashboard.Client.Units
{
    public partial class ClockUnit : Unit
    {
        public ClockUnit()
            : this(0, 0, 1, 2)
        {
            
        }

        public ClockUnit(int row, int column, int rowSpan, int columnSpan) 
            : base(row,column,rowSpan,columnSpan)
        {
            InitializeComponent();
        }

        public class ClockViewModel:ViewModelBase
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

            public ClockViewModel()
            {
                _timer.Tick += OnTimerTick;

                _timer.Start();
            }

            protected virtual void OnTimerTick(object sender, EventArgs e)
            {
                CurrentTime = DateTime.Now.ToLongTimeString();
            }
        }

        public override INotifyPropertyChanged ViewModel
        {
            get { return new ClockViewModel(); }
        }
    }
}
