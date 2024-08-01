### ExcludeAwsNativeEbsVolumesFromSnapshotInput
Input to mark volumes to be excluded for EC2 snapshot.

- awsNativeEc2InstanceId: System.String
  - Rubrik ID of EC2 instance.
- volumeIdExclusions: list of VolumeIdExclusions
  - List of maps of Rubrik IDs to excluded status of volumes.
