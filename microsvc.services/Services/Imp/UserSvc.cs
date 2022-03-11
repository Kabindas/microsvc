using microsvc.services.DbRepos.User;
using microsvc.services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace microsvc.services.Services.Imp
{
    public class UserSvc : IUserSvc
    {
        private readonly userContext userdb;
        public UserSvc(userContext userdb)
        {
            this.userdb = userdb;
        }
        public IEnumerable<UserEntity> ListUsers()
        {
            return userdb.UserEntity;
        }
    }
}
