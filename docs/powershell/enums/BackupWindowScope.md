### BackupWindowScope
Selects which backup window layer applies to a managed object. Used in
read replies to indicate which layer's window is being returned for the
object.

- BACKUP_WINDOW_SCOPE_OBJECT_LEVEL - The object-level backup window override configured directly on the
managed object.
- BACKUP_WINDOW_SCOPE_SLA_LEVEL - Governed at the SLA level; the group is the SLA's window, or unset
when the SLA defines none -- scope stays SLA_LEVEL either way.
