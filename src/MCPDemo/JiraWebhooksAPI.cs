using System.Diagnostics;

namespace MCPDemo;

public static class JiraWebhooksAPI
{
    private static void ExecutePrompt(string prompt)
    {
        Console.WriteLine("Executing prompt: {0}", prompt);
        Task.Run(() =>
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c copilot -p \"{prompt}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var process = new Process { StartInfo = processStartInfo };
            process.OutputDataReceived += (sender, args) =>
            {
                if (args.Data != null)
                    Console.WriteLine(args.Data);
            };
            process.ErrorDataReceived += (sender, args) =>
            {
                if (args.Data != null)
                    Console.Error.WriteLine(args.Data);
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            process.WaitForExit();
            Console.WriteLine("Prompt completed");
        });

    }
    public static WebApplication AddJiraConfluenceWebhooks(this WebApplication app)
    {
        app.MapGet("/commentAdded", (int ticketId) =>
        {
            ExecutePrompt($"A new comment has been added to ticket ID {ticketId}. Please analyze the ticket, review all existing comments and relevant documentation, and add a new comment in the ticket if additional clarification or information is needed to move the ticket forward.");
            return Results.Ok();
        });

        app.MapGet("/ticketCreated", (int ticketId) =>
        {
            ExecutePrompt($"A new ticket has been created with ID {ticketId}. Please analyze the ticket, review related documentation and similar tickets, and add a comment in the ticket that provides a comprehensive explanation containing all the information a developer needs to implement the best possible solution.");
            return Results.Ok();
        });

        app.MapGet("/confluencePageUpdated", (int pageId) =>
        {
            ExecutePrompt($"A page with ID {pageId} has been updated. Please analyze the updated page, review all relevant documentation, and identify all related tickets. In the Jira ticket comment, notify developers that the documentation has changed, specify what has changed, and provide actionable suggestions based on the updates. Additionally, add a comment in Confluence summarizing which related tickets were affected by the change.");
            return Results.Ok();
        });

        return app;
    }
}
