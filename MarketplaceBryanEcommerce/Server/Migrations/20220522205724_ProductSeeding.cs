using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketplaceBryanEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "La vida de Brian (título original: Life of Brian; 1979) es el tercer largometraje del grupo de comedia inglés Monty Python. Trata la historia de un judío que nace el mismo día que Jesucristo y ya de adulto es varias veces confundido con él. Con canciones clásicas de los Python como «Always Look On The Bright Side Of Life» (Mira siempre el lado positivo de la vida), cantada por un coro de crucificados, la película es, junto con Los caballeros de la mesa cuadrada y El sentido de la vida una de las más exitosas de Monty Python.", "https://upload.wikimedia.org/wikipedia/en/thumb/1/18/Lifeofbrianfilmposter.jpg/220px-Lifeofbrianfilmposter.jpg", 9.99m, "Life of Bryan" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Ready Player One (titulada Ready Player One: comienza el juego en Hispanoamérica) es una película estadounidense de acción y ciencia ficción de 2018, producida y dirigida por Steven Spielberg, escrita por Zak Penn y Ernest Cline y basada en la novela homónima de Cline. La película está protagonizada por Tye Sheridan, Olivia Cooke, Ben Mendelsohn, T. J. Miller, Simon Pegg y Mark Rylance.", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", 7.99m, "Ready Player One (película)" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "El laberinto del fauno es una película hispano-mexicana2​ de los géneros drama y fantasía oscura, escrita, producida y dirigida por Guillermo del Toro. Fue distribuida por Warner Bros Pictures España y estrenada el 11 de octubre de 2006 en España, y una semana y media después se estrenó en México. La película fue seleccionada por la Academia Mexicana de Artes y Ciencias Cinematográficas para representar a México en los premios Óscar, en la categoría de Mejor Película de Lengua Extranjera (Best Foreign Language Film). Fue la película de mejores críticas a nivel mundial durante 2006, también la película con más candidaturas a los premios Óscar entre las que no son de habla inglesa. También fue ganadora de 11 premios Ariel, destacado a la de mejor película y director.", "https://upload.wikimedia.org/wikipedia/en/6/67/Pan%27s_Labyrinth.jpg", 6.99m, "El laberinto del fauno" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
