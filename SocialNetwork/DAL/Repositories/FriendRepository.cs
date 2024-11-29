﻿using SocialNetwork.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DAL.Repositories
{
    public class FriendRepository : BaseRepository, IFriendRepository
    {
        public IEnumerable<FriendEntity> FindAllUserId(int userId)
        {
            return Query<FriendEntity>(@"select * from friends where user_id = :user_id", new { user_id = userId });
        }
        public int Create(FriendEntity friendEntity)
        {
            return Execute(@"insert into friends (user_id, friend_id) values (:user_id, :friend_id)", friendEntity);
        }

        public IEnumerable<FriendEntity> FindByUserId(int userId)
        {
            return Query<FriendEntity>("select * from friends where user_id = :user_id", new { user_id = userId });
        }
        public int Delete(int id)
        {
            return Execute(@"delete from friends where id = :id_p", new { ip_p = id });
        }
    }

    public interface IFriendRepository
    {
        int Create(FriendEntity friendEntity);
        IEnumerable<FriendEntity> FindAllUserId(int userId);
        int Delete(int id);
    }
}