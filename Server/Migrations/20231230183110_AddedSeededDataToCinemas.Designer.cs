﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TIN_Project.Server.Context;

#nullable disable

namespace TIN_Project.Server.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20231230183110_AddedSeededDataToCinemas")]
    partial class AddedSeededDataToCinemas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<int>("MoviesIdMovie")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenresIdGenre")
                        .HasColumnType("INTEGER");

                    b.HasKey("MoviesIdMovie", "GenresIdGenre");

                    b.HasIndex("GenresIdGenre");

                    b.ToTable("GenreMovie");

                    b.HasData(
                        new
                        {
                            MoviesIdMovie = 1,
                            GenresIdGenre = 1
                        },
                        new
                        {
                            MoviesIdMovie = 1,
                            GenresIdGenre = 11
                        },
                        new
                        {
                            MoviesIdMovie = 2,
                            GenresIdGenre = 11
                        },
                        new
                        {
                            MoviesIdMovie = 2,
                            GenresIdGenre = 12
                        },
                        new
                        {
                            MoviesIdMovie = 3,
                            GenresIdGenre = 1
                        },
                        new
                        {
                            MoviesIdMovie = 3,
                            GenresIdGenre = 12
                        },
                        new
                        {
                            MoviesIdMovie = 4,
                            GenresIdGenre = 6
                        },
                        new
                        {
                            MoviesIdMovie = 5,
                            GenresIdGenre = 11
                        },
                        new
                        {
                            MoviesIdMovie = 6,
                            GenresIdGenre = 4
                        },
                        new
                        {
                            MoviesIdMovie = 6,
                            GenresIdGenre = 12
                        },
                        new
                        {
                            MoviesIdMovie = 7,
                            GenresIdGenre = 13
                        });
                });

            modelBuilder.Entity("TIN_Project.Server.Models.Cinema", b =>
                {
                    b.Property<int>("IdCinema")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("IdCinema");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            IdCinema = 1,
                            Address = "Złota 59, 00-120 Warszawa",
                            Name = "Multikino"
                        },
                        new
                        {
                            IdCinema = 2,
                            Address = "Wołoska 12, 02-675 Warszawa",
                            Name = "Cinema City"
                        },
                        new
                        {
                            IdCinema = 3,
                            Address = "Gen. W. Andersa 5, 00-147 Warszawa",
                            Name = "Kino Muranów"
                        },
                        new
                        {
                            IdCinema = 4,
                            Address = "Marszałkowska 28, 00-576 Warszawa",
                            Name = "Kino Luna"
                        },
                        new
                        {
                            IdCinema = 5,
                            Address = "Chmielna 33, 00-021 Warszawa",
                            Name = "Kino Atlantic"
                        },
                        new
                        {
                            IdCinema = 6,
                            Address = "Ludwika Narbutta 50A, 02-541 Warszawa",
                            Name = "Kino Iluzjon"
                        });
                });

            modelBuilder.Entity("TIN_Project.Server.Models.Genre", b =>
                {
                    b.Property<int>("IdGenre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("IdGenre");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            IdGenre = 1,
                            Name = "Action"
                        },
                        new
                        {
                            IdGenre = 2,
                            Name = "Adventure"
                        },
                        new
                        {
                            IdGenre = 3,
                            Name = "Comedy"
                        },
                        new
                        {
                            IdGenre = 4,
                            Name = "Crime"
                        },
                        new
                        {
                            IdGenre = 5,
                            Name = "Drama"
                        },
                        new
                        {
                            IdGenre = 6,
                            Name = "Fantasy"
                        },
                        new
                        {
                            IdGenre = 7,
                            Name = "Historical"
                        },
                        new
                        {
                            IdGenre = 8,
                            Name = "Horror"
                        },
                        new
                        {
                            IdGenre = 9,
                            Name = "Mystery"
                        },
                        new
                        {
                            IdGenre = 10,
                            Name = "Romance"
                        },
                        new
                        {
                            IdGenre = 11,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            IdGenre = 12,
                            Name = "Thriller"
                        },
                        new
                        {
                            IdGenre = 13,
                            Name = "Western"
                        });
                });

            modelBuilder.Entity("TIN_Project.Server.Models.Movie", b =>
                {
                    b.Property<int>("IdMovie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("PosterUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("TrailerUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("IdMovie");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            IdMovie = 1,
                            Description = "A team of superheroes save the world from a powerful threat.",
                            PosterUrl = "https://www.themoviedb.org/t/p/w1280/ugX4WZJO3jEvTOerctAWJLinujo.jpg",
                            Title = "The Avengers",
                            TrailerUrl = "https://www.youtube.com/watch?v=eOrNdBpGMv8"
                        },
                        new
                        {
                            IdMovie = 2,
                            Description = "A thief enters people's dreams to steal information.",
                            PosterUrl = "https://www.themoviedb.org/t/p/original/aSY6QhgEeUYky0TMfAXjvRJj5bL.jpg",
                            Title = "Inception",
                            TrailerUrl = "https://www.youtube.com/watch?v=YoHD9XEInc0"
                        },
                        new
                        {
                            IdMovie = 3,
                            Description = "A vigilante fights crime in Gotham City.",
                            PosterUrl = "https://www.themoviedb.org/t/p/original/qJ2tW6WMUDux911r6m7haRef0WH.jpg",
                            Title = "The Dark Knight",
                            TrailerUrl = "https://www.youtube.com/watch?v=EXeTwQWrcwY"
                        },
                        new
                        {
                            IdMovie = 4,
                            Description = "A hobbit embarks on a journey to destroy a powerful ring.",
                            PosterUrl = "https://www.themoviedb.org/t/p/original/6oom5QYQ2yQTMJIbnvbkBL9cHo6.jpg",
                            Title = "The Lord of the Rings: The Fellowship of the Ring",
                            TrailerUrl = "https://www.youtube.com/watch?v=V75dMMIW2B4"
                        },
                        new
                        {
                            IdMovie = 5,
                            Description = "A hacker discovers that the world is a simulation.",
                            PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/qK76PKQLd6zlMn0u83Ej9YQOqPL.jpg",
                            Title = "The Matrix",
                            TrailerUrl = "https://www.youtube.com/watch?v=m8e-FF8MsqU"
                        },
                        new
                        {
                            IdMovie = 6,
                            Description = "Various interconnected stories of criminals, lowlifes, and a mysterious briefcase.",
                            PosterUrl = "https://www.themoviedb.org/t/p/w1280/d5iIlFn5s0ImszYzBPb8JPIfbXD.jpg",
                            Title = "Pulp Fiction",
                            TrailerUrl = "https://www.youtube.com/watch?v=s7EdQ4FqbhY"
                        },
                        new
                        {
                            IdMovie = 7,
                            Description = "A freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.",
                            PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6UjfRbaSdpNeaJvLIPTdhCO6yzJ.jpg",
                            Title = "Django Unchained",
                            TrailerUrl = "https://www.youtube.com/watch?v=_iH0UBYDI4g"
                        });
                });

            modelBuilder.Entity("TIN_Project.Server.Models.MovieRepertoire", b =>
                {
                    b.Property<int>("IdMovieRepertoire")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdMovie")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdRepertoire")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MovieIdMovie")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RepertoireIdRepertoire")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ShowTime")
                        .HasColumnType("TEXT");

                    b.HasKey("IdMovieRepertoire");

                    b.HasIndex("MovieIdMovie");

                    b.HasIndex("RepertoireIdRepertoire");

                    b.ToTable("MovieRepertoires");
                });

            modelBuilder.Entity("TIN_Project.Server.Models.Order", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdMovieRepertoire")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdUser", "IdMovieRepertoire");

                    b.HasIndex("IdMovieRepertoire");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TIN_Project.Server.Models.Repertoire", b =>
                {
                    b.Property<int>("IdRepertoire")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Day")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdCinema")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdRepertoire");

                    b.HasIndex("IdCinema");

                    b.ToTable("Repertoires");
                });

            modelBuilder.Entity("TIN_Project.Server.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RefreshTokenExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("IdUser");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            IdUser = 1,
                            BirthDate = new DateOnly(1999, 1, 1),
                            Email = "wowowow",
                            Name = "John",
                            Password = "password",
                            Role = 1,
                            Surname = "Doe",
                            Username = "username"
                        });
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("TIN_Project.Server.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresIdGenre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TIN_Project.Server.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesIdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TIN_Project.Server.Models.MovieRepertoire", b =>
                {
                    b.HasOne("TIN_Project.Server.Models.Movie", "Movie")
                        .WithMany("MovieRepertoires")
                        .HasForeignKey("MovieIdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TIN_Project.Server.Models.Repertoire", "Repertoire")
                        .WithMany("MovieRepertoires")
                        .HasForeignKey("RepertoireIdRepertoire")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Repertoire");
                });

            modelBuilder.Entity("TIN_Project.Server.Models.Order", b =>
                {
                    b.HasOne("TIN_Project.Server.Models.MovieRepertoire", "MovieRepertoire")
                        .WithMany("Orders")
                        .HasForeignKey("IdMovieRepertoire")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TIN_Project.Server.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieRepertoire");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TIN_Project.Server.Models.Repertoire", b =>
                {
                    b.HasOne("TIN_Project.Server.Models.Cinema", "Cinema")
                        .WithMany("Repertoires")
                        .HasForeignKey("IdCinema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("TIN_Project.Server.Models.Cinema", b =>
                {
                    b.Navigation("Repertoires");
                });

            modelBuilder.Entity("TIN_Project.Server.Models.Movie", b =>
                {
                    b.Navigation("MovieRepertoires");
                });

            modelBuilder.Entity("TIN_Project.Server.Models.MovieRepertoire", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("TIN_Project.Server.Models.Repertoire", b =>
                {
                    b.Navigation("MovieRepertoires");
                });

            modelBuilder.Entity("TIN_Project.Server.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
