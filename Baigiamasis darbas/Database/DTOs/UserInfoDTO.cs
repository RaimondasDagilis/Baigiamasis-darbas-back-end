﻿namespace Baigiamasis_darbas.Database.DTOs
{
    public class UserInfoDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PersonalId { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public byte[] Avatar { get; set; }
    }
}