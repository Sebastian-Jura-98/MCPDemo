using static ToolsResourcesPrompts;

namespace MCPDemo;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMcp(this IServiceCollection services)
    {
        services
            .AddMcpServer()
            .WithHttpTransport()
            .WithTools<ToolsResourcesPrompts>()
            .WithResources<SimpleResource>()
            .WithPrompts<ToolsResourcesPrompts>();

        return services;
    }
}
