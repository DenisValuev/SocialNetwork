using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class FriendUserView
    {
        public void Show(IEnumerable<Friend> friends)
        {
            Console.WriteLine("Список друзей:");
            if (friends.Count() == 0)
            {
                Console.WriteLine("Список Ваших друзей пуст!");
                return;
            }

            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine("Имя: {0}, Фамилия {1}, Почтовый адрес: {2}", friend.FirstNameFriend, friend.LastNameFriend, friend.EmailFriend);
            });
        }
    }
}
