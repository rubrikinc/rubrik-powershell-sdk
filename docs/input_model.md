# The SDK's input model

When calling an `Invoke-RscXxx` cmdlet,
you can specify the input data in 2 different ways:
With `-Input` or with `-Patch`.

## Working with `-Patch`

- FieldProfile defaults to DEFAULT

```shell
PS> (Invoke-RscQueryCluster -List -Var @{first=1}).Nodes[0]|Remove-NullProperties

PauseStatus         : NOT_PAUSED
Status              : CONNECTED
SubStatus           : DEFAULT
SystemStatus        : OK
Type                : ROBO
Id                  : 9b429c53-2afe-44b5-b4e4-e3a4308afb
IsHealthy           : False
Name                : West
SystemStatusMessage : 1 Node Down.
Version             : 8.0.2-p2-22661
```

You want to see more fields. If you need help with the field names,
you can work with the `-GetInput` parameter:

```shell
PS> (Invoke-RscQueryCluster -List -GetInput).FieldInfo()
https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/clusterconnection.doc.html
```

Say we want to see the snapshot count:

```shell
PS /Users/guirava/sdk> (Invoke-RscQueryCluster -List -Var @{first=1} -Patch nodes.snapshotCount).Nodes[0]|Remove-NullProperties

PauseStatus         : NOT_PAUSED
Status              : DISCONNECTED
SubStatus           : DEFAULT
SystemStatus        : OK
Type                : ROBO
Id                  : 9b429c53-2afe-44b5-b4e4-e3a4308a69fb
IsHealthy           : False
Name                : WestWales
SnapshotCount       : 68
SystemStatusMessage : 1 Node Down.
Version             : 8.0.2-p2-22662
```

Say we want to see the CDM upgrade info:

```shell
PS /Users/guirava/sdk> (Invoke-RscQueryCluster -List -Var @{first=1} -Patch nodes.cdmUpgradeInfo).Nodes[0].CdmUpgradeInfo|Remove-NullProperties

ClusterJobStatus     : READY_FOR_DOWNLOAD
VersionStatus        : UPGRADE_RECOMMENDED
ClusterUuid          : 9b429c53-2afe-44b5-b4e4-e3a4308a69fb
CurrentStateProgress : 0
FastUpgradePreferred : True
FinishedStates       :
OverallProgress      : 0
PendingStates        :
StateMachineStatus   : IDLE
StateMachineStatusAt : 3/13/2023 2:31:44 PM
Version              : 8.0.2-p2-22662
```

## Working with `-Input`

- no field profile (no exploration, no file overrides.
  => FieldProfile is set to EMPTY)
