using Microsoft.AspNetCore.Mvc;
using ContractMaster.Services;
using ContractMaster.Models;
using System;

namespace ContractMaster.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class JobsController : ControllerBase
  {
    private readonly JobsService _service;
    public JobsController(JobsService jobs_service)
    {
      _service = jobs_service;
    }
    [HttpGet]
    public ActionResult<Job> Get()
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
    public ActionResult<Job> Get(int id)
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
    public ActionResult<Job> Create([FromBody] Job newJob)
    {
      try
      {
        return Ok(_service.Create(newJob));
      }
      catch (Exception error)
      {
        return BadRequest(error.Message);
      }

    }

    [HttpPut("{id")]
    public ActionResult<Job> Edit([FromBody] Job updated, int id)
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
    public ActionResult<Job> Delete(int id)
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