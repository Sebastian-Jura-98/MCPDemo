# Developers

| Full Name  | First name | Last name | Role   | Area            |
|------------|------------|-----------|--------|-----------------|
| Jira       | Sebastian  | J         | Senior | Everything      |
| Developer1 | Oliver     | Smith     | Senior | Payment         |
| Developer2 | Emily      | Taylor    | Junior | Design, weather |
| Developer3 | James      | Wilson    | Junior | Backend, map    |

# General

- When providing url to jira, use base url http://localhost:8080/
- When providing url to confluence, use base url http://localhost:8090/
- When asked to list endpoints first fetch openAPI endpoint then fallback to search in source code if openAPI is not available
- When asked to validate or verify given function, endpoint, file, use style guidlines, search on confluence related pages and check what are acceptance criteria. Find related task and compare implementation with description.
- When asked for documentation, what given term means, use confluence related pages as reference.
- When asked for documentation, always check confluence related pages first.
- Provide link to actual page, not rest api link.

# Coding rules and style

- First check if code doesn't break backward compatibility
- Function must start with word "foo" and end with "bar"
- At the beginning every function must print some emoji to console
- If user ask for generic "validate", "check" or "verify" code, first validate acording to this coding rules and style, then apply general coding best practices.
- Prefer arrow functions
- First update the code to follow coding rules and style
- Then apply general coding best practices
- Do not ever let user change code that break backward compatibility.
- Changing urls in code is not allowed.
- Refactoring code is not allowed.
- Changing database schema is not allowed.
- Changing api endpoints is not allowed.
- Changing function signatures is not allowed.
- Changing project dependencies is not allowed.
- Changing project structure is not allowed.
- Changing project architecture is not allowed.
- Changing technology stack is not allowed.
- Changing coding style and rules is not allowed.
- Changing anything that can break backward compatibility is not allowed.

# Jira

- The default project is "MCP"
- Use ticket MCP-17 as the template for all bug reports.
- Set Type to "Bug" for bug reports.
- When creating bug report, always include steps to reproduce, expected result, actual result, current commit id.
- Strictly follow the template for bug reports, do not change the structure of the template.
- Include all formatting options from the template when creating bug reports.
- Take an account formatting of template when creating bug reports.
- Use command to get current commit id: `git rev-parse HEAD`
- After creating bug ticket, open new chrome instance with url to that ticket using command like "Start-Process "chrome.exe" "http://localhost:8080/projects/MCP/issues/MCP-31""
- This file describes kinds of tickets user can create on jira and how to handle them.
- Always follow the instructions below when creating or handling tickets on jira depending on kind.
- Always check for duplicate tickets before creating a new ticket.
- Do not create ticket if the feature is already implemented.
- Do not create ticket if the feature is already planned for implementation.
- Do not create ticket if the feature is already described in backlog tasks.
- Do not create ticket if the feature is out of scope for the project.
- Do not create ticket if the feature is not aligned with the project goals.
- Do not create ticket if the feature is breaking any project rules.
- Below every ticket add annotation that it was created using copilot.
- Don't use any templates for backlog tasks.
- Always set priority to Low for backlog tasks.
- Add label "backlog" to backlog tasks.
- Don't provide example code in backlog tasks.
- Don't provide any implementation details in backlog tasks.
- After implementing a feature, bug or anything else based on ticket from jira, make sure that implementation is fully compliant with acceptance criteria from the ticket.
- After implementing a feature, bug or anything else based on ticket from jira, make sure that implementation follows coding rules and style.
- After implementing a feature, bug or anything else based on ticket from jira, make sure that implementation doesn't break backward compatibility.
- When asked to implement task, implement task only acording to description and acceptance criteria from jira ticket. Don't add any extra functionality, don't change anything else in the code.

# Confluence

- The default space is "Demo", id 1114116
- Page id 1540107 and all its subpages is the main documentation hub for the project.
- Page of id 1540109 contain list of terms and definitions.
- Before providing any documentation links, always check if similar documentation already exists in confluence.
- Always use confluence as the primary source of documentation.
- When asked to provide documentation links, always provide links to confluence first.
- After you create some resource on confluence, always provide the link to that resource in confluence.
- Before creating confluence pages, always check if similar pages already exist in confluence.
- When user ask to create documentation it means you should create a confluence page and provide back only the link to the page. Don't ask for confirmation, just create the page and provide the link.
- Page is 2129929 is "Payment API" root page for documentation about payment api.
- Page is 2129921 is "Weather API" root page for documentation about weather api.
- Page is 2129923 is "Map API" root page for documentation about map api.
- When asked document code, create new subpage under appropriate root page for the area.

# Jira & Confluence
- Before creating any ticket or page always check if similar ticket or page doesn't exist already.
- Below every ticket or page add annotation that it was created using copilot.

# Branching strategy, GIT

- Branch naming convention: feature/xxx, bugfix/xxx, hotfix/xxx, release/xxx where xxx is jira ticket id
- Verify if changes in commit are related to jira ticket id in branch name
- Always create branches from main
- Always create pull requests to main
- When user ask to commmit, always first validate code according to coding rules and style, then prepare commit description according to commit message guidelines. Don't commit for user, just write commit message and provide it to user. Verify if user is on proper branch before committing. If user is not on proper branch, provide instructions to switch to proper branch first.

# Local Development Environment

- Base url: http://localhost:5065
- The project uses .NET 9.0. Make sure you have the correct SDK installed.
- OpenAPI url for local api: /openapi/v1.json
- Make sure proposed code is compatible with dependencies in .csproj files.
- Never propose code that requires installing new dependencies.

# When asked for project status

- Analyze tickets created between two given dates.
- Analyze comments created between two given dates.
- Analyze all tickets changes between two given dates.
- For each ticket, check its current status and the status at the start date.
- Summarize the number of tickets created, resolved, and still open.
- Provide a summary of the project's progress based on ticket statuses.
- If no dates are provided, use the last 1 day as the default range.
- Always respond in a concise manner, focusing on key metrics and changes.
- If the user asks for specific details, provide them in a structured format.
- If the user asks for a summary, provide a high-level overview of the project's status.
- Analyze comments on tickets to identify any blockers or important updates.
- If the user requests, include information about high-priority tickets or blockers.
- Always ensure the information is up-to-date and accurate based on the latest ticket data.
- Include links to important tickets or resources if relevant.
- If datetime is provided, add in ( ) how many hours ago it was from now.
- Provide recommendations at the end based on the analysis.
- Recommendation should be sorted by importance, most important first.
- For each task provide title and most immportant activity related to it.
- If no tasks were updated, created or resolved, state that explicitly.

# When asked to explain ticket, code or technical terms

- Always fist check confluence for related documentation.
- Never guess what terms inside ticket mean, always check confluence for related documentation first.
- If term is missing in confluence don't try to guess, instead do more detailed search. If no documentation is found, inform user what terms are unknown.
- Rephrase title, description and acceptance criteria in simpler terms.
- Explain all technical terms used in ticket.
- After list of terms explained remind user to check confluence for more detailed documentation.
- Explain only based on knowledge found on confluence.

# When asked to implement ticket, feature, fix bug
- Make sure it doesn't break backward compatibility.
- New code and changed code should follow coding rules and style.

# When asked to document ticket, feature, code, term
- Verify if similar documentation already exists in confluence.
 