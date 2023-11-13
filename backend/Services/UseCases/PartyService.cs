using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Resenhapp.Repositories.Data;
using Resenhapp.Repositories.Models;
using Resenhapp.Migrations;
using Resenhapp.Services.Interfaces;

namespace Resenhapp.Services.UseCases;

public class PartyService: IPartyService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public PartyService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task Create(Party party)
    {
        _context.Parties.Add(party);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Party party)
    {
        _context.Parties.Remove(party);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Party>> GetAll()
    {
        return await _context.Parties.ToListAsync();
    }

    public async Task<Party?> GetById(int id)
    {
        return await _context.Parties.FindAsync(id);
    }

    public async Task<List<Party>> GetByUserId(int id)
    {
        return await _context.Parties.Where(party => party.User!.Id == id).ToListAsync();
    }

    public Task Update(Party new_party)
    {
        throw new NotImplementedException();
    }
}