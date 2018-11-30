/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 4: OwlCommunity
 * Class: OwlMemberList
 * Written by: Zachary Goncalves
 */
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
        OwlMember lookedUpUser; 

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
        public OwlMember searchList(int memberID, ref bool searchSuccessful)
        {
            searchSuccessful = false;
            foreach (OwlMember member in memberList)
            {
                if (member.owlID == memberID)
                {
                    lookedUpUser = member;
                    searchSuccessful = true;
                    break;
                }
                else
                {
                    lookedUpUser = null;
                    searchSuccessful = false;
                }
            }
            return lookedUpUser;
        }
        public string displayList()
        {
            string display = "";
            foreach (OwlMember member in memberList)
            {
                display += member.ToString();
            }
            return display;
        }
    }
}
