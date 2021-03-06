using SMA.ApplicationServices.DTOs;
using SMA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMA.ApplicationServices.Helpers
{
    public static class PostConvertHelper
    {
           #region Post methods
        
                public static Post ToPostEntity(this PostDto postDto)
                {
                    return new Post
                    {
                        Id = postDto.PostId,
                        CreatedByUserId = postDto.CreatedByUserId,
                        PostBody = postDto.PostBody,
                        ImageId = postDto.ImageId,
                         CreatedOn = postDto.CreatedOn,
                        UpdatedOn = postDto.UpdatedOn,
                        UpdatedBy = postDto.UpdatedBy
        
                    };
                }
        
                public static PostDto ToPostDto(this Post post)
                {
                    return new PostDto
                    {
                        PostId = post.Id,
                        CreatedByUserId = post.CreatedByUserId,
                        PostBody = post.PostBody,
                        ImageId=post.ImageId,
                         CreatedOn = post.CreatedOn,
                        UpdatedOn = post.UpdatedOn,
                        UpdatedBy = post.UpdatedBy
                    };
                }
        
                public static IEnumerable<PostDto> ToPostDtos(this IEnumerable<Post> post)
                {
                    return post.Select(x => x.ToPostDto());
                }
        
        
        
                #endregion
    }
}