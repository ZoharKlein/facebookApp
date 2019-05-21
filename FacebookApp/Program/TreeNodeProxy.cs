using System.Windows.Forms;

namespace Program
{
    internal class TreeNodeProxy : TreeNode
    {
        public ILikedPagesComponent Node { get; private set; }

        public TreeNodeProxy(string i_LikedPageName, ILikedPagesComponent i_Node) : base(i_LikedPageName)
        {
            Node = i_Node;
            Node.AddPageComponent += OnAddComponent;
            Node.RemovePageComponent += OnRemoveComponent;
        }

        private void OnAddComponent(ILikedPagesComponent i_AddComponent)
        {
            if(i_AddComponent is LikedPagesComposite)
            {
                Nodes.Add((i_AddComponent as LikedPagesComposite).Node = new TreeNodeProxy(i_AddComponent.LikedPageName, i_AddComponent));
            }
            else if (i_AddComponent is LikedPagesItem)
            {
                Nodes.Add((i_AddComponent as LikedPagesItem).Node = new TreeNodeProxy(i_AddComponent.LikedPageName, i_AddComponent));
            }
        }

        private void OnRemoveComponent(ILikedPagesComponent i_RemoveComponent)
        {
            if (i_RemoveComponent is LikedPagesComposite)
            {
                Nodes.Remove((i_RemoveComponent as LikedPagesComposite).Node = new TreeNodeProxy(i_RemoveComponent.LikedPageName, i_RemoveComponent));
            }
            else if (i_RemoveComponent is LikedPagesItem)
            {
                Nodes.Remove((i_RemoveComponent as LikedPagesItem).Node = new TreeNodeProxy(i_RemoveComponent.LikedPageName, i_RemoveComponent));
            }
        }
    }
}
