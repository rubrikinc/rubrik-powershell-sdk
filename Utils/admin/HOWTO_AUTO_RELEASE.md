# Automated SDK Release

`Invoke-RscSdkAutoRelease.ps1` automates the full release pipeline without
requiring manual version entry. It follows the same steps as
`HOWTO_MAKE_A_RELEASE.md` but computes the version automatically from the
repository state.

## PR requirements

Every pull request that introduces a user-facing change **must** update
`CHANGELOG.md` before it can be merged. Schema-only PRs (automatic schema
updates from the Jenkins pipeline) are exempt.

### What to add

Under the `## Version TBD` block, add a line to the appropriate section:

```markdown
## Version TBD

New Features:
- Brief description of the new feature or cmdlet (#<PR number>)

Fixes:
- Brief description of what was fixed (#<PR number>)

Breaking Changes:
- Brief description of what changed and how to migrate (#<PR number>)
```

### Rules

- Each entry must include the PR number as `(#NNN)` at the end.
- Write for SDK users, not internal reviewers — describe the visible behavior change.
- A single PR may add entries to more than one section if applicable.
- If a section has no changes, leave it empty or write `None` — do not omit the heading.
- Schema-only PRs (no new features, fixes, or breaking changes) do not need a changelog entry.

### Why this matters

The automated release pipeline (`Invoke-RscSdkAutoRelease.ps1`) determines
whether to increment the minor version by checking whether the `## Version TBD`
block has any real entries. A PR that skips the changelog update will not
trigger a minor version bump, and its changes may be grouped into a future
release under a different version than expected.

## Prerequisites

Same as the manual release:

- On the `devel` branch with a clean working tree (`git status`).
- `gh` CLI is authenticated (`gh auth status`).
- `$env:RSC_PSGalleryKeyFile` is set and points to a valid JSON file
  containing `{ "apiKey": "..." }`.

## How the version is determined

`Get-NextReleaseVersionNumber.ps1` computes the next version as
`Major.Minor.Schema`:

| Component | Source |
|-----------|--------|
| **Major** | `### Major Version` field in `RubrikSecurityCloud/VERSION.md` |
| **Minor** | `### Minor Version` field in `VERSION.md`, then adjusted (see rules below) |
| **Schema** | Extracted from the `Description` field in `RubrikSecurityCloud.psd1` — updated automatically by the Jenkins schema pipeline |

### Minor version adjustment rules

| Condition | Result |
|-----------|--------|
| Major in `VERSION.md` is greater than the last released Major in `CHANGELOG.md` | Minor is reset to `0` |
| `## Version TBD` block in `CHANGELOG.md` has entries under **New Features**, **Fixes**, or **Breaking Changes** (excluding `None`) | Minor is incremented by `1` |
| Neither condition is true | Minor is unchanged |

> Only the Major version should be edited manually in `VERSION.md`.
> When the Major is bumped, reset Minor to `0` in `VERSION.md` as well.

## Usage

```powershell
# Preview — prints every action without making changes (default)
.\Utils\admin\Invoke-RscSdkAutoRelease.ps1

# Execute — runs the full release for real
.\Utils\admin\Invoke-RscSdkAutoRelease.ps1 -NotDry
```

## Pipeline steps

| Step | Script | Always runs | Description |
|------|--------|-------------|-------------|
| 0a | `Test-RscSdkRelease.ps1`        | Yes | Confirms PSGallery version, GitHub release tag, and `main` branch all agree. Aborts if inconsistent. |
| 0b | `Build-RscSdk.ps1`              | No (skipped in dry run) | Full build and test suite pre-flight. |
| 1  | `Get-NextReleaseVersionNumber.ps1` | Yes | Computes next version. Aborts if it matches the currently published version — nothing to release. |
| 2  | `Set-RscSdkVersion.ps1`         | No (skipped in dry run) | Writes the new version into `.psd1` and replaces `TBD` in `CHANGELOG.md`. |
| 3  | `git commit` + `git push`       | No (skipped in dry run) | Commits and pushes the version bump to the current branch. |
| 4  | `Test-RscSdkCandidate.ps1`      | Yes | Validates the branch is not `main`, changelog version matches `.psd1`, and the tag is not already published on GitHub. |
| 5  | `New-RscSdkRelease.ps1`         | Yes (dry or live) | Resets `main` to `devel`, builds release config, force-pushes `main`, creates GitHub release, publishes to PSGallery. |
| 6  | `Test-RscSdkRelease.ps1`        | No (skipped in dry run) | Post-release sanity check — confirms everything is coherent after publish. |

## Abort conditions

The script stops early (without making any changes) if:

- Current release state is inconsistent (step 0a).
- The computed next version equals the currently published version (step 1) —
  this means there is nothing new to release.
- Release candidate validation fails (step 4) — e.g. version mismatch or tag
  already exists.

## Troubleshooting

| Problem | Resolution |
|---------|------------|
| "next version is the same as current" | Add entries to `## Version TBD` in `CHANGELOG.md` or bump the Major version in `VERSION.md`. |
| "Version mismatch" at step 4 | Run step 2 manually: `Set-RscSdkVersion.ps1 -NewVersion <version>`. |
| Build fails at step 0b | Fix the failing tests before releasing. |
| PSGallery publish fails | Check `$env:RSC_PSGalleryKeyFile` and API key validity. |
| `gh release create` fails | Check `gh auth status` and repo permissions. |
