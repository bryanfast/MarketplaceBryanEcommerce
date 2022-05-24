﻿// <auto-generated />
using MarketplaceBryanEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarketplaceBryanEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220524192239_FeaturedProductsAndCorrectHasData")]
    partial class FeaturedProductsAndCorrectHasData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MarketplaceBryanEcommerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Peliculas",
                            Url = "peliculas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Alimentos",
                            Url = "alimentos"
                        });
                });

            modelBuilder.Entity("MarketplaceBryanEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "La vida de Brian (título original: Life of Brian; 1979) es el tercer largometraje del grupo de comedia inglés Monty Python. Trata la historia de un judío que nace el mismo día que Jesucristo y ya de adulto es varias veces confundido con él. Con canciones clásicas de los Python como «Always Look On The Bright Side Of Life» (Mira siempre el lado positivo de la vida), cantada por un coro de crucificados, la película es, junto con Los caballeros de la mesa cuadrada y El sentido de la vida una de las más exitosas de Monty Python.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/18/Lifeofbrianfilmposter.jpg/220px-Lifeofbrianfilmposter.jpg",
                            Title = "Life of Brian"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Ready Player One (titulada Ready Player One: comienza el juego en Hispanoamérica) es una película estadounidense de acción y ciencia ficción de 2018, producida y dirigida por Steven Spielberg, escrita por Zak Penn y Ernest Cline y basada en la novela homónima de Cline. La película está protagonizada por Tye Sheridan, Olivia Cooke, Ben Mendelsohn, T. J. Miller, Simon Pegg y Mark Rylance.",
                            Featured = true,
                            ImageUrl = "https://pics.filmaffinity.com/Ready_Player_One-508487059-large.jpg",
                            Title = "Ready Player One (película)"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "El laberinto del fauno es una película hispano-mexicana2​ de los géneros drama y fantasía oscura, escrita, producida y dirigida por Guillermo del Toro. Fue distribuida por Warner Bros Pictures España y estrenada el 11 de octubre de 2006 en España, y una semana y media después se estrenó en México. La película fue seleccionada por la Academia Mexicana de Artes y Ciencias Cinematográficas para representar a México en los premios Óscar, en la categoría de Mejor Película de Lengua Extranjera (Best Foreign Language Film). Fue la película de mejores críticas a nivel mundial durante 2006, también la película con más candidaturas a los premios Óscar entre las que no son de habla inglesa. También fue ganadora de 11 premios Ariel, destacado a la de mejor película y director.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/67/Pan%27s_Labyrinth.jpg",
                            Title = "El laberinto del fauno"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Ricas palomitas de maiz, para que disfrutes la peli que compraste",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9b/Patlam%C4%B1%C5%9F_m%C4%B1s%C4%B1r.JPG",
                            Title = "Palomitas"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Coca-Cola (conocida comúnmente como Coca en muchos países hispanohablantes; en inglés también conocida como Coke) es una bebida azucarada gaseosa vendida a nivel mundial en tiendas, restaurantes y máquinas expendedoras en más de doscientos países o territorios.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/15-09-26-RalfR-WLC-0098.jpg/338px-15-09-26-RalfR-WLC-0098.jpg?20150926234117",
                            Title = "Cocalcola"
                        });
                });

            modelBuilder.Entity("MarketplaceBryanEcommerce.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Defautl"
                        },
                        new
                        {
                            Id = 2,
                            Name = "HD"
                        },
                        new
                        {
                            Id = 3,
                            Name = "FHD"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dulces"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Saladas"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Bebidas"
                        });
                });

            modelBuilder.Entity("MarketplaceBryanEcommerce.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            OriginalPrice = 200.00m,
                            Price = 99.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 3,
                            OriginalPrice = 2000.00m,
                            Price = 999.99m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 2,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 2,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 4,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 5,
                            OriginalPrice = 19.99m,
                            Price = 10.00m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 6,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        });
                });

            modelBuilder.Entity("MarketplaceBryanEcommerce.Shared.Product", b =>
                {
                    b.HasOne("MarketplaceBryanEcommerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MarketplaceBryanEcommerce.Shared.ProductVariant", b =>
                {
                    b.HasOne("MarketplaceBryanEcommerce.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketplaceBryanEcommerce.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("MarketplaceBryanEcommerce.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
