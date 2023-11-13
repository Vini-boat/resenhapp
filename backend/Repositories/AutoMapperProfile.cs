using AutoMapper;
using Resenhapp.Repositories.Data;
using Resenhapp.Repositories.DTOs;
using Resenhapp.Repositories.Models;
namespace Resenhapp.Repositories;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Guest, GuestDTO>();
        CreateMap<GuestDTO, Guest>();

        CreateMap<Item, ItemDTO>();
        CreateMap<ItemDTO, Item>();
                
        CreateMap<Person, PersonDTO>();
        CreateMap<PersonDTO, Person>();

        CreateMap<Party, PartyDTO>();
        CreateMap<PartyDTO, Party>();

        CreateMap<User, UserDTO>();
        CreateMap<UserDTO, User>();
    
    }
}