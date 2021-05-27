using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Helpers;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string usernmae);
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParans);
        Task<MemberDto> GetMemberAsync(string username, bool? isCurrentUser);
        Task<string> GetUserGender(string username);
        Task<AppUser> GetUserByPhotoId(int photoId);
    }
}