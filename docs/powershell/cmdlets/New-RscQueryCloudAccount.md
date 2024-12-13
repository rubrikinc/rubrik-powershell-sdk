# New-RscQueryCloudAccount
## Subcommands
### cloudaccount
- There is a single argument of type System.String.
- Returns CloudAccount.
### cloudaccounts
List all cloud accounts.

- There are 4 arguments.
    - sortBy - CloudAccountSortByFieldEnum: Specification on how to sort a list of cloud accounts.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of CloudAccountFilterInputs: Specification on how to filter a list of cloud accounts.
    - features - list of CloudAccountFeatures: Filters and shows cloud accounts for a specific use-cases or features. Default value: [ARCHIVAL].
- Returns list of CloudAccounts.
### currentfeaturepermissions
Current permissions are the set of permissions the client has given to Rubrik. This will retrieve permissions for all the features currently active in the account. If these permissions are older than the latest set of permissions we require, the account will go in Update Permissions state

- There are 2 arguments.
    - cloudVendor - CloudVendor: Vendor of the cloud account.
    - cloudAccountIds - list of System.Strings: List of Rubrik IDs of the cloud accounts.
- Returns list of CloudAccountFeaturePermissions.
### exocomputemappings
List the mappings from accounts to Exocompute cloud accounts with specified filters.

- There are 2 arguments.
    - cloudVendor - CloudVendor: Vendor of the cloud account.
    - exocomputeAccountIdsFilter - list of System.Strings: List of mapped Exocompute account IDs.
- Returns list of CloudAccountsExocomputeAccountMappings.
### iampairsbyandlocation
List the IAM pairs of the provided cloud account and any missing permission groups, if applicable, for an optional archival location.

- There is a single argument of type AllIamPairsByCloudAccountAndLocationInput.
- Returns list of AwsIamPairsWithMissingPermissions.
### latestfeaturepermissions
Latest Permissions are the most recent set of permissions we require for a feature. This will retrieve the permissions for all the features currently active in the accounts along with the features passed in the call.

- There are 4 arguments.
    - cloudVendor - CloudVendor: Vendor of the cloud account.
    - cloudAccountIds - list of System.Strings: List of Rubrik IDs of the cloud accounts.
    - features - list of CloudAccountFeatures: Cloud account features.
    - featuresWithPermissionsGroups - list of FeatureWithPermissionsGroupss: Cloud account features with specific permissions groups.
- Returns list of CloudAccountFeaturePermissions.
### withexocomputemappings
Retrieves the list of all accounts with their Exocompute account mapping, if exists.

- There are 3 arguments.
    - cloudVendor - CloudVendor: Vendor of the cloud account.
    - features - list of CloudAccountFeatures: Cloud account features. Rubrik offers a cloud account feature as part of Rubrik Security Cloud (RSC).
    - exocomputeAccountIdsFilter - list of System.Strings: List of mapped Exocompute account IDs.
- Returns list of CloudAccountWithExocomputeMappings.
