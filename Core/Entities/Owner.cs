﻿namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Profil { get; set; }
        public string Avatar { get; set; } //path for photo
        public Address Address { get; set; }
    }
}
