namespace Program
{
    public delegate void LikedPagesComponentDelegate<T>(T i_Component);

    internal interface ILikedPagesComponent
    {
        string LikedPageName { get; }

        event LikedPagesComponentDelegate<ILikedPagesComponent> AddPageComponent;

        event LikedPagesComponentDelegate<ILikedPagesComponent> RemovePageComponent;
    }
}
