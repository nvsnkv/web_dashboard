using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Dashboard.Client.Units
{
    public class VisualTreeWalkingClockUnit : ClockUnit
    {
        protected override void DoInitialize()
        {
            DataContext = new VisualTreeWalkingViewModel(this);
        }

        public class VisualTreeWalkingViewModel:ViewModel
        {
            private readonly VisualTreeWalkingClockUnit _view;

            public VisualTreeWalkingViewModel(VisualTreeWalkingClockUnit view)
            {
                _view = view;
            }

            protected override void OnTimerTick(object sender, EventArgs e)
            {
                var parents = new List<DependencyObject>();
                
                var parent = VisualTreeHelper.GetParent(_view);
                while (parent != null)
                {
                    parents.Add(parent);
                    parent = VisualTreeHelper.GetParent(parent);
                }

                var parentsList = parents.Aggregate("", 
                    (current, obj) => current + (obj.GetType().Name + Environment.NewLine)
                    );

                CurrentTime = parentsList;
            }
        }
    }
}