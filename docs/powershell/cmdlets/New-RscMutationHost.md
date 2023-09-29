# New-RscMutationHost
## Subcommands
### bulkdelete
- There is a single argument of type BulkDeleteHostInput.
- Returns ResponseSuccess.
### bulkrefresh
Refresh multiple hosts with a single request.

- There is a single argument of type BulkRefreshHostsInput.
- Returns BulkRefreshHostsReply.
### bulkregister
Register hosts

Supported in v5.0+
Register hosts with Rubrik clusters.

- There is a single argument of type BulkRegisterHostInput.
- Returns BulkRegisterHostReply.
### bulkupdate
- There is a single argument of type BulkUpdateHostInput.
- Returns BulkUpdateHostReply.
### changevfd
Install or uninstall volume filter driver on hosts.

- There is a single argument of type ChangeVfdOnHostInput.
- Returns ChangeVfdOnHostReply.
### refresh
- There is a single argument of type RefreshHostInput.
- Returns RefreshHostReply.
