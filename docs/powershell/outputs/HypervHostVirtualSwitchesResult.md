### HypervHostVirtualSwitchesResult
Per-host virtual switches (or a per-host error under partial success).

- hostId: System.String
  - The host identifier this entry corresponds to (echoes an input host ID).
- virtualSwitches: list of HypervVirtualSwitchInfos
  - Virtual switches on this host. Empty when error is set.
- error: System.String
  - Human-readable error for this host; empty on success.
- hasMore: System.Boolean
  - Indicates whether additional virtual switches exist beyond those returned.
