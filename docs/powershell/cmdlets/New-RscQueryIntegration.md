# New-RscQueryIntegration
## Subcommands
### integration
Read the integration with the specified integration ID.

- There is a single argument of type System.Int32.
- Returns ReadIntegrationReply.
### integrations
List the integrations of the specified types.

- There are 4 arguments.
    - integrationTypes - list of IntegrationTypes: List of integration types.
    - nameFilter - System.String: Optional filter for integration names.
    - integrationSortBy - IntegrationSortBy: Optional filter for sorting integrations.
    - sortOrder - SortOrder: Sorts the order of results.
- Returns ListIntegrationsReply.
