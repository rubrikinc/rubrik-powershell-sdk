# New-RscQuerySmb
## Subcommands
### configuration
Get SMB configuration

Supported in v5.0+
Get SMB configuration.

- There is a single argument of type GetSmbConfigurationInput.
- Returns GetSmbConfigurationReply.
### domains
Paginated list of SMB domains.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - filters - list of SmbDomainFilterInputs: Filter for SMB domains.
    - sortBy - SmbDomainSortByInput: Sort by argument for SMB domains.
- Returns SmbDomainConnection.
