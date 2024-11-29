using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class FriendAddView
    {
        UserService userService;
        FriendService friendService;

        public FriendAddView(UserService userService, FriendService friendService)
        {
            this.userService = userService;
            this.friendService = friendService;
        }

        public void Show(User user)
        {
            var friendAddData = new FriendAddData();

            Console.Write("Введите почтовый адрес пользователя: ");
            friendAddData.FriendEmail = Console.ReadLine();

            friendAddData.UserId = user.Id;

            try
            {
                friendService.AddFriend(friendAddData);
                SuccessMessage.Show("Друг успешно добавлен!");
                user = userService.FindById(user.Id);

            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение!");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при добавлении друга");
            }
        }
    }
}
