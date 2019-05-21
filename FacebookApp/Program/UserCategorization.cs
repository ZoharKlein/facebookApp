using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Program
{
    internal class UserCategorization
    {
        public ImageList ImageListOfFriends { get; set; }

        public UserCategorization(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            SumOfAllFriends = 0;
            SumOfAllMarried = 0;
            SumOfAllSingle = 0;
            MaleFriends = new List<DiscoverMeUser>();
            FemaleFriends = new List<DiscoverMeUser>();
            ListOfAllUser = new List<DiscoverMeUser>();
            ListOfAllUserNames = new List<string>();
        }

        public DiscoverMeUserFriends DiscoverMeUserFriends { get; set; }

        public User LoggedInUser { get; set; }

        public int SumOfAllFriends { get; set; }

        public int SumOfAllMarried { get; set; }

        public int SumOfAllSingle { get; set; }

        public List<DiscoverMeUser> MaleFriends { get; set; }

        public List<DiscoverMeUser> FemaleFriends { get; set; }

        public List<DiscoverMeUser> ListOfAllUser { get; set; }

        public List<string> ListOfAllUserNames { get; set; }

        public void CountFriendsAndCategorizationFriendsByRelationship()
        {
            for (IEnumerator discoverMeUserFriend = (DiscoverMeUserFriends as IEnumerable).GetEnumerator();
                discoverMeUserFriend.MoveNext();)
            {
                SumOfAllFriends += 1;

                switch ((discoverMeUserFriend.Current as DiscoverMeUser).RelationshipStatus)
                {
                    case User.eRelationshipStatus.Married:
                        SumOfAllMarried += 1;
                        break;
                    case User.eRelationshipStatus.Single:
                        SumOfAllSingle += 1;
                        break;
                    default:
                        break;
                }
            }
        }

        public void CategorizationFriendsByGender()
        {
            for (IEnumerator discoverMeUserFriend = (DiscoverMeUserFriends as IEnumerable).GetEnumerator();
                discoverMeUserFriend.MoveNext();)
            {
                switch ((discoverMeUserFriend.Current as DiscoverMeUser).Gender)
                {
                    case User.eGender.male:
                        MaleFriends.Add(discoverMeUserFriend.Current as DiscoverMeUser);
                        break;

                    case User.eGender.female:
                        FemaleFriends.Add(discoverMeUserFriend.Current as DiscoverMeUser);
                        break;

                    default:
                        break;
                }
            }
        }

        public void AddAllFriends()
        {
            for (IEnumerator discoverMeUserFriend = (DiscoverMeUserFriends as IEnumerable).GetEnumerator();
                discoverMeUserFriend.MoveNext();)
            {
                ListOfAllUser.Add(discoverMeUserFriend.Current as DiscoverMeUser);
            }
        }

        public void AddAllFriendsName()
        {
            for (IEnumerator discoverMeUserFriend = (DiscoverMeUserFriends as IEnumerable).GetEnumerator();
                discoverMeUserFriend.MoveNext();)
            {
                ListOfAllUserNames.Add((discoverMeUserFriend.Current as DiscoverMeUser).FirstName);
            }
        }
    }
}
