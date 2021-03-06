﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using SlashIo.DAL;
using SlashIo.Models;


[assembly: OwinStartup(typeof(SlashIo.Startup))]

namespace SlashIo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(() => new MainDbContext());
            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
            app.CreatePerOwinContext<RoleManager<AppRole>>((options, context) => new RoleManager<AppRole>(new RoleStore<AppRole>(new MainDbContext())));

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Home/Login"),
            });
            app.UseFacebookAuthentication(
            appId: "123",
            appSecret: "123");
        }
    }
}
