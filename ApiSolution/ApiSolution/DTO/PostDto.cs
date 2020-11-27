using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSolution.DTO
{
    public class PostDto
    {
        public PostDto()
        {
            CommentsDtos = new List<CommentsDto>();
        }
        public string PostTittle { get; set; }
        public long Id { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public virtual ICollection<CommentsDto> CommentsDtos { get; set; }
    }
}