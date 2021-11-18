using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;

[Route("v1/categories")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    [Route("")]
    [AllowAnonymous]
    public async Task<ActionResult<List<Category>>> Get([FromServices] DataContext context)
    {
        var categories = await context.Categories.AsNoTracking().ToListAsync();
        return Ok(categories);
    }

    [HttpGet]
    [Route("{id:int}")]
    [AllowAnonymous]
    public async Task<ActionResult<Category>> GetById(int id, [FromServices] DataContext context)
    {
        var category = await context.Categories.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return Ok(category);
    }

    [HttpPost]
    [Route("")]
    [Authorize(Roles = "employee")]
    public async Task<ActionResult<Category>> Post([FromBody] Category model, [FromServices] DataContext context)
    // [FromBody], diz ao método onde pegar os valores recebidos na requisição.
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        try
        {
            // Persistindo no banco
            context.Categories.Add(model);
            await context.SaveChangesAsync();
            return Ok(model);
        }
        catch (System.Exception)
        {
            return BadRequest(new { message = "An error occur while trying to save category." });
        }
    }

    [HttpPut]
    [Route("{id:int}")]
    [Authorize(Roles = "employee")]
    public async Task<ActionResult<Category>> Put(int id, [FromBody] Category model, [FromServices] DataContext context)
    {
        // Verificando se o ID informado é o mesmo do modelo
        if (model.Id != id)
            return NotFound(new { message = "Category not found!" });

        // Verificando se os dados estão válidos
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        try
        {
            // O framework se encarrega de verificar propriedade por propriedade e analisar o que mudou. Automaticamente ele persisti no banco. Desnecessário passar parâmetro.
            context.Entry<Category>(model).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(model);
        }
        catch (DbUpdateConcurrencyException)
        {
            return BadRequest(new { message = "An error occur while trying to update category. This category is already updated." });
        }
        catch (Exception)
        {
            return BadRequest(new { message = "An error occur while trying to update category" });
        }
    }

    [HttpDelete]
    [Route("{id:int}")]
    [Authorize(Roles = "employee")]
    public async Task<ActionResult<Category>> Delete(int id, [FromServices] DataContext context)
    {
        var category = await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        if (category == null)
            return NotFound(new { message = "Category was not found" });

        try
        {
            context.Categories.Remove(category);
            await context.SaveChangesAsync();
            return Ok(category);
        }
        catch (Exception)
        {
            return BadRequest(new { message = "An error occur while trying to remove category" });
        }
    }
}