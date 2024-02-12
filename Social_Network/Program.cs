using Social_Network.BLL.Exceptions;
using Social_Network.BLL.Models;
using Social_Network.BLL.Services;
using Social_Network.PLL.Views;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Social_Network
{
    internal class Program
    {
        static MessageService messageService;
        static FriendService friendService;
        static UserService userService;
        public static MainView mainView;
        public static RegistrationView registrationView;
        public static AuthenticationView authenticationView;
        public static UserMenuView userMenuView;
        public static UserInfoView userInfoView;
        public static UserDataUpdateView userDataUpdateView;
        public static MessageSendingView messageSendingView;
        public static FriendAddView friendAddView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;

        static void Main(string[] args)
        {
            userService = new UserService();
            messageService = new MessageService();
            friendService = new FriendService(); 

            mainView = new MainView();
            registrationView = new RegistrationView(userService);
            authenticationView = new AuthenticationView(userService);
            userMenuView = new UserMenuView(userService);
            userInfoView = new UserInfoView();
            userDataUpdateView = new UserDataUpdateView(userService);
            messageSendingView = new MessageSendingView(messageService, userService);
            friendAddView = new FriendAddView(friendService, userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutcomingMessageView = new UserOutcomingMessageView();

            while (true)
            {
                mainView.Show();
            }
        }
    }
}