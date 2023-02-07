using DAW.Helpers.Jwt;
using DAW.Services.UserService;

namespace DAW.Helpers.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IUserService userService, IJwtUtils jwtUtils)
        {
            var headers = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ");
            Console.WriteLine(headers[1]);
            var tokenul = headers[1];
            var userId = jwtUtils.ValidateJwtToken(tokenul);
            if (userId != null)
            {
                // attach user to context on successful jwt validation
                context.Items["User"] = userService.GetById(userId);
            }

            await _next(context);
        }

    }
}
