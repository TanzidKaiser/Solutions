using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiSolution.Infrastructure.Model
{
    [Table("Posts")]
    public class Posts : Entity
    {
        public string PostTittle { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}