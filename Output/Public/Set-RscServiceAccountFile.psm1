function Set-RscServiceAccountFile {
    <#
    .SYNOPSIS
    Read in a ServiceAccount.json file and store it's content in 
    an encrypted format.

    .DESCRIPTION
    Read in a ServiceAccount.json file and store its content in 
    an encrypted XML format.

    Connect-Rsc can accept service account credentials from the
    command line as parameters, or from a service account file.
    The service account file is in json format when downloaded
    from the RSC Web UI. However, for security, it is advised
    to not store sensitive access information on disk in plain
    text.

    The service_account.json that is provided by the RSC Web UI
    contains a secret key, which is classed as sensitive information
    as it is a credential.

    The Rubrik RSC PowerShell SDK, will not accept a JSON file as
    a valid credential file. The file has to be stored on disk
    in an encrypted XML format, which can only be decrypted by
    the same user profile in PowerShell.

    Set-RscServiceAccountFile will read the JSON provided by the
    RSC Web UI, and encrypt the contents in an XML file.

    By default, the encrypted credential file will be stored in the
    user's PowerShell profile. The user profile can be determined by
    inspecting the $PROFILE PS variable. Users can also elect to store
    the XML file in a different path, by specifying the -OutputFilePath
    parameter when using Set-RscServiceAccountFile.

    .EXAMPLE
    Read the RSC-provided service account json file and store the credential
    in the user profile (PROFILE-PATH//rubrik-powershell-sdk/rsc_service_account_default.xml)

    Please note, that by default Connect-Rsc will try and access this file
    if no parameters to the cmdlet are provided by the user.

    Set-RscServiceAccountFile -InputFilePath myServiceAccountName.json

    .EXAMPLE
    Read the RSC-provided service account json file and store the credential
    in a custom location

    Set-RscServiceAccountFile -InputFilePath myServiceAccountName.json -OutputFilePath myServiceAccountName.xml

    .LINK    
    #>

    [CmdletBinding()]
    Param(
        [Parameter(
            Mandatory = $true, 
            ValueFromPipelineByPropertyName = $false,
            Position = 0)]
        [ValidateScript({Test-Path $_})] # Check if the input file exists before starting
        [string]$InputFilePath,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $false,
            Position = 1)]
        [string]$OutputFilePath,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $false,
            Position = 2)]
        [switch]$DisablePrompts,

        [Parameter(
            Mandatory = $false
        )]
        [switch]$KeepOriginalClearTextFile
    )
    
    Process
    {    
        try
        {
            # This will be placed under the user PowerShell Profile
            $sdk_credential_store_path = "/rubrik-powershell-sdk"
            $sdk_default_credential_file = [RubrikSecurityCloud.Files]::DefaultServiceAccountFileName
        
            $outFile = $null

            if ($OutputFilePath){
                $outFile = $OutputFilePath
            }else{
                $outfile = Join-Path (Join-Path -Path (Split-Path $PROFILE) -ChildPath $sdk_credential_store_path) -ChildPath $sdk_default_credential_file    
                               
                if ((Test-Path -PathType Container -Path (Split-Path $outFile)) -eq $false){
                    Write-Output("`nCreating credential store...")
                    $null = New-Item -ItemType Directory -Force -Path (Split-Path -Path $OutFile)
                }
            }

            Write-Output("`nReading RSC Service Account JSON File from $InputFilePath")
            $saContent = Get-Content $InputFilePath | ConvertFrom-Json
            $secureContent = @{
                "client_id" = ConvertTo-SecureString -String $saContent.client_id -AsPlainText -Force
                "client_secret" = ConvertTo-SecureString -String $saContent.client_secret -AsPlainText -Force
                "name" = $saContent.name
                "access_token_uri" = $saContent.access_token_uri
            }

            if (Test-Path -PathType Leaf -Path $outFile){
                if ($DisablePrompts){
                    $answer = "yes"
                }else{
                    Write-Output("`nA file containing a RSC credential exists at $outfile")
                    $answer = Read-Host "Overwrite the existing file? [Yes/No]"
                }
                if ("yes","y" -contains $answer.ToLower()){
                    Write-Output("Existing file will be overwritten...")
                    Write-Output("`nSaving credential file: $outFile")   
                    Export-CliXml -InputObject $secureContent -Path $outFile
                }else{
                    Throw "Unable to continue. File exists. User elected not to overwrite an existing destination file."
                }
            }else{
                Write-Output("`nSaving credential file: $outFile")   
                Export-CliXml -InputObject $secureContent -Path $outFile
            }

            # Check if the user is ok with us removing the original json file
            if ($KeepOriginalClearTextFile) {
               $answer = "no"
            }elseif ($DisablePrompts){
                $answer = "yes"
            }else{
                Write-Output("`nRubrik strongly discourage keeping clear text service account files.")
                $answer = Read-Host "Delete the original JSON file? [YES/No]"
            }
            if ("yes","y" -contains $answer.ToLower()){
                try {
                    Write-Information("Removing $InputFilePath...")
                    Remove-Item $InputFilePath
                }
                catch {
                    Write-Error("Failed to remove file: $InputFilePath. Error: $_");
                }
                
            }else{
                Write-Warning("Preserving original credential file: $InputFilePath. Please ensure this is stored securely.")
            }
        }
        catch {
            Write-Error("Unable to save credentials to $outFile`: $_")
            return
        }
    } 
}
