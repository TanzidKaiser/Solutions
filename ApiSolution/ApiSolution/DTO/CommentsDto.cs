using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSolution.DTO
{
    public class CommentsDto
    {
        public long Id { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Comment { get; set; }
        public long? PostId { get; set; }
        public decimal? TotalLike { get; set; }
        public decimal? TotalDisLike { get; set; }
    }
}