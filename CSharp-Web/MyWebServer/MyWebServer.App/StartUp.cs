﻿namespace MyWebServer.App
{
    using System.Threading.Tasks;
    using MyWebServer;
    using MyWebServer.Controllers;
    using MyWebServer.App.Controllers;

    public class Startup
    {
        public static async Task Main()
            => await new HttpServer(routes => routes
                .MapGet<HomeController>("/", c => c.Index())
                .MapGet<HomeController>("/ToCats", c => c.LocalRedirect())
                .MapGet<HomeController>("/Softuni", c => c.ToSoftUni())
                .MapGet<HomeController>("/Error", c => c.Error())
                .MapGet<AnimalsController>("/Cats", c => c.Cats())
                .MapGet<AnimalsController>("/Dogs", c => c.Dogs())
                .MapGet<AnimalsController>("/Bunnies", c => c.Bunnies())
                .MapGet<AnimalsController>("/Turtles", c => c.Turtles())
                .MapGet<AccountController>("/Cookie", c => c.CookiesCheck())
                .MapGet<AccountController>("/Session", c => c.SessionCheck())
                .MapGet<CatsController>("/Cats/Create", c => c.Create())
                .MapGet<CatsController>("/Cats/save", c => c.Save()))
            .Start();
    }
}
