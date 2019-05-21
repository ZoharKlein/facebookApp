using System;

namespace Program
{
    internal class LikedPagesItem : ILikedPagesComponent
    {
        public event LikedPagesComponentDelegate<ILikedPagesComponent> AddPageComponent;

        public event LikedPagesComponentDelegate<ILikedPagesComponent> RemovePageComponent;

        public TreeNodeProxy Node { get; set; }

        public string LikedPageName { get; private set; }

        public LikedPagesItem(string i_LikedPageName)
        {
            LikedPageName = i_LikedPageName;
        }

        public void OnAddPageComponent(ILikedPagesComponent i_AddPageComponent)
        {
            throw new Exception("You can't add a Page to into another Page");
        }

        public void OnRemovePageComponent(ILikedPagesComponent i_RemovePageComponent)
        {
            RemovePageComponent.Invoke(i_RemovePageComponent);
        }
    }
}
