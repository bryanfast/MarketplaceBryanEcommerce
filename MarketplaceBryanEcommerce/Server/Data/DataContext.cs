
namespace MarketplaceBryanEcommerce.Server.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)   
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "Life of Bryan",
                Description = "La vida de Brian (título original: Life of Brian; 1979) es el tercer largometraje del grupo de comedia inglés Monty Python. Trata la historia de un judío que nace el mismo día que Jesucristo y ya de adulto es varias veces confundido con él. Con canciones clásicas de los Python como «Always Look On The Bright Side Of Life» (Mira siempre el lado positivo de la vida), cantada por un coro de crucificados, la película es, junto con Los caballeros de la mesa cuadrada y El sentido de la vida una de las más exitosas de Monty Python.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/18/Lifeofbrianfilmposter.jpg/220px-Lifeofbrianfilmposter.jpg",
                Price = 9.99m,
            },
             new Product
             {
                 Id = 2,
                 Title = "Ready Player One (película)",
                 Description = "Ready Player One (titulada Ready Player One: comienza el juego en Hispanoamérica) es una película estadounidense de acción y ciencia ficción de 2018, producida y dirigida por Steven Spielberg, escrita por Zak Penn y Ernest Cline y basada en la novela homónima de Cline. La película está protagonizada por Tye Sheridan, Olivia Cooke, Ben Mendelsohn, T. J. Miller, Simon Pegg y Mark Rylance.",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                 Price = 7.99m,
             },
             new Product
             {
                 Id = 3,
                 Title = "El laberinto del fauno",
                 Description = "El laberinto del fauno es una película hispano-mexicana2​ de los géneros drama y fantasía oscura, escrita, producida y dirigida por Guillermo del Toro. Fue distribuida por Warner Bros Pictures España y estrenada el 11 de octubre de 2006 en España, y una semana y media después se estrenó en México. La película fue seleccionada por la Academia Mexicana de Artes y Ciencias Cinematográficas para representar a México en los premios Óscar, en la categoría de Mejor Película de Lengua Extranjera (Best Foreign Language Film). Fue la película de mejores críticas a nivel mundial durante 2006, también la película con más candidaturas a los premios Óscar entre las que no son de habla inglesa. También fue ganadora de 11 premios Ariel, destacado a la de mejor película y director.",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/67/Pan%27s_Labyrinth.jpg",
                 Price = 6.99m,
             });
        }

        public DbSet<Product> Products { get; set; }
    }
}
