using System;
using System.Collections;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Program
{
    public class DiscoverMeUserFriends : IEnumerable
    {
        private readonly List<DiscoverMeUser> r_DiscoverMeUsers;

        public DiscoverMeUserFriends(User i_LoggedInUser)
        {
            r_DiscoverMeUsers = new List<DiscoverMeUser>();
            addValuesToList(i_LoggedInUser);
        }

        private void addValuesToList(User i_LoggedInUser)
        {
            foreach (User user in i_LoggedInUser.Friends)
            {
                User.eRelationshipStatus eRelationshipStatus = User.eRelationshipStatus.ItsComplicated;

                try
                {
                    eRelationshipStatus = user.RelationshipStatus.Value;
                }
                catch(Exception e)
                {           
                }

                this.r_DiscoverMeUsers.Add(new DiscoverMeUser
                                                              {
                                                                 FirstName = user.FirstName,
                                                                 LastName = user.LastName,
                                                                 Gender = user.Gender.Value,
                                                                 RelationshipStatus = eRelationshipStatus,
                                                                 Birthday = user.Birthday,
                                                                 PictureNormalURL = user.PictureNormalURL
                                                              });
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this.r_DiscoverMeUsers.GetEnumerator();
        }
    }
}
