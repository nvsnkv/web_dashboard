using System.Collections.ObjectModel;
using Dashboard.Client.Units;

namespace Dashboard.Client.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        public ObservableCollection<Unit> Units { get; private set; }

        public DashboardViewModel()
        {
            Units = new ObservableCollection<Unit>();
        }
    }
}