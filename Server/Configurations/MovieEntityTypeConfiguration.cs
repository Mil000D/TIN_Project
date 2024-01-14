using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TIN_Project.Server.Models;

namespace TIN_Project.Server.Configurations
{
	public class MovieEntityTypeConfiguration : IEntityTypeConfiguration<Movie>
	{
		public void Configure(EntityTypeBuilder<Movie> builder)
		{
			builder.HasKey(x => x.IdMovie);
			builder.Property(x => x.EnglishTitle).HasMaxLength(40).IsRequired();
			builder.Property(x => x.PolishTitle).HasMaxLength(40).IsRequired();
			builder.Property(x => x.EnglishDescription).HasMaxLength(1000).IsRequired();
			builder.Property(x => x.PolishDescription).HasMaxLength(1000).IsRequired();
			builder.Property(x => x.TrailerUrl).HasMaxLength(100).IsRequired();
			builder.Property(x => x.PosterUrl).HasMaxLength(100).IsRequired();
            builder
             .HasMany(p => p.Genres)
                .WithMany(t => t.Movies)
                .UsingEntity<Dictionary<string, object>>(
                    "GenreMovie",
                    r => r.HasOne<Genre>().WithMany().HasForeignKey("GenresIdGenre"),
                    l => l.HasOne<Movie>().WithMany().HasForeignKey("MoviesIdMovie"),
                    je =>
                    {
                        je.HasKey("MoviesIdMovie", "GenresIdGenre");
						je.HasData(
							new { MoviesIdMovie = 1, GenresIdGenre = 1 },
							new { MoviesIdMovie = 1, GenresIdGenre = 11 },
							new { MoviesIdMovie = 2, GenresIdGenre = 11 },
							new { MoviesIdMovie = 2, GenresIdGenre = 12 },
							new { MoviesIdMovie = 3, GenresIdGenre = 1 },
							new { MoviesIdMovie = 3, GenresIdGenre = 12 },
							new { MoviesIdMovie = 4, GenresIdGenre = 6 },
							new { MoviesIdMovie = 5, GenresIdGenre = 11 },
							new { MoviesIdMovie = 6, GenresIdGenre = 4 },
							new { MoviesIdMovie = 6, GenresIdGenre = 12 },
							new { MoviesIdMovie = 7, GenresIdGenre = 13 },
							new { MoviesIdMovie = 8, GenresIdGenre = 4 },
							new { MoviesIdMovie = 8, GenresIdGenre = 5 },
                            new { MoviesIdMovie = 9, GenresIdGenre = 4 },
                            new { MoviesIdMovie = 9, GenresIdGenre = 5 },
                            new { MoviesIdMovie = 10, GenresIdGenre = 4 },
                            new { MoviesIdMovie = 10, GenresIdGenre = 5 },
							new { MoviesIdMovie = 11, GenresIdGenre = 11 },
							new { MoviesIdMovie = 12, GenresIdGenre = 2 },
							new { MoviesIdMovie = 12, GenresIdGenre = 11 },
                            new { MoviesIdMovie = 13, GenresIdGenre = 2 },
                            new { MoviesIdMovie = 13, GenresIdGenre = 11 },
                            new { MoviesIdMovie = 14, GenresIdGenre = 2 },
                            new { MoviesIdMovie = 14, GenresIdGenre = 11 },
                            new { MoviesIdMovie = 15, GenresIdGenre = 2 },
                            new { MoviesIdMovie = 15, GenresIdGenre = 11 },
                            new { MoviesIdMovie = 16, GenresIdGenre = 2 },
                            new { MoviesIdMovie = 16, GenresIdGenre = 6 },
							new { MoviesIdMovie = 17, GenresIdGenre = 2 },
							new { MoviesIdMovie = 17, GenresIdGenre = 6 },
							new { MoviesIdMovie = 18, GenresIdGenre = 4 },
							new { MoviesIdMovie = 18, GenresIdGenre = 12 },
							new { MoviesIdMovie = 19, GenresIdGenre = 4 },
							new { MoviesIdMovie = 19, GenresIdGenre = 12 },
							new { MoviesIdMovie = 20, GenresIdGenre = 5 }
                            );
                    });
			builder.HasData(new Movie
			{
				IdMovie = 1,
				EnglishTitle = "The Avengers",
				PolishTitle = "Avengers",
				EnglishDescription = "A team of superheroes save the world from a powerful threat.",
				PolishDescription = "Zespół superbohaterów ratuje świat przed potężnym zagrożeniem.",
				TrailerUrl = "https://www.youtube.com/watch?v=eOrNdBpGMv8",
				PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg",
			},
			new Movie
			{
				IdMovie = 2,
				EnglishTitle = "Inception",
				PolishTitle = "Incepcja",
				EnglishDescription = "A thief enters people's dreams to steal information.",
				PolishDescription = "Złodziej wkracza do snów ludzi, aby ukraść informacje.",
				TrailerUrl = "https://www.youtube.com/watch?v=YoHD9XEInc0",
				PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/oYuLEt3zVCKq57qu2F8dT7NIa6f.jpg",
			},
			new Movie
			{
				IdMovie = 3,
				EnglishTitle = "The Dark Knight",
				PolishTitle = "Mroczny Rycerz",
				EnglishDescription = "A vigilante fights crime in Gotham City.",
				PolishDescription = "Samozwańczy sprawiedliwy walczy ze złem w Gotham City.",
				TrailerUrl = "https://www.youtube.com/watch?v=EXeTwQWrcwY",
				PosterUrl = "https://www.themoviedb.org/t/p/original/qJ2tW6WMUDux911r6m7haRef0WH.jpg",
			},
			new Movie
			{
				IdMovie = 4,
				EnglishTitle = "The Lord of the Rings: The Fellowship of the Ring",
				PolishTitle = "Władca Pierścieni: Drużyna Pierścienia",
				EnglishDescription = "A hobbit embarks on a journey to destroy a powerful ring.",
				PolishDescription = "Hobbit wyrusza w podróż, aby zniszczyć potężny pierścień.",
				TrailerUrl = "https://www.youtube.com/watch?v=V75dMMIW2B4",
				PosterUrl = "https://www.themoviedb.org/t/p/original/6oom5QYQ2yQTMJIbnvbkBL9cHo6.jpg",
			},
			new Movie
			{
				IdMovie = 5,
				EnglishTitle = "The Matrix",
				PolishTitle = "Matrix",
				EnglishDescription = "A hacker discovers that the world is a simulation.",
				PolishDescription = "Haker odkrywa, że świat jest symulacją.",
				TrailerUrl = "https://www.youtube.com/watch?v=m8e-FF8MsqU",
				PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/qK76PKQLd6zlMn0u83Ej9YQOqPL.jpg",
			},
			new Movie
			{
				IdMovie = 6,
				EnglishTitle = "Pulp Fiction",
				PolishTitle = "Pulp Fiction",
				EnglishDescription = "Various interconnected stories of criminals, lowlifes, and a mysterious briefcase.",
				PolishDescription = "Różne powiązane ze sobą historie kryminalistów, łotrów i tajemniczej walizki.",
				TrailerUrl = "https://www.youtube.com/watch?v=s7EdQ4FqbhY",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/d5iIlFn5s0ImszYzBPb8JPIfbXD.jpg",
			},
			new Movie
			{
				IdMovie = 7,
				EnglishTitle = "Django Unchained",
				PolishTitle = "Django",
				EnglishDescription = "A freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.",
				PolishDescription = "Uwolniony niewolnik wyrusza, aby uratować swoją żonę przed brutalnym właścicielem plantacji w Missisipi.",
				TrailerUrl = "https://www.youtube.com/watch?v=_iH0UBYDI4g",
				PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6UjfRbaSdpNeaJvLIPTdhCO6yzJ.jpg",
			},
			new Movie
			{
				IdMovie = 8,
				EnglishTitle = "The Shawshank Redemption",
				PolishTitle = "Skazani na Shawshank",
				EnglishDescription = "Framed in the 1940s for the double murder of his wife and her lover, upstanding banker Andy Dufresne begins a new life at the Shawshank prison, where he puts his accounting skills to work for an amoral warden. During his long stretch in prison, Dufresne comes to be admired by the other inmates -- including an older prisoner named Red -- for his integrity and unquenchable sense of hope.",
				PolishDescription = "Andy Dufresne jest młodym, obiecującym bankierem. Jego życie zmienia się drastycznie, kiedy zostaje niesłusznie oskarżony o zamordowanie swojej żony i jej kochanka. Skazany na dożywocie, trafia do więzienia Shawshank, gdzie rządy sprawują sadystyczni strażnicy oraz dyrektor hipokryta i oszust. Andy żeby przeżyć lata, jakie przyjdzie mu spędzić w celi, Andy będzie musiał wykazać się sprytem i wolą przetrwania.",
				TrailerUrl = "https://www.youtube.com/watch?v=NmzuHjWmXOc&ab_channel=RottenTomatoesClassicTrailers",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/sBnhJ4f5KAzg6C3FwnEb8QFj8SB.jpg"
			},
			new Movie
			{
				IdMovie = 9,
				EnglishTitle = "The Godfather",
				PolishTitle = "Ojciec Chrzestny",
				EnglishDescription = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
				PolishDescription = "Starzejący się patriarcha rodu przestępczego przekazuje kontrolę nad swoim imperium swojemu synowi.",
				TrailerUrl = "https://www.youtube.com/watch?v=sY1S34973zA",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/3bhkrj58Vtu7enYsRolD1fZdja1.jpg",
			},
			new Movie
			{
				IdMovie = 10,
				EnglishTitle = "The Godfather: Part II",
				PolishTitle = "Ojciec Chrzestny II",
				EnglishDescription = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
				PolishDescription = "Wczesne życie i kariera Vito Corleone w Nowym Jorku w latach 20. XX wieku, podczas gdy jego syn Michael rozszerza i wzmacnia swoje wpływy w rodzinnej mafii.",
				TrailerUrl = "https://www.youtube.com/watch?v=9O1Iy9od7-A",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/hek3koDUyRQk7FIhPXsa6mT2Zc3.jpg",
			},
			new Movie
			{
				IdMovie = 11,
				EnglishTitle = "Interstellar",
				PolishTitle = "Interstellar",
				EnglishDescription = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
				PolishDescription = "Grupa badaczy podróżuje przez tunel czasoprzestrzenny w kosmosie, aby zapewnić przetrwanie ludzkości.",
				TrailerUrl = "https://www.youtube.com/watch?v=0vxOhd4qlnA",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg"
			},
			new Movie
			{
				IdMovie = 12,
				EnglishTitle = "Hunger Games",
				PolishTitle = "Igrzyska Śmierci",
				EnglishDescription = "Katniss Everdeen voluntarily takes her younger sister's place in the Hunger Games: a televised competition in which two teenagers from each of the twelve Districts of Panem are chosen at random to fight to the death.",
				PolishDescription = "Katniss Everdeen dobrowolnie bierze miejsce swojej młodszej siostry w Igrzyskach Śmierci: telewizyjnym konkursie, w którym dwóch nastolatków z każdego z dwunastu Dystryktów Panem zostaje wybranych losowo do walki na śmierć i życie.",
				TrailerUrl = "https://www.youtube.com/watch?v=mfmrPu43DF8&ab_channel=LionsgateMovies",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/yXCbOiVDCxO71zI7cuwBRXdftq8.jpg"
			},
			new Movie
			{
				IdMovie = 13,
				EnglishTitle = "The Hunger Games: Catching Fire",
				PolishTitle = "Igrzyska Śmierci: W Pierścieniu Ognia",
				EnglishDescription = "Katniss Everdeen and Peeta Mellark become targets of the Capitol after their victory in the 74th Hunger Games sparks a rebellion in the Districts of Panem.",
				PolishDescription = "Katniss Everdeen i Peeta Mellark stają się celem Kapitolu po tym, jak ich zwycięstwo w 74 Igrzyskach Śmierci wywołuje rebelię w Dystryktach Panem.",
				TrailerUrl = "https://www.youtube.com/watch?v=EAzGXqJSDJ8",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/uFQbcR7h1stMlN1d3a7RmV0luLZ.jpg"
			},
			new Movie
			{
				IdMovie = 14,
				EnglishTitle = "The Hunger Games: Mockingjay - Part 1",
				PolishTitle = "Igrzyska Śmierci: Kosogłos. Część 1",
				EnglishDescription = "Katniss Everdeen is in District 13 after she shatters the games forever. Under the leadership of President Coin and the advice of her trusted friends, Katniss spreads her wings as she fights to save Peeta and a nation moved by her courage.",
				PolishDescription = "Katniss Everdeen znajduje się w Dystrykcie 13 po tym, jak na zawsze zakończyła igrzyska. Pod przywództwem prezydent Coin i z radą zaufanych przyjaciół, walczy o uratowanie Peety i narodu poruszonego jej odwagą.",
				TrailerUrl = "https://www.youtube.com/watch?v=3PkkHsuMrho",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/4FAA18ZIja70d1Tu5hr5cj2q1sB.jpg"
			},
			new Movie
			{
				IdMovie = 15,
				EnglishTitle = "The Hunger Games: Mockingjay - Part 2",
				PolishTitle = "Igrzyska Śmierci: Kosogłos. Część 2",
				EnglishDescription = "Katniss and a team of rebels from District 13 prepare for the final battle that will decide the fate of Panem.",
				PolishDescription = "Katniss i drużyna rebeliantów z Dystryktu 13 przygotowują się do ostatecznej bitwy, która zdecyduje o losach Panem.",
				TrailerUrl = "https://www.youtube.com/watch?v=n-7K_OjsDCQ&ab_channel=TheHungerGames",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/lImKHDfExAulp16grYm8zD5eONE.jpg"
			},
			new Movie
			{
				IdMovie = 16,
				EnglishTitle = "The Lord of the Rings: The Two Towers",
				PolishTitle = "Władca Pierścieni: Dwie Wieże",
				EnglishDescription = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
				PolishDescription = "Podczas gdy Frodo i Sam zbliżają się do Mordoru z pomocą przewrotnego Golluma, podzielona drużyna stawia opór nowemu sojusznikowi Saurona, Sarumanowi, i jego hordom Isengardu.",
				TrailerUrl = "https://www.youtube.com/watch?v=LbfMDwc4azU",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/5VTN0pR8gcqV3EPUHHfMGnJYN9L.jpg"
			},
			new Movie
			{
				IdMovie = 17,
				EnglishTitle = "The Lord of the Rings: The Return of the King",
				PolishTitle = "Władca Pierścieni: Powrót Króla",
				EnglishDescription = "Aragorn is revealed as the heir to the ancient kings as he, Gandalf and the other members of the broken fellowship struggle to save Gondor from Sauron's forces. Meanwhile, Frodo and Sam take the ring closer to the heart of Mordor, the dark lord's realm.",
				PolishDescription = "Aragorn walczy, aby wypełnić przepowiednię i poprowadzić swoich zwolenników przeciw rosnącej sile Władcy Ciemności Saurona, aby Powiernik Pierścienia mógł zakończyć swoją misję. Tymczasem Frodo i Sam zabierają pierścień bliżej serca Mordoru, królestwa ciemnego pana.",
				TrailerUrl = "https://www.youtube.com/watch?v=r5X-hFf6Bwo",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/rCzpDGLbOoPwLjy3OAm5NUPOTrC.jpg"
			},
			new Movie
			{
				IdMovie = 18,
				EnglishTitle = "Se7en",
				PolishTitle = "Siedem",
				EnglishDescription = "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.",
				PolishDescription = "Dwóch detektywów, nowicjusz i weteran, tropi seryjnego mordercę, który używa siedmiu grzechów głównych jako swoich motywów.",
				TrailerUrl = "https://www.youtube.com/watch?v=J4YV2_TcCoE",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/6yoghtyTpznpBik8EngEmJskVUO.jpg"
			},
			new Movie
			{
				IdMovie = 19,
				EnglishTitle = "The Silence of the Lambs",
				PolishTitle = "Milczenie Owiec",
				EnglishDescription = "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.",
				PolishDescription = "Młoda agentka F.B.I. poszukuje pomocy u uwięzionego i manipulującego kanibala zabójcy, aby złapać innego seryjnego mordercę, szaleńca, który obdziera ze skóry swoje ofiary.",
				TrailerUrl = "https://www.youtube.com/watch?v=6iB21hsprAQ&ab_channel=MGM",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/uS9m8OBk1A8eM9I042bx8XXpqAq.jpg"
			},
			new Movie
			{
				IdMovie = 20,
				EnglishTitle = "Fight Club",
				PolishTitle = "Podziemny Krąg",
				EnglishDescription = "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.",
				PolishDescription = "Bezsenni biurowi robotnicy i niefrasobliwy producent mydła tworzą podziemny klub walki, który ewoluuje w coś znacznie więcej.",
				TrailerUrl = "https://www.youtube.com/watch?v=SUXWAEX2jlg",
				PosterUrl = "https://www.themoviedb.org/t/p/w1280/pB8BM7pdSp6B6Ih7QZ4DrQ3PmJK.jpg"
            }
			);
		}
	}
}
