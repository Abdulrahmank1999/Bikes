using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bike.Models
{
    public class Model
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)][Required]
        public string Name { get; set; }

        [ForeignKey("Make")]
        public int MakeFk { get; set; }

        public Make Make { get; set; }
    }
}
