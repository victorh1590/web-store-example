using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers
{
  public class HomeController : Controller
  {
    private IStoreRepository _repository;

    public HomeController(IStoreRepository repository) 
    {
      _repository = repository;
    }

    public IActionResult Index() => View(); // Send products from repository to view.
  }
}