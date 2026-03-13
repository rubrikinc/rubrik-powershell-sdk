### ProvisionCloudDirectCloudVmReply
Response containing provisioning details for a NAS Cloud Direct virtual machine.

- cloudProvider: CloudDirectCloudProvider
  - Cloud provider for the virtual machine provisioning.
- cloudRegion: System.String
  - Cloud region for virtual machine provisioning.
- imageId: System.String
  - Cloud provider-specific image identifier for the virtual machine.
- userData: System.String
  - Enrollment data for the NAS Cloud Direct virtual machine encoded as JSON.
- regionImageIds: list of RegionImageIdEntrys
  - Maps cloud region to image ID.
Single entry returned when a specific region is requested.
All available regions returned when no specific region is requested.
