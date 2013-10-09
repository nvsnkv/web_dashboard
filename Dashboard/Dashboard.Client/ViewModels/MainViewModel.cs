using Dashboard.Client.Units;

namespace Dashboard.Client.ViewModels
{
    public class MainViewModel:ViewModelBase
    {
        #region ctors
        public MainViewModel()
        {
            Dashboard = new DashboardViewModel();
            
            var clock = new ClockUnit();
            
            var secondClock = new ClockUnit(1, 1, 1, 3);
            
            Dashboard.Units.Add(clock);
            Dashboard.Units.Add(secondClock);
        }

        public MainViewModel(DashboardViewModel dashboard)
        {
            Dashboard = dashboard;
        } 
        #endregion

        public DashboardViewModel Dashboard { get; private set; }
    }
}