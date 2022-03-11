using microsvc.services.DbRepos.User;
using microsvc.services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace microsvc.services.Services.Imp
{
    public class UserSvc : IUserSvc
    {
        private readonly UserContext userdb;
        public UserSvc(UserContext userdb)
        {
            this.userdb = userdb;
        }
        public IEnumerable<UserEntity> ListUsers()
        {
            return userdb.UserEntity;
        }
    }
}
