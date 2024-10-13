using DeckArchief.Models;
using Microsoft.EntityFrameworkCore;

namespace DeckArchief.Data
{
    public class DeckDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<CurrentValue> CurentValues { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = @"Data source=.; Initial Catalog=DbDeckArchief; Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connection);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///<summery>
            ///Specify Brand
            ///</summery>
            modelBuilder.Entity<Brand>()
                .Property(a => a.Id);
            ///<summery>
            ///Specify Collection
            ///</summery>
            modelBuilder.Entity<Collection>()
                .Property(a => a.Id);
            ///<summery>
            ///Specify CurrentValue
            ///</summery>
            modelBuilder.Entity<CurrentValue>()
                .Property(a => a.Id);
            ///<summery>
            ///Specify Deck
            ///</summery>
            modelBuilder.Entity<Deck>()
                .Property(a => a.Id);
            ///<summery>
            ///Specify Produser
            ///</summery>
            modelBuilder.Entity<Producer>()
                .Property(a => a.Id);
            ///<summery>
            ///Specify User
            ///</summery>
            modelBuilder.Entity<User>()
                .Property(a => a.Id);
            ///<summery>
            ///Specify Wishlist
            ///</summery>
            modelBuilder.Entity<Wishlist>()
                .Property(a => a.Id);

            /// <summary>
            /// data seed brand
            /// </summary>
            Brand brandEntity = new Brand()
            {
                Id = 1,
                Name = "Test Brand",
                Adress = "Test a",
                ProducerName = "Test b"
            };
            /// <summary>
            /// data seed Collection
            /// </summary>
            Collection collectionEntity = new Collection()
            {
                Id = 1,
                Name = "Test Collection",
                StartDate = DateOnly.FromDateTime(DateTime.Now),
                TotalAmount = 1
            };
            /// <summary>
            /// data seed CurrentValue
            /// </summary>
            CurrentValue currentValueEntity = new CurrentValue()
            {
                Id = 1,
                DeckName = "Test Deck",
                Date = DateOnly.FromDateTime(DateTime.Now),
                Price = 10.50
            };
            /// <summery>
            /// data seed Deck
            /// </summery>
            Deck deckEntity = new Deck()
            {
                Id = 1,
                Name = "Test Deck",
                Series = "Test a",
                Price = 10.50,
                BrandName = "Test b",
                ProducerName = "Test c",
                Designer = "Test d",
                Color = "Test e",
                CurrentValue1 = 10.50,
                //CollectionId = 1
            };
            /// <summary>
            /// data seed Producer
            /// </summary>
            Producer producerEntity = new Producer()
            {
                Id = 1,
                Name = "Test Producer",
                Adress = "Test a",
                Brands = "Test b"
            };
            /// <summary>
            /// data seed User
            /// </summary>
            User userEntity = new User()
            {
                Id = 1,
                Name = "Test User",
                LastName = "Test a",
                UserName = "Test user",
                Password = "Test"
            };
            /// <summary>
            /// data seed Wishlist
            /// </summary>
            Wishlist wishlistEntity = new Wishlist()
            {
                Id = 1,
                Name = "Test "
            };

            base.OnModelCreating(modelBuilder);
        }
    }
}
