### MssqlRootProperties
Supported in v5.0+

- rootId: System.String
  - Supported in v5.0+
ID of the root of this object.
- rootName: System.String
  - Required. Supported in v5.0+
Name of the root of this object.
- rootType: MssqlRootPropertiesRootType
  - Required. Supported in v5.0+
Type of the root object for this object. The root object is the top-level object from which this object is derived. If this object is an availability database, the root object is **_MssqlAvailabilityGroup_**. Otherwise, if this object is part of a cluster, the root object is **_WindowsCluster_**. Otherwise, the root object is **_Host_**.
- rootRole: System.String
  - Supported in v5.3+
Role of the root object for this object if the root object is a Host and part of a **_MssqlAvailabilityGroup_**.
