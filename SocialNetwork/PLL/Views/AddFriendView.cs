using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class AddFriendView
    {
        UserService userService;
        FriendService friendService;
        public AddFriendView(FriendService friendService, UserService userService)
        {
            this.friendService = friendService;
            this.userService = userService;
        }

        public void Show(User user)
        {
            var friendAddData = new FriendAddData();
            Console.Write("Введите почтовый адрес друга: ");
            string inputMail = Console.ReadLine();
            User userFriend = userService.FindByEmail(inputMail);

            try
            {
                friendAddData.idFriend = userFriend.Id;
                friendAddData.idMy = user.Id;
                friendService.AddFriend(friendAddData);
                SuccessMessage.Show("Друг был добавлен!");
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
                AlertMessage.Show("Произошла ошибка при отправке сообщения!");
            }

        }
    }
}
