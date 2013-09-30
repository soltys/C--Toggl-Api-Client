﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Toggl.Properties;

namespace Toggl.Services
{
    public class UserService
    {
        private ITogglService ToggleSrv { get; set; }


        public UserService(string apiKey)
            : this(new TogglService(apiKey))
        {
        }

        public UserService()
            : this(new TogglService())
        {
        }

        public UserService(ITogglService srv)
        {
            ToggleSrv = srv;
        }

        /// <summary>
        /// 
        /// https://www.toggl.com/public/api#get_me
        /// </summary>
        /// <returns></returns>
        public User GetCurrent()
        {
            var url = ApiRoutes.User.CurrentUserURl;

            var obj = ToggleSrv.Get(url).GetData<User>();

            return obj;
        }

        /// <summary>
        /// 
        /// https://www.toggl.com/public/api#get_me_data
        /// </summary>
        /// <returns></returns>
        public User GetCurrentExtended()
        {
            var url = ApiRoutes.User.CurrentUserURlExtended;

            var obj = ToggleSrv.Get(url).GetData<User>();

            return obj;
        }

        public List<User> GetFromWorkspace()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        ///  https://www.toggl.com/public/api#post_project_users
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public User AddToProject(User obj)
        {
            throw new NotImplementedException();
          
           
        }
       
    }
}
