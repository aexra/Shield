﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Shield.Web.Data.Contexts;
using Shield.Web.Dtos.Contract;
using Shield.Web.Data.Models;
using System.Xml;

namespace Shield.Web.Controllers;

[Route("api/contract")]
[ApiController]
public class ContractController : ControllerBase
{
    private readonly DataContext _context;

    public ContractController(DataContext context) 
    { 
        _context = context;
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetAllContracts()
    {
        return Ok(_context.Contracts);
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> CreateContract([FromBody] ContractDto dto)
    {
        var entity = await _context.Contracts.AddAsync(new Contract { Address=dto.Address, PlanSrc=dto.TEMPplansrcTEMP, Owners=string.Join(";", dto.Owners), Bailee=dto.Bailee });
        await _context.SaveChangesAsync();
        return Ok(entity.Entity);
    }

    [HttpGet("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetContract([FromRoute] int id)
    {
        var contract = await _context.Contracts.FindAsync(id);
        if (contract != null) return Ok(contract);
        else return NotFound();
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteContract([FromRoute] int id)
    {
        var contract = await _context.Contracts.FindAsync(id);
        if (contract != null)
        {
            _context.Contracts.Remove(contract);
            await _context.SaveChangesAsync();
            return Ok(contract);
        }
        else return NotFound();
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> UpdateContract([FromRoute] int id, [FromBody] ContractDto dto)
    {
        var contract = await _context.Contracts.FindAsync(id);
        if (contract != null)
        {
            contract.Address = dto.Address;
            contract.PlanSrc = dto.TEMPplansrcTEMP;
            contract.Owners = string.Join(";", dto.Owners);
            contract.Bailee = dto.Bailee;

            await _context.SaveChangesAsync();
            return Ok();
        }
        else return NotFound();
    }
}