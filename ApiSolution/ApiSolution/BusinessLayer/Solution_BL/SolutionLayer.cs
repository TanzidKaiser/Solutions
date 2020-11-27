using ApiSolution.DTO;
using ApiSolution.Infrastructure;
using ApiSolution.Infrastructure.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ApiSolution.BusinessLayer.Solution_BL
{
    public class SolutionLayer
    {
        private UnitOfWork uow = null;
        public SolutionLayer(UnitOfWork uow_)
        {
            uow = uow_;
        }

        public object GetAllPosts()
        {
            var data = uow.Repository<Posts>().GetAll().Where(s=>s.Status == EntityStatus.Active).ToList();
            var posts = new List<PostDto>();
            foreach(var a in data)
            {
                var post = new PostDto();
                post.Id = a.Id;
                post.PostTittle = a.PostTittle;
                post.CreateBy = a.CreateBy;
                post.CreateDate = a.CreateDate;
                foreach(var c in a.Comments)
                {
                    var comment = new CommentsDto();
                    comment.Id = c.Id;
                    comment.Comment = c.Comment;
                    comment.TotalDisLike = c.TotalDisLike;
                    comment.TotalLike = c.TotalLike;
                    comment.CreateBy = c.CreateBy;
                    comment.CreateDate = c.CreateDate;

                    post.CommentsDtos.Add(comment);
                }
                posts.Add(post);
            }
            //var postData = Mapper.Map
            return posts;
        }

        public object SetLike(long id)
        {
            var data = uow.Repository<Comments>().GetById(s => s.Id == id);
            data.TotalLike += 1;
            uow.SaveChanges();
            return "success";
        }

        public object SetDisLike(long commentId)
        {
            var data = uow.Repository<Comments>().GetById(s => s.Id == commentId);
            data.TotalDisLike += 1;
            uow.SaveChanges();
            return "success";
        }

        public object SearchPost(string tittle)
        {
            var data = uow.Repository<Posts>().GetAll().Where(s => s.Status == EntityStatus.Active
            && s.PostTittle.Contains(tittle)).ToList();

            var posts = new List<PostDto>();
            foreach (var a in data)
            {
                var post = new PostDto();
                post.Id = a.Id;
                post.PostTittle = a.PostTittle;
                post.CreateBy = a.CreateBy;
                post.CreateDate = a.CreateDate;
                foreach (var c in a.Comments)
                {
                    var comment = new CommentsDto();
                    comment.Id = c.Id;
                    comment.Comment = c.Comment;
                    comment.TotalDisLike = c.TotalDisLike;
                    comment.TotalLike = c.TotalLike;
                    comment.CreateBy = c.CreateBy;
                    comment.CreateDate = c.CreateDate;

                    post.CommentsDtos.Add(comment);
                }
                posts.Add(post);
            }
            //var postData = Mapper.Map
            return posts;
        }
    }
}