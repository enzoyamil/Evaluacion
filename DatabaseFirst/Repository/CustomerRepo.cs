using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFirst.Repository
{
    public class CustomerRepo
    {
        public async static Task<IEnumerable<Customer>> GetCustomerAsync()
        {
            using var data = new SalesContext();
            return await data.Customer.ToListAsync();
        }

        public async static Task<Customer> GetCustomerAsync(int Id)
        {
            using var data = new SalesContext();
            return await data.Customer.Where(x=>x.Id==Id).FirstOrDefaultAsync();
        }
        public async static Task <bool> insertCustomerAsync(Customer customer)
        {
            bool exito = true;
            try {
                using var data = new SalesContext();
                data.Add(customer);
                await data.SaveChangesAsync();
            } 
            catch(Exception){

                exito = false;
            }
            return exito;
        }
        //Editar un Customer

        public async static Task<bool> UpdateCustomerAsync(Customer customer)
        {
            bool exito = true;
            try {
                using var data = new SalesContext();
                var editado = await data.Customer.Where(x => x.Id == customer.Id).FirstOrDefaultAsync();
                editado.LastName = customer.LastName;
                editado.FirstName = customer.FirstName;
                editado.City = customer.City;
                editado.Country = customer.Country;
                editado.Phone = customer.Phone;
                await data.SaveChangesAsync();

            } catch (Exception) { throw; }
            
            return exito;

        }
        //eliminar Customer

        public async static Task<bool> DelateCustomerAsync(int Id)
        {
            bool exito = true;
            try {
                using var data = new SalesContext();
                var eliminado = await data.Customer.Where(x => x.Id == Id).FirstOrDefaultAsync();
                data.Customer.Remove(eliminado);
                await data.SaveChangesAsync();
            } 
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        
    }
}
