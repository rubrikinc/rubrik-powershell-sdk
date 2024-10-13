# How to make an SDK release

## 1. Prerequisites

- You need to be an admin on the github repo.
- Start in the `devel` branch on your local machine,
  make sure it is up to date with
  the `origin/devel` branch, and that there are no uncommitted changes.
- If you know what's on the dev branch right now is exactly
  what you want to release, you can skip to [step 3](#3-create-a-new-release).
- Step 2 is about curating the release: changing the version number,
  updating the changelog, etc.

## 2. Curate the release

### 2.1. Check what is currently released

```powershell
.\Utils\admin\Test-RscSdkRelease.ps1
```

This script checks the current release status of the SDK.
It shows if the current release is coherent: what is on the `main`
branch on GitHub is what's on the PowerShell gallery, etc.

### 2.2. Check the release candidate

The release candidate is the `devel` branch.

Run a local build and test:

```powershell
.\Utils\Build-RscSdk.ps1
```

### 2.3. Curate the changelog

The top entry in `CHANGELOG.md` should say `TBD` :

```markdown
# Changelog

## Version TBD

... changes ...
```

At this point leave the "TBD" as is, we will update it later. Make sure
the content of the last entry is correct. In particular, make sure PR
links are included and that the PRs are closed.

### 2.4. bump the version

```powershell
.\Utils\admin\Set-RscSdkVersion.ps1 <maj>.<min>
```

and push to the branch:

```powershell
git commit -a -m "Bump version to <maj>.<min>"
git push
```

### 2.5. Test the release candidate

We're not running SDK tests here, we are only testing if the package
is well formed.

```powershell
PS > .\Utils\admin\Test-RscSdkCandidate.ps1

version in RubrikSecurityCloud.psd1: 1.11
version in CHANGELOG.md:             1.11
Published on GitHub repo:            False

This branch is a candidate for a release.

semanticVersion isPublished versionTag   versionEntry
--------------- ----------- ----------   ------------
1.11                  False Version_1.11 Version 1.11…
```

## 3. Create a new release

### 3.1. From the local machine

We first do a dry run to see if any error occurs during build, tests, packaging,
updating the `main` branch (locally),
or publishing to the PowerShell gallery (with `-WhatIf`).

```powershell
PS> .\Utils\admin\New-RscSdkRelease.ps1
...
Dry run completed. Local changes were not pushed to the remote repository.
```

If no error occured, run the script again with the `-NotDry` switch:

```powershell
.\Utils\admin\New-RscSdkRelease.ps1 -NotDry
```

### 3.2. From the GitHub workflow

From https://github.com/rubrikinc/rubrik-powershell-sdk/actions/workflows/release.yml

- Click on `Run workflow`
- Select the branch `devel`
- Click on `Run workflow`

## 4. Troubleshoting

```powershell
Exception:
Line |
     | Remove-Item:
     | ..\Utils\Clean-RscSdk.ps1:15 Line
     | -Recurse -Force .\Output.Release -ErrorAction Stop
     | Access to the path
     | '..\Output.Release\...'
     | is denied.
```

Part of the release process is to clean up build and output directories,
if you're on Windows and you get this error, it's likely because you have
a PowerShell session or an IDE holding files that the script is
trying to clean up. Close everything and start a new `pwsh.exe` session.

If you keep running into this issue on Windows, you can try to run the
script in a sub-session:

```powershell
> pwsh.exe -NoProfile -Command "& { <SCRIPT>.ps1 }"
```
