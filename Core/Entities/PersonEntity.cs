using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class PersonEntity
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("full_name", TypeName = "varchar(500)")]
        public string FullName { get; set; }

        [Column("gender", TypeName = "varchar(10)")]
        public string Gender { get; set; }

        [Column("height")]
        public int Height { get; set; }

        [Column("weight")]
        public int Weight { get; set; }

        public ISet<PersonRegionEntity> PersonRegion { get; set; } = new HashSet<PersonRegionEntity>();
    
        public ISet<GamesCompetitorEntity> GamesCompetitors { get; set; } = new HashSet<GamesCompetitorEntity>();
    }
}
