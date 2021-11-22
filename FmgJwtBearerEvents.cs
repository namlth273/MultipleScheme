using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace MultipleScheme
{
    public class FmgJwtBearerEvents : JwtBearerEvents
    {
        private readonly ILogger<FmgJwtBearerEvents> _logger;

        public FmgJwtBearerEvents(ILogger<FmgJwtBearerEvents> logger)
        {
            _logger = logger;
        }

        public override Task TokenValidated(TokenValidatedContext context)
        {
            _logger.LogInformation("Hello from FMG");
            return base.TokenValidated(context);
        }
    }

    public class FuseJwtBearerEvents : JwtBearerEvents
    {
        private readonly ILogger<FmgJwtBearerEvents> _logger;

        public FuseJwtBearerEvents(ILogger<FmgJwtBearerEvents> logger)
        {
            _logger = logger;
        }

        public override Task TokenValidated(TokenValidatedContext context)
        {
            _logger.LogInformation("Hello from Fuse.......");
            return base.TokenValidated(context);
        }
    }

    public static class FuseJwtBearerDefaults
    {
        /// <summary>
        /// Default value for AuthenticationScheme property in the JwtBearerAuthenticationOptions
        /// </summary>
        public const string AuthenticationScheme = "Fuse";
    }

    public static class FmgJwtBearerDefaults
    {
        /// <summary>
        /// Default value for AuthenticationScheme property in the JwtBearerAuthenticationOptions
        /// </summary>
        public const string AuthenticationScheme = "Bearer";
    }
}