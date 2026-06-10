### SetCoordinatorLabelsInput
Request to set coordinator labels on virtual machines in
a Cloud Direct cluster. This always receives the full
cluster mapping -- all virtual machines must be included.

- clusterUuid: System.String
  - Cloud Direct cluster UUID.
- entries: list of CoordinatorLabelEntryInputs
  - Label assignments for each virtual machine.
