using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Helpers;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
         Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);

          Task<AppUser> GetUserWithLikes(int userId);
          // list of users a specific user has liked
          Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);

/*
        Task<PagedList<LikeDto>> GetUserLikes(string predicate, int userId);
        // predicate  as in a list of users that have been liked OR liked by, 
        // also takes in the Int of the specific users userId

        //Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);

       */

    }
}