using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace VisualTreeViewer
{
    public class TreeNode
    {
        private readonly List<TreeNode> _children = new List<TreeNode>();
        
        public FrameworkElement Item { get; private set; }

        public IEnumerable<TreeNode> Children
        {
            get { return _children; }
        }

        public TreeNode(FrameworkElement item)
        {
            Item = item;

            var childrenCount = VisualTreeHelper.GetChildrenCount(Item);
            for (var i = 0; i < childrenCount; i++)
            {
                _children.Add(new TreeNode((FrameworkElement)VisualTreeHelper.GetChild(Item,i)));
            }
        }

        public override string ToString()
        {
            return TypeInfo;
        }

        public string TypeInfo
        {
            get
            {
                return Item.GetType().Name + "(" + Item.GetType().BaseType.Name + ")";
            }
        }
    }
}