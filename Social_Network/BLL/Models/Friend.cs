﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.BLL.Models
{
    public class Friend
    {
        public int Id { get; }
        public string UserEmail { get; }
        public string FriendEmail { get; }

        public Friend(int id, string userEmail, string friendEmail)
        {
            Id = id;
            UserEmail = userEmail;
            FriendEmail = friendEmail;
        }
    }
}
