### ProvisionCloudDirectCloudVmInput
Input for provisioning a NAS Cloud Direct virtual machine.

- clusterUuid: System.String
  - The UUID of the NAS Cloud Direct cluster to provision the virtual machine for.
- cloudProvider: CloudDirectCloudProvider
  - Cloud provider to provision the virtual machine in.
- cloudRegion: System.String
  - Cloud region to provision the virtual machine in.
- listRegions: System.Boolean
  - Indicates whether to include image IDs for all available regions.
Mutually exclusive with the cloud_region argument.
