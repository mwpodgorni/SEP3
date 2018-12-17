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
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
        }


        //GET /api/customers/1
        [HttpGet]
        public CustomerDto GetCustomer(string id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Customer,CustomerDto>(customer);
        }

        //POST /api/customers
        [HttpPost]
        public CustomerDto CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return customerDto;
        }

        //PUT /api/customers/1
        [HttpPut]
        public void UpdateCustomer(string id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerToEdit = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerToEdit == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map<CustomerDto, Customer>(customerDto, customerToEdit);

            _context.SaveChanges();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public void DeleteCustomer(string id)
        {
            var customerToRemove = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerToRemove == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerToRemove);
            _context.SaveChanges();
        }

    }
}
