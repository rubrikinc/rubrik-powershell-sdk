### ParentAppInfo
Supported in v5.0+

- id: System.String
  - Supported in v5.0+
ID assigned to the vApp object that manages a specified virtual machine.
- isProtectedThruHierarchy: System.Boolean
  - Required. Supported in v5.0+
Boolean value that indicates whether a virtual machine is protected through the SLA Domain assigned to the parent vApp. Set to 'true' when the virtual machine is protected through the parent vApp, otherwise set to 'false'. Direct assignment of a virtual machine to an SLA Domain is not possible when this value is 'true'. Also, setting this value to true is not possible when the virtual machine has an existing direct assignment to an SLA Domain.
