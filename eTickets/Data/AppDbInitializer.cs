using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Identity;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="Saphire Cinema",
                            Logo = "https://unsplash.com/photos/23LET4Hxj_U",
                            Description = "This is the description of Saphire Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Ruby Cinema",
                            Logo = "https://unsplash.com/photos/evlkOfkQ5rE",
                            Description = "This is the description of Ruby Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Diamond Cinema",
                            Logo = "https://unsplash.com/photos/nW1n9eNHOsc",
                            Description = "This is the description of Diamond Cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor() 
                        {
                            FullName = "Leonardo Di Caprio",
                            Bio = "Leo is an american actor with Oscar award",
                            ProfilePictureURL = "https://t1.gstatic.com/licensed-image?q=tbn:ANd9GcRyPzbmJ96_NB0dLxPCtVCL9rEwwkovxB00Ieksc8kkeBQlb1kMZGibfKNlR9xh033D"
                        },
                        new Actor()
                        {
                            FullName = "Brad Pitt",
                            Bio = "Brad is an american actor",
                            ProfilePictureURL = "https://flxt.tmsimg.com/assets/1366_v9_bc.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Matthew McConaughey",
                            Bio = "Mathew is an american actor with Oscar award",
                            ProfilePictureURL = "https://img.a.transfermarkt.technology/portrait/big/94540-1636851420.jpg?lm=1"
                        },
                        new Actor()
                        {
                            FullName = "Charlie Hannem",
                            Bio = "Charlie is an english actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/MJK34322_Charlie_Hunnam_%28The_Lost_City_Of_Z%2C_Berlinale_2017%29.jpg/800px-MJK34322_Charlie_Hunnam_%28The_Lost_City_Of_Z%2C_Berlinale_2017%29.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Margot Robbie",
                            Bio = "Margot is an australian actress",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTgxNDcwMzU2Nl5BMl5BanBnXkFtZTcwNDc4NzkzOQ@@._V1_FMjpg_UX1000_.jpg"
                        },
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName="Christopher Nolan",
                            Bio="Christopher is an english producer",
                            ProfilePictureURL="https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Christopher_Nolan_Cannes_2018.jpg/440px-Christopher_Nolan_Cannes_2018.jpg"
                        },
                        new Producer()
                        {
                            FullName="Quentin Tarantino",
                            Bio="Quentin is an american producer",
                            ProfilePictureURL="https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Quentin_Tarantino_by_Gage_Skidmore.jpg/440px-Quentin_Tarantino_by_Gage_Skidmore.jpg"
                        },
                        new Producer()
                        {
                            FullName="Guy Ritchie",
                            Bio="Guy is an english producer",
                            ProfilePictureURL="https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/GuyRitchiebyKathyHutchins.jpg/440px-GuyRitchiebyKathyHutchins.jpg"
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name="Once upon time in Holywood...",
                            Description="it's a comedy created by quentin tarantino in 2019",
                            Price = 39.99,
                            ImageURL="https://m.media-amazon.com/images/M/MV5BOTg4ZTNkZmUtMzNlZi00YmFjLTk1MmUtNWQwNTM0YjcyNTNkXkEyXkFqcGdeQXVyNjg2NjQwMDQ@._V1_FMjpg_UX1000_.jpg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = enums.MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name="Inglourious Basterds",
                            Description="it's an action about nazi created by quentin tarantino in 2009",
                            Price = 31.99,
                            ImageURL="https://m.media-amazon.com/images/M/MV5BOTJiNDEzOWYtMTVjOC00ZjlmLWE0NGMtZmE1OWVmZDQ2OWJhXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_FMjpg_UX1000_.jpg",
                            StartDate=DateTime.Now.AddDays(-105),
                            EndDate=DateTime.Now.AddDays(-90),
                            CinemaId = 3,
                            ProducerId = 2,
                            MovieCategory = enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name="Inception",
                            Description="it's a drama about time created by cristopher nolan in 2010",
                            Price = 33.99,
                            ImageURL="https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg",
                            StartDate=DateTime.Now.AddDays(-95),
                            EndDate=DateTime.Now.AddDays(-80),
                            CinemaId = 3,
                            ProducerId = 1,
                            MovieCategory = enums.MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name="Django Unchained",
                            Description="it's a drama about chainer black people created by quentin tarantino in 2012",
                            Price = 36.99,
                            ImageURL="https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg",
                            StartDate=DateTime.Now.AddDays(-65),
                            EndDate=DateTime.Now.AddDays(-30),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = enums.MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name="The Gentlemen",
                            Description="it's a drama about leader of crime band created by guy ritchie in 2020",
                            Price = 45.99,
                            ImageURL="https://m.media-amazon.com/images/M/MV5BMTlkMmVmYjktYTc2NC00ZGZjLWEyOWUtMjc2MDMwMjQwOTA5XkEyXkFqcGdeQXVyNTI4MzE4MDU@._V1_FMjpg_UX1000_.jpg",
                            StartDate=DateTime.Now.AddDays(-1),
                            EndDate=DateTime.Now.AddDays(20),
                            CinemaId = 2,
                            ProducerId = 3,
                            MovieCategory = enums.MovieCategory.Drama
                        },
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 1
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
        
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if(!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
