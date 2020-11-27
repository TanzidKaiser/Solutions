using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiSolution.Infrastructure.Model
{
    public enum EntityStatus { Active = 1, Inactive = 0, Deleted = -1 }

    public class Entity
    {
        public Entity()
        {
            Status = EntityStatus.Active;
            CreateDate = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public EntityStatus Status { get; set; }
    }
}