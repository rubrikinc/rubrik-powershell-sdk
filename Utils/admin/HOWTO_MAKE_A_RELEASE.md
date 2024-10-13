# How to make an SDK release

## Prerequisites

- You need to be an admin on the github repo.
- Start in the `devel` branch, make sure it is up to date with
  the `origin/devel` branch, and that there are no uncommitted changes.

## Steps

### 1. Check what is currently released

```powershell
.\Utils\admin\Test-RscSdkRelease.ps1
```

This script checks the current
release status of the SDK. Run it to see what is currently released.
It will also make sure the release is coherent: what is on the `main`
branch is what's on GitHub and also what's on the PowerShell gallery.

### 2. Check the release candidate

The release candidate is the `devel` branch.

#### 2.1. Curate the changelog

The top entry in `CHANGELOG.md` should say `TBD` :

```markdown
# Changelog

## Version TBD

... changes ...
```

At this point leave the "TBD" as is, we will update it later. Make sure
the content of the last entry is correct. In particular, make sure PR
links are included and that the PRs are closed.

#### 2.2. bump the version

```powershell
.\Utils\admin\Set-RscSdkVersion.ps1 <maj>.<min>
```

and push it to the branch:

```powershell
git commit -a -m "Bump version to <maj>.<min>"
git push
```

#### 2.3. Test the release candidate

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

### 3. Create a new release

We first do a dry run to see if any error occurs during build, tests, packaging,
and commiting to the `main` branch.

```powershell
PS> .\Utils\admin\New-RscSdkRelease.ps1
...
Dry run completed. Local changes were not pushed to the remote repository.
```

If no error occured, run the script again with the `-NotDry` switch:

```powershell
.\Utils\admin\New-RscSdkRelease.ps1 -NotDry
```

## Troubleshoting

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
