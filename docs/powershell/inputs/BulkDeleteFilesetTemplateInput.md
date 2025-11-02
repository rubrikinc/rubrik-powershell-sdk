### BulkDeleteFilesetTemplateInput
Input for deleting multiple fileset templates.

- ids: list of System.Strings
  - Required. Provide an array with the ID of each fileset template to remove.
- preserveSnapshots: System.Boolean
  - Flag to indicate whether to convert snapshots of filesets of the deleted templates to relics or to delete them. Applies to all templates being deleted. Default is true.
