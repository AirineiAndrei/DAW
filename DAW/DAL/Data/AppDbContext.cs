using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeVideo> RecipeVideos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientInRecipe> IngredientInRecipes { get; set; }
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DAW;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>();
            modelBuilder.Entity<RecipeVideo>(
                entity =>
                {
                    entity.HasOne(x => x.Recipe)
                    .WithOne(x => x.Video)
                    .HasForeignKey<RecipeVideo>(x => x.RecipeId);
                }
                );
            modelBuilder.Entity<Comment>(
                entity =>
                {
                    entity.HasOne(x => x.Recipe)
                    .WithMany(x => x.Comments)
                    .HasForeignKey(x => x.RecipeId);
                }
                );
            modelBuilder.Entity<Ingredient>();
            modelBuilder.Entity<IngredientInRecipe>(
                entity => 
                {
                    entity.HasKey(x => new { x.RecipeId, x.IngredientId });

                    entity.HasOne(x => x.Recipe)
                    .WithMany(x => x.Ingredients)
                    .HasForeignKey(x => x.RecipeId);

                    entity.HasOne(x => x.Ingredient)
                    .WithMany(x => x.Recipes)
                    .HasForeignKey(x => x.IngredientId);
                }
            );
            modelBuilder.Entity<User>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
