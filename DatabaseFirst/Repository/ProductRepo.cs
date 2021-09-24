using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFirst.Repository
{
    public class ProductRepo
    {
        public static async Task<IEnumerable<Product>> GetProductAsync()
        {
            using var data = new SalesContext();//conexion a la base de datos;
            return await data.Product.Where(x=>x.UnitPrice>=10).ToListAsync();
        }

        //obtencion de Productos por ID
        public static async Task<Product> GetProductIdAsync(int Id)
        {
            using var data = new SalesContext();
            return await data.Product.Where(x=>x.Id==Id).FirstOrDefaultAsync();
        }

        //insercion de Productos
        public static async Task<bool> InsertProductAsync(Product product)
        {
            bool exito = true;
            try
            {
                using var data = new SalesContext();
                data.Add(product);
                await data.SaveChangesAsync();
            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }
        //Editar un Producto

        public static async Task<bool> UpdateProductAsync(Product product)
        {
            bool exito = true;
            try {

                using var data = new SalesContext();
                var editado = await data.Product.Where(x => x.Id == product.Id).FirstOrDefaultAsync(); ;
                editado.ProductName = product.ProductName;
                editado.SupplierId = product.SupplierId;
                editado.UnitPrice = product.UnitPrice;
                editado.Package = editado.Package;
                editado.IsDiscontinued = editado.IsDiscontinued;
                await data.SaveChangesAsync();

            } catch (Exception){

                throw;

            }
    
            return exito;
        }
        // Eliminar Producto
        public static async Task<bool> Delate(int Id)
        {
            bool exito = true;
            try
            {
                using var data = new SalesContext();
                var eliminado = await data.Product.Where(x => x.Id == Id).FirstOrDefaultAsync();
                data.Product.Remove(eliminado);
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
