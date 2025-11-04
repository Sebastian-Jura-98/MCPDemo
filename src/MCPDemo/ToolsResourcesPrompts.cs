using Microsoft.Extensions.AI;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Globalization;

/// <summary>
/// Sample MCP tools for demonstration purposes.
/// These tools can be invoked by MCP clients to perform various operations.
/// </summary>
internal class ToolsResourcesPrompts
{
    [McpServerTool]
    [Description("Generates a random number between the specified minimum and maximum values.")]
    public int GenerateRandomNumber([Description("The minimum value (inclusive).")] int min, [Description("The maximum value (exclusive).")] int max)
    {
        return Random.Shared.Next(min, max);
    }

    [McpServerResource]
    [McpServerPrompt(Name = "TicketName")]
    [Description("Whats the name jira ticket")]
    public IReadOnlyCollection<ChatMessage> TicketName([Description("The ID of the Jira ticket.")] int id)
    {
        var content = string.Format(CultureInfo.InvariantCulture, "Tell what is the name of jira ticket id {0}.", id);
        return [
            new (ChatRole.User, content)
        ];
    }

    [McpServerResourceType]
    public class SimpleResource
    {
        [McpServerResource, Description("Template for feature request.")]
        public string GetFeatureRequestTemplate() => "Title, descriptions, acceptance criteria, favourite pet, faviourite color";
    }
}
