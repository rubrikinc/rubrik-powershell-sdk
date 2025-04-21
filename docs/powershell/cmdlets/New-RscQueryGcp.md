# New-RscQueryGcp
## Subcommands
### cloudaccountmissingpermissionsforaddition
Check GCP projects permissions for addition.

- There are 2 arguments.
    - sessionId - System.String: Session ID of the current OAuth session.
    - projectIds - list of System.Strings: List of GCP project native IDs.
- Returns list of GcpCloudAccountMissingPermissionsForAdditions.
### cloudaccountprojectsbyfeature
List of GCP projects configured for a feature.

- There are 4 arguments.
    - feature - CloudAccountFeature: A cloud account feature of Rubrik Security Cloud.
    - projectStatusFilters - list of CloudAccountStatuss: List of project status filters to apply.
    - projectSearchText - System.String: Search text for project name, native ID and number.
    - aggregateFeatures - System.Boolean: Denotes if features are to be aggregated or flattened.
- Returns list of GcpCloudAccountProjectDetails.
### cloudaccountprojectsforoauth
List of GCP projects to add after successful authorization.

- There are 3 arguments.
    - sessionId - System.String: Session ID of the current OAuth session.
    - features - list of CloudAccountFeatures: Cloud account features.
    - checkPermissions - System.Boolean: Specfies whether to check permission of projects required for addition.
- Returns list of GcpCloudAccountProjectForOauths.
### featurepermissionsforcloudaccount
List of permissions required to enable the given feature.

- There is a single argument of type CloudAccountFeature.
- Returns list of GcpPermissions.
### getdefaultcredentialsserviceaccount
Returns the service account corresponding to global credentials. Return empty string if global credentials are absent

- The getdefaultcredentialsserviceaccount subcommand takes no arguments.
- Returns System.String.
### latestpermissionsbypermissionsgroup
Details of all the supported permission groups for the specified features.

- There is a single argument of type list of CloudAccountFeatures.
- Returns list of GcpFeatureWithPermissionGroupss.
### nativeavailablekmscryptokeys
List of GCP KMS Crypto keys accessible in the provided region.

- There are 2 arguments.
    - projectId - System.String: ID of the Project.
    - regionName - System.String: GCP region native name.
- Returns list of GcpNativeKmsCryptoKeys.
### nativecompatiblemachinetypes
List of compatible machine types for instance.

- There are 2 arguments.
    - targetZone - System.String: The zone of the to-be-created instance.
    - snapshotId - System.String: ID of snapshot.
- Returns list of System.Strings.
### nativenetworks
List of networks available in a GCP project along with subnetworks and firewall rules.

- There is a single argument of type System.String.
- Returns list of GcpNativeNetworks.
### nativeprojectswithaccessiblenetworks
List of all the GCP projects with accessible networks in this service project.

- There is a single argument of type System.String.
- Returns list of NetworkHostProjects.
### nativeregions
List of regions available to a GCP project along with zones.

- There is a single argument of type System.String.
- Returns list of GcpNativeRegions.
### nativestoredmachinetypes
List of all the distinct machine types of the GCP instances stored with Polaris.

- The nativestoredmachinetypes subcommand takes no arguments.
- Returns list of System.Strings.
### nativestoredmachinetypesinproject
List of all the distinct machine types of the GCP instances stored with Polaris.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### nativestorednetworknames
List of all the distinct network names of the GCP instances stored with Polaris.

- The nativestorednetworknames subcommand takes no arguments.
- Returns list of System.Strings.
### nativestorednetworknamesinproject
List of all the distinct network names of the GCP instances stored with Polaris.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### nativestoredregions
List of all the distinct regions of the GCP instances stored with Polaris.

- The nativestoredregions subcommand takes no arguments.
- Returns list of System.Strings.
### nativestoredregionsinproject
List of all the distinct regions of the GCP instances stored with Polaris.

- There is a single argument of type System.String.
- Returns list of System.Strings.
