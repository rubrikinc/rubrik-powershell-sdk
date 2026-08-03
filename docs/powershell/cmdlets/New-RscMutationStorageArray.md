# New-RscMutationStorageArray
## Subcommands
### add
Add storage arrays to Rubrik clusters.

- There is a single argument of type AddStorageArraysInput.
- Returns AddStorageArraysReply.
### addv1
Add a storage array

Supported in v9.6+
Adds a storage array object and initiates an asynchronous job to obtain the metadata of the storage array for the object. Fields username and password are required for Array Integration features. Field apiToken is required for Volume Protection features.

- There is a single argument of type AddStorageArrayV1Input.
- Returns AsyncRequestStatus.
### delete
Delete storage arrays from Rubrik clusters.

- There is a single argument of type DeleteStorageArraysInput.
- Returns DeleteStorageArraysReply.
### refresh
Refresh storage arrays in Rubrik clusters.

- There is a single argument of type RefreshStorageArraysInput.
- Returns RefreshStorageArraysReply.
### update
Update storage arrays in Rubrik clusters.

- There is a single argument of type UpdateStorageArraysInput.
- Returns UpdateStorageArraysReply.
### updatev1
Update a storage array

Supported in v9.6+
Update the properties of a specified storage array object. At least one of isVolumeProtectionEnabled or isSnapshotOffloadingEnabled must be true. When isSnapshotOffloadingEnabled is true, username and password must either be provided in the request or already stored on the array. When isVolumeProtectionEnabled is true, apiToken must either be provided in the request or already stored on the array.

- There is a single argument of type UpdateStorageArrayV1Input.
- Returns UpdateStorageArrayV1Reply.
