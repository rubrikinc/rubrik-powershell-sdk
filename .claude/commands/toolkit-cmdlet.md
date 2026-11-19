# Toolkit Cmdlet

Create a new Rubrik PowerShell SDK toolkit cmdlet from scratch, or audit an existing one against SDK conventions.

## Usage

```
/toolkit-cmdlet <Verb>-Rsc<Noun> [description of what it does]
```

Examples:
- `/toolkit-cmdlet Get-RscMssqlLinkedAvailabilityGroup` — audits an existing cmdlet
- `/toolkit-cmdlet New-RscNutanixSnapshot Takes an on-demand snapshot of a Nutanix VM` — creates a new one

If the cmdlet already exists, audit it against all conventions below and report gaps. If it does not exist, create it.

If no description is provided, infer it from the verb and noun.

---

## Step 1: Gather information

Before writing any code, research using only what's inside the SDK repo:

1. **Find the operation name** — The generated domain cmdlets enumerate all available operations. Read the relevant generated file for the domain (e.g., `./RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/generated/New-RscQueryMssql.cs` or `New-RscMutationMssql.cs`) and search for operations related to the noun. The `-Operation` parameter's `[ValidateSet]` in those files is the authoritative list of valid operation names to pass to `New-RscQuery -Gql` / `New-RscMutation -Gql`.

2. **Check for existing coverage** — Search `./Toolkit/Public/` for any cmdlet that already uses the target GQL operation:
   ```bash
   grep -rl "<operationName>" ./Toolkit/Public/
   ```
   If a match exists, report it to the user and ask whether they want to proceed with the new cmdlet or audit the existing one instead.

3. **Understand the return type and fields** — Read the C# type file at `./RubrikSecurityCloud/RubrikSecurityCloud.Schema/Elements/type/<TypeName>.cs`. Each field has a comment showing the GraphQL name and C# type. Extract all scalar and simple nested fields and **present the full list to the user as a menu**, grouped by category (scalars first, then nested objects). Ask which fields they want beyond the auto-initialized defaults. The user understands the domain — let them choose.

   Example presentation:
   ```
   Scalar fields (always cheap to include):
     Id, Name, Region, Zone, MachineType, ProjectId, IsRelic, CloudNativeId, NativeId, NativeName

   Nested object fields (include the sub-fields you need):
     EffectiveSlaDomain (SLA name/id), GcpNativeProject (project details), SnapshotDistribution, ...

   Which fields would you like included beyond the defaults?
   ```

   Once confirmed, map chosen field names to the C# property names shown in the comments. Scalar fields and concrete nested types can be added via `$query.Field.Nodes[0]`. Interface-typed fields (marked `(interface)` in comments) are handled by the auto-defaults — do not attempt to set them explicitly.

3. **Related existing cmdlets** — Find the closest analogous cmdlet in `./Toolkit/Public/` and read it in full as a style reference for field construction, filter patterns, and pipeline types.

4. **Existing nouns** — Confirm the noun follows established patterns (e.g., `RscMssqlLinkedAvailabilityGroup` matches the domain prefix `Mssql`). List `./Toolkit/Public/` to verify.

5. **Relevant RSC types for pipeline input** — Look at how similar cmdlets declare pipeline params (e.g., `[RubrikSecurityCloud.Types.Cluster]`, `[RubrikSecurityCloud.Types.GlobalSlaReply]`) and match the pattern for this domain.

Report all findings before proceeding.

---

## Step 2: Clarify with the user (if needed)

If any of these are ambiguous, ask before writing code:

- Which verb? Must be an approved PowerShell verb — run `Get-Verb` to see the full list. Common ones: `Get`, `New`, `Set`, `Remove`, `Start`, `Stop`, `Protect`, `Suspend`, `Resume`, `Register`
- Is this a list/single-object query, a mutation, or both?
- What parameter sets make sense? (e.g., `Id`, `Name`, `List`)
- What should pipe in? (Cluster, Sla, MssqlDatabase, etc.)

**Naming rule: nouns are always singular.** PowerShell convention is `Get-Item` not `Get-Items`, even when the cmdlet returns a list. Use `Get-RscGcpInstance`, not `Get-RscGcpInstances`.

---

## Step 3: Write the cmdlet

File location: `./Toolkit/Public/<Verb>-Rsc<Noun>.ps1`

### Conventions (MUST follow all of these):

**File and function naming**
- Filename must exactly match the function name: `<Verb>-Rsc<Noun>.ps1`
- Function name inside must exactly match the filename base
- Start with `#Requires -Version 3`

**Comment-based help** (immediately after `function Name {`)
- `.SYNOPSIS` — one line, present tense, no period
- `.DESCRIPTION` — multi-sentence; cover what it retrieves, default behavior, available filters, what `-Detail` adds if applicable
- `.LINK` — one entry per backing operation, pointing to the specific page on the developer center. PowerShell supports multiple `.LINK` blocks and all appear under "RELATED LINKS" in `Get-Help`:
  ```
  .LINK
  https://developer.rubrik.com/Rubrik-Security-Cloud-API/API-Reference/queries/mssqlDatabases/
  .LINK
  https://developer.rubrik.com/Rubrik-Security-Cloud-API/API-Reference/queries/mssqlDatabase/
  ```
  Use the pattern `queries/<operationName>/` for queries and `mutations/<operationName>/` for mutations.
- `.PARAMETER` — one block per parameter; include `.PARAMETER AsQuery` with this exact text:
  ```
  Return the query object instead of running the query.
  Preliminary read-only queries may still run to gather IDs or other data needed to build the main query.
  ```
- `.EXAMPLE` — at minimum 2 examples: one showing list/default usage, one showing a common filter

**CmdletBinding and parameters**
- Always `[CmdletBinding(DefaultParameterSetName = "List")]` for Get-* cmdlets
- Standard parameter sets for Get-* cmdlets:
  - `"Id"` — lookup by FID
  - `"List"` (default) — filterable list with Name, Sla, Cluster, Relic, Replica
- `-Name` must be `Position = 0` in the `"List"` parameter set so callers can omit the parameter name: `Get-RscMssqlDatabase "foo"` instead of `Get-RscMssqlDatabase -Name "foo"`
- Always include `-AsQuery [Switch]` (no ParameterSetName, so available in all sets)
- Never include a `-Detail [Switch]` parameter. Field selection is always explicit in code (see below) — there is no profile switching at runtime.
- Pipeline parameters use `ValueFromPipeline = $true` with the correct RSC type:
  - SLA: `[RubrikSecurityCloud.Types.GlobalSlaReply]$Sla`
  - Cluster: `[RubrikSecurityCloud.Types.Cluster]$Cluster`
  - Org: `[RubrikSecurityCloud.Types.Org]$Org`
  - Domain-specific objects: use the exact RSC type (e.g., `[RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase`)
- Use `[ValidateSet(...)]` for string parameters with a fixed set of values
- Use `[System.Nullable[bool]]` (not `[Boolean]`) for three-state parameters like `-Relic` and `-Replica`, and detect "not specified" with `$PSBoundParameters.ContainsKey('paramName')`. Never use `[Boolean]` for user-facing parameters — it forces callers to write `-Relic:$true` instead of `-Relic $true`.

**Prefer typed RSC objects over raw string IDs for parameters**
Parameters that represent RSC objects (workloads, SLA domains, clusters, instances, etc.) should be typed as the RSC .NET type, not as `[String]`. Extract the `.Id` property internally. This applies to both pipeline inputs and named parameters on mutations.

```powershell
# Correct
[RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase
$query.Var.input.Id = $RscMssqlDatabase.Id

# Wrong
[String]$DatabaseId
$query.Var.input.Id = $DatabaseId
```

Raw `[String]` IDs are only acceptable when no corresponding RSC type exists or the parameter is genuinely a free-form string (e.g., a target database name).

**Always use `New-RscQuery -Gql <queryName>` and `New-RscMutation -Gql <mutationName>`**
Never use domain-specific cmdlets like `New-RscQueryMssql` or `New-RscMutationVmware`. The `-Gql` parameter takes the exact camelCase operation name from the RSC schema, which keeps the backing query visible and discoverable.

**Never use `-FieldProfile` or `-AddField` for field selection**
`-FieldProfile` switches between pre-built patch files which obscures what fields are actually requested. `-AddField` has a known bug where it fails to generate placeholder values in certain circumstances.

When you need extra fields beyond the defaults, add them by modifying `$query.Field.Nodes[0]` properties in place — `New-RscQuery` pre-initializes the Nodes array with one element, so `[0]` is always safe:

```powershell
$query = New-RscQuery -Gql mssqlDatabases
$query.Var.filter = @()

# Add fields on top of the auto-initialized defaults
$query.Field.Nodes[0].Cluster = New-Object RubrikSecurityCloud.Types.Cluster
$query.Field.Nodes[0].Cluster.Id = "FETCH"
$query.Field.Nodes[0].Cluster.Name = "FETCH"
```

Use `"FETCH"` as the placeholder string value and `$true` for booleans. Derive C# type names from the comments in `./RubrikSecurityCloud/RubrikSecurityCloud.Schema/Elements/type/<TypeName>.cs`.

**Two known pitfalls with explicit field construction:**

1. **Never replace `$query.Field.Nodes` with a PowerShell array.** Doing `$query.Field.Nodes = @( $node )` assigns an `Object[]` to what the SDK expects as a `List<T>`. This silently breaks the field spec and the query returns empty results. Always modify `$query.Field.Nodes[0]` in place instead.

2. **Never assign a concrete type to an interface-typed field.** Fields declared as a GraphQL interface (e.g., `EffectiveSlaDomain: SlaDomain`) use `InterfaceHelper.CompositeAsFieldSpec` internally. Assigning `New-Object RubrikSecurityCloud.Types.GlobalSlaReply` to such a property can generate empty or invalid inline fragments, silently dropping that field from the query. Leave interface-typed fields alone — the auto-initialized defaults handle them correctly.

If you don't need fields beyond what the defaults provide, it is fine to skip `$query.Field` manipulation entirely and just invoke the query as-is. The auto-field spec from `New-RscQuery` includes all commonly useful fields.

**Query construction (Get-* cmdlets)**
```powershell
Process {
    # Single object by ID
    if ($PSCmdlet.ParameterSetName -eq "Id") {
        $query = New-RscQuery -Gql <singleQueryName>
        $query.Var.fid = $Id
        # Define fields explicitly
        $query.Field = New-Object RubrikSecurityCloud.Types.<ReturnType>
        $query.Field.Id = "FETCH"
        $query.Field.Name = "FETCH"
        # ... additional fields
        if ($AsQuery) { return $query }
        $query.Invoke()
        return
    }

    # List
    $query = New-RscQuery -Gql <connectionQueryName>
    $query.Var.filter = @()

    # Define fields explicitly
    $node = New-Object RubrikSecurityCloud.Types.<NodeType>
    $node.Id = "FETCH"
    $node.Name = "FETCH"
    # ... additional fields
    $query.Field.Nodes = @( $node )

    if ($Name) {
        $f = New-Object RubrikSecurityCloud.Types.Filter
        $f.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
        $f.Texts = $Name
        $query.Var.filter += $f
    }
    if ($Sla) {
        $f = New-Object RubrikSecurityCloud.Types.Filter
        $f.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::EFFECTIVE_SLA
        $f.Texts = $Sla.Id
        $query.Var.filter += $f
    }
    if ($Cluster) {
        $f = New-Object RubrikSecurityCloud.Types.Filter
        $f.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
        $f.Texts = $Cluster.Id
        $query.Var.filter += $f
    }
    if ($PSBoundParameters.ContainsKey('Relic')) {
        $f = New-Object RubrikSecurityCloud.Types.Filter
        $f.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_RELIC
        $f.Texts = $Relic
        $query.Var.filter += $f
    }
    if ($PSBoundParameters.ContainsKey('Replica')) {
        $f = New-Object RubrikSecurityCloud.Types.Filter
        $f.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_REPLICATED
        $f.Texts = $Replica
        $query.Var.filter += $f
    }

    if ($AsQuery) { return $query }
    ($query.Invoke()).Nodes
}
```

**Mutation construction (New-*, Set-*, Remove-*, etc.)**

For destructive operations (`Remove-*`, `Stop-*`, or anything that deletes or overwrites data), add `SupportsShouldProcess = $true` to `[CmdletBinding()]` and wrap the `Invoke()` call with `$PSCmdlet.ShouldProcess(...)`. This enables `-WhatIf` and `-Confirm` support automatically.

```powershell
[CmdletBinding(SupportsShouldProcess = $true)]

Process {
    $query = New-RscMutation -Gql <mutationName>
    $query.Var.input = New-Object RubrikSecurityCloud.Types.<InputType>
    $query.Var.input.SomeField = $SomeParam.Id

    if ($AsQuery) { return $query }

    if ($PSCmdlet.ShouldProcess($SomeParam.Name, "<verb> <noun>")) {
        $query.Invoke()
    }
}
```

Non-destructive mutations (snapshots, mounts, exports) do not require `ShouldProcess`.

**Always add `-AsQuery` guard immediately before `Invoke()`.**

---

### PowerShell best practices (from Microsoft strongly-encouraged guidelines)

These apply to every cmdlet. Reference: https://learn.microsoft.com/en-us/powershell/scripting/developer/cmdlet/strongly-encouraged-development-guidelines

**Singular parameter names** — even for parameters that accept arrays or lists, use the singular form (e.g., `-Name`, not `-Names`). This matches PowerShell built-in conventions.

**`[Switch]` vs `[Boolean]` vs `Nullable<bool>`**
- Use `[Switch]` for flags that are simply present or absent (e.g., `-AsQuery`, `-PassThru`). Do **not** use `[Boolean]` for these.
- Use `[System.Nullable[bool]]` when a parameter has three meaningful states: true, false, and "not specified" (e.g., `-Relic` — filter to relics, filter to non-relics, or don't filter at all). Check with `$PSBoundParameters.ContainsKey('Relic')` to detect "not specified".
- Never use `[Boolean]` for user-facing parameters; it forces callers to write `-Relic:$true` instead of `-Relic $true`.

**Wildcard support for `-Name`** — where the underlying API supports substring or pattern matching, accept wildcards in the `-Name` parameter and document it in `.PARAMETER Name`. If the API only supports exact match, say so explicitly.

**`PassThru` parameter for mutations** — cmdlets that modify state and return nothing by default should support `-PassThru` so callers can receive the result object in the pipeline. Add it as a `[Switch]` and conditionally return the result:

```powershell
[Parameter(Mandatory = $false)][Switch]$PassThru

# In Process:
$result = $query.Invoke()
if ($PassThru) { $result }
```

**`WriteVerbose` and `WriteWarning`**
- Call `Write-Verbose` for informational steps callers may want when running with `-Verbose` (e.g., "Filtering by SLA: Gold").
- Call `Write-Warning` before operations that may have unintended consequences (e.g., relic filtering that returns zero results).

**Consistent parameter types** — if a parameter name (e.g., `-Cluster`, `-Sla`) appears in multiple cmdlets, always use the same .NET type. Never use `[String]` for `-Sla` in one cmdlet and `[RubrikSecurityCloud.Types.GlobalSlaReply]` in another.

---

## Step 4: Write the format file

File location: `./Toolkit/Format/<TypeName>.Format.ps1xml`

Every Get-* cmdlet that returns a new object type needs a format file so the default table view shows sensible columns. Choose 4-6 fields that give the most useful at-a-glance information (typically: Id, Name, status/health field, cluster or location, SLA domain, and one domain-specific field).

Look at existing format files (e.g., `MssqlDatabase.Format.ps1xml`) for the exact XML structure. Key points:
- `<TypeName>` must match the full RSC .NET type name (e.g., `RubrikSecurityCloud.Types.MssqlDatabase`)
- Use `<TableControl>` with `<TableHeaders>` and `<TableRowEntries>`
- Column widths should be proportional — Id columns can be narrow, name columns wider
- Property expressions can use `<ScriptBlock>` for computed values (e.g., truncating a long ID, formatting a nested property like `$_.EffectiveSlaDomain.Name`)

```xml
<?xml version="1.0" encoding="utf-8"?>
<Configuration>
  <ViewDefinitions>
    <View>
      <Name>RubrikSecurityCloud.Types.<TypeName></Name>
      <ViewSelectedBy>
        <TypeName>RubrikSecurityCloud.Types.<TypeName></TypeName>
      </ViewSelectedBy>
      <TableControl>
        <TableHeaders>
          <TableColumnHeader><Label>Name</Label><Width>30</Width></TableColumnHeader>
          <TableColumnHeader><Label>Id</Label><Width>38</Width></TableColumnHeader>
          <TableColumnHeader><Label>Cluster</Label><Width>20</Width></TableColumnHeader>
          <TableColumnHeader><Label>SLA Domain</Label><Width>25</Width></TableColumnHeader>
        </TableHeaders>
        <TableRowEntries>
          <TableRowEntry>
            <TableColumnItems>
              <TableColumnItem><PropertyName>Name</PropertyName></TableColumnItem>
              <TableColumnItem><PropertyName>Id</PropertyName></TableColumnItem>
              <TableColumnItem><ScriptBlock>$_.Cluster.Name</ScriptBlock></TableColumnItem>
              <TableColumnItem><ScriptBlock>$_.EffectiveSlaDomain.Name</ScriptBlock></TableColumnItem>
            </TableColumnItems>
          </TableRowEntry>
        </TableRowEntries>
      </TableControl>
    </View>
  </ViewDefinitions>
</Configuration>
```

If the cmdlet returns an existing type that already has a format file, skip this step.

---

## Step 5: Write the e2e test

File location: `./Toolkit/Tests/e2e/<Verb>-Rsc<Noun>.Tests.ps1`

Use the full cmdlet name as the filename — for example, `Get-RscGcpInstance.Tests.ps1`, not `GcpNative.Tests.ps1`. One test file per cmdlet.

Test conventions:
- Dot-source `E2eTestInit.ps1`
- Use `$Global:data` hashtable to pass results between `It` blocks
- Gracefully skip (not fail) when data is absent: `Set-ItResult -Skipped -Because "..."`
- Use `Add-E2eDiagnosticEntry $diag` for pass/skip/fail logging
- Chain tests — e.g., list first, then test by-ID and by-Name using objects from the list result
- For mutations: test `-AsQuery` returns a query object (doesn't require live data)

Minimum test structure:
```powershell
BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
    $Global:diag = New-E2eDiagnostics -Api "<Noun>"
    $Global:data = @{ objects = $null }
}

Describe -Name '<Verb>-Rsc<Noun>' -Tag 'E2E' -Fixture {
    Context 'List' {
        It 'retrieves objects' {
            $data.objects = <Verb>-Rsc<Noun>
            if (@($data.objects).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List" "skip" "None found"
                Set-ItResult -Skipped -Because "No objects found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List" "pass" "Found $(@($data.objects).Count)"
            $data.objects | Should -Not -BeNullOrEmpty
        }
    }

    Context 'By Id' {
        It 'retrieves by Id' {
            if (-not $data.objects) { Set-ItResult -Skipped -Because "No objects from list"; return }
            $obj = <Verb>-Rsc<Noun> -Id $data.objects[0].Id
            $obj | Should -Not -BeNullOrEmpty
        }
    }

    Context 'AsQuery' {
        It 'returns query object with -AsQuery' {
            $q = <Verb>-Rsc<Noun> -AsQuery
            $q | Should -BeOfType [RubrikSecurityCloud.RscQuery]
        }
    }
}

AfterAll {
    Save-E2eDiagnostics $diag
}
```

---

## Step 6: Breaking changes

Before modifying an existing cmdlet, identify any breaking changes — changes that would break existing scripts that call the cmdlet today:

**Breaking:**
- Removing or renaming a parameter
- Changing a parameter's type (e.g., `[String]` → `[RubrikSecurityCloud.Types.MssqlDatabase]`)
- Removing a parameter set
- Changing `DefaultParameterSetName`
- Changing what the cmdlet returns (type, shape, or whether it returns `.Nodes` vs the raw object)

**Non-breaking:**
- Adding new optional parameters
- Adding new parameter sets
- Fixing filter logic bugs that didn't affect the return type
- Updating help text
- Adding format files

**When breaking changes are unavoidable**, note them clearly so the PR description can call them out explicitly. The PR description must include a `## Breaking Changes` section listing each removed/renamed/retyped parameter and what callers need to update.

When a parameter type change would be breaking (e.g., `[String]$Id` → typed object), consider adding the new typed parameter alongside the old one with a deprecation notice in `.PARAMETER` help rather than removing the old one immediately.

---

## Step 7: Verify

After writing both files:

1. Check `./Toolkit/Tests/unit/ToolkitIntegrity.Tests.ps1` — confirm the new filename matches the `^[a-zA-Z]+-Rsc[a-zA-Z0-9]+\.ps1$` pattern (it should automatically pass if naming is correct)
2. Confirm the function is exported — check `./RubrikSecurityCloud.psd1` or the module manifest for the `FunctionsToExport` list; add the new function name if it uses an explicit list
3. Confirm no use of `-FieldProfile`, `-AddField`, `-Detail`, or `Connect-Rsc` in the cmdlet body
4. For audits: confirm no existing use of `-Detail` parameter — flag it as a deviation to remove
5. Summarize: what files were created/modified, what GQL operation backs the cmdlet, what parameter sets and pipeline types are supported
6. Offer to handle the git and GitHub steps for the user — do not ask them to run commands themselves. Ask if they'd like you to commit, push, and open a PR before proceeding.

   When they say yes, follow this flow:

   **Check the remotes first** (`git remote -v`):
   - If `origin` points to `rubrikinc/rubrik-powershell-sdk` (they cloned upstream directly): run `gh repo fork --clone=false` to create a fork under their GitHub account, add it as a remote named `fork`, push the branch there, and open a PR targeting `rubrikinc/rubrik-powershell-sdk`'s `devel` branch.
   - If `origin` already points to their personal fork (URL contains their GitHub username, not `rubrikinc`): push directly to `origin` and open the PR targeting `rubrikinc/rubrik-powershell-sdk`'s `devel` branch using `gh pr create --repo rubrikinc/rubrik-powershell-sdk --base devel`.
   - If `origin` points to `rubrikinc` and they have push access (Rubrik team member): push directly to `origin` and open the PR with `gh pr create --base devel`.

   In all cases:
   - Create a feature branch named after the cmdlet (e.g., `Get-RscNutanixVirtualMachine`)
   - Stage only the files created in this session (cmdlet, format file, e2e test, CHANGELOG)
   - Write a clear PR description summarizing what the cmdlet does and how to test it

7. Tell the user to load the dev utilities and sync the files — and emphasize the leading dot-space:
   ```powershell
   # The leading ". " (dot space) is required — without it, functions are
   # loaded into a child scope and disappear immediately.
   . ./Toolkit/Utils/ToolkitDev.ps1

   Update-RscToolkit -SkipTest
   Test-RscToolkit -SkipE2ETests
   ```

8. If a new format file was created in Step 4, tell the user to load it for the current session. `Update-RscToolkit` copies the file to `Output/Toolkit/Format/`, but `FormatsToProcess` in the module manifest is only updated at build time (`make build`). To see the formatted table output immediately without a full rebuild, run:
   ```powershell
   Update-FormatData -PrependPath ./Output/Toolkit/Format/<TypeName>.Format.ps1xml
   ```
   After a `make build`, the format file is included in `FormatsToProcess` and loads automatically on module import — `Update-FormatData` is only needed for the current interactive dev session.
