using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerProject.Core.Models;
using NLayerProject.Core.Services;
using NLayerProject.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IServices<Person> _personService;


        public PersonController(IServices<Person> personService)
        {
            _personService = personService;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var persons = await _personService.GetAllAsync();

            return Ok(persons);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            var newPerson = await _personService.AddAsync(person);

            return Created(string.Empty, newPerson);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var person = await _personService.GetByIdAsync(id);

            return Ok(person);
        }
    }
}
