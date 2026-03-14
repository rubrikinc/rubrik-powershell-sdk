# Skill: RSC PowerShell SDK Release

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

### 2. Build and test

> **Shortcut**: If the last commit on `devel` was the automatic schema
> update pipeline, it succeeded, and no PR was merged since then, you can
> skip this step and go straight to step 3.

```powershell
./Utils/Build-RscSdk.ps1
```
Ensure the build passes cleanly. Fix any issues before continuing.

### 3. Curate CHANGELOG.md
Open `CHANGELOG.md` and review the top entry (which says `## Version TBD`).
Make sure all notable changes are listed with PR links.
Sections: New Features, Bug Fixes, Breaking Changes.

### 4. Bump version
```powershell
./Utils/admin/Set-RscSdkVersion.ps1 -NewVersion "X.Y"
```
This updates `ModuleVersion` in the `.psd1` and the `## Version` heading in
`CHANGELOG.md`. Commit and push to devel:
```powershell
git add -A && git commit -m "Bump version to X.Y" && git push
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
