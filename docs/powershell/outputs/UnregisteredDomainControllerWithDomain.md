### UnregisteredDomainControllerWithDomain
One auto-discovered AD domain controller without RBS, enriched with its
parent AD domain's name and SID.

- hostname: System.String
  - Hostname of the domain controller as discovered.
- domainControllerGuid: System.String
  - GUID of the domain controller (stable identity across clusters).
- domainControllerSite: System.String
  - AD site the domain controller belongs to. Optional.
- fsmoRoles: list of FsmoRoless
  - FSMO roles held by this domain controller
(e.g., PDC Emulator, RID Master, Schema Master, Infrastructure Master,
Domain Naming Master).
- isGlobalCatalog: System.Boolean
  - True if this domain controller is a Global Catalog server.
- isReadOnly: System.Boolean
  - True if this domain controller is a Read-Only Domain Controller (RODC).
- lastDiscoveredTimestamp: DateTime
  - Most recent discovery timestamp across all clusters observing this DC.
- domainName: System.String
  - Name of the parent AD domain (FQDN).
- domainSid: System.String
  - SID of the parent AD domain.
- invocationId: System.String
  - AD invocation-ID for this domain controller, when reported by the AD
server. Mirrors the registered-DC path's DcInfo.invocationId. Nullable:
unset for DCs discovered only via managed objects (older clusters) or
when the AD server does not report an invocation-ID.
