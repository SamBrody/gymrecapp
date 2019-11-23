using Microsoft.EntityFrameworkCore;

namespace GYMRecordApp.Models.Context
{
    class GymContext:DbContext
    {
        public DbSet<TrainCountM> TrainCounts { get; set; }
        public DbSet<VRecM> VRecs { get; set; }
        public DbSet<WeightM> WeightModels { get; set; }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=gymrecordsdb22;user=root;password=Sam19brody96117$emyon");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TrainCountM>(entity =>
            {
                entity.HasKey(e => e.ID_train_counter);
            });

            modelBuilder.Entity<VRecM>(entity =>
            {
                entity.HasKey(e => e.ID_V);
            });

            modelBuilder.Entity<WeightM>(entity =>
            {
                entity.HasKey(e => e.ID_weight);
            });
        }


    }
}
