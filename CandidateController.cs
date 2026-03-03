using ADO.NET_APP.DataAccess;
using ADO.NET_APP.Models;
using Microsoft.AspNetCore.Mvc;
namespace ADO.NET_APP.Controllers
{
    public class CandidateController : Controller
    {
        private readonly CandidateService _candidateService;
        public CandidateController()
        {
            _candidateService = new CandidateService();
        }
     
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            Candidate candidate = _candidateService.GetCandidate(id);
            if (candidate == null)
                return NotFound();
            return View(candidate);
        }

    }
}
