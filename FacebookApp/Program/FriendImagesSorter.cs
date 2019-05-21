using System.Collections.Generic;

namespace Program
{
    public class FriendImagesSorter
    {
        public IComparer Comparer { get; set; }

        public FriendImagesSorter()
        {
        }

        public void Sort(List<DiscoverMeUser> i_ListOfUsers)
        {
            for (int g = i_ListOfUsers.Count / 2; g > 0; g /= 2)
            {
                for (int i = g; i < i_ListOfUsers.Count; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (Comparer.ShouldSwap(i_ListOfUsers[j].FirstName, i_ListOfUsers[j + g].FirstName))
                        {
                            doSwap(ref i_ListOfUsers, j, g);
                        }
                    }
                }
            }
        }

        private void doSwap(ref List<DiscoverMeUser> i_ListOfUsers, int j, int g)
        {
            DiscoverMeUser temp = i_ListOfUsers[j];
            i_ListOfUsers[j] = i_ListOfUsers[j + g];
            i_ListOfUsers[j + g] = temp;
        }
    }
}
