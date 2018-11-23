using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OwlCommunity.Classes;
using OwlCommunity.Views;
using OwlCommunity.Controllers;

namespace OwlCommunity.Classes
{
    public class GlobalData
    {
        public static Views.MainForm ff = new Views.MainForm();
        FormController form = new FormController(ff);
        public static OwlMemberList userList = new OwlMemberList();
    }

} 
