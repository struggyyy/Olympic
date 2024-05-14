using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        /*public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }*/

        public DbSet<MedalEntity> Medals { get; set; }
        public DbSet<CompetitorEventEntity> CompetitorEvents { get; set; }
        public DbSet<GamesCompetitorEntity> GamesCompetitors { get; set; }
        public DbSet<EventEntity> Events { get; set; }
        public DbSet<SportEntity> Sports { get; set; }
        public DbSet<GamesCityEntity> GamesCities { get; set; }
        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<PersonRegionEntity> PersonRegions { get; set; }
        public DbSet<NocRegionEntity> NocRegions { get; set; }
        public DbSet<GamesEntity> Games { get; set; }
        public DbSet<PersonEntity> Persons { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("server=localhost;port=3306;database=olympics;user=root;password=123;Allow User Variables=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("olympics");
            //modelBuilder.Entity<CompetitorEventEntity>().HasNoKey();
            //modelBuilder.Entity<EventEntity>()
                //.HasMany<EventEntity>()  
                //.WithOne()               
                //.HasForeignKey("EventId");
            modelBuilder.Entity<EventEntity>().HasOne<SportEntity>(eventt => eventt.SportName).WithMany(sport => sport.Events).HasForeignKey(eventt => eventt.SportId);
            modelBuilder.Entity<CompetitorEventEntity>().HasOne<EventEntity>(competitorEvent => competitorEvent.Event).WithMany(eventt => eventt.CompetitorEvents).HasForeignKey(competitorEvent => competitorEvent.EventId);
            modelBuilder.Entity<CompetitorEventEntity>().HasOne<MedalEntity>(competitorEvent => competitorEvent.Medal).WithMany(medal => medal.CompetitorEvents).HasForeignKey(competitorEvent => competitorEvent.MedalId);
            modelBuilder.Entity<CompetitorEventEntity>().HasOne<GamesCompetitorEntity>(competitorEvent => competitorEvent.GamesCompetitors).WithMany(gamesCompetitor => gamesCompetitor.CompetitorEvents).HasForeignKey(competitorEvent => competitorEvent.CompetitorId);
            modelBuilder.Entity<PersonRegionEntity>().HasOne<NocRegionEntity>(personRegion => personRegion.NocRegion).WithMany(nocRegion => nocRegion.PersonRegions).HasForeignKey(personRegion => personRegion.RegionId);
            modelBuilder.Entity<GamesCityEntity>().HasOne<CityEntity>(gamesCity => gamesCity.City).WithMany(city => city.GamesCity).HasForeignKey(gamesCity => gamesCity.CityId);
            modelBuilder.Entity<GamesCityEntity>().HasOne<GamesEntity>(gamesCity => gamesCity.Games).WithMany(games => games.GamesCity).HasForeignKey(gamesCity => gamesCity.GamesId);
            modelBuilder.Entity<GamesCompetitorEntity>().HasOne<GamesEntity>(gamesCompetitor => gamesCompetitor.Games).WithMany(games => games.GamesCompetitors).HasForeignKey(gamesCompetitor => gamesCompetitor.GamesId);
            modelBuilder.Entity<PersonRegionEntity>().HasOne<PersonEntity>(personRegion => personRegion.Person).WithMany(person => person.PersonRegion).HasForeignKey(personRegion => personRegion.PersonId);
            modelBuilder.Entity<GamesCompetitorEntity>().HasOne<PersonEntity>(gamesCompetitor => gamesCompetitor.Person).WithMany(person => person.GamesCompetitors).HasForeignKey(gamesCompetitor => gamesCompetitor.PersonId); 


        }
    }
}

