### SearchNutanixVmInput
Input for InternalSearchNutanixVm.

- cursor: System.String
  - Pagination cursor returned by the previous request.
- id: System.String
  - Required. v5.0-v5.3: ID of the vm
v6.0-v8.0: ID of the vm.
v8.1+: ID of the virtual machine.
- limit: System.Int32
  - Maximum number of entries in the response.
- path: System.String
  - Required. The path query. Either path prefix or filename prefix.
