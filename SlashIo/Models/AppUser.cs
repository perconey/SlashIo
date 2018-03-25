using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlashIo.Models
{
    public class AppUser : IdentityUser
    {
        //gruby 2 - dodaj wlasciwosci ktorych nie ma w IdentityUserze
        public string Property { get; set; }
    }
}