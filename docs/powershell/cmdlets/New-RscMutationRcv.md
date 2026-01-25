# New-RscMutationRcv
## Subcommands
### approveprivateendpoint
ApproveRCVPrivateEndpoint approves a pending request for RCV private
endpoints. After approving the private endpoint connection request, the
customer can start using the private tunnel to send data to and from the
CDM cluster to the Rubrik hosted storage account.

- There is a single argument of type ApproveRcvPrivateEndpointInput.
- Returns ApproveRcvPrivateEndpointReply.
### createlocationsfromtemplate
Creates Rubrik Cloud Vault Azure locations from the specified location template.

- There is a single argument of type CreateRcvLocationsFromTemplateInput.
- Returns list of Targets.
### createprivateendpointapprovalrequest
CreateRCVPrivateEndpointApprovalRequest creates an approval request for an
RCV private endpoint. Once the request is approved, the customer can start
using their RCV archival location through the private endpoint.

- There is a single argument of type CreateRcvPrivateEndpointApprovalRequestInput.
- Returns CreateRcvPrivateEndpointApprovalRequestReply.
### updatedestinationroleformigration
Updates the destination role ARN for S3 or S3-compatible to an RCV location
for migration using DataSync. This is needed when the data migrator runs in
the customers environment.

- There is a single argument of type UpdateDestinationRoleForRcvMigrationInput.
- Returns UpdateDestinationRoleForRcvMigrationReply.
### updateencryptionkeyformigration
Updates the encryption key of the source location that will be used for
migration to RCV.

- There is a single argument of type UpdateEncryptionKeyForRcvMigrationInput.
- Returns UpdateEncryptionKeyForRcvMigrationReply.
### updateprivateendpoint
UpdateRCVPrivateEndpoint updates the name and description of an existing
RCV private endpoint connection.

- There is a single argument of type UpdateRcvPrivateEndpointInput.
- Returns UpdateRcvPrivateEndpointReply.
### updatetarget
Updates the Rubrik Cloud Vault Azure archival location.

- There is a single argument of type UpdateRcvTargetInput.
- Returns Target.
