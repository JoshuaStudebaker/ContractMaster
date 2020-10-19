using Microsoft.AspNetCore.Mvc;
using ContractMaster.Services;
using ContractMaster.Models;
using System;

namespace ContractMaster.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ContractorsController : ControllerBase
  {
    private readonly ContractorsService _service;
    public ContractorsController(ContractorsService contractors_service)
    {
      _service = contractors_service;
    }
    [HttpGet]
    public ActionResult<Contractor> Get()
    {
      try
      {
        return Ok(_service.GetAll());
      }
      catch (Exception error)
      {
        return BadRequest(error.Message);
      }

    }

    [HttpGet("{id")]
    public ActionResult<Contractor> Get(int id)
    {
      try
      {
        return Ok(_service.GetById(id));
      }
      catch (Exception error)
      {
        return BadRequest(error.Message);
      }

    }

    [HttpPost]
    public ActionResult<Contractor> Create([FromBody] Contractor newContractor)
    {
      try
      {
        return Ok(_service.Create(newContractor));
      }
      catch (Exception error)
      {
        return BadRequest(error.Message);
      }

    }

    [HttpPut("{id")]
    public ActionResult<Contractor> Edit([FromBody] Contractor updated, int id)
    {
      try
      {
        updated.Id = id;
        return Ok(_service.Edit(id));
      }
      catch (Exception error)
      {
        return BadRequest(error.Message);
      }

    }

    [HttpDelete("{id")]
    public ActionResult<Contractor> Delete(int id)
    {
      try
      {
        return Ok(_service.Delete(id));
      }
      catch (Exception error)
      {
        return BadRequest(error.Message);
      }

    }

  }


}