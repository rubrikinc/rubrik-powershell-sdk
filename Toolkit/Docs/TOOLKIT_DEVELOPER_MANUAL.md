# RSC SDK Toolkit Developer Manual

## 1 Introduction

From an end-user point of view, the RSC PowerShell SDK presents itself
as one package:

```powershell
Install-Module -Name RubrikSecurityCloud
```

Internally to the SDK, there are two components:

- The **Core** component; it is mostly C# code, and it implements core
  functionality such as the REST API client, the authentication,
  logging, API metrics, etc., and of course, a .NET object model for the
  Rubrik Security Cloud GraphQL API.
- The **Toolkit** component; it is script PowerShell code, and
  it provides the end-user with cmdlets that are easy to use, and
  that abstract the GraphQL model away.

This document is about the **Toolkit** component, and how to develop
new cmdlets for it.

### 1.1 Cmdlet Development

Toolkit cmdlets are written in PowerShell, and are located in the
`Toolkit/Public` directory.

All `*.ps*1` files in that directory are
part of the build, and will be included in the module.

Please see: [Public Functions](../Public/README.md)

### 1.2 Format file Development

All `.ps1xml` files in `Toolkit/Format` are part of the build, and will
be included in the module.

Please see: [Format Files](../Format/README.md)

### 1.3 Private Functions

`Toolkit/Private` is also part of the build, but is not exported as
part of the module. It is used for internal functions, and for
functions that are not ready for public consumption.

Please see: [Private Functions](../Private/README.md)

## 2 Developer Workflow

All work is done on the repo's `devel` branch.

There are
[2 branches on the repo](https://github.com/rubrikinc/rubrik-powershell-sdk/branches)
that are of interest to developers: `main` and `devel`

- `main` is the stable branch, and it is the branch that is used to
  build the module that is published to the PowerShell Gallery.
  Only SDK maintainers can push to `main`.
- `devel` is the development branch, and it is the branch that is used
  to push PRs to. All work is done on `devel`. Note also that we don't
  `git push` to `devel` but rather submit PRs to it.

### 2.1 Clone the devel branch

Bring the SDK down to your local machine. For example:

```powershell
PS ~/> git clone -b devel git@github.com:rubrikinc/rubrik-powershell-sdk.git
```

You can also use the HTTPS URL, or the GitHub CLI,
or any other method you prefer (you could also fork the repo),
just make sure you're on the `devel` branch.

### 2.2 Build the SDK

> Note: you will need to have the .NET Core SDK
> installed on your machine to build the Rubrik Security Cloud SDK.
> You can download it from [here](https://dotnet.microsoft.com/download).

Start by building the SDK in Debug Mode, in the `Output/` directory:

```powershell
PS ~/rubrik-powershell-sdk> .\Utils\Build-RscSdk.ps1
```

`Build-RscSdk.ps1` will build the SDK core and assemble it with Toolkit scripts
into the `Output/` directory. Build times are vastly different depending on
the OS: it takes a few minutes on Windows, but up to an hour (!)
on macOS or Linux (due to the .NET Core build system being drastically slower
on non-Windows platforms).

`Build-RscSdk.ps1` cleans up the local repo, builds the SDK, copies it
to the `Output/` directory, and then tests it. As this point you should not
see any build errors and all tests should pass.

Once built, you can import the module from `Output/` with a Utils script:

```powershell
PS ~/rubrik-powershell-sdk> ./Utils/Import-RscModuleFromLocalOutputDir.ps1
```

At this point you could start working on the Toolkit, and just
run `.\Utils\Build-RscSdk.ps1` to test your changes, but it will
be a slow dev workflow.
Instead, we recommend using the ToolkitDev.ps1 script.

### 2.3 ToolkitDev.ps1

To aid in the development of the toolkit, we have provided a
`ToolkitDev.ps1` script under `Toolkit/Utils`. Source it in your
PowerShell session to get a development environment set up:

```powershell
PS ~/rubrik-powershell-sdk> . ./Toolkit/Utils/ToolkitDev.ps1

Importing RubrikSecurityCloud module from ~/Output
RSC Toolkit loaded.
Imported 167 cmdlets and functions from RubrikSecurityCloud.


Toolkit status:
---------------

SDK root: ~/rubrik-powershell-sdk
Source directory: <SDK root>/Toolkit
Output directory: <SDK root>/Output/Toolkit

All toolkit files in Output are up to date.

Toolkit development utilities:
------------------------------

-> Run Update-RscToolkit to update the Output directory and re-import the module.
-> Run Get-RscToolkitStatus to compare the source files with the Output directory.
```

Note that the `ToolkitDev.ps1` script automatically imports the
module from the `Output/` directory, so you don't need to run
`Import-RscModuleFromLocalOutputDir.ps1` if you're sourcing `ToolkitDev.ps1`.

ToolkitDev.ps1 brings 3 utility functions into your session:

- `Update-RscToolkit`: Copies the toolkit files to the Output directory
  and re-imports the module.
- `Get-RscToolkitStatus`: Compares the source files with the Output directory.
- `Test-RscToolkit`: Runs the toolkit tests. Note that `Update-RscToolkit`
  runs `Test-RscToolkit` by default.

Typically, you just run `Update-RscToolkit` after making changes to the
Toolkit source files (anything under `Toolkit/`), and it will copy the
files to the `Output/` directory, and re-import the module, and
run the tests. If you want to skip the tests, you can use the `-SkipTest`
switch.

### 2.4 Example workflow

Say you're working on a new cmdlet, `Get-RscStuff` . It's a public cmdlet so
its source file is `Toolkit/Public/Get-RscStuff.ps1` . You can inspire yourself
from other ps1 files in `Toolkit/Public`, but typically you'll want to
write a function with the same name:

```powershell
#Requires -Version 3
function Get-RscStuff {
    <#
    .SYNOPSIS
    ...
    .DESCRIPTION
    ...
    .PARAMETER ...
    #>
    [CmdletBinding()]
    Param ( ..... )
    Process { ......}
}
```

Its companion test file is `Toolkit/Tests/Unit/Get-RscStuff.Tests.ps1` . You can
start with a simple test - for example, to make sure the cmdlet has a
`Synopsis` and a `Description`:

```powershell
<#
.SYNOPSIS
Basic tests for Get-RscStuff
#>
BeforeAll {
    . "$PSScriptRoot\..\..\Utils\ToolkitDev.ps1" -Quiet
}

Describe -Name "Get-RscStuff" -Fixture {
  It -Name "Get-RscStuff" -Test {
    (Get-Help Get-RscStuff).Synopsis | Should -Not -BeNullOrEmpty
    (Get-Help Get-RscStuff).Description | Should -Not -BeNullOrEmpty
  }
}
```

Now you have a new cmdlet and a test for it. You can run `Update-RscToolkit`
to copy the files to the `Output/` directory, re-import the module, and run
the tests (especially the new test you just wrote).

As you develop `Get-RscStuff`, use the unit test to test, validate and
experiment with the cmdlet.

Once you're happy with `Get-RscStuff`, you can submit a PR.

## Submitting a PR

When you're ready to submit a PR, make sure you've done the following:

1. Clean up your cmdlet code and tests. Make sure your code is clean,
   and that your tests pass. For example:
   - During your dev workflow you may have added
     tests that helped you develop the cmdlet, but that are not necessary
     for the final version of the cmdlet.
   - Maybe you have some `Write-Host`
     statements that you used for debugging, etc.
   - Maybe you have some commented-out code that you used for
     experimenting, etc.
   - Analyze your cmdlet code: maybe some parts of it can be refactored
     into a private function (that would be in `Toolkit/Private`), etc.
2. Update the `CHANGELOG.md` file with your changes.
3. Rebase your branch on the `devel` branch:
   `git rebase --rebase origin devel`
4. Run `Utils\Build-RscSdk.ps1` . It will build the SDK from scratch,
   including the core and the Toolkit, and run the tests. It will also
   clean up the local repo, so you can be sure that your PR is clean.
