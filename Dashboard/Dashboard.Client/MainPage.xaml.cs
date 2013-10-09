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
using VisualTreeViewer;

namespace Dashboard.Client
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var builder = new VisualTreeBuilder((FrameworkElement)VisualTreeHelper.GetRoot(LayoutRoot));
            TreeViewer.ItemsSource = new[] { builder.Tree };
        }
    }
}
