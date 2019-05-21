using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Program
{
    internal class FacadeFormDiscoverMeManageLikedPages
    {
        public readonly List<Page> m_PagesList = new List<Page>();
        public LikedPagesComposite m_LikedPagesComposite;
        public LikedPagesItem m_LikedPagesItem;

        public User LoggedInUser { get; set; }

        internal void FetchLikedPages()
        {
            foreach (Page page in LoggedInUser.LikedPages)
            {
                m_PagesList.Add(page);
            }
        }

        internal void CreateNewCompositeItem(string i_CategoryName)
        {
            m_LikedPagesComposite = new LikedPagesComposite(i_CategoryName);
        }

        internal void CreateNewItem(string i_PageName)
        {
            m_LikedPagesItem = new LikedPagesItem(i_PageName);
        }
    }
}
