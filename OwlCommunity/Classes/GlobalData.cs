/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 4: OwlCommunity
 * Class: Global Data
 * Written by: Zachary Goncalves
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OwlCommunity.Views;
using OwlCommunity.Controllers;

namespace OwlCommunity.Classes
{
    public class GlobalData
    {
        public static Views.MainForm ff = new Views.MainForm();
        public static OwlMemberList userList = new OwlMemberList();
    }

} 
