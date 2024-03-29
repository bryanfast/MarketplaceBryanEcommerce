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
    [Migration("20220522205724_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MarketplaceBryanEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "La vida de Brian (título original: Life of Brian; 1979) es el tercer largometraje del grupo de comedia inglés Monty Python. Trata la historia de un judío que nace el mismo día que Jesucristo y ya de adulto es varias veces confundido con él. Con canciones clásicas de los Python como «Always Look On The Bright Side Of Life» (Mira siempre el lado positivo de la vida), cantada por un coro de crucificados, la película es, junto con Los caballeros de la mesa cuadrada y El sentido de la vida una de las más exitosas de Monty Python.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/18/Lifeofbrianfilmposter.jpg/220px-Lifeofbrianfilmposter.jpg",
                            Price = 9.99m,
                            Title = "Life of Bryan"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ready Player One (titulada Ready Player One: comienza el juego en Hispanoamérica) es una película estadounidense de acción y ciencia ficción de 2018, producida y dirigida por Steven Spielberg, escrita por Zak Penn y Ernest Cline y basada en la novela homónima de Cline. La película está protagonizada por Tye Sheridan, Olivia Cooke, Ben Mendelsohn, T. J. Miller, Simon Pegg y Mark Rylance.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                            Price = 7.99m,
                            Title = "Ready Player One (película)"
                        },
                        new
                        {
                            Id = 3,
                            Description = "El laberinto del fauno es una película hispano-mexicana2​ de los géneros drama y fantasía oscura, escrita, producida y dirigida por Guillermo del Toro. Fue distribuida por Warner Bros Pictures España y estrenada el 11 de octubre de 2006 en España, y una semana y media después se estrenó en México. La película fue seleccionada por la Academia Mexicana de Artes y Ciencias Cinematográficas para representar a México en los premios Óscar, en la categoría de Mejor Película de Lengua Extranjera (Best Foreign Language Film). Fue la película de mejores críticas a nivel mundial durante 2006, también la película con más candidaturas a los premios Óscar entre las que no son de habla inglesa. También fue ganadora de 11 premios Ariel, destacado a la de mejor película y director.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/67/Pan%27s_Labyrinth.jpg",
                            Price = 6.99m,
                            Title = "El laberinto del fauno"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
