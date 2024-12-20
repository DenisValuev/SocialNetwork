﻿using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class RegistrationVeiw
    {
        UserService userService;
        public RegistrationVeiw(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var userRegistrationData = new UserRegistrationData();

            Console.Write("Для нового пользователя введите имя: ");
            userRegistrationData.FirstName = Console.ReadLine();

            Console.Write("Ваша фамилия: ");
            userRegistrationData.LastName = Console.ReadLine();

            Console.Write("Пароль: ");
            userRegistrationData.Password = Console.ReadLine();

            Console.Write("Почтовый адрес: ");
            userRegistrationData.Email = Console.ReadLine();

            try
            {
                this.userService.Register(userRegistrationData);

                SuccessMessage.Show("Ваш профиль успешно создан. Вы можете войти в систему под своими учетными данными.");
            }
            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение.");
            }
            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при регистрации.");
            }
        }
    }
}
