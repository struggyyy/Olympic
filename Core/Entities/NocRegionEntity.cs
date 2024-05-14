using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class NocRegionEntity
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("noc", TypeName = "varchar(5)")]
        public string Noc { get; set; }

        [Column("region_name", TypeName = "varchar(200)")]
        public string RegionName { get; set; }

        public ISet<PersonRegionEntity> PersonRegions { get; set; }
    }
}
