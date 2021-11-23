using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;


namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        
IUserRepository UserRepository {get;}
ILikesRepository LikesRepository  {get;}

Task<Boolean> Complete();

Boolean HasChanges();

    }

}