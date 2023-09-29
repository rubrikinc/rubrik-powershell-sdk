# New-RscMutationAzureNative
## Subcommands
### excludemanageddisksfromsnapshot
Exclude the Managed Disks from snapshots, for the specified virtual machines.

- There is a single argument of type ExcludeAzureNativeManagedDisksFromSnapshotInput.
- Returns System.String.
### startcreatemanageddisksnapshotsjob
Start a job to create snapshots of the Azure Native Managed Disks identified by the given IDs. When started, this will start taking an on-demand snapshot of the selected disks as per the SLA Policy assigned to the respective disks.

- There is a single argument of type StartCreateAzureNativeManagedDiskSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startcreatevirtualmachinesnapshotsjob
Start a job to create a snapshot for the Azure Native virtual machine identified by the IDs. When started, this will start taking an on-demand snapshot of the selected VMs as per the SLA Policy assigned to the respective VMs.

- There is a single argument of type StartCreateAzureNativeVirtualMachineSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startdisablesubscriptionprotectionjob
Start a job to disable protection for a specified Azure subscription.

- There is a single argument of type StartDisableAzureNativeSubscriptionProtectionJobInput.
- Returns AsyncJobStatus.
### startexportmanageddiskjob
Start a job to export the specified Azure Native Managed Disks to the desired destination.

- There is a single argument of type StartExportAzureNativeManagedDiskJobInput.
- Returns AsyncJobStatus.
### startexportvirtualmachinejob
Start a job to export the Azure native virtual machine for a specified snapshot to a specified destination.

- There is a single argument of type StartExportAzureNativeVirtualMachineJobInput.
- Returns AsyncJobStatus.
### startrefreshsubscriptionsjob
Start a job to refresh Azure Native subscription for the given subscription IDs. When started, this job will update the Rubrik platform with any changes that have been done on Azure for the respective subscription.

- There is a single argument of type StartRefreshAzureNativeSubscriptionsJobInput.
- Returns BatchAsyncJobStatus.
### startrestorevirtualmachinejob
Start a job to restore Azure Native virtual machine with the selected snapshot. When started, this will replace the original VM with the selected snapshot.

- There is a single argument of type StartRestoreAzureNativeVirtualMachineJobInput.
- Returns AsyncJobStatus.
