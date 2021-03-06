﻿using System;
namespace DienChanApp.Models
{
    public class User
    {
        public int id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public int permissionId { get; set; }

        public UserPermission permission { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public DateTime createdDate { get; set; }

        public string token { get; set; }

        public string profileImageUrl { get; set; }

        public bool isProfileImageChange { get; set; }
    }

    public class UserPermission
    {
        public int id { get; set; }

        public string permissionName { get; set; }

        public string permissionDescription { get; set; }
    }
}
