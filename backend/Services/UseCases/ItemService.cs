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

    public async Task Create(ItemDTO item)
    {
        var new_item = _mapper.Map<Item>(item);
        _context.Items.Add(new_item);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteById(int id)
    {
        var item_to_delete = await _context.Items.FindAsync(id);
        if (item_to_delete == null) throw new Exception();
        _context.Items.Remove(item_to_delete);
        await _context.SaveChangesAsync();
    }

    public async Task<List<ItemDTO>> GetAll()
    {
        return _mapper.Map<List<ItemDTO>>(await _context.Items.ToListAsync());
    }

    public async Task<ItemDTO?> GetById(int id)
    {
        return _mapper.Map<ItemDTO>(await _context.Items.FindAsync(id));
    }

    public async Task Update(ItemDTO new_item)
    {
        var item = await _context.Items.FindAsync(new_item.Id);
        if (item == null) throw new Exception();  
        item = _mapper.Map<Item>(new_item);
        await _context.SaveChangesAsync();
    }
}