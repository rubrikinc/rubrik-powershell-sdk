### CoordinatorLabelEntryInput
Input variant of CoordinatorLabelEntry (used in requests).

- hardwareId: System.String
  - Virtual machine hardware ID.
- labels: list of CoordinatorLabels
  - Ordered list of labels to assign to this virtual machine.
An empty list means the virtual machine is unrestricted
(can run any task type).
- deviceState: System.String
  - Device state previously supplied by the caller.
