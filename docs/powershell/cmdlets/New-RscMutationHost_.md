# New-RscMutationHost
## Subcommands
### bulkcopyautomigratablenas
Register NAS systems corresponding to CDM NAS hosts

Supported in v8.1+
Create NAS systems and child objects for auto-migratable NAS Hosts.

- There is a single argument of type BulkCopyAutomigratableNasHostsInput.
- Returns BulkCopyAutomigratableNasHostsReply.
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
### bulkregisterasync
Register hosts

Supported in v5.3+
Register multiple hosts and perform discovery for databases and Microsoft SQL Server instances. When called, this API returns a success message, but completes the host registration in the background. Monitor the status of the background host discovery with the "status" field in GET API on /hosts. The POST API on /hosts can take longer for discovery, depending on the number of hosts on the system. POST on this API can be used instead to perform the discovery in the background and quickly register the host. Doing this requires that you install RBS for Linux and Windows hosts, similar to regular register using POST on /hosts.

- There is a single argument of type BulkRegisterHostAsyncInput.
- Returns BulkRegisterHostAsyncReply.
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
