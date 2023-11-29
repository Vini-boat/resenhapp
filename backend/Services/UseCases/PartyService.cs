using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Resenhapp.Repositories.Data;
using Resenhapp.Repositories.Models;
using Resenhapp.Repositories.DTOs;
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

    public async Task<PartyDTO?> AddExpense(int party_id, ExpenseDTO expense)
    {
        var party = await _context.Parties.FindAsync(party_id);
        party?.Expenses!.Add(_mapper.Map<Expense>(expense));
        await _context.SaveChangesAsync();
        return _mapper.Map<PartyDTO>(await _context.Parties.FindAsync(party_id));
    }

    public async Task<PartyDTO?> AddGuest(int party_id, GuestDTO guest)
    {
        var party = await _context.Parties.FindAsync(party_id);
        party?.Guests!.Add(_mapper.Map<Guest>(guest));
        await _context.SaveChangesAsync();
        return _mapper.Map<PartyDTO>(await _context.Parties.FindAsync(party_id));
    }

    public async Task<PartyDTO?> Create(PartyDTO party)
    {
        var user = await _context.Users.FindAsync(party.UserId);
        if (user == null) throw new Exception();
        var new_party = new Party {
            User = user,
            Guests = _mapper.Map<List<Guest>>(party.Guests),
            Expenses = _mapper.Map<List<Expense>>(party.Expenses)
        };
        _context.Parties.Add(new_party);
        await _context.SaveChangesAsync();
        return _mapper.Map<PartyDTO>(new_party);
    }
    
    public async Task DeleteById(int id)
    {
        var party_to_delete = await _context.Parties.FindAsync(id);
        if (party_to_delete == null) throw new Exception();
        _context.Parties.Remove(party_to_delete);
        await _context.SaveChangesAsync();
    }

    public async Task<List<PartyDTO>> GetAll()
    {
        return _mapper.Map<List<PartyDTO>>(await _context.Parties.ToListAsync());
    }

    public async Task<PartyDTO?> GetById(int id)
    {
        return _mapper.Map<PartyDTO>(await _context.Parties.FindAsync(id));
    }

    public async Task<List<PartyDTO>> GetByUserId(int id)
    {
        return _mapper.Map<List<PartyDTO>>(
            await _context.Parties
                            .Where(party => party.User!.Id == id)
                            .ToListAsync()
        );
    }
}