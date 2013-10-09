﻿using System.Windows;
using System.Windows.Controls;

namespace Dashboard.Client.Units
{
    public abstract class Unit:UserControl
    {
        protected Unit(int row, int column, int rowSpan, int columnSpan)
        {
            ColumnSpan = columnSpan;
            RowSpan = rowSpan;
            Column = column;
            Row = row;

        }

        public int Row { get; private set; }
        public int Column { get; private set; }

        public int RowSpan { get; private set; }
        public int ColumnSpan { get; private set; }
        
        public bool Initialized { get; private set; }
        public bool Positioned { get; private set; }

        public void SetPosition()
        {
            SetAttachedProperties(this);
        }

        public void Initialize()
        {
            if (Initialized) return;

            DoInitialize();
            Initialized = true;
        }

        private void SetAttachedProperties(DependencyObject element)
        {
            if (Positioned) return;

            element.SetValue(Grid.RowProperty, Row);
            element.SetValue(Grid.ColumnProperty, Column);
            element.SetValue(Grid.RowSpanProperty, RowSpan);
            element.SetValue(Grid.ColumnSpanProperty, ColumnSpan);

            Positioned = true;
        }

        protected abstract void DoInitialize();
    }
}