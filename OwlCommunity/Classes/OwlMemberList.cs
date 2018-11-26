using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwlCommunity.Models;

namespace OwlCommunity.Classes
{
    [Serializable()]
    public class OwlMemberList
    {
        List<OwlMember> memberList;
        int numMembers;

        // Parameterless Constructor
        public OwlMemberList()
        {
            numMembers = 0;
            memberList = new List<OwlMember>();
        }

        // Returns number of members in the member list
        public int Count()
        {
            return numMembers = memberList.Count();
        }

        // Adds member to list
        public void addToList(OwlMember member)
        {
            memberList.Add(member);
        }

        // Removes member from list
        public void removeFromList(OwlMember member)
        {
            memberList.Remove(member);
        }

        // Searches for OwlMember in the list
        public string searchList(OwlMember user, ref bool searchSuccessful)
        {
            searchSuccessful = false;
            string returnMember = "";
            foreach (OwlMember member in memberList)
            {
                bool match = false;
                bool endOfList = false;
              
                if (match)
                {
                    returnMember = member.ToString();
                    searchSuccessful = true;
                    break;
                }
                else
                {
                    if (endOfList)
                    {
                        returnMember = "No member found!";
                        searchSuccessful = false;
                    }
                }
            }
            return returnMember;
        }

    }
}
