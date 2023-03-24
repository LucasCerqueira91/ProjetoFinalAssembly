using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
using System.Xml.Linq;


namespace WebApiRecipes
{
    public class Program
    {
        public static void Main(string[] args)
        {


            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //        Main objective: The creation of a recipe website and a management application.
        //Information
        //During the development of the project all resources are valid as long as the respect the
        //development requirements and do not influence negativity the students.
        //In this scope the client is the teacher of the class, that can be consulted if any questions arise
        //during the hope project development.Make as little assumption as possible, in case of doubt,
        //as the client.
        //The projecto will be divided in 4 (four) parts:
        //• Front office & Back office (ASP.Net);
        //• DAL(Data Access Layer);
        //• Database(SQL);
        //        The front office will be composed of a website where the following functionalities must be
        //        implemented:
        //• Unregistered users must be allowed to:
        //o Register;
        //        o Use the search option(that must be executed using several fields on the
        //        content);
        //o View the details on each recipe;
        //• Register users must be allowed to:
        //o Do all actions that unregistered users do (except register);
        //o Insert new recipes(which must be pending approval);
        //    o Insert comments on recipes;
        //o Rate recipes;
        //o Add recipes as favourites, to consult later;
        //o Manage user favourites;
        //    o Login;
        //    o Access personal area and manage personal information;
        //    The back office will be restricted to administrators, these users must be allowed to:
        //        • Manage website users’ access(lock and unlock);
        //• Approve pending recipes content;
        //• Add new ingredients;
        //• Add new categories;
        //• Add new difficulty levels;

    }
}
