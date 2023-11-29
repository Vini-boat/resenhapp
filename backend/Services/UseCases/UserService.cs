using Microsoft.EntityFrameworkCore;
using AutoMapper;

using Resenhapp.Services.Interfaces;
using Resenhapp.Repositories.Data;
using Resenhapp.Repositories.Models;
using Resenhapp.Repositories.DTOs;
using Microsoft.AspNetCore.Mvc;

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
    public async Task Create(UserDTO user)
    {
        var new_user = _mapper.Map<User>(user);
        _context.Users.Add(new_user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteById(int id)
    {
        var user_to_delete = await _context.Users.FindAsync(id);
        if (user_to_delete == null) throw new Exception();
        _context.Users.Remove(user_to_delete);
        await _context.SaveChangesAsync();
    }

    public async Task<List<UserDTO>> GetAll()
    {
        return _mapper.Map<List<UserDTO>>(await _context.Users.ToListAsync());
    }

    public async Task<UserDTO?> GetById(int id)
    {
        return _mapper.Map<UserDTO>(await _context.Users.FindAsync(id));
    }
    public async Task Update(UserDTO new_user)
    {
        var user = await _context.Users.FindAsync(new_user.Id);
        if (user == null) throw new Exception();  
        user = _mapper.Map<User>(new_user);
        await _context.SaveChangesAsync();
    }
}