using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiSolution.Infrastructure.Model
{
    [Table("Comments")]
    public class Comments : Entity
    {
        public string Comment { get; set; }
        public long? PostId { get; set; }
        [ForeignKey("PostId")]
        public virtual Posts Post { get; set; }

        public decimal? TotalLike { get; set; }
        public decimal? TotalDisLike { get; set; }
       
    }
}