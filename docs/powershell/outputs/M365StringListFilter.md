### M365StringListFilter
String values to keep or drop. At least one of include or exclude must be non-empty.
When both are set, an item must match include and not match exclude.

- include: list of System.Strings
  - Items matching any value in this list are kept.
- exclude: list of System.Strings
  - Items matching any value in this list are dropped.
