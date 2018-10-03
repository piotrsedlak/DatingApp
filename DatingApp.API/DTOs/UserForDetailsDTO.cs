using System;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.DTOs
{
    public class UserForDetailsDTO
    {
         public int Id { get; set; }

        public string Username { get; set; }



        public string Gender { get; set; }

        public int Age { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set; }

        
        public DateTime LastActive { get; set; }
        public String Introduction { get; set; }

        public string Interest { get; set; }

        public String LookingFor { get; set; }

        public String City { get; set; }

        public String Country { get; set; }

        public string PhotoUrl { get; set; }

        public ICollection<PhotosForDetailsDTO> Photos { get; set; }
    }
}