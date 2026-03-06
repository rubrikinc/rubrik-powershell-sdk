# RSC PowerShell SDK — Project Context

## What This Repo Is
The **Rubrik Security Cloud (RSC) PowerShell SDK**. It provides PowerShell
cmdlets for the RSC GraphQL API. Published to the
[PowerShell Gallery](https://www.powershellgallery.com/packages/RubrikSecurityCloud).

## Branches
| Branch   | Purpose                                                    |
|----------|------------------------------------------------------------|
| `main`   | Release branch — force-pushed from `devel` at release time |
| `devel`  | Development branch — all work happens here                 |

Generated C# type updates are periodically pushed to `devel` via an
internal Rubrik pipeline. Do not manually edit files under
`RubrikSecurityCloud/RubrikSecurityCloud.Schema/generated/`.

## Architecture Overview

### Module Loading (order matters)

1. `RubrikSecurityCloud.psd1` — manifest, declares `RootModule` and `NestedModules`
2. `LoadModule.psm1` (`RootModule`) — loads the compiled C# DLL
   - PS Desktop (5.1): loads from `net481/`, registers `AssemblyResolve` handlers
     for dependency version conflicts (Unsafe, Vectors, Buffers, Text.Json)
   - PS Core (7+): loads from `net6.0/`
   - **Fragile**: this file was carefully tuned across PS versions and OSes.
     Do not modify without testing on both PS 5.1 (Windows) and PS 7+ (all OSes).
3. `PublicFunctions.psm1` (`NestedModules`) — imports script-based functions:
   - `Public/*.ps*1` (core scripts)
   - `Toolkit/Public/*.ps*1` (toolkit scripts)
   - Exports function basenames via `Export-ModuleMember`
4. `FormatsToProcess` in `.psd1` — loads `Toolkit/Format/*.ps1xml` for display formatting

### UpdatePsd1.ps1
Run at build time (MSBuild target `GeneratePSD1File`). Scans `Toolkit/Format/`
for `.ps1xml` files and updates the `FormatsToProcess` array in the `.psd1`
using regex replacement. Do not hand-edit `FormatsToProcess` — it gets overwritten.

### Fragility Warnings
- **`LoadModule.psm1`**: Carefully tuned across PS 5.1 (Windows) and PS 7+
  (all OSes). On Desktop edition, registers a *session-wide* `AssemblyResolve`
  handler to redirect 5 system assemblies to bundled versions — can conflict
  with other modules. Do not modify without testing on both PS editions.
- **Hardcoded TFM paths** (`net6.0`, `net481`) in `LoadModule.psm1` — must
  be updated if target frameworks change.
- **Build target ordering**: `GeneratePSD1File` and `CopySupportFiles` both
  run `AfterTargets="Build"` with no explicit ordering. Works in practice
  (MSBuild document order) but is not guaranteed.
- **Function name must match filename** — `PublicFunctions.psm1` exports by
  `$Public.Basename`. If a file defines a function with a different name, it
  won't be exported.
- **`Write-Output` in `PublicFunctions.psm1`** on every import — pollutes the
  pipeline. Avoid capturing `Import-Module` output.

### Key Directories

| Path                                               | Purpose                                               |
|----------------------------------------------------|-------------------------------------------------------|
| `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/` | Core module: C# cmdlets, LoadModule, PublicFunctions |
| `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/Cmdlets/`     | Hand-written C# cmdlets (10)          |
| `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/generated/`   | Auto-generated C# cmdlets (~122)      |
| `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/Public/`      | Core script functions (.psm1)         |
| `RubrikSecurityCloud/RubrikSecurityCloud.Schema/`                 | C# types (generated, do not edit)     |
| `Toolkit/`                                         | Script-based layer (see below)                        |
| `Utils/`                                           | Build, test, import scripts                           |
| `Utils/admin/`                                     | Release workflow scripts                              |
| `Output/`                                          | Debug build output (gitignored)                       |
| `Output.Release/`                                  | Release build output (gitignored)                     |

### Toolkit (`Toolkit/`)
High-level PowerShell wrappers over the core compiled cmdlets.
Toolkit scripts have full access to all C# types since the DLL loads first.

| Subdir          | Purpose                                                         |
|-----------------|-----------------------------------------------------------------|
| `Public/`       | Exported functions (e.g. `Get-RscCluster`, `Get-RscHelp`)      |
| `Private/`      | Internal helpers (e.g. `FileUtils.ps1`, `Show-RscAbout.ps1`)   |
| `Format/`       | `.ps1xml` display format definitions                            |
| `Operations/`   | GraphQL field profile patches (`DEFAULT/`, `DETAIL/`)           |
| `Templates/`    | Code-gen templates for new Toolkit cmdlets                      |
| `Tests/`        | Pester tests (unit + e2e)                                       |
| `Utils/`        | Dev utilities: `ToolkitDev.ps1`, `Run-PesterTests.ps1`         |

#### How Toolkit Scripts Call the Core
Toolkit scripts use three main compiled cmdlets as the bridge to the API:
- `New-RscQuery*` / `New-RscMutation*` — create GraphQL query/mutation objects
- `Invoke-Rsc` — sends query to RSC and returns typed results
- Direct .NET type access: `[RubrikSecurityCloud.Types.ClusterFilterInput]`,
  enum values, `SchemaMeta` reflection — all available since DLL loads first.

Key shared utility: `Remove-NullProperties` (Toolkit/Public/) — called by
most Toolkit scripts to strip null fields from API responses.

#### Operations Patches (`Toolkit/Operations/`)
Patch files that tweak auto-generated GraphQL field selections.
`DEFAULT/` for minimal fields, `DETAIL/` for expanded fields.
Syntax: `+field.path` to add, `-field.path` to remove.
Filename must match the GraphQL operation name.

#### Toolkit Dev Workflow
```powershell
. ./Toolkit/Utils/ToolkitDev.ps1        # load dev utilities
Update-RscToolkit                        # copy to Output/ + reimport + test
Get-RscToolkitStatus                     # compare source vs Output
```

### Build (`Makefile` / `Utils/Build-RscSdk.ps1`)
```bash
make build          # debug build (quick)
make test           # run all tests
make build-release  # release build (includes tests)
make clean          # remove all build artifacts
```

The `.csproj` has MSBuild targets that copy files to the output dir:
- `CopyPublicFiles`: `Public/*` → `$(TargetDir)/../Public/`
- `CopyToolkitPublicFiles`: `Toolkit/Public/*` → `$(TargetDir)/../Toolkit/Public/`
- `CopyToolkitPrivateFiles`: `Toolkit/Private/*` → `$(TargetDir)/../Toolkit/Private/`
- `CopyToolkitFormatFiles`: `Toolkit/Format/*` → `$(TargetDir)/../Toolkit/Format/`
- `GeneratePSD1File`: runs `UpdatePsd1.ps1`

### Testing
```powershell
./Utils/Test-RscSdk.ps1                  # full suite
./Utils/Test-RscSdk.ps1 -SkipCoreTests  # toolkit tests only
./Utils/Test-RscSdk.ps1 -SkipE2ETests   # unit tests only
```

## Release Workflow (Manual)

### Prerequisites
- `gh` CLI authenticated
- `$env:RSC_PSGalleryKeyFile` pointing to JSON: `{ "apiKey": "..." }`

### Steps
1. **Verify current release state**: `./Utils/admin/Test-RscSdkRelease.ps1`
   — confirms PSGallery version, GitHub release tag, and `main` branch all agree
2. **On `devel`**: curate `CHANGELOG.md` (top entry should list changes)
3. **Bump version**: `./Utils/admin/Set-RscSdkVersion.ps1 -NewVersion "X.Y"`
   — updates `.psd1` + `CHANGELOG.md` heading. Commit + push to `devel`.
4. **Validate candidate**: `./Utils/admin/Test-RscSdkCandidate.ps1`
5. **Dry run**: `./Utils/admin/New-RscSdkRelease.ps1` (no `-NotDry`)
6. **Execute release**: `./Utils/admin/New-RscSdkRelease.ps1 -NotDry`
   - Validates candidate
   - Resets `main` to match `devel` (`git reset --hard devel`)
   - Builds release configuration
   - Force-pushes `main`
   - Creates GitHub release via `gh release create`
   - Publishes to PSGallery via `Publish-Module`
   - Returns to `devel`, adds new `## Version TBD` changelog entry

### Admin Scripts (`Utils/admin/`)
| Script                          | Purpose                                              |
|---------------------------------|------------------------------------------------------|
| `Test-RscSdkRelease.ps1`       | Verify current published release is coherent         |
| `Set-RscSdkVersion.ps1`        | Bump version in `.psd1` + `CHANGELOG.md`             |
| `Test-RscSdkCandidate.ps1`     | Validate `devel` is ready for release                |
| `New-RscSdkRelease.ps1`        | Master release orchestrator (dry-run by default)     |
| `Update-RscSdkMainBranch.ps1`  | Reset `main` to source branch + build                |
| `Publish-RscSdk.ps1`           | Publish to PowerShell Gallery                        |
| `Get-RscSdkLatestChangelog.ps1` | Parse latest changelog entry                        |
| `Set-RscSdkLatestChangelog.ps1` | Update changelog version heading                    |
| `New-RscSdkChangelogEntry.ps1` | Add new TBD entry to changelog                       |

## Conventions
- Toolkit scripts use `.ps1` extension (not `.psm1`)
- Core scripts use `.psm1` extension
- All public functions follow `Verb-RscNoun` naming
- Toolkit Private scripts are dot-sourced on demand (not auto-loaded)
- Do not edit `FormatsToProcess` in `.psd1` — managed by `UpdatePsd1.ps1`
- Do not edit generated C# files under `RubrikSecurityCloud.Schema/generated/`
