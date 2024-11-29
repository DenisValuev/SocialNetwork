using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class Friend
    {
        public int Id { get; }
        public string FirstNameFriend { get; set; }
        public string LastNameFriend { get; set; }
        public string EmailFriend { get; set; }

        public Friend(int id, string firsNameFriend, string lastNameFriend, string emailFriend)
        {
            Id = id;
            FirstNameFriend = firsNameFriend;
            LastNameFriend = lastNameFriend;
            EmailFriend = emailFriend;
        }
    }
}
