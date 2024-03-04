using Microsoft.AspNetCore.Mvc;
using RestAPI.Entities;
using RestAPI.Repositories;

namespace RestAPI.Controllers
{
    [Route("Offre")]
    [ApiController]
    public class RestOffresController : ControllerBase
    {
        private readonly OffreRepository _offreRepository;

        public RestOffresController(OffreRepository offreRepository)
        {
            _offreRepository = offreRepository;
        }

        // GET All Method
        [HttpGet]
        public async Task<ActionResult<Offre>> GetAll()
        {
            try
            {
                var response = await _offreRepository.GetAll();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Une erreur inattendue est survenue : {ex.Message}");
            }
        }

        // GET Method
        [HttpGet("{id}")]
        public async Task<ActionResult<Offre>> GetById(int id)
        {
            try
            {
                var response = await _offreRepository.GetById(id);
                if (response == null)
                {
                    return NotFound();
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Une erreur inattendue est survenue : {ex.Message}");
            }
        }

        // POST Method
        [HttpPost]
        public async Task<ActionResult<Offre>> SaveOffre(Offre offre)
        {
            try
            {
                var response = await _offreRepository.Saveoffre(offre);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Une erreur inattendue est survenue : {ex.Message}");
            }
        }

        // DELETE method
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOffre(int id)
        {
            try
            {
                var isDeleted = await _offreRepository.Deleteoffre(id);
                if (isDeleted)
                {
                    return Ok(true);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Une erreur inattendue est survenue : {ex.Message}");
            }
        }
    }
}
