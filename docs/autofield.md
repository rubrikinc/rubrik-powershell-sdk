# AutoField: Automatic GraphQL Field Selection

## The Problem AutoField Solves

REST APIs return all fields by default. GraphQL requires you to specify
every field you want. This creates a usability gap: SDK users coming from
REST expect to get useful data without manually specifying dozens of fields.

AutoField bridges this gap. It automatically selects fields for your queries
using **profiles** — configurable notches between the two extremes:

| Approach      | Fields returned           | Effort required           |
|---------------|---------------------------|---------------------------|
| REST          | Everything                | None                      |
| **AutoField** | **Profile-based subset**  | **None (or minimal)**     |
| Raw GraphQL   | Exactly what you specify  | Full manual specification |

## Profiles

AutoField supports six profiles, set via `-FieldProfile`:

| Profile   | Behavior                                                          |
|-----------|-------------------------------------------------------------------|
| `DEFAULT` | Pattern-matched subset of common fields (the default)             |
| `DETAIL`  | DEFAULT + all fields at depth ≤ 1, with loop detection            |
| `FULL`    | DEFAULT + all fields at depth ≤ 40 (nearly everything)            |
| `EMPTY`   | No fields selected — use with `-AddField` to build from scratch   |
| `CUSTOM`  | Same rules as DEFAULT, but reads patches from a custom directory  |
| `UNSET`   | Internal sentinel — resolves to DEFAULT at runtime                |

**In practice, you'll mostly use `DEFAULT` and `DETAIL`.**

`DEFAULT` selects fields whose names match well-known patterns: `id`, `name`,
`status`, `state`, `count`, `description`, `type`, `version`, `email`,
`objectType`, plus container branches like `nodes`, `pageInfo`, `data`,
and `items`. This gives you a compact, useful result set.

`DETAIL` includes everything DEFAULT selects, plus all fields and sub-objects
at depth ≤ 1 from the root. It skips fields that would cause loops (e.g., a
`Cluster` with a `snappableConnection` that points back to clusters).

`FULL` goes deep (depth ≤ 40) — useful for exploration, but responses can
be very large.

`CUSTOM` uses the same field selection rules as DEFAULT, but reads
operation patch files from a **user-specified directory** instead of the
SDK's bundled `Toolkit/Operations/DEFAULT/`. This lets you maintain your
own set of patch files outside the SDK — useful for org-wide defaults or
per-project field customizations that shouldn't require forking the SDK.

To use CUSTOM:

1. Create a directory with your `.patch` files (same format as
   `Toolkit/Operations/DEFAULT/` — see
   [Operation Patch Files](#operation-patch-files)):
   ```
   ~/my-rsc-patches/
   └── QueryClusterConnection.patch
   ```

2. Point `RSC_CUSTOM_DIR` to it:
   ```powershell
   $env:RSC_CUSTOM_DIR = "$HOME/my-rsc-patches"
   ```

3. Use `-FieldProfile CUSTOM`:
   ```powershell
   $q = New-RscQuery -Gql clusterConnection -FieldProfile CUSTOM
   ```

If `RSC_CUSTOM_DIR` is not set or the directory doesn't exist, CUSTOM
falls back to reading patches from the current working directory.

## How to Use AutoField

### Basic: Just Create the Query

AutoField runs automatically with the `DEFAULT` profile:

```powershell
$q = New-RscQuery -Gql clusterConnection
$q | Invoke-Rsc   # returns clusters with id, name, status, type, etc.
```

### Choosing a Profile

```powershell
# More fields (depth ≤ 1 expansion)
$q = New-RscQuery -Gql clusterConnection -FieldProfile DETAIL

# Nearly all fields
$q = New-RscQuery -Gql clusterConnection -FieldProfile FULL

# No fields (blank slate)
$q = New-RscQuery -Gql clusterConnection -FieldProfile EMPTY
```

### Adding and Removing Fields

Use `-AddField` and `-RemoveField` to patch the profile's selection.
Fields are specified as dotted paths:

```powershell
# Add specific fields to the default selection
$q = New-RscQuery -Gql clusterConnection `
    -AddField Nodes.GeoLocation.Address, Nodes.EstimatedRunway

# Remove a field you don't need
$q = New-RscQuery -Gql clusterConnection `
    -RemoveField Nodes.Version

# Combine both
$q = New-RscQuery -Gql clusterConnection `
    -AddField Nodes.GeoLocation.Address `
    -RemoveField Nodes.Status
```

Patches always override profile rules — if you `-AddField` something the
profile would exclude, it gets included. If you `-RemoveField` something
the profile would include, it gets excluded.

### Discovering Valid Field Paths

Use `-ValidPatchSet` to see all valid field paths for a query:

```powershell
# List all patchable fields
New-RscQuery -Gql clusterConnection -ValidPatchSet

# Filter to find specific fields
New-RscQuery -Gql clusterConnection -ValidPatchSet |
    Where-Object { $_ -match "location" }
```

### Using a Field Object (`-Field`)

For full manual control, pass a typed object whose non-null properties
define the selected fields:

```powershell
$fieldObj = Get-RscType -Name ClusterConnection -InitialProperties @(
    "Nodes.Id", "Nodes.Name", "Nodes.Status"
)
$q = New-RscQuery -Gql clusterConnection -Field $fieldObj
```

You can combine `-Field` with `-AddField` / `-RemoveField` — the field
object is applied first, then patches modify it.

### Copying and Modifying (`-Copy`)

Clone an existing query and tweak it:

```powershell
$q1 = New-RscQuery -Gql clusterConnection
$q2 = New-RscQuery -Copy $q1 -AddField Nodes.GeoLocation.Address
```

The copy is by value — modifying `$q2` does not affect `$q1`.

### File-Based Patches (`-FilePatch`)

Apply patches from a file:

```powershell
$q = New-RscQuery -Gql clusterConnection `
    -FilePatch ./my-cluster-fields.patch
```

The file format is one field per line, prefixed with `+` or `-`:

```text
+ Nodes.GeoLocation.Address
+ Nodes.EstimatedRunway
- Nodes.Version
```

### Inspecting the Generated Query

After creating a query, inspect what fields AutoField selected:

```powershell
$q = New-RscQuery -Gql clusterConnection
$q.GqlRequest().Query    # show the full GraphQL query text
```

## Operation Patch Files

Operation patch files are permanent, per-operation field overrides that
ship with the SDK. They live in `Toolkit/Operations/` and are applied
automatically when a query is created.

### Directory Structure

```
Toolkit/Operations/
├── DEFAULT/                    # patches for DEFAULT profile
│   ├── QueryCdmMssqlLogShippingTargets.patch
│   └── QueryMssqlDatabaseLiveMounts.patch
├── DETAIL/                     # patches for DETAIL profile
│   ├── QueryClusterConnection.patch
│   └── QueryMssqlDatabaseLiveMounts.patch
└── README.md
```

### File Format

Each file is named `{OperationName}.patch`. The operation name is the
GraphQL operation name (e.g., `QueryClusterConnection`), which you can
find with:

```powershell
$q.GqlOperation().Name
```

Patch file syntax — one field path per line:

```text
+ Nodes.creationDate
+ Nodes.mountedDatabaseName
- Nodes.someUnwantedField
```

Lines starting with `+` add a field. Lines starting with `-` (or `!`)
remove a field. Blank lines and fields without a prefix are treated as
additions.

### When to Use Operation Patches

Use an operation patch file when:
- The DEFAULT or DETAIL profile consistently misses a field that users need
- A field causes issues (API bugs, excessive data) and should be excluded
  by default
- The fix should ship with the SDK (not require per-user configuration)

**Example**: The `DETAIL` profile for `QueryClusterConnection` removes
connection sub-objects that would make the response very large:

```text
-nodes.activitySeriesConnection
-nodes.clusterDiskConnection
-nodes.clusterNodeConnection
-nodes.snappableConnection
-nodes.cdmRbacMigrationStatus
-nodes.isTprEnabled
```

### Creating a New Patch File

1. Create the query and inspect its fields:
   ```powershell
   $q = New-RscQuery -Gql mssqlDatabaseLiveMounts
   $q.GqlRequest().Query
   ```

2. Test the patch manually with `-AddField`:
   ```powershell
   $q2 = New-RscQuery -Copy $q -AddField Nodes.creationDate
   $q2.GqlRequest().Query   # verify the field appears
   ```

3. Create the patch file at
   `Toolkit/Operations/DEFAULT/{OperationName}.patch`

4. Copy to `DETAIL/` if the same patch should apply there

5. Run `Update-RscToolkit` to deploy and test

## How AutoField Works Under the Covers

### Initialization

When `_makeFields()` runs (in `RscGqlPSCmdlet.cs`), it calls:

```csharp
Autofield.Init()
```

This resets all state:
- Sets `FieldCount = 0`
- Clears `IncludedFields`, `ExcludedFields`, `LoopyFields`
- Resets the `PatchSet`
- Pre-loads `Config.FieldsToSkip` as unwanted fields

### The Decision Algorithm

For each field encountered during query construction, AutoField calls
`_Includes(nodeName, isLeaf)`. The decision flows through these checks
in order:

```
1. Global cap → FieldCount > 1000? → EXCLUDE (unless FULL profile)
2. Explicit include patch? → INCLUDE
3. Explicit exclude patch? → EXCLUDE
4. Parent is patched in + field is a leaf? → INCLUDE
5. Field is a branch + any patch targets a descendant? → INCLUDE
6. Profile-based rules (see below)
```

Checks 2–5 mean **patches always override profile rules**.

### Profile-Based Rules

When no patch matches, the profile decides:

#### DEFAULT Profile

**Branches** (non-leaf nodes) are included if the field name matches
any pattern in `Config.DefaultProfileBranchPattern`:

| Pattern               | Matches            |
|-----------------------|--------------------|
| `^data$`              | `data`             |
| `^items$`             | `items`            |
| `^nodes$`             | `nodes`            |
| `^pageinfo$`          | `pageInfo`         |
| `^asyncrequeststatus$`| `asyncRequestStatus` |
| `^jobids$`            | `jobIds`           |
| `^output$`            | `output`           |

Plus hardcoded special cases: `physicalChildConnection` and
`effectiveSLADomain` (with loop detection).

**Leaves** (scalars and enums) are included if the field name matches
any pattern in `Config.DefaultProfileLeafPatternWithExceptions`:

| Pattern        | Matches                       | Exceptions           |
|----------------|-------------------------------|----------------------|
| `^count$`      | `count`                       | —                    |
| `^description$`| `description`                 | —                    |
| `^email$`      | `email`                       | —                    |
| `id$`          | `id`, `fid`, `cdmId`, etc.    | —                    |
| `^name$`       | `name`                        | —                    |
| `^type$`       | `type`                        | —                    |
| `^version$`    | `version`                     | —                    |
| `^has`         | `hasNextPage`, `hasMore`, etc.| —                    |
| `^is`          | `isReady`, `isActive`, etc.   | `isTprEnabled`       |
| `status`       | `status`, `syncStatus`, etc.  | `cdmRbacMigrationStatus`, `eosStatus` |
| `state`        | `state`, `connectionState`    | —                    |

(Plus: `endCursor`, `startCursor`, `jobId`, `message`, `success`, `total`,
`numWorkloadDescendants`, `objectType`, `slaAssignment`, `username`)

#### DETAIL Profile

Starts with everything DEFAULT includes, then adds:
- All leaf fields regardless of name pattern (at any depth)
- All branch fields at depth ≤ 1
- Skips `edges` (uses `nodes` instead)
- Hardcoded exclusion: `datagovAutoEnablePolicyConfig` (API server bug
  workaround, SPARK-230377)
- Loop detection: if a field name appears earlier in the path, it's
  excluded as a probable loop

#### FULL Profile

Same as DETAIL but with `maxDepth = 40` instead of 1.

### Loop Detection

Both DETAIL and FULL profiles check for loops by comparing the current
field name against all ancestor field names in the path. If
`nodes[last] == nodes[i]` for any `i < last`, the field is flagged as
loopy and excluded. This prevents infinite recursion in self-referential
types (e.g., a cluster's `snappableConnection` containing clusters).

Detected loops are recorded in `Autofield.LoopyFields` for debugging.

### Interface / Union Type Handling

GraphQL interfaces and union types (e.g., `CdmHierarchyObject`) are
handled at the C# type level. The generated code for each type implements
`IFieldSpec` and knows how to produce field selections for all
concrete implementations. AutoField's profile rules apply uniformly to
the flattened field tree, regardless of whether a field comes from an
interface or a concrete type.

## Patch Application Order

Patches and field sources are applied in this specific order within
`_makeFields()`:

```
1. Autofield.Init()
   └── loads Config.FieldsToSkip as unwanted fields

2. -Copy (if provided)
   └── seeds PatchSet from the copied query's field spec

3. -Field (if provided)
   └── seeds PatchSet from the field object's non-null properties

4. -FilePatch (if provided)
   └── reads patch entries from file(s)

5. -AddField / -RemoveField (if provided)
   └── applies cmdlet-level string patches

6. Operation patch file
   └── reads {OperationsDir}/{OpName}.patch (if it exists)

7. Profile rules evaluate
   └── for any field not already decided by patches 1–6
```

Later patches override earlier ones (last writer wins). For example, if
`-Copy` includes a field but `-RemoveField` excludes it, the field is
excluded. Note that the operation patch file (step 6) is applied **after**
`-AddField`/`-RemoveField`, so SDK-shipped patches take precedence over
cmdlet-level overrides. If you need to override an operation patch, use
`-Field` with a fully specified field object, or use `-FieldProfile EMPTY`
with `-AddField` to bypass profile-based patches entirely.

The operation patch file (step 6) is loaded from a directory that
depends on the profile:
- `DEFAULT` or `UNSET` → `Toolkit/Operations/DEFAULT/`
- `DETAIL` → `Toolkit/Operations/DETAIL/`
- `CUSTOM` → `$env:RSC_CUSTOM_DIR` (or current working directory if unset)

## Global Configuration

`Config.cs` defines SDK-wide AutoField settings:

| Setting                                  | Purpose                                         |
|------------------------------------------|--------------------------------------------------|
| `FieldsToSkip`                           | Fields excluded from all queries (e.g., pre-GA features) |
| `DefaultProfileLeafPatternWithExceptions`| Regex patterns for DEFAULT leaf inclusion         |
| `DefaultProfileBranchPattern`            | Patterns for DEFAULT branch inclusion             |

**When to add to Config vs. a patch file:**
- Add to `Config.FieldsToSkip` when a field should be excluded globally,
  across all operations (e.g., a broken or pre-GA field).
- Add to `DefaultProfileLeafPatternWithExceptions` when a field name
  pattern should be recognized by DEFAULT across all queries.
- Use an operation patch file when the override is specific to one
  operation.

## Key Source Files

| File | What it contains |
|------|-----------------|
| `RubrikSecurityCloud/RubrikSecurityCloud.Common/Autofield.cs` | Profile enum, `Init()`, `Includes()`, `DefaultIncludes()`, `DetailsIncludes()`, `FullIncludes()` |
| `RubrikSecurityCloud/RubrikSecurityCloud.Common/Config.cs` | `FieldsToSkip`, `DefaultProfileLeafPatternWithExceptions`, `DefaultProfileBranchPattern` |
| `RubrikSecurityCloud/RubrikSecurityCloud.Common/RscPatchSet.cs` | `WantedFields`/`UnwantedFields` hash sets, patch parsing from strings/files/objects |
| `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/Private/RscGqlPSCmdlet.cs` | `_makeFields()` — orchestrates the full patch application order |
| `Toolkit/Operations/DEFAULT/` | Patch files for the DEFAULT profile |
| `Toolkit/Operations/DETAIL/` | Patch files for the DETAIL profile |
