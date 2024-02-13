# New-RscMutationNas
## Subcommands
### bulkdeletenassystems
Delete multiple NAS systems

Supported in v7.0+
Triggers a delete of the specified NAS systems. Returns an asynchronous request to check their delete status.

- There is a single argument of type BulkDeleteNasSystemsInput.
- Returns BatchAsyncRequestStatus.
### deletenassystem
Delete a registered NAS system

Supported in v7.0+
Delete a NAS system by specifying the NAS system ID.

- There is a single argument of type DeleteNasSystemInput.
- Returns AsyncRequestStatus.
### refreshnassystems
On-demand discovery of a list of NAS systems

Supported in v7.0+
Runs the NAS_DISCOVER job for autodiscovery/refresh of NAS systems.

- There is a single argument of type RefreshNasSystemsInput.
- Returns RefreshNasSystemsReply.
### registernassystem
Register a NAS System

Supported in v7.0+
Register a NAS system such as a NetApp or an Isilon cluster to be protected.

- There is a single argument of type RegisterNasSystemInput.
- Returns RegisterNasSystemReply.
### updatenassystem
Modify the information for a registered NAS system

Supported in v7.0+
Change the hostname that is associated with a NAS system. Update the credentials used to access the vendor-specific APIs.

- There is a single argument of type UpdateNasSystemInput.
- Returns UpdateNasSystemReply.
