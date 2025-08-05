// File: Transaction_Summerizer_Services/Profiles/UserProfile.cs
using AutoMapper;
using Transaction_Summerizer_Models;
using Transaction_Summerizer_Services.DTO;

namespace Transaction_Summerizer_Services.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Users, UserDTO>().ReverseMap();
            CreateMap<Categories, CategoryDTO>().ReverseMap();
        }
    }
}
