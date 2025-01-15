### Exclude
A path or pattern defining the data excluded from Cloud Direct NAS Shares.

- path: System.String
  - Excludes paths relative to the root of the user issuing the excluding task. Does not distinguish between files and directories.
- pattern: System.String
  - Pattern excludes paths relative to the root using glob patterns. Directories are indicated with a trailing '/'.
