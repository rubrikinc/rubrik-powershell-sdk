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
	[string] $EnvName
)

try{
	Write-Output ([String]::Format("Using environment: {0}", $envName))
	
	$debugConfig = Get-Content DebuggerScripts\debugconfig.json | ConvertFrom-Json

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
		$sa_file = $envConfig.filePath
		Import-Module '.\bin\Debug\net6.0\RubrikSecurityCloud.psd1'
		Write-Output("Connecting to Rubrik Security Cloud using `"Connect-Rsc`"...")
		Connect-Rsc -ServiceAccountFile $sa_file
		Set-Location \
	} 
	else
	{
		$sa_id = $envConfig.sa_id
		$sa_secret = $envConfig.$sa_secret
		$sa_url = $envConfig.$sa_url

		Import-Module '.\bin\Debug\net6.0\RubrikSecurityCloud.psd1'
		Write-Output("Connecting to Rubrik Security Cloud using `"Connect-Rsc`"...")
		Connect-Rsc -Server $sa_url -ClientId $sa_id -ClientSecret $sa_secret
		Set-Location \
	}
}
catch{
	Write-Error("Unable to connecto to Rubrik Security Cloud: "+$_)
	exit 1
}

