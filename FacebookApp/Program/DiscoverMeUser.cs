using static FacebookWrapper.ObjectModel.User;

namespace Program
{
    public class DiscoverMeUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public eGender Gender { get; set; }

        public eRelationshipStatus RelationshipStatus { get; set; }

        public string Birthday { get; set; }

        public string PictureNormalURL { get; set; }
    }
}