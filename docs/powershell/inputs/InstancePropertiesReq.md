### InstancePropertiesReq
Request for getting instance properties for a specific cloud vendor.

- vendor: VendorType
  - Cloud vendor type for which to retrieve instance properties.
- cdmVersion: System.String
  - The CDM version to restrict the results to, for example "9.5.3-36638".
When set, only the instance types that the version supports are
returned. When empty, every instance type that the vendor supports is
returned.
