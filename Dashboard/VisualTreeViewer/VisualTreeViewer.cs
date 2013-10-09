using System;
using System.Net;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace VisualTreeViewer
{
    public class VisualTreeBuilder
    {
        public VisualTreeBuilder(FrameworkElement element)
            :this(new TreeNode(element))
        {
            
        }

        public VisualTreeBuilder(TreeNode tree)
        {
            Tree = tree;
        }

        public TreeNode Tree { get; private set; }
    }
}
