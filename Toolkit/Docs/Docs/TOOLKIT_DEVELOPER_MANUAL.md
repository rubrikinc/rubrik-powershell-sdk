# RSC SDK Toolkit Developer Manual

## Introduction

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

## Cmdlet Development

Toolkit cmdlets are written in PowerShell, and are located in the
`Toolkit/Public` directory.

All `*.ps*1` files in that directory are
part of the build, and will be included in the module.

Please see: [Public Functions](../Public/README.md)

## Format file Development

All `.ps1xml` files in `Toolkit/Format` are part of the build, and will
be included in the module.

Please see: [Format Files](../Format/README.md)

## Private Functions

`Toolkit/Private` is also part of the build, but is not exported as
part of the module. It is used for internal functions, and for
functions that are not ready for public consumption.

Please see: [Private Functions](../Private/README.md)

## Developer Workflow

Start by building the SDK in Debug Mode, in the `Output/` directory:

```powershell
PS ~/rubrik-powershell-sdk> make
```

Once built, you can import the module from `Output/` with a Utils script:

```powershell
PS ~/rubrik-powershell-sdk> cd Toolkit
PS ~/rubrik-powershell-sdk/Toolkit> ./Utils/Import-ModuleFromOutputDir.ps1

Welcome to the Rubrik Security Cloud PowerShell SDK!

 Please refer to the Getting Started section of the Readme documentation:
 https://github.com/rubrikinc/rubrik-powershell-sdk#getting-started

PS ~/rubrik-powershell-sdk/Toolkit>
```

We work with the RubrikSecurityCloud module that's in the `Output/` directory
because it allows you to test your changes without having to install the
module.

To aid in the development of the toolkit, we have provided a
`ToolkitDev.ps1` script under `Toolkit/Utils`.

```powershell
PS ~/rubrik-powershell-sdk/Toolkit> . ./Utils/ToolkitDev.ps1

Welcome to the Rubrik Security Cloud PowerShell SDK!

 Please refer to the Getting Started section of the Readme documentation:
 https://github.com/rubrikinc/rubrik-powershell-sdk#getting-started


RubrikSecurityCloud module imported from Output directory.

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

Note that the `ToolkitDev.ps1` script will automatically import the
module from the `Output/` directory, so you don't need to run
`Import-ModuleFromOutputDir.ps1` if you're sourcing `ToolkitDev.ps1`.

`Update-RscToolkit` will update the `Output/` directory with the latest
changes from the `Toolkit/` directory, and re-import the module.

### Manual workflow

So say you're working on `Toolkit/Public/Get-RscStuff.ps1` :

1. Make your changes to `Toolkit/Public/Get-RscStuff.ps1`
2. Run `Update-RscToolkit` to update the `Output/` directory.
   It will also automatically re-import the module.
3. Test your changes manually by running `Get-RscStuff` in the
   PowerShell console.

### TDD workflow

The Manual Workflow is fine to start with, but we want to
be Test-Driven, so we need to automate the testing.

`Toolkit/Makefile` defaults to running `Update-RscToolkit` and
running all tests in `Toolkit/Tests/` :

```powershell
PS ~/rubrik-powershell-sdk/Toolkit> make

Copied 0 files to Output directory.
Imported module from Output directory.

Toolkit status:
---------------

SDK root: ~/rubrik-powershell-sdk
Source directory: <SDK root>/Toolkit
Output directory: <SDK root>/Output/Toolkit

All toolkit files in Output are up to date.

[Toolkit] Running PowerShell unit tests...

Tests completed in 2.93s
Tests Passed: 1, Failed: 0, Skipped: 0 NotRun: 0

[Toolkit] Running e2e tests...

Tests completed in 3.5s
Tests Passed: 3, Failed: 0, Skipped: 0 NotRun: 0

PS ~/rubrik-powershell-sdk/Toolkit>
```

TDD Workflow:

1. Make your changes to `Toolkit/Public/Get-RscStuff.ps1`
2. Update the tests in `Toolkit/Tests/Get-RscStuff.Tests.ps1`
3. `make`
