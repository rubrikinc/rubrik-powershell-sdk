### AzureLiveMountDetails
Azure Live Mount Details.

- targetVm: VirtualMachineDetails
  - Virtual machine on which disk is mounted.
- sourceVm: VirtualMachineDetails
  - Virtual machine from which disk is selected to be mounted.
- targetSubscription: SubscriptionDetails
  - Target Subscription.
- resourceGroup: ResourceGroupDetails
  - Resource group on which disk is selected to be mounted.
- diskDetails: list of AzureMountDiskDetailss
  - Details of disks which are mounted.
- region: AzureCommonRegion
  - Region where disk is mounted.
