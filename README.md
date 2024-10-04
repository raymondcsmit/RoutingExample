# RoutingExample

This simple example should help your students visualize how the routing system works in ASP.NET Core MVC and how URLs are mapped to controller actions.

Route Template: The route template {controller}/{action}/{id?} tells the system to look at the URL and map the parts of the URL to a controller, action, and optional id.
Routing Table Population: When the application starts, the routing system builds a routing table based on the defined routes (like the default route in our case).
URL Matching: When a request comes in, the routing system matches the URL to a route in the table and invokes the correct controller and action method.
Optional Parameters: The id? in the route template is optional, so URLs without the id still match the route (e.g., /Home/Index and /Products).
