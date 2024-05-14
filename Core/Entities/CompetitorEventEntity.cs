using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class CompetitorEventEntity
    {
        [Column("event_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }

        [Column("competitor_id")]
        public int CompetitorId { get; set; }

        [Column("medal_id")]
        public int MedalId { get; set; }

        public EventEntity Event { get; set; }
        public MedalEntity Medal { get; set; }

        //public ISet<GamesCompetitorEntity> GamesCompetitors { get; set; } = new HashSet<GamesCompetitorEntity>();
        public GamesCompetitorEntity GamesCompetitors { get; set; }

    }
}
