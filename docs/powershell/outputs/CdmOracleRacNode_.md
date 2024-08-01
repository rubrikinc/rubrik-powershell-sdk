### CdmOracleRacNode
Representation of a single node in an Oracle RAC.

- nodeName: System.String
  - Host name of the RAC node.
- status: HostConnectivityStatusEnum
  - Connectivity status of the RAC node.
- hostFid: System.String
  - FID of the physical host object of the RAC node.
- host: PhysicalHost
  - Physical host object of the RAC node.
