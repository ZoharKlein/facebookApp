namespace Program
{
    internal class LikedPagesComposite : ILikedPagesComponent
    {
        public event LikedPagesComponentDelegate<ILikedPagesComponent> AddPageComponent;

        public event LikedPagesComponentDelegate<ILikedPagesComponent> RemovePageComponent;

        public TreeNodeProxy Node { get; set; }

        public string LikedPageName { get; private set; }

        public LikedPagesComposite(string i_LikedPageName)
        {
            LikedPageName = i_LikedPageName;
        }

        public void OnAddPageComponent(ILikedPagesComponent i_AddPageComponent)
        {
            AddPageComponent.Invoke(i_AddPageComponent);
        }

        public void OnRemovePageComponent(ILikedPagesComponent i_RemovePageComponent)
        {
            RemovePageComponent.Invoke(i_RemovePageComponent);
        }
    }
}
