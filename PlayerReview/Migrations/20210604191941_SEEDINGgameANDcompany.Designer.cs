﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayerReview.Data;

namespace PlayerReview.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210604191941_SEEDINGgameANDcompany")]
    partial class SEEDINGgameANDcompany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PlayerReview.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("text");

                    b.Property<string>("Logo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Treyarch",
                            Logo = "https://yt3.ggpht.com/ytc/AAUvwnh8dnAnPVNQQqjVbu0FSHFcc2-V0y_v4N738TR-9Q=s900-c-k-c0x00ffffff-no-rj"
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Rockstar",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Rockstar_Games_Logo.svg/1200px-Rockstar_Games_Logo.svg.png"
                        },
                        new
                        {
                            Id = 3,
                            CompanyName = "Activision",
                            Logo = "https://lh3.googleusercontent.com/proxy/gLOIG6uMP6dvK3deO3DSW21R4KwuNbKrgI1XF2OQlUrYkiR_IK0gYHAdoPxHDUYC3OW9JfR1RO_BbtuxUpNB_XVwOZX18xhv-eMHC3iC_UO6RsEm_zM_dxd7QS299vo"
                        },
                        new
                        {
                            Id = 4,
                            CompanyName = "Gurilla Games",
                            Logo = "https://upload.wikimedia.org/wikipedia/en/thumb/1/17/Guerrilla_logo.svg/1200px-Guerrilla_logo.svg.png"
                        },
                        new
                        {
                            Id = 5,
                            CompanyName = "Ghost Games",
                            Logo = "https://seeklogo.com/images/G/ghost-games-logo-8F6060DF77-seeklogo.com.png"
                        });
                });

            modelBuilder.Entity("PlayerReview.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("GameName")
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 2,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor",
                            GameName = "Grand Theft Auto",
                            Image = "https://media.rockstargames.com/rockstargames/img/global/news/upload/actual_1421419184.jpg"
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 1,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor",
                            GameName = "Black Ops",
                            Image = "https://cdn.europosters.eu/image/750/posters/call-of-duty-black-ops-cover-i8700.jpg"
                        },
                        new
                        {
                            Id = 4,
                            CompanyId = 3,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor",
                            GameName = "Crash Bandicoot",
                            Image = "https://cdn.europosters.eu/image/750/posters/crash-bandicoot-4-ride-i99518.jpg"
                        },
                        new
                        {
                            Id = 5,
                            CompanyId = 4,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor",
                            GameName = "Horizon",
                            Image = "https://cdn.europosters.eu/image/750/posters/horizon-zero-dawn-key-art-i34856.jpg"
                        },
                        new
                        {
                            Id = 6,
                            CompanyId = 5,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor",
                            GameName = "Need for Speed",
                            Image = "https://lh3.googleusercontent.com/proxy/Xb1jfc8iI2vPhYM_N2kvbmCjQIyYc0n6RX2wBGT-MhbXjB63DygrF2vIlyi_3jxajbHsPy9-6u3fPRmadwTWktwEB0ypGLcxjb3O0FWSUt7FFG8ykhJQJiXMj3lmizjSS-tYEIjHy7g"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor",
                            GameName = "Modern Warfare",
                            Image = "https://m.media-amazon.com/images/M/MV5BMTc3NWY2ZTMtNTNlZC00MWM2LWI5MzYtMmU1YzY0ODk5ZjQ1XkEyXkFqcGdeQXVyODA2MTkwODk@._V1_.jpg"
                        },
                        new
                        {
                            Id = 7,
                            CompanyId = 5,
                            Description = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor",
                            GameName = "Need for Speed Heat",
                            Image = "https://posterspy.com/wp-content/uploads/2019/12/46a85b70014089.5d717791b29ac.png"
                        });
                });

            modelBuilder.Entity("PlayerReview.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("PlayerReview.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PlayerReview.Models.Game", b =>
                {
                    b.HasOne("PlayerReview.Models.Company", "Company")
                        .WithMany("Games")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlayerReview.Models.Review", b =>
                {
                    b.HasOne("PlayerReview.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlayerReview.Models.User", b =>
                {
                    b.HasOne("PlayerReview.Models.Review", "Review")
                        .WithMany()
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
