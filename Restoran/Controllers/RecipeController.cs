using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restoran.models;

namespace Restoran.Controllers
{
    [ApiController]
    [Route("/recipes")]
    public class RecipeController : Controller { 

    
        private RestoranDBContext RestoranDBContextt;
       public RecipeController(RestoranDBContext ctx)
        {

            this.RestoranDBContextt = ctx;

        }

        [HttpGet]
        [Route("/recepti")]
        public async Task<ActionResult<IEnumerable<Recipe>>> getRecipes()
        {
            return await RestoranDBContextt.recipes.ToListAsync();
        }



        // GET: api/Recipes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Recipe>> GetRecipe(int id)
        {
            var recipe = await RestoranDBContextt.recipes.FindAsync(id);

            if (recipe == null)
            {
                return NotFound();
            }

            return recipe;
        }

        // PUT: api/Recipes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecipe(int id, Recipe recipe)
        {
            if (id != recipe.RecpeId)
            {
                return BadRequest();
            }

            RestoranDBContextt.Entry(recipe).State = EntityState.Modified;

            try
            {
                await RestoranDBContextt.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Recipes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        [Route("/dodajRecept")]
        public async Task<ActionResult<Recipe>> PostRecipe(Recipe recipe)
        {
            RestoranDBContextt.recipes.Add(recipe);
            await RestoranDBContextt.SaveChangesAsync();

            return CreatedAtAction("GetRecipe", new { id = recipe.RecpeId }, recipe);
        }

        // DELETE: api/Recipes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Recipe>> DeleteRecipe(int id)
        {
            var recipe = await RestoranDBContextt.recipes.FindAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }

            RestoranDBContextt.recipes.Remove(recipe);
            await RestoranDBContextt.SaveChangesAsync();

            return recipe;
        }

        private bool RecipeExists(int id)
        {
            return RestoranDBContextt.recipes.Any(e => e.RecpeId == id);
        }
    }
}