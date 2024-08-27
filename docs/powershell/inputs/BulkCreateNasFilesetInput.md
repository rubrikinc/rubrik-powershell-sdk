### BulkCreateNasFilesetInput
Supported in v7.0+

- isHardlinkSupportEnabled: System.Boolean
  - Supported in v7.0+
- isPassthrough: System.Boolean
  - Supported in v7.0+
- snapMirrorLabelForFullBackup: System.String
  - 
- snapMirrorLabelForIncrementalBackup: System.String
  - 
- filesetTemplate: FilesetTemplateCreateInput
  - Required. Supported in v7.0+
      Fileset Template object.
- nasShareIds: list of System.Strings
  - Required. Supported in v7.0+
      An array of NAS share IDs the primary fileset is created for.
