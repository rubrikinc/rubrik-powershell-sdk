# Invoke-RscQueryAccount
## Subcommands
### Id
Account ID.

- The Id subcommand takes no arguments.
- Returns System.String.
### Owner
List of account owners.

- The Owner subcommand takes no arguments.
- Returns a list of Users.
### Product
- The Input parameter takes a hashtable with 5 name and value pairs.
    - endDateArg - DateTime: End date of product (yyyy-mm-dd).
    - nameFilter - a list of ProductNames: Name of product (Data Protection, Ransomware Investigation, etc.).
    - startDateArg - DateTime: Start date of product (yyyy-mm-dd).
    - stateFilter - a list of ProductStates: State of product (Active, Expired, etc.).
    - typeFilter - a list of ProductTypes: Type of product (Revenue, POC, etc.).
- Returns a list of AccountProducts.
### Setting
This endpoint is deprecated.

- The Setting subcommand takes no arguments.
- Returns AccountSetting.
