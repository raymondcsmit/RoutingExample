namespace RoutingExample
{
    public class RequestDirectionMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestDirectionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Check for the "direction" query parameter
            var query = context.Request.Query;
            string controllerName = "";
            if (context.Request.RouteValues.TryGetValue("controller", out var controllerValue))
            {
                controllerName = controllerValue?.ToString() ?? "";
            }
            string actionName = "";
            if (context.Request.RouteValues.TryGetValue("action", out var actionValue))
            {
                actionName = actionValue?.ToString() ?? "";
            }
            if (controllerName == "Products")
            {
                context.Response.Redirect($"/{actionName}/About");
            }

            // If no condition is met, continue processing the request
            await _next(context);
        }
    }
}
