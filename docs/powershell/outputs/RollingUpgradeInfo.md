### RollingUpgradeInfo
Overall RU status.

- ruCurrentNodes: list of System.Strings
  - The list of names of the nodes that are currently being upgraded.
- ruNodeInfoList: list of RollingUpgradeNodeInfoEntrys
  - The list of RuNodeInfoEntry objects, one per node.
- ruNodesPlan: System.String
  - The list of names of the nodes that are planned in the upgrade.
