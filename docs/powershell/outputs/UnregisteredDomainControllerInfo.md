### UnregisteredDomainControllerInfo
Information about an auto-discovered domain controller that is not registered with Rubrik.

- hostname: System.String
  - Hostname of the unregistered domain controller.
- domainControllerGuid: System.String
  - Active Directory GUID of the domain controller. Used as the unique key for deduplication.
- domainControllerSite: System.String
  - Active Directory site name where the domain controller is located.
- fsmoRoles: list of FsmoRoless
  - FSMO (Flexible Single Master Operation) roles held by this domain controller.
- isGlobalCatalog: System.Boolean
  - Whether this domain controller is a Global Catalog server.
- isReadOnly: System.Boolean
  - Whether this is a Read-Only Domain Controller (RODC).
- lastDiscoveredTimestamp: DateTime
  - Timestamp when this domain controller was last seen during Active Directory topology enumeration.
