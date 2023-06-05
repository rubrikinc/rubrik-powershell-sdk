# rubrik-powershell-sdk

Thank you for using the Rubrik PowerShell SDK.

We rely on your feedback to improve the SDK !

## Installation

### Powershell >= 6.0

This Beta release needs PowerShell 6.0 or later.
Your default installation may be an older version,

see:
[microsoft.com: Installing PowerShell](https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell?view=powershell-7.3)

### Install from the PowerShell Gallery

This is the recommended way to install the SDK.

```powershell
Install-Module -Name RubrikSecurityCloud
```

More info: [RubrikSecurityCloud package on the gallery](https://www.powershellgallery.com/packages/RubrikSecurityCloud)

### Install from source

For advanced users, you can install the SDK from source.
It will allow you to see the SDK source code and
contribute to it.

Start by cloning the repo:

```shell
git clone git@github.com:rubrikinc/rubrik-powershell-sdk.git
cd rubrik-powershell-sdk
```

Then install the module from local sources:

```powershell
./Utils/import.ps1 -Local
```

### Import the SDK module

```powershell
Import-Module RubrikSecurityCloud
```

## Getting Started

Retrieve a service account file from the RSC UI,
and store it locally, say: `/path/to/service/account/file.json`.

Note that JSON files retrieved from the RSC UI are
**clear text** files that contain a **secret**.

First, generate an **encrypted** service account file
from the clear-text one and delete the clear-text one:

```powershell
Set-RscServiceAccountFile /path/to/service/account/file.json
```

`Set-RscServiceAccountFile` will generate an encrypted service account (SA)
file, store it in a default location, and prompt you to delete the
clear-text SA file. We recommend that you delete the clear-text SA file
after you have generated the encrypted one to avoid any security issues
(if you ever need a clear-text SA file again, they can easily be
retrieved from the RSC UI).

You only need to do the step with `Set-RscServiceAccountFile` once.
After that, you can connect to RSC with:

```powershell
Connect-Rsc
```

It will see that there is an encrypted SA file in the default location,
use it to retrieve an access token from the API server,
and store it in the session state.
Any subsequent calls to `Connect-Rsc` will use the same token.

As a matter of fact, it is OK to call `Connect-Rsc` willy-nilly;
for example, you can start every script you write with `Connect-Rsc` at the
top, and it will re-use any connection existing in the session, or
create a new one if needed. Note also that any existing connection in
the session is only visible within your session and is not visible
to other sessions, or to other users.

You can then run any of the commands in the SDK,
for example, to retrieve the current account info:

```powershell
Get-RscAccount
Get-RscAccount -Detail
(Get-RscAccount).AccountId
```

To list clusters:

```powershell
$c=Get-RscCluster
$c # show all clusters
$c.Count # show number of clusters
$c[0] # show first cluster
$c.id # list cluster ids
```

To run raw GraphQL queries:

```powershell
Invoke-Rsc -Query "query accountSettings{accountSettings{isEulaAccepted}}"

$vms=(Invoke-Rsc -Query 
  "query GetVsphereVmList{vSphereVmNewConnection{nodes{id name}}}").Nodes
```

To see all cmdlets in the SDK:

```powershell
(Get-Module RubrikSecurityCloud).ExportedCommands.Keys | Sort-Object
```

Then to disconnect:

```powershell
Disconnect-Rsc
```

It is good practice and recommended to finish your scripts
with `Disconnect-Rsc`. Note however that it is not strictly
necessary, as the connection will be closed automatically
when the session ends.

## Samples

_Samples_ are scripts that demonstrate how to use the SDK.
They are located in the `Samples` directory.

## Documentation

- [RSC PowerShell SDK Developer Manual](docs/developer_manual.md)
- [Schema reference](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference)
