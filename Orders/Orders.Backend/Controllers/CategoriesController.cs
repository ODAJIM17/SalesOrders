using Microsoft.AspNetCore.Mvc;
using Orders.Backend.UnitsOfWork.Interfaces;
using Orders.Shared.Entities;

namespace Orders.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : GenericController<Category>
{
    public CategoriesController(IGenericUnitOfWork<Category> unitOfWork) : base(unitOfWork)
    {
    }
}