# New-RscMutationActiveDirectory
## Subcommands
### createlivemount
Initiate a Live Mount of an Active Directory Domain Controller snapshot

Supported in v9.0+
Initiates a job to perform a Live Mount of an Active Directory Domain Controller snapshot. Returns the job instance ID.

- There is a single argument of type CreateActiveDirectoryLiveMountInput.
- Returns AsyncRequestStatus.
### createunmount
Remove a Live Mount of an Active Directory Domain Controller snapshot

Supported in v9.0+
Initiates a job to remove a Live Mount of an Active Directory Domain Controller snapshot. Returns the job instance ID.

- There is a single argument of type CreateActiveDirectoryUnmountInput.
- Returns AsyncRequestStatus.
### modifylivemount
Modifies a Live Mount of an Active Directory domain controller snapshot

Supported in v9.0+
Modifies the parameters of a Live Mount of an Active Directory domain controller snapshot.

- There is a single argument of type ModifyActiveDirectoryLiveMountInput.
- Returns System.String.
### restoreobjects
Restore the given objects to the Active Directory

Supported in v9.0+
Initiates a recovery for the given Active Directory objects.

- There is a single argument of type RestoreActiveDirectoryObjectsInput.
- Returns AsyncRequestStatus.
