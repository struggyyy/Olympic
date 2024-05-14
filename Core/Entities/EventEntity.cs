using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class EventEntity
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("sport_id")]
        public int SportId { get; set; }

        [Column("event_name", TypeName = "varchar(200)")]
        public string EventName { get; set; }

        public SportEntity SportName { get; set; }

        public ISet<CompetitorEventEntity> CompetitorEvents { get; set;} = new HashSet<CompetitorEventEntity>();
    }
}
