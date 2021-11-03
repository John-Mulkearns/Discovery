using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class UserRepository : IUserRepository
    {

        private readonly DataContext _context;
        public IMapper _mapper { get; }

        public UserRepository(DataContext context, IMapper mapper)
        {
           _mapper = mapper;
            _context = context;

        }

        public async Task<MemberDto> GetMemberAsync(string username)  //🔷
        {
            return await _context.Users
                .Where(x => x.UserName == username)
                .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
        }

//without automapper you could manually code mappings 
//to say what you want returned in the MemberDto as below


    public async Task<MemberDto> GetMemberAsyncNoAutomapper(string username)   //🔷
        {
             return await _context.Users
             .Where(x=>x.UserName==username)
             .Select(user=> new MemberDto{
            Id=user.Id,
            Username=user.UserName,
          //  Age=user.GetAge(),
            Gender=user.Gender,
            Introduction=user.Introduction,
            Interests=user.Interests,
            City=user.City,
            Country=user.Country
            // etc ++ and how do you code Photos Array

             }).SingleOrDefaultAsync();

        }




        public async Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams)  //🔷
        {
          var query= _context.Users
                .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
                .AsNoTracking();
                return await PagedList<MemberDto>.CreateAsync(query, userParams.PageNumber, userParams.PageSize);
        }



        public async Task<AppUser> GetUserByIdAsync(int id)  //🔷
        {
            return await _context.Users.FindAsync(id);
        }



        public async Task<AppUser> GetUserByUsernameAsync(string username)  //🔷
        {
           return await _context.Users
                .Include(p => p.Photos)      // remove comments to bring back thier photos this is EAGER LOADING
                .SingleOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<IEnumerable<AppUser>> GetUsersAsync()  //🔷
        {
            return await _context.Users
            .Include(p => p.Photos)  //  same here as above
                .ToListAsync();
        }
 
        public async Task<bool> SaveAllAsync()  //🔷
        {
           return await _context.SaveChangesAsync() > 0;  
           // if anything changed this will return a value greater than zero
           
        }

        public  void Update(AppUser user)  //🔷
        {
            _context.Entry(user).State = EntityState.Modified;
        }
    }
}