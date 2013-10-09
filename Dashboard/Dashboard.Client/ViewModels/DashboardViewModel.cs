using System.Collections.ObjectModel;
using System.Windows;

namespace Dashboard.Client.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        public ObservableCollection<UIElement> Views { get; private set; }
    }
}