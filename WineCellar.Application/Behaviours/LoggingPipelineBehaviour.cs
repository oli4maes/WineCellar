using Microsoft.Extensions.Logging;

namespace WineCellar.Application.Behaviours;

public class LoggingPipelineBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly ILogger<LoggingPipelineBehaviour<TRequest, TResponse>> _logger;

    public LoggingPipelineBehaviour(ILogger<LoggingPipelineBehaviour<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }

    public async ValueTask<TResponse> Handle(TRequest message, CancellationToken cancellationToken,
        MessageHandlerDelegate<TRequest, TResponse> next)
    {
        _logger.LogInformation("Starting request {@RequestName}, {@DateTimeUtc}",
            typeof(TRequest).Name,
            DateTime.UtcNow);

        try
        {
            return await next(message, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,
                "Error handling message of type {@messageType}, {@DateTimeUtc}, {@Error}",
                message.GetType().Name,
                DateTime.UtcNow,
                ex);
            throw;
        }
    }
}