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
    [Migration("20231228170048_AddedRoles")]
    partial class AddedRoles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<int>("GenresIdGenre")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoviesIdMovie")
                        .HasColumnType("INTEGER");

                    b.HasKey("GenresIdGenre", "MoviesIdMovie");

                    b.HasIndex("MoviesIdMovie");

                    b.ToTable("GenreMovie");
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
