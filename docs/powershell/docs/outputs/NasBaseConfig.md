### NasBaseConfig
Supported in v5.0+

- apiCertificate: System.String
  - Supported in v5.0+
  TLS certification to validate NAS server.
- apiEndpoint: System.String
  - Supported in v5.0+
  API endpoint to access NAS API 'FLASHBLADE'.
- apiHostname: System.String
  - Supported in v5.0+
  Hostname or IP used in the NAS API calls.
- apiUsername: System.String
  - Supported in v5.0+
  v5.0-v5.3: username to access NAS API
  v6.0+: Username to access NAS API.
- vendorType: System.String
  - Required. Supported in v5.0+
  v5.0-v5.3: Type of NAS vendor 'ISILON/NETAPP/FLASHBLADE'
  v6.0+: Specifies the NAS vendor, which can be ISILON, NETAPP, FLASHBLADE, or NUTANIX.
- zoneName: System.String
  - Supported in v5.0+
  Name of the Isilon zone that data IP belongs to.
- isSnapdiffEnabled: System.Boolean
  - Supported in v5.1
  If snapdiff is enabled on NetApp NAS host
- isIsilonChangelistEnabled: System.Boolean
  - Supported in v5.2+
  v5.2: A Boolean value that specifies whether Changelist is enabled on Isilon NAS share. When this value is 'true', metadata fetches during backup operations use the Isilon Changelist feature. The Changelist feature improves incremental backup performance by tracking the difference between two snapshots, reducing the metadata scanning time during a backup job.
  v5.3+: Indicates if Changelist is enabled on Isilon NAS share. When this value is 'true', metadata fetches during backup operations use the Isilon Changelist feature. The Changelist feature improves incremental backup performance by tracking the difference between two snapshots, reducing the metadata scanning time during a backup job.
- isNetAppSnapDiffEnabled: System.Boolean
  - Supported in v5.2+
  v5.2: A Boolean value that specifies whether SnapDiff is enabled on NetApp NAS share. When this value is 'true', metadata fetches during backup operations use the NetApp SnapDiff feature. The SnapDiff feature improves incremental backup performance by tracking the difference between two snapshots, reducing the metadata scanning time during a backup job.
  v5.3+: Indicates if SnapDiff is enabled on NetApp NAS share. When this value is 'true', metadata fetches during backup operations use the NetApp SnapDiff feature. The SnapDiff feature improves incremental backup performance by tracking the difference between two snapshots, reducing the metadata scanning time during a backup job.
- isShareAutoDiscoveryEnabled: System.Boolean
  - Supported in v5.3+
  Specifies whether shares on the NAS host are automatically discovered. When this value is 'true', Rubrik periodically (every 30 minutes by default) connects to the NAS host to discover NFS and SMB shares.
- isNutanixCftEnabled: System.Boolean
  - Supported in v6.0+
  Indicates whether CFT (Change File Tracking) is enabled on the Nutanix NAS share. When this value is 'true', metadata fetches during backup operations use the Nutanix CFT feature. The CFT feature improves incremental backup performance by tracking the difference between two snapshots, reducing the metadata scanning time  during a backup job.
