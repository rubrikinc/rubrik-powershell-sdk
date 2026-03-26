---
name: release-to-psgallery
description: Walk through a manual release of the RSC PowerShell SDK
---

# RSC PowerShell SDK Release

Walk the user through a manual release of the RSC PowerShell SDK.
All scripts are under `Utils/` and `Utils/admin/`.

## Prerequisites Check
Before starting, verify:
- [ ] On `devel` branch
- [ ] `gh` CLI is authenticated (`gh auth status`)
- [ ] `$env:RSC_PSGalleryKeyFile` is set and points to a valid JSON file
- [ ] Working tree is clean (`git status`)

## Step-by-step

### 1. Verify current release state
```powershell
./Utils/admin/Test-RscSdkRelease.ps1
```
This checks that PSGallery version, GitHub latest release tag, and `main`
branch psd1+changelog all agree. If they don't, investigate before proceeding.

### 2. Build and test (pre-flight)
```powershell
./Utils/Build-RscSdk.ps1
```
This is a debug build to catch issues early. The actual release build
happens later inside `New-RscSdkRelease.ps1`. Fix any issues before continuing.

### 3. Curate CHANGELOG.md
Open `CHANGELOG.md` and review the top entry (which says `## Version TBD`).
Make sure all notable changes are listed with PR links.
Sections: New Features, Bug Fixes, Breaking Changes.

### 4. Bump version

**Version number convention**: `Major.Minor.YYYYMMDD`
- The `YYYYMMDD` date comes from the schema version, NOT today's date.
  Read it from the first line of `docs/graphql/schema-public.graphql`
  (e.g. `# v20260309-27` → use `20260309`, strip any `-*` suffix).
- Schema-only update (no new features/fixes): keep the current minor, bump the date
  (e.g. `1.14.20260105` → `1.14.20260309`)
- Changelog has new features, fixes, or breaking changes beyond a schema update:
  bump minor at least +1 (e.g. `1.14.20260105` → `1.15.20260309`)

Suggest the version to the user based on the changelog content, then run:
```powershell
./Utils/admin/Set-RscSdkVersion.ps1 -NewVersion "Major.Minor.YYYYMMDD"
```
For example: `./Utils/admin/Set-RscSdkVersion.ps1 -NewVersion "1.15.20260309"`

This updates `ModuleVersion` in the `.psd1` and the `## Version` heading in
`CHANGELOG.md`. Commit and push to devel:
```powershell
git add CHANGELOG.md RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/RubrikSecurityCloud.psd1
git commit -m "Bump version to Major.Minor.YYYYMMDD"
git push
```

### 5. Validate release candidate
```powershell
./Utils/admin/Test-RscSdkCandidate.ps1
```
Confirms: not on main, changelog version matches psd1, tag not already
published on GitHub.

### 6. Dry run
```powershell
./Utils/admin/New-RscSdkRelease.ps1
```
Without `-NotDry`, this runs the full release locally without pushing or
publishing. Review the output for any issues.

### 7. Execute release
```powershell
./Utils/admin/New-RscSdkRelease.ps1 -NotDry
```
This will:
1. Validate candidate again
2. Checkout `main` and `git reset --hard devel`
3. Build release configuration
4. Commit and force-push `main`
5. Create GitHub release via `gh release create`
6. Publish to PowerShell Gallery
7. Return to `devel`
8. Add new `## Version TBD` changelog entry and push

### 8. Post-release verification
```powershell
./Utils/admin/Test-RscSdkRelease.ps1
```
Confirm everything is coherent again.

## Troubleshooting

- **PSGallery publish fails**: check `$env:RSC_PSGalleryKeyFile` and API key validity
- **gh release create fails**: check `gh auth status` and repo permissions
- **Version mismatch**: run `./Utils/admin/Test-RscSdkRelease.ps1` to diagnose
- **Build fails on release config**: run `make clean` then retry
