using Microsoft.EntityFrameworkCore;
using AutoMapper;

using Resenhapp.Services.Interfaces;
using Resenhapp.Repositories.Data;
using Resenhapp.Repositories.Models;

namespace Resenhapp.Services.UseCases;

public class UserService : IUserService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public UserService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task Create(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(User user)
    {
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }

    public async Task<List<User>> GetAll()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User?> GetById(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    public Task Update(User user)
    {
        throw new NotImplementedException();
    }
}