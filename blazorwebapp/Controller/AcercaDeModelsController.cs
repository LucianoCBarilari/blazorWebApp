using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using blazorwebapp.Data;


namespace blazorwebapp.Controller
{
    [Route("/api")]
    [ApiController]
    public class AcercaDeModelsController : ControllerBase
    {



        /*private readonly Portweb _db;

        public AcercaDeModelsController(Portweb context)
        {
            _db = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<AcercaDeModel>>> mostrar() {
            Console.WriteLine("executed");
            return (await _db.AcercaDeModel.ToListAsync()).ToList();
        }*/

        // GET: AcercaDeModels
        //public async Task Getdata() => await _context.AcercaDeModel.FindAsync();
        /*
        // GET: AcercaDeModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AcercaDeModel == null)
            {
                return NotFound();
            }

            var acercaDeModel = await _context.AcercaDeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (acercaDeModel == null)
            {
                return NotFound();
            }

            return View(acercaDeModel);
        }

        // GET: AcercaDeModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AcercaDeModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,Descripcion")] AcercaDeModel acercaDeModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(acercaDeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(acercaDeModel);
        }

        // GET: AcercaDeModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AcercaDeModel == null)
            {
                return NotFound();
            }

            var acercaDeModel = await _context.AcercaDeModel.FindAsync(id);
            if (acercaDeModel == null)
            {
                return NotFound();
            }
            return View(acercaDeModel);
        }

        // POST: AcercaDeModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido,Descripcion")] AcercaDeModel acercaDeModel)
        {
            if (id != acercaDeModel.Id)
            {
                return NotFoundResult();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acercaDeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcercaDeModelExists(acercaDeModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(acercaDeModel);
        }

        // GET: AcercaDeModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AcercaDeModel == null)
            {
                return NotFound();
            }

            var acercaDeModel = await _context.AcercaDeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (acercaDeModel == null)
            {
                return NotFound();
            }

            return View(acercaDeModel);
        }

        // POST: AcercaDeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AcercaDeModel == null)
            {
                return Problem("Entity set 'Portweb.AcercaDeModel'  is null.");
            }
            var acercaDeModel = await _context.AcercaDeModel.FindAsync(id);
            if (acercaDeModel != null)
            {
                _context.AcercaDeModel.Remove(acercaDeModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcercaDeModelExists(int id)
        {
          return _context.AcercaDeModel.Any(e => e.Id == id);
        }
    }*/
    }
}
