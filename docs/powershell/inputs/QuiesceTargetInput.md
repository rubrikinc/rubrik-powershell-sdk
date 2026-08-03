### QuiesceTargetInput
A single customer-selected quiesce target on a Pure Storage protection group. The targetType field selects which sibling fields apply. A VMware virtual machine target uses only vmId (scripts are stored on the VirtualMachine record itself); an RBA host target uses hostId plus the optional per-phase scripts. Validation rejects entries that mix the wrong sibling fields with a given type.

- postSnapScript: VmBackupScriptInput
  - For RBA_HOST targets, the optional script that runs after the snapshot completes (post-freeze thaw). POST_SNAP failures always degrade to CONTINUE regardless of failureHandling.
- preBackupScript: VmBackupScriptInput
  - For RBA_HOST targets, the optional script that runs before the snapshot freeze. PRE_BACKUP is the only phase whose failureHandling=ABORT can stop the backup job.
- vmId: System.String
  - For VMware virtual machine targets, the identifier of the selected VirtualMachine. Scripts are stored on the VirtualMachine record and looked up at snapshot time through the existing updateVm surface (see Privilege.ManageBackupScripts).
- hostId: System.String
  - For RBA_HOST targets, the identifier of the selected RBA-installed host. No host-level script storage exists today, so per-phase scripts are carried inline by the sibling fields below.
- targetType: QuiesceTargetTargetType
  - Required. The type of protected workload this quiesce target represents. Use vmId for a VMware virtual machine target, or hostId plus the optional per-phase scripts for an RBA host target.
- postBackupScript: VmBackupScriptInput
  - For RBA_HOST targets, the optional script that runs after the entire backup completes. POST_BACKUP failures always degrade to CONTINUE regardless of failureHandling.
