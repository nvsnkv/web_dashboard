using System.Windows.Controls;

namespace Dashboard.Client.Units
{
    public abstract class Unit:UserControl
    {
        protected Unit(uint row, uint column)
        {
            Column = column;
            Row = row;
        }

        public uint Row { get; private set; }
        public uint Column { get; private set; }


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