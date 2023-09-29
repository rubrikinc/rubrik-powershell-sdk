# New-RscQueryAccount
## Subcommands
### enabledfeatures
Provides a list of all features enabled for the Rubrik account.

- The enabledfeatures subcommand takes no arguments.
- Returns AllEnabledFeaturesForAccountReply.
### id
Account ID.

- The id subcommand takes no arguments.
- Returns System.String.
### lookup
Retrieve account information.

- There is a single argument of type LookupAccountInput.
- Returns LookupAccountReply.
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
### users
All the users on the current account.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns list of Users.
