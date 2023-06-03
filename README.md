# rubrik-powershell-sdk

Thank you for using the Rubrik PowerShell SDK.

We rely on your feedback to improve the SDK !

## Installation

### Powershell >= 6.0

This Alpha release needs PowerShell 6.0 or later.
Your default installation may be an older version,

see:
[microsoft.com: Installing PowerShell](https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell?view=powershell-7.3)

### git clone

For this alpha release, you will need to install the SDK
from its GitHub repository. Start by cloning the repo:

```shell
git clone git@github.com:rubrikinc/rubrik-powershell-sdk.git
cd rubrik-powershell-sdk
```

### Import the SDK

Then in PowerShell,
set the `RSC_SERVICE_ACCOUNT_FILE` environment variable
to the path of the service account file you downloaded
from the Rubrik UI.

```powershell
[Environment]::SetEnvironmentVariable(
    "RSC_SERVICE_ACCOUNT_FILE", 
    "/path/to/service/account/file.json", "User"
)
```

and import the module.

```powershell
. ./Utils/import.ps1
```

Note the custom import code instead of the
standard `Import-Module` cmdlet. This is because the SDK
is not yet published to the PowerShell Gallery, so we need
to use a custom import script to load the module.

## Getting Started

```powershell
Connect-Rsc
```

It will retrieve an access token and store it in the session
state. Any subsequent calls to `Connect-Rsc` will use the
same token.

You can then run any of the commands in the SDK,
for example, to retrieve the current account info:

```powershell
Get-RscAccount
```

To list clusters:

```powershell
Get-RscCluster
```

To run raw GraphQL queries:

```powershell
Invoke-Rsc -OperationText '{"query": "query GetVsphereVmList{vSphereVmNewConnection{nodes{id name}}}" }'
```

Then to disconnect:

```powershell
Disconnect-Rsc
```

## Documentation

- [RSC PowerShell SDK Developer Manual](docs/developer_manual.md)
- [Schema reference](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference)
