using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class GamesCompetitorEntity
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("games_id")]
        public int GamesId { get; set; }

        [Column("person_id")]
        public int PersonId { get; set; }

        [Column("age")]
        public int Age { get; set; }

        //public CompetitorEventEntity CompetitorEvent { get; set; }
        public ISet<CompetitorEventEntity> CompetitorEvents { get; set; } = new HashSet<CompetitorEventEntity>();  

        public GamesEntity Games { get; set; }

        public PersonEntity Person { get; set; }


    }
}
