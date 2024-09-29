# Rubrik Security Cloud SDK

Thank you for using the Rubrik Security Cloud PowerShell SDK.

We rely on
[your feedback](https://github.com/rubrikinc/rubrik-powershell-sdk/discussions)
to improve the SDK !

Rubrik fully supports this SDK. If you have problems with the SDK, please open a GitHub issue or contact your account team. Please note that Rubrik supports the SDK, but can't debug your scripts.

If you need to work with the CDM SDK, please see:
[github.com/rubrikinc/rubrik-sdk-for-powershell](https://github.com/rubrikinc/rubrik-sdk-for-powershell)

## :hammer: Installation

### Powershell >= 5.0

This release needs PowerShell 5.0 or later.

#### Operating Systems that Support PowerShell 5.0

1. Windows Server: PowerShell >=5.0 comes installed by default on
   Windows Server 2016 and later
2. Windows Client OS: PowerShell >=5.0 comes installed by default on
   Windows 10 and later
3. Linux and Mac: PowerShell >=5.0 is available for Linux and Mac OS X
   via the [PowerShell Core](https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-macos)

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
./Utils/Import-RscModuleFromLocalOutputDir.ps1
```

### Import the SDK module

```powershell
Import-Module RubrikSecurityCloud
```

## Getting Started

### :key: Service Account files

Retrieve a [service account file from the RSC UI](https://docs.rubrik.com/en-us/saas/saas/service_account.html),

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

> :warning: If no user profile is created and -OutputFilePath is not specified,
> follow these steps:
>
> 1. Check whether a profile exists by running `Test-Path $PROFILE` in
>    PowerShell. If this command returns `True`, then a profile exists.
>    If it returns `False`, proceed to the next step.
>
> 2. You can create a new profile using the `New-Item` command:
>    `New-Item -ItemType File -Path $PROFILE -Force`.
>    This creates a new file at the location specified by `$PROFILE`,
>    which is where PowerShell looks for your profile.

### :electric_plug: Connecting to RSC

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

### :hourglass: SDK version vs API version

Now that you're connected, it's good to make sure your version
of the SDK is not too far off from the version of the API server.
Run:

```powershell
PS> Get-RscVersion

SdkSchemaVersion ServerVersion
---------------- -------------
v20230524-16     v20230524-16
```

If your SDK version is too old, you will see a warning.
You can still use the SDK, but you may not be able to use
the latest features of the API server, and you may see
some deprecation errors in your scripts. It's important to note
that the SDK is backward compatible, but only for a limited
time. If when running your scripts, you see deprecation errors,
you should upgrade your SDK to the latest version as soon as
possible before the deprecated features are removed from the API server.

### :running: Running commands

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
Invoke-Rsc -GqlQuery "query accountSettings{accountSettings{isEulaAccepted}}"

$vms=(Invoke-Rsc -GqlQuery 
  "query GetVsphereVmList{vSphereVmNewConnection{nodes{id name}}}").Nodes
```

To see all cmdlets in the SDK:

```powershell
(Get-Module RubrikSecurityCloud).ExportedCommands.Keys | Sort-Object
```

### :electric_plug: Disconnecting

Then to disconnect:

```powershell
Disconnect-Rsc
```

It is good practice and recommended to finish your scripts
with `Disconnect-Rsc`. Note however that it is not strictly
necessary, as the connection will be closed automatically
when the session ends.

## Learning more about this SDK

:point_right: Start with the
[RSC PowerShell SDK Developer Manual](docs/developer_manual.md).
Once you've covered the basics on this page, the developer manual
will teach you how to use the SDK to build your own scripts.

It refers to _samples_ that demonstrate how to use the SDK;
you can also peruse the [samples](Samples/) directly.

Another great way to learn about the SDK is to look at its
end-to-end (e2e) tests: [tests/e2e](Tests/e2e/)

GraphQL schema reference:

- [Online schema reference](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference)
- [Local schema reference](docs/graphql/rsc_schema.graphql.json)
