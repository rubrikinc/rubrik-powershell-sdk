### GcpVmConfigInput
Inputs needed to create VMs on GCP.

- cdmVersion: System.String
  - The CDM version to use for the cluster if it is created using a marketplace image. This field must not be used if the cluster is created using an image ID.
- vmType: VmType
  - Standard, dense or extra dense virtual machine.
- nodeSizeGb: System.Int32
  - The size of the node in GB. This field is only needed for creating disk-based cluster.
- imageId: System.String
  - The image ID to use for the cluster. This field must not be used if the cluster is created using a marketplace image (using the cdm_version field). If this field is used, the cdm_version field will be ignored.
- labels: System.String
  - Labels to apply to the GCP instance. List of tag key=value separated by commas.
- serviceAccounts: list of GcpServiceAccountInputs
  - Service accounts to apply to the GCP instance.
- instanceType: GcpInstanceType
  - Instance type to use for the GCP instance.
- deleteProtection: System.Boolean
  - If delete protection to apply to the GCP instance.
- networkConfig: list of GcpSubnetInputs
  - GCP subnet configs for each node.
- testImage: GcpTestImage
  - Test image to use for the Rubrik cluster. This field is only used for internal testing purposes.
