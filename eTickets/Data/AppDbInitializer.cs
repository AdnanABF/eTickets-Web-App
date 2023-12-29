using eTickets.Data.Enums;
using eTickets.Models;
using System.ComponentModel;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            var dbContext = serviceProvider.GetRequiredService<AppDbContext>();

            dbContext.Database.EnsureCreated();

            //Cinema
            if (!dbContext.Cinemas.Any())
            {
                dbContext.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                dbContext.SaveChanges();
            }

            //Actors
            if (!dbContext.Actors.Any())
            {
                dbContext.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                dbContext.SaveChanges();
            }

            //Producers
            if (!dbContext.Producers.Any())
            {
                dbContext.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                dbContext.SaveChanges();
            }

            //Movies
            if (!dbContext.Movies.Any())
            {
                dbContext.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaID = 3,
                            ProducerID = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaID = 1,
                            ProducerID = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaID = 4,
                            ProducerID = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaID = 1,
                            ProducerID = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 1,
                            ProducerID = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaID = 1,
                            ProducerID = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                dbContext.SaveChanges();
            }

            //Actors & Movies
            if (!dbContext.ActorMovieMaps.Any())
            {
                dbContext.ActorMovieMaps.AddRange(new List<ActorMovieMap>()
                    {
                        new ActorMovieMap()
                        {
                            ActorID = 1,
                            MovieID = 1
                        },
                        new ActorMovieMap()
                        {
                            ActorID = 3,
                            MovieID = 1
                        },

                         new ActorMovieMap()
                        {
                            ActorID = 1,
                            MovieID = 2
                        },
                         new ActorMovieMap()
                        {
                            ActorID = 4,
                            MovieID = 2
                        },

                        new ActorMovieMap()
                        {
                            ActorID = 1,
                            MovieID = 3
                        },
                        new ActorMovieMap()
                        {
                            ActorID = 2,
                            MovieID = 3
                        },
                        new ActorMovieMap()
                        {
                            ActorID = 5,
                            MovieID = 3
                        },


                        new ActorMovieMap()
                        {
                            ActorID = 2,
                            MovieID = 4
                        },
                        new ActorMovieMap()
                        {
                            ActorID = 3,
                            MovieID = 4
                        },
                        new ActorMovieMap()
                        {
                            ActorID = 4,
                            MovieID = 4
                        },


                        new ActorMovieMap()
                        {
                            ActorID = 2,
                            MovieID = 5
                        },
                        new ActorMovieMap()
                        {
                            ActorID = 3,
                            MovieID = 5
                        },
                        new ActorMovieMap()
                        {
                            ActorID = 4,
                            MovieID = 5
                        },
                        new ActorMovieMap()
                        {
                            ActorID = 5,
                            MovieID = 5
                        },


                        new ActorMovieMap()
                        {
                            ActorID = 3,
                            MovieID = 6
                        },
                        new ActorMovieMap()
                        {
                            ActorID = 4,
                            MovieID = 6
                        },
                        new ActorMovieMap()
                        {
                            ActorID = 5,
                            MovieID = 6
                        },
                    });
                dbContext.SaveChanges();
            }
        }
    }
}
