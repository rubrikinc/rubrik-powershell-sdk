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

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - list of SmbDomainFilterInputs: Filter for SMB domains.
    - sortBy - SmbDomainSortByInput: Sort by argument for SMB domains.
- Returns SmbDomainConnection.
