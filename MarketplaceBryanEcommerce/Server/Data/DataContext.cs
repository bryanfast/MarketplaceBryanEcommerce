
namespace MarketplaceBryanEcommerce.Server.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>().HasKey(
                p => new  { p.ProductId,p.ProductTypeId}
                );

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id=1, Name="Defautl"},
                new ProductType { Id = 2, Name = "HD" },
                new ProductType { Id = 3, Name = "FHD" },
                new ProductType { Id = 4, Name = "Dulces" },
                new ProductType { Id = 5, Name = "Saladas" },
                new ProductType { Id = 6, Name = "Bebidas" }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId=1,
                    ProductTypeId=2,
                    Price=99.99m,
                    OriginalPrice=200.00m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 999.99m,
                    OriginalPrice = 2000.00m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 4,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 5,
                    Price = 10.00m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 6,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                });
            modelBuilder.Entity<Category>().HasData(
             new Category
             {
                 Id=1,
                 Name="Peliculas",
                 Url="peliculas",
             },
             new Category
             {
                 Id = 2,
                 Name = "Alimentos",
                 Url = "alimentos",
             });
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                CategoryId=1,
                Featured=true,
                Title = "Life of Brian",
                Description = "La vida de Brian (título original: Life of Brian; 1979) es el tercer largometraje del grupo de comedia inglés Monty Python. Trata la historia de un judío que nace el mismo día que Jesucristo y ya de adulto es varias veces confundido con él. Con canciones clásicas de los Python como «Always Look On The Bright Side Of Life» (Mira siempre el lado positivo de la vida), cantada por un coro de crucificados, la película es, junto con Los caballeros de la mesa cuadrada y El sentido de la vida una de las más exitosas de Monty Python.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/18/Lifeofbrianfilmposter.jpg/220px-Lifeofbrianfilmposter.jpg",
            },
             new Product
             {
                 Id = 2,
                 CategoryId = 1,
                 Title = "Ready Player One (película)",
                 Description = "Ready Player One (titulada Ready Player One: comienza el juego en Hispanoamérica) es una película estadounidense de acción y ciencia ficción de 2018, producida y dirigida por Steven Spielberg, escrita por Zak Penn y Ernest Cline y basada en la novela homónima de Cline. La película está protagonizada por Tye Sheridan, Olivia Cooke, Ben Mendelsohn, T. J. Miller, Simon Pegg y Mark Rylance.",
                 ImageUrl = "https://pics.filmaffinity.com/Ready_Player_One-508487059-large.jpg",
             },
             new Product
             {
                 Id = 3,
                 CategoryId = 1,
                 Featured = true,
                 Title = "El laberinto del fauno",
                 Description = "El laberinto del fauno es una película hispano-mexicana2​ de los géneros drama y fantasía oscura, escrita, producida y dirigida por Guillermo del Toro. Fue distribuida por Warner Bros Pictures España y estrenada el 11 de octubre de 2006 en España, y una semana y media después se estrenó en México. La película fue seleccionada por la Academia Mexicana de Artes y Ciencias Cinematográficas para representar a México en los premios Óscar, en la categoría de Mejor Película de Lengua Extranjera (Best Foreign Language Film). Fue la película de mejores críticas a nivel mundial durante 2006, también la película con más candidaturas a los premios Óscar entre las que no son de habla inglesa. También fue ganadora de 11 premios Ariel, destacado a la de mejor película y director.",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/67/Pan%27s_Labyrinth.jpg",
             },
             new Product
             {
                 Id = 4,
                 CategoryId = 2,
                 Title = "Palomitas",
                 Description = "Ricas palomitas de maiz, para que disfrutes la peli que compraste",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9b/Patlam%C4%B1%C5%9F_m%C4%B1s%C4%B1r.JPG",
             },
             new Product
             {
                 Id = 5,
                 CategoryId = 2,
                 Title = "Cocalcola",
                 Description = "Coca-Cola (conocida comúnmente como Coca en muchos países hispanohablantes; en inglés también conocida como Coke) es una bebida azucarada gaseosa vendida a nivel mundial en tiendas, restaurantes y máquinas expendedoras en más de doscientos países o territorios.",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/15-09-26-RalfR-WLC-0098.jpg/338px-15-09-26-RalfR-WLC-0098.jpg?20150926234117",
             });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants{ get; set; }
    }
}
