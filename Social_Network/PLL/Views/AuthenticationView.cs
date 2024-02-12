using Social_Network.BLL.Exceptions;
using Social_Network.BLL.Models;
using Social_Network.BLL.Services;
using Social_Network.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.PLL.Views
{
    public class AuthenticationView
    {
        UserService userService;
        public AuthenticationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var authenticationData = new UserAuthenticationData();

            Console.WriteLine("Введите почтовый адрес:");
            authenticationData.Email = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            authenticationData.Password = Console.ReadLine();

            try
            {
                var user = this.userService.Authenticate(authenticationData);

                SuccessMessage.Show("Вы успешно вошли в социальную сеть!");
                SuccessMessage.Show("Добро пожаловать " + user.FirstName);

                Program.userMenuView.Show(user);
            }

            catch (WrongPasswordException)
            {
                AlertMessage.Show("Пароль не корректный!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }

        }
    }
}
