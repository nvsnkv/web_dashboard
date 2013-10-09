namespace Dashboard.Client.ViewModels
{
    public class MainViewModel:ViewModelBase
    {
        #region ctors
        public MainViewModel()
            : this(new DashboardViewModel())
        {

        }

        public MainViewModel(DashboardViewModel dashboard)
        {
            Dashboard = dashboard;
        } 
        #endregion

        public DashboardViewModel Dashboard { get; private set; }
    }
}