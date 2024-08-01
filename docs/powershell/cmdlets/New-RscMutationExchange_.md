# New-RscMutationExchange
## Subcommands
### bulkupdatedag
Update multiple Exchange DAGs

Supported in v8.0+
Update multiple Exchange DAGs with the specified properties.

- There is a single argument of type BulkUpdateExchangeDagInput.
- Returns V1BulkUpdateExchangeDagResponse.
### createmount
Create a request to mount a Microsoft Exchange database snapshot

Supported in v8.0+
Create a request to mount a Microsoft Exchange database snapshot.

- There is a single argument of type CreateExchangeSnapshotMountInput.
- Returns AsyncRequestStatus.
### createondemandbackup
Take an on-demand backup of a Microsoft Exchange database

Supported in v8.0+
Takes an on-demand backup of a Microsoft Exchange database. The forceFullSnapshot property can be set to true to force a full snapshot. To check the result of the request, poll /exchange/request/{id}.

- There is a single argument of type CreateOnDemandExchangeDatabaseBackupInput.
- Returns AsyncRequestStatus.
### deletesnapshotmount
Request to delete a mount for the Microsoft Exchange database snapshot

Supported in v8.0+
Request to delete a mount for Microsoft Exchange database snapshot.

- There is a single argument of type DeleteExchangeSnapshotMountInput.
- Returns AsyncRequestStatus.
