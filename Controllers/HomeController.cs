using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using northwind_net.Models;

namespace northwind_net.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            FileGatway aGateway = new FileGatway();
            List<Catagory> aListOfCategories = aGateway.GetCategory("C:\\Users\\Nahom\\source\\repos\\northwind_net\\Categories.csv");
                ViewBag.ListOfCategories = aListOfCategories;


                List<Employee> aListOfEmployees = aGateway.GetEmployee("C:\\Users\\Nahom\\source\\repos\\northwind_net\\Employees.csv");
                ViewBag.ListOfEmployees = aListOfEmployees;


                List<OrderDetail> aListOfOrderDetails = aGateway.GetOrderDetail("C:\\Users\\Nahom\\source\\repos\\northwind_net\\OrderDetails.csv");
                ViewBag.ListOfOrderDetails = aListOfOrderDetails;


                List<Product> aListOfProducts = aGateway.GetProduct("C:\\Users\\Nahom\\source\\repos\\northwind_net\\Products.csv");
                ViewBag.ListOfProducts = aListOfProducts;


                List<Shipper> aListOfShippers = aGateway.GetShipper("C:\\Users\\Nahom\\source\\repos\\northwind_net\\Shippers.csv");
                ViewBag.ListOfShippers = aListOfShippers;


                List<Supplier> aListOfSuppliers = aGateway.GetSupplier("C:\\Users\\Nahom\\source\\repos\\northwind_net\\Suppliers.csv");
                ViewBag.ListOfSuppliers = aListOfSuppliers;

                return View();
        }
    }
}
