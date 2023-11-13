using Resenhapp.Services.Interfaces;
using Resenhapp.Services.UseCases;

namespace Resenhapp.Services;

public static class ServicesExtentions{

    public static IServiceCollection AddDatabaseServices(this IServiceCollection services){

        services.AddScoped<IItemService, ItemService>();
        services.AddScoped<IPartyService, PartyService>();
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}