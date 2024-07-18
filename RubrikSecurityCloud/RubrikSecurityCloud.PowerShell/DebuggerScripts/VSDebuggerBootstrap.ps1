<#
	Usage:
	1. Rename debugconfig.json.template to debugconfig.json
	2. Update the debugconfig.json file to match your environment.
		Note: If only the service account file is going to be used,
		the sa_id, sa_secret and sa_url values can be left empty.
	3. Update your debug settings in the VS PowerShell project:
		To call this script at compile time:
		In the Debug settings of the project, set:

			Launch: Executable
			Executable: C:\Program Files\PowerShell\7\pwsh.exe
			Application Arguments: -NoExit -File "..\..\..\DebuggerScripts\VSDebuggerBootstrap.ps1 -EnvName: sa_rsc_pso"
#>

param(
	[switch] $UseServiceAccountFile=$true,
	[switch] $VerboseLogging=$false,
	[string] $EnvName
)
Set-Location $PSScriptRoot\..
$psd1_path = ".\bin\Debug\RubrikSecurityCloud.psd1"

try{
	Write-Output ([String]::Format("Using environment: {0}", $envName))
	
	$debugConfig = Get-Content .\DebuggerScripts\debugconfig.json | ConvertFrom-Json

	if ($null -eq $debugConfig)
	{
		Throw "Unable to load debugger config from debugconfig.json"
	}

	$envConfig = $($debugConfig).Environments | Where-Object {$_.Name -eq $EnvName}

	if ($null -eq $envConfig)
	{
		Throw "Unable to find config $EnvName in debugconfig.json"
	}

	if ($UseServiceAccountFile)
	{
		try{
			$sa_profile_dir = Join-Path (Split-Path $PROFILE) -ChildPath "rubrik-powershell-sdk"

			$sa_file_full_path = $envConfig.filePath
			$sa_file_name = Split-Path $sa_file_full_path -Leaf
			$sa_file_extension = [System.IO.Path]::GetExtension($sa_file_full_path)
			$sa_file_base_name = [System.IO.Path]::GetFileNameWithoutExtension($sa_file_name)
			$sa_enc_file_name = "$sa_file_base_name.xml"
			$sa_enc_file_full_path = Join-Path $sa_profile_dir -ChildPath $sa_enc_file_name
		}
		catch{
			Throw "Unable to get or set serivce account file paths: $_"
		}

		if ($VerboseLogging){
			Write-Output("=== ENVIRONMENT SETTINGS ===")
			Write-Output('$sa_profile_dir: ' + $sa_profile_dir)
			Write-Output('$sa_file_full_path: ' + $sa_file_full_path)
			Write-Output('$sa_file_name: ' + $sa_file_name)
			Write-Output('$sa_file_extension: ' + $sa_file_extension)
			Write-Output('$sa_enc_file_name: ' + $sa_enc_file_name)
			Write-Output('$sa_enc_file_full_path: ' + $sa_enc_file_full_path)
		}

		try{
			# Import the RSC module from the debug build
			Import-Module $psd1_path
		}
		catch{
			Throw "Unable to import Rubrik Security Cloud Module: $_"
		}
		

		try{
			#Check if the encrypted SA file exists and if not, create it.
			if (-Not (Test-Path $sa_enc_file_full_path)){
				Set-RscServiceAccountFile -InputFilePath $sa_file_full_path -OutputFilePath $sa_enc_file_full_path -KeepOriginalClearTextFile
			}
		}
		catch{
			Throw "Unable to encrypt and save service account file: $_"
		}

		try{
			Write-Output("Connecting to Rubrik Security Cloud using `"Connect-Rsc`"...")

			Connect-Rsc -ServiceAccountFile $sa_enc_file_full_path -Verbose
			Set-Location \
		}
		catch{
			Write-Output "Unable to connect to Rubrik Security Cloud: $_"
		}
	} 
	else
	{
		$sa_id = $envConfig.sa_id
		$sa_secret = $envConfig.$sa_secret
		$sa_url = $envConfig.$sa_url

		Import-Module $psd1_path
		Write-Output("Connecting to Rubrik Security Cloud using `"Connect-Rsc`"...")
		Connect-Rsc -Server $sa_url -ClientId $sa_id -ClientSecret $sa_secret
		Set-Location \
	}
}
catch{
	Write-Error($_)
	exit 1
}

