using System.Drawing;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Program
{
    public class FacadeFormDiscoverMeMain
    {
        public User LoggedInUser { get; private set; }

        public LoginResult LoginUser { get; private set; }

        public string ProfilePictuerStr { get; private set; }

        public string ProfileNameStr { get; private set; }

        public string ProfileEmailStr { get; private set; }

        public int SumOfAllFriends { get; private set; }

        public int SumOfAllMarried { get; private set; }

        public int SumOfAllSingle { get; private set; }

        public List<DiscoverMeUser> MaleFriends { get; private set; }

        public List<DiscoverMeUser> FemaleFriends { get; private set; }
       
        public DiscoverMeUserFriends m_DiscoverMeUserFriends = null;
        public readonly List<Event> m_EventsList = new List<Event>();
        private static UserCategorization m_UserCategorization = null;
        private readonly FacadeFilterImage r_FacadeFilterImage = new FacadeFilterImage();
        public Image m_OriginalProfilePictureImage;

        internal void LoginAndInit()
        {
            LoginUser = FacebookService.Login(FormDiscoverMeLogin.Instance.AppID, "public_profile", "user_birthday", "user_about_me", "user_friends", "user_events", "user_likes", "user_photos", "user_relationships", "user_relationship_details");
            LoggedInUser = LoginUser.LoggedInUser;
        }

        internal void LoadProfileImage()
        {
            ProfilePictuerStr = LoggedInUser.PictureNormalURL;
        }

        internal void LoadBasicInfoOnMenuBar()
        {
            ProfileNameStr = LoggedInUser.Name;
            ProfileEmailStr = LoggedInUser.Email;
        }

        internal void FetchFriends()
        {
            m_UserCategorization = new UserCategorization(LoggedInUser);
            m_DiscoverMeUserFriends = new DiscoverMeUserFriends(LoggedInUser);
            m_UserCategorization.DiscoverMeUserFriends = m_DiscoverMeUserFriends;
            m_UserCategorization.CountFriendsAndCategorizationFriendsByRelationship();
            m_UserCategorization.CategorizationFriendsByGender();
            m_UserCategorization.AddAllFriends();
            m_UserCategorization.AddAllFriendsName();
            updateFetchFriendsProperties();
        }

        private void updateFetchFriendsProperties()
        {
            SumOfAllFriends = m_UserCategorization.SumOfAllFriends;
            SumOfAllSingle = m_UserCategorization.SumOfAllSingle;
            SumOfAllMarried = m_UserCategorization.SumOfAllMarried;
            MaleFriends = m_UserCategorization.MaleFriends;
            FemaleFriends = m_UserCategorization.FemaleFriends;
        }

        internal List<DiscoverMeUser> getAllFriends()
        {
            return m_UserCategorization.ListOfAllUser;
        }

        internal List<string> getAllFriendsNames()
        {
            return m_UserCategorization.ListOfAllUserNames;
        }

        internal Status PostStatus(string i_TextToPost)
        {
            return this.LoggedInUser.PostStatus(i_TextToPost);
        }

        internal Image ChangeProfilePictureBySelectedItem(string i_SelectedItem)
        {
            r_FacadeFilterImage.OriginalProfilePicture = m_OriginalProfilePictureImage;

            return r_FacadeFilterImage.ChangeFilterImage(i_SelectedItem);
        }

        internal void sortFriendImagesByUserChoice(int i_SelectedUserChoiseToSortFriendImages)
        {
            FriendImagesSorter sorter = new FriendImagesSorter();

            switch (i_SelectedUserChoiseToSortFriendImages)
            {
                case (int)eSortFriendImages.MinLength:
                            sorter.Comparer = new MinComparer();    
                        break;

                case (int)eSortFriendImages.MaxLength:
                        sorter.Comparer = new MaxComparer();
                        break;

                case (int)eSortFriendImages.Alphabet:
                        sorter.Comparer = new AlphabetComparer();
                        break; 
                    
                default:
                    break;
            }

            sorter.Sort(MaleFriends);
            sorter.Sort(FemaleFriends);
        }
    }
}
