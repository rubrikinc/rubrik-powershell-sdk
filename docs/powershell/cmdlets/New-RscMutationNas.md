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
### hiderevealnasshares
Hide or reveal NAS shares

Supported in v7.0+
Hide individually selected NAS shares by setting the "action" field to "Hide". Reveal selected NAS shares by setting the "action" field to "Reveal".

- There is a single argument of type HideRevealNasSharesInput.
- Returns ResponseSuccess.
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
### updatenasshares
Bulk update multiple NAS shares

Supported in v7.0+
Updates fields like changelist of multiple NAS shares.

- There is a single argument of type UpdateNasSharesInput.
- Returns System.String.
### updatenassystem
Modify the information for a registered NAS system

Supported in v7.0+
Change the hostname that is associated with a NAS system. Update the credentials used to access the vendor-specific APIs.

- There is a single argument of type UpdateNasSystemInput.
- Returns UpdateNasSystemReply.
