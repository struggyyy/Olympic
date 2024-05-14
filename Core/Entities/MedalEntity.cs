using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MedalEntity
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("medal_name", TypeName = "varchar(50)")]
        public string MedalName { get; set; }

        public ISet<CompetitorEventEntity> CompetitorEvents { get; set;} = new HashSet<CompetitorEventEntity>();
        
    }
}
