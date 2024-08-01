# New-RscMutationGcp
## Subcommands
### cloudaccountaddmanualauthproject
Adds a new cloud account for the GCP project which is not already added.

- There is a single argument of type GcpCloudAccountAddManualAuthProjectInput.
- Returns System.Boolean.
### cloudaccountaddprojects
Add cloud account for GCP projects for the given features.

- There is a single argument of type GcpCloudAccountAddProjectsInput.
- Returns GcpCloudAccountAddProjectsReply.
### cloudaccountdeleteprojects
Delete cloud account for the given GCP project cloud account IDs and feature.

- There is a single argument of type GcpCloudAccountDeleteProjectsInput.
- Returns GcpCloudAccountDeleteProjectsReply.
### cloudaccountoauthcomplete
Complete the OAuth flow and pass the authorization code.

- There is a single argument of type GcpCloudAccountOauthCompleteInput.
- Returns GcpCloudAccountOauthCompleteReply.
### cloudaccountoauthinitiate
Initiate a session before doing Gcp OAuth flow.

- There is a single argument of type GcpCloudAccountOauthInitiateInput.
- Returns GcpCloudAccountOauthInitiateReply.
### cloudaccountupgradeprojects
Upgrade cloud account for the given GCP project cloud account IDs and feature.

- There is a single argument of type GcpCloudAccountUpgradeProjectsInput.
- Returns GcpCloudAccountUpgradeProjectsReply.
### createreadertarget
Creates reader type for GCP archival location on a CDM cluster.

- There is a single argument of type CreateGcpReaderTargetInput.
- Returns Target.
### createtarget
- There is a single argument of type CreateGcpTargetInput.
- Returns Target.
### setdefaultserviceaccountjwtconfig
Sets the default GCP service account authorization key.

- There is a single argument of type GcpSetDefaultServiceAccountJwtConfigInput.
- Returns System.Boolean.
### updatetarget
- There is a single argument of type UpdateGcpTargetInput.
- Returns Target.
### upgradecloudaccountpermissionswithoutoauth
Set GCP Cloud Account feature status to Connected from Update Permissions state without any permission validation. It should be used by caution from cloud accounts which have been set up without using OAuth, only after adding the latest permissions that are required.

- There is a single argument of type UpgradeGcpCloudAccountPermissionsWithoutOauthInput.
- Returns UpgradeGcpCloudAccountPermissionsWithoutOauthReply.
