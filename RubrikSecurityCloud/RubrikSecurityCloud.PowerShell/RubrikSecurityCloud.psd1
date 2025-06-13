#
# Module manifest for module 'RubrikSecurityCloud'
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'LoadModule.psm1'

# Version number of this module.
ModuleVersion = '1.13.0'

# Supported PSEditions
# CompatiblePSEditions = @()

# ID used to uniquely identify this module
GUID = '088f2cd2-1ece-40e3-8942-d3b997d7c875'

# Author of this module
Author = 'Rubrik'

# Company or vendor of this module
CompanyName = 'Rubrik'

# Copyright statement for this module
Copyright = '(c) Rubrik. All rights reserved.'

# Description of the functionality provided by this module
# NOTE: This entry is generated.
Description = 'PowerShell Module for Rubrik Security Cloud. GraphQL schema version: v20250505-56 .'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.0.0'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# DotNetFrameworkVersion = ''

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
# RequiredModules = @()

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# Filled in by UpdatePsd1.ps1
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = @(
  "Toolkit/Format/AwsNativeEc2Instance.Format.ps1xml",
  "Toolkit/Format/AzureNativeVirtualMachine.Format.ps1xml",
  "Toolkit/Format/CloudNativeTagRule.Format.ps1xml",
  "Toolkit/Format/Db2Database.Format.ps1xml",
  "Toolkit/Format/Db2Instance.Format.ps1xml",
  "Toolkit/Format/GlobalSlaReply.Format.ps1xml",
  "Toolkit/Format/HyperVVirtualMachine.Format.ps1xml",
  "Toolkit/Format/MongoCollection.Format.ps1xml",
  "Toolkit/Format/MongoDatabase.Format.ps1xml",
  "Toolkit/Format/MongoSource.Format.ps1xml",
  "Toolkit/Format/MssqlDatabase.Format.ps1xml",
  "Toolkit/Format/MssqlInstance.Format.ps1xml",
  "Toolkit/Format/MssqlLogShippingTarget.Format.ps1xml",
  "Toolkit/Format/NutanixVm.Format.ps1xml",
  "Toolkit/Format/OracleDatabase.Format.ps1xml",
  "Toolkit/Format/OracleHost.Format.ps1xml",
  "Toolkit/Format/Org.Format.ps1xml",
  "Toolkit/Format/Permission.Format.ps1xml",
  "Toolkit/Format/PhysicalHost.Format.ps1xml",
  "Toolkit/Format/Role.Format.ps1xml",
  "Toolkit/Format/SapHanaDatabase.Format.ps1xml",
  "Toolkit/Format/SapHanaSystem.Format.ps1xml",
  "Toolkit/Format/Snappable.Format.ps1xml",
  "Toolkit/Format/VsphereVm.Format.ps1xml",
  "Toolkit/Format/WindowsCluster.Format.ps1xml")

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('PublicFunctions.psm1')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
# FunctionsToExport = @('List-RscCluster')
FunctionsToExport = '*'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = '*'

# Variables to export from this module
VariablesToExport = '*'

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = @("Rubrik","RubrikSecurityCloud","Ransomware_Recovery","Data_Security", "Data_Protection")

        # A URL to the license for this module.
        LicenseUri = 'https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/LICENSE'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/rubrikinc/rubrik-powershell-sdk'

        # A URL to an icon representing this module.
        IconUri = 'https://i.imgur.com/Zbdd4Ko.jpg'

        # ReleaseNotes of this module
        # ReleaseNotes = ''

        # Prerelease string of this module
        # Prerelease = 'Beta'

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}
