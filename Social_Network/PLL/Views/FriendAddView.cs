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
    public class FriendAddView
    {
        UserService userService;
        FriendService friendService;

        public FriendAddView(FriendService friendService, UserService userService) 
        {
            this.userService = userService;
            this.friendService = friendService;
        }

        public void Show(User user)
        {
            var friendAddData = new FriendAddData();
            Console.Write("Введите почтовый адрес друга: ");
            friendAddData.FriendEmail = Console.ReadLine();
            friendAddData.UserId= user.Id;

            try
            {
                friendService.FriendAdd(friendAddData);
                SuccessMessage.Show("Пользователь успешно добавлен в друзья!");
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
                AlertMessage.Show("Произошла ошибка при добавлении в друзья!");
            }

        }


        }
}
