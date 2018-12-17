using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using CarRental.Core.Contracts;
using CarRental.Core.Dtos;
using CarRental.Core.Models;
using CarRental.DataAccess.SQL;

namespace CarRental.WebUI.Controllers.API
{
    public class CustomersController : ApiController
    {
        private DataContext _context;

        public CustomersController()
        {
                _context = new DataContext();
        }

        // GET /api/customers
        [HttpGet]
        public IHttpActionResult GetCustomers()
        {
            var customerDtos =  _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);
        }


        //GET /api/customers/1
        [HttpGet]
        public IHttpActionResult GetCustomer(string id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customer,CustomerDto>(customer));
        }

        //POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri+"/"+customer.Id), customerDto);
        }

        //PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(string id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerToEdit = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerToEdit == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map<CustomerDto, Customer>(customerDto, customerToEdit);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(string id)
        {
            var customerToRemove = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerToRemove == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerToRemove);
            _context.SaveChanges();

            return Ok();
        }

    }
}
