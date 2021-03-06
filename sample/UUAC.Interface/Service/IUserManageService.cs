using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UUAC.Entity;
using UUAC.Entity.DTOEntities;
using Vulcan.DataAccess;

namespace UUAC.Interface.Service
{
    public interface IUserManageService
    {
        Task<PagedList<IUserInfo>> QueryUserList(string orgCode, string qText, PageView view);
        Task<IUserInfo> GetUserInfo(string userId);
        Task<bool> CheckUserId(string id, string userId);
        Task<int> SaveUserInfo(DtoUserInfo entity, int type,string viewRootCode);
        Task<int> RemoveUserInfo(string userId);
        Task<List<IOrganization>> QueryOrgTreeByParentCode(string parentCode);
        Task<List<IUserInfo>> QueryUserListByParentCode(string parentCode);

        Task<int> CheckLogin(string userId, string password);
    }
}
