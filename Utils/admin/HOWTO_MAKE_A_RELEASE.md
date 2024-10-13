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

We want to make sure the package version is newer than what is currently
released, and that it matches the latest entry in `CHANGELOG.md`.

```powershell
.\Utils\admin\Test-RscSdkCandidate.ps1
```

If the version is not set on the package, or if it is not the same as the
latest entry in `CHANGELOG.md`, you need push a new commit to the `devel`
branch with the updated version:

```powershell
.\Utils\admin\Set-RscSdkVersion.ps1 <maj>.<min>
```

Then run `Test-RscSdkCandidate.ps1` again to verify.

Verify also that the latest entry in `CHANGELOG.md` is correct.

```powershell
git commit -a -m "Bump version to <maj>.<min>"
git push
```

### 3. Create a new release

First do a dry run to see what will be released:

```powershell
.\Utils\admin\New-RscSdkRelease.ps1
```

If everything looks good, run the script again with the `-NotDryRun` switch:

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
a PowerShell session or an IDE that is using files that the script is
trying to clean up. Other OSes handle this better, but on Windows you
need to close your IDEs, your explorer windows, your PowerShell sessions,
and start a new one and start over...