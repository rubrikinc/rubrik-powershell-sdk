# How to make an SDK release

## 1. Prerequisites

- You need to be an admin on the GitHub repo.
- On the `devel` branch with a clean working tree (`git status`).
- `gh` CLI is authenticated (`gh auth status`).
- `$env:RSC_PSGalleryKeyFile` is set and points to a valid JSON file
  containing `{ "apiKey": "..." }`.

## 2. Curate the release

> **Shortcut**: If the last commit on `devel` was the automatic schema
> update pipeline, it succeeded, and no PR was merged since then, you can
> skip the build/test in step 2.2 and go straight to step 2.3.

### 2.1. Check what is currently released

```powershell
.\Utils\admin\Test-RscSdkRelease.ps1
```

This checks the current release status: whether PSGallery version,
GitHub release tag, and `main` branch all agree. If they don't,
investigate before proceeding.

### 2.2. Build and test

Make sure the `devel` branch is up to date and clean of any uncommitted
changes. Run a local build and test:

```powershell
.\Utils\Build-RscSdk.ps1
```

### 2.3. Curate the changelog

The top entry in `CHANGELOG.md` should say `TBD`:

```markdown
# Changelog

## Version TBD

... changes ...
```

Leave the "TBD" as is — we will update it next. Make sure the content of
the last entry is correct. In particular, make sure PR links are included
and that the PRs are closed.

### 2.4. Bump the version

```powershell
.\Utils\admin\Set-RscSdkVersion.ps1 <maj>.<min>
```

Commit and push to the branch:

```powershell
git commit -a -m "Bump version to <maj>.<min>"
git push
```

### 2.5. Validate the release candidate

We're not running SDK tests here, we are only testing if the package
is well formed.

```powershell
.\Utils\admin\Test-RscSdkCandidate.ps1
```

Confirms: not on `main`, changelog version matches `.psd1`, tag not
already published on GitHub.

## 3. Create a new release

### 3.1. Dry run

```powershell
.\Utils\admin\New-RscSdkRelease.ps1
```

Without `-NotDry`, this runs the full release locally without pushing
or publishing. Review the output for any issues.

### 3.2. Execute release

```powershell
.\Utils\admin\New-RscSdkRelease.ps1 -NotDry
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

## 4. Post-release verification

```powershell
.\Utils\admin\Test-RscSdkRelease.ps1
```

Confirm everything is coherent again (PSGallery, GitHub tag, `main` branch).

## 5. Troubleshooting

- **PSGallery publish fails**: check `$env:RSC_PSGalleryKeyFile` and API key validity.
- **`gh release create` fails**: check `gh auth status` and repo permissions.
- **Version mismatch**: run `.\Utils\admin\Test-RscSdkRelease.ps1` to diagnose.
- **Build fails on release config**: run `make clean` then retry.
- **Windows file-lock error** (`Access to the path ... is denied`):
  A PowerShell session or IDE is holding files the script needs to clean.
  Close everything and start a new `pwsh.exe` session, or run in a sub-session:
  ```powershell
  pwsh.exe -NoProfile -Command "& { <SCRIPT>.ps1 }"
  ```
