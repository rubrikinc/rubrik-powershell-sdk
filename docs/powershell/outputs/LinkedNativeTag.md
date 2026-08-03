### LinkedNativeTag
One native tag from an external source system linked to an RSC tag.
Same shape is reused on the Hyper-V virtual machine type so the UI
can render native tags consistently across the system-tag detail
page and the virtual machine inventory list. The
assignedObjectsCount and rubrikCluster fields are populated only
when rendered on the system-tag detail page; consumers in virtual
machine list contexts can ignore them.

- id: System.String
  - Stable ID of the native tag in the source system.
- name: System.String
  - Display name of the native tag.
- source: NativeTagSource
  - Source system that owns the tag.
- assignedObjectsCount: System.Int32
  - Number of objects (e.g. VMs) currently assigned to this native tag
in the source system. Populated on the system-tag detail page;
unset elsewhere.
- rubrikCluster: RubrikClusterRef
  - Rubrik cluster the native tag belongs to. Populated on the
system-tag detail page; unset elsewhere.
