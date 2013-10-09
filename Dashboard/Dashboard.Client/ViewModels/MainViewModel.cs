using Dashboard.Client.Units;

namespace Dashboard.Client.ViewModels
{
    public class MainViewModel:ViewModelBase
    {
        #region ctors
        public MainViewModel()
        {
            Dashboard = new DashboardViewModel();
            
            var clock = new VisualTreeWalkingClockUnit();
            clock.Initialize();

            Dashboard.Units.Add(clock);
        }

        public MainViewModel(DashboardViewModel dashboard)
        {
            Dashboard = dashboard;
        } 
        #endregion

        public DashboardViewModel Dashboard { get; private set; }
    }
}