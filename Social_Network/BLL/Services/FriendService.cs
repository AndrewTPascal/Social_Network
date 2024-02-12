using Social_Network.BLL.Exceptions;
using Social_Network.BLL.Models;
using Social_Network.DAL.Entities;
using Social_Network.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.BLL.Services
{
    public class FriendService
    {
        IFriendRepository friendRepository;
        IUserRepository userRepository;

        public FriendService() 
        {
            friendRepository= new FriendRepository();
            userRepository= new UserRepository();
        }

        public void FriendAdd(FriendAddData friendAddData) 
        {
            var findUserEntity = this.userRepository.FindByEmail(friendAddData.FriendEmail);
            if (findUserEntity is null) throw new UserNotFoundException();

            var friendEntity = new FriendEntity
            {
                friend_id = findUserEntity.id,
                user_id = friendAddData.UserId
            };

            if (this.friendRepository.Create(friendEntity) == 0)
                throw new Exception();

        }
    }
}
