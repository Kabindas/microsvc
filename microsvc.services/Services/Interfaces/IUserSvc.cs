using microsvc.services.DbRepos.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace microsvc.services.Services.Interfaces
{
    public interface IUserSvc
    {
        IEnumerable<UserEntity> ListUsers();
    }
}
