# Rubrik Security Cloud PowerShell Module and SDK

The Rubrik Security Cloud PowerShell module extends your PowerShell console to give you full access to the Rubrik Security Cloud API.

(For the community CDM SDK for PowerShell, please see:
[github.com/rubrikinc/rubrik-sdk-for-powershell](https://github.com/rubrikinc/rubrik-sdk-for-powershell))

## Support

Rubrik supports the commands and general functionality of this project. Rubrik cannot support custom script logic.

While this module may work with PowerShell 5.x, we recommend PowerShell >= 7.0. 
When troubleshooting, the first recommendation will be to upgrade from 5.x.

To give feedback on this project, open a new [discussion](https://github.com/rubrikinc/rubrik-powershell-sdk/discussions). 

## :hammer: Installation

Visit the [Rubrik Developer Center PowerShell documentation](https://developer.rubrik.com/SDKs-and-Tools/PowerShell/) 
for official installation instructions. 

## Advanced: Installing from Source

While we recommend using the [PowerShell Gallery]([url](https://www.powershellgallery.com/packages/RubrikSecurityCloud)) to install,
advanced users may install the module from source.

Start by cloning the repo:

```shell
git clone git@github.com:rubrikinc/rubrik-powershell-sdk.git
cd rubrik-powershell-sdk
```

Then install the module from local sources:

```powershell
./Utils/Import-RscModuleFromLocalOutputDir.ps1
```

At this point you can follow the [Connecting to RSC](https://developer.rubrik.com/SDKs-and-Tools/PowerShell/#connecting-to-rsc) 
instructions on the Developer Center.

### :hourglass: Module Version vs API version

Once connected, check that your version of the module is not too far off from the version of the API server.
Run:

```powershell
PS> Get-RscVersion

SdkSchemaVersion ServerVersion
---------------- -------------
v20230524-16     v20230524-16
```

If your module version is too old, you will see a warning.
You can still use the module, but you may not be able to use
the latest features, and you may see
some deprecation errors in your scripts. The module is generally backward compatible for a limited
time. If you see deprecation errors when running your scripts,
upgrade your module to the latest version as soon as possible.

### :running: Running commands

You can then run any of the commands in the module,
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

To see all cmdlets in the module:

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

## Learning More

:point_right: Start with the
[RSC PowerShell Module Developer Manual](docs/developer_manual.md).
Once you've covered the basics on this page, the developer manual
will teach you how to use the module to build your own scripts.

It refers to _samples_ that demonstrate how to use the module;
you can also peruse the [samples](Samples/) directly.

Another great way to learn about the module is to look at its
end-to-end (e2e) tests: [tests/e2e](Tests/e2e/)

GraphQL schema reference:

- [Online schema reference](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference)
- [Local schema reference](docs/graphql/rsc_schema.graphql.json)
