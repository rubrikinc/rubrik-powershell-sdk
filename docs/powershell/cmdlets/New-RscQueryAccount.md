# New-RscQueryAccount
## Subcommands
### id
Account ID.

- The id subcommand takes no arguments.
- Returns System.String.
### owners
List of account owners.

- The owners subcommand takes no arguments.
- Returns list of Users.
### products
- There are 5 arguments.
    - nameFilter - list of ProductNames: Name of product (Data Protection, Ransomware Investigation, etc.).
    - typeFilter - list of ProductTypes: Type of product (Revenue, POC, etc.).
    - stateFilter - list of ProductStates: State of product (Active, Expired, etc.).
    - startDateArg - DateTime: Start date of product (yyyy-mm-dd).
    - endDateArg - DateTime: End date of product (yyyy-mm-dd).
- Returns list of AccountProducts.
### settings
This endpoint is deprecated.

- The settings subcommand takes no arguments.
- Returns AccountSetting.
### swithexocomputemappings
Retrieves the list of all accounts with their Exocompute account mapping, if exists.

- There are 3 arguments.
    - cloudVendor - CloudVendor: Vendor of the cloud account.
    - features - list of CloudAccountFeatures: Cloud account features. Rubrik offers a cloud account feature as part of Rubrik Security Cloud (RSC).
    - exocomputeAccountIdsFilter - list of System.Strings: List of mapped Exocompute account IDs.
- Returns list of CloudAccountWithExocomputeMappings.
