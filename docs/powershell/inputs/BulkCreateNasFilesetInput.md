### BulkCreateNasFilesetInput
Supported in v7.0+

- filesetTemplate: FilesetTemplateCreateInput
  - Required. Supported in v7.0+
Fileset Template object.
- isHardlinkSupportEnabled: System.Boolean
  - Supported in v7.0+
- isPassthrough: System.Boolean
  - Supported in v7.0+
- nasShareIds: list of System.Strings
  - Required. Supported in v7.0+
An array of NAS share IDs the primary fileset is created for.
- snapMirrorLabelForFullBackup: System.String
  - Rubrik CDM uses prefix matching to select the latest SnapMirror snapshot that matches this value when taking a full backup of a SnapMirror destination share.
- snapMirrorLabelForIncrementalBackup: System.String
  - Rubrik CDM uses prefix matching to select the latest SnapMirror snapshot that matches this value when taking an incremental backup of a SnapMirror destination share.
