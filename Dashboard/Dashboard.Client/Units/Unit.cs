using System.Windows.Controls;

namespace Dashboard.Client.Units
{
    public abstract class Unit:UserControl
    {
        public bool Initialized { get; private set; }

        public void Initialize()
        {
            if (Initialized) return;

            DoInitialize();
            Initialized = true;
        }

        protected abstract void DoInitialize();
    }
}