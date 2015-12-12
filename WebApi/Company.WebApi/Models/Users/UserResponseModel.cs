namespace Company.WebApi.Models.Users
{
    using System;
    using System.Linq;
    using AutoMapper;
    using Company.Data.Models;
    using Company.WebApi.Infrastructure;

    public class UserResponseModel : IMapFrom<User>, IHaveCustomMappings
    {
        public string Username { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<User, UserResponseModel>()
                .ForMember(x => x.Username, opts => opts.MapFrom(z => z.UserName));
        }
    }
}