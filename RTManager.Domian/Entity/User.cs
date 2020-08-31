using RTManager.Domian.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTManager.Domian.Entity
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public User() { }
        public User(int id, string userName)
        {
            Id = id;
            UserName = userName;
        }
    }
}
