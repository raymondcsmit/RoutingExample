using Microsoft.AspNetCore.Mvc;

namespace RoutingExample.Controllers
{
    public class ProductsController : Controller
    {
        #region routing table

        private readonly EndpointDataSource _endpointDataSource;

        public ProductsController(EndpointDataSource endpointDataSource)
        {
            _endpointDataSource = endpointDataSource;
        }

        public IActionResult ShowRoutes()
        {
            var routes = _endpointDataSource.Endpoints;

            // Create a simple list of route names
            var routeList = new List<string>();

            foreach (var endpoint in routes)
            {
                // Only show endpoints with a DisplayName
                if (!string.IsNullOrEmpty(endpoint.DisplayName))
                {
                    routeList.Add(endpoint.DisplayName);
                }
            }

            // Pass the list of routes to the view
            return View(routeList); // Use this to return a view
        }


        #endregion routing table


        // Action to handle "/Products"
        public IActionResult Index()
        {
            return View();
        }

        // Action to handle "/Products/Details/{id}"
        public IActionResult Detail(int id)
        {
            return View();
        }
    }

}
