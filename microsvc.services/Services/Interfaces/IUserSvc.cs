using microsvc.services.DbRepos.User;
using System.Collections.Generic;

namespace microsvc.services.Services.Interfaces
{
    public interface IUserSvc
    {
        IEnumerable<UserEntity> ListUsers();
    }
}
