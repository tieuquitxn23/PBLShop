using AutoMapper;
using PBLShop.Model.Models;
using PBLShop.Web.Models;

namespace PBLShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
            });
        }

    }
}