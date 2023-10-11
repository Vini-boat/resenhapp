using AutoMapper;

namespace Resenhapp;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Guest, GuestDTO>();
        CreateMap<GuestDTO, Guest>();
    }
}