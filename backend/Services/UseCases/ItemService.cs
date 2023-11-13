using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Resenhapp.Repositories.Data;
using Resenhapp.Repositories.Models;
using Resenhapp.Repositories.DTOs;
using Resenhapp.Services.Interfaces;

namespace Resenhapp.Services.UseCases;



public class ItemService : IItemService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public ItemService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task Create(Item item)
    {
        _context.Items.Add(item);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Item item)
    {
        _context.Items.Remove(item);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Item>> GetAll()
    {
        return await _context.Items.ToListAsync();
    }

    public async Task<Item?> GetById(int id)
    {
        return await _context.Items.FindAsync(id);
    }

    public async Task Update(ItemDTO new_item)
    {
        var item = await _context.Items.FindAsync(new_item.Id);
        if (item == null) throw new Exception("deu nulo");  
        item = _mapper.Map<Item>(new_item);
        await _context.SaveChangesAsync();
    }
}