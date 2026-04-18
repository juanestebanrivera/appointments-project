namespace Appointments.Api.Infrastructure.Middlewares;

public class CorrelationIdMiddleware(RequestDelegate next)
{
    private const string CorrelationIdHeaderKey = "X-Correlation-ID";

    public async Task InvokeAsync(HttpContext context, ILogger<CorrelationIdMiddleware> logger)
    {
        string correlationId =
            context.Request.Headers.TryGetValue(CorrelationIdHeaderKey, out var headerValue) &&
            !string.IsNullOrWhiteSpace(headerValue)
                ? headerValue.ToString()
                : Guid.NewGuid().ToString();

        context.Response.Headers[CorrelationIdHeaderKey] = correlationId;

        using (logger.BeginScope(new { CorrelationId = correlationId }))
        {
            await next(context);
        }
    }
}