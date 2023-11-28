using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Resenhapp.Repositories.Data;
using Resenhapp.Repositories.Models;
using Resenhapp.Repositories.DTOs;
using Resenhapp.Migrations;
using Resenhapp.Services.Interfaces;
using SQLitePCL;

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

    public async Task<Party?> AddExpense(int party_id, ExpenseDTO expense)
    {
        var party = await _context.Parties.FindAsync(party_id);
        party?.Expenses!.Add(_mapper.Map<Expense>(expense));
        await _context.SaveChangesAsync();
        return party;
    }

    public async Task<Party?> AddGuest(int party_id, GuestDTO guest)
    {
        var party = await _context.Parties.FindAsync(party_id);
        party?.Guests!.Add(_mapper.Map<Guest>(guest));
        await _context.SaveChangesAsync();
        return party;
    }

    public async Task<Party?> Create(PartyDTO party)
    {
        var user = await _context.Users.FindAsync(party.UserId);
        if (user == null) return null;
        var new_party = new Party {
            User = user,
            Guests = _mapper.Map<List<Guest>>(party.Guests),
            Expenses = _mapper.Map<List<Expense>>(party.Expenses)
        };
        _context.Parties.Add(new_party);
        await _context.SaveChangesAsync();
        return new_party;
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
}