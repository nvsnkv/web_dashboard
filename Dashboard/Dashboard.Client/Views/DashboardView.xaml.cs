using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Dashboard.Client.Units;

namespace Dashboard.Client.Views
{
    public partial class DashboardView : ItemsControl
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            var unit = item as Unit;
            if (unit != null)
            {
                if (!unit.Initialized)
                    unit.Initialize();

                if (!unit.Positioned)
                    unit.SetPosition();
            }

            base.PrepareContainerForItemOverride(element, item);
        }
    }
}
