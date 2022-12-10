function Get-ServiceAccountFile
{
    # Check if the RSC_SERVICE_ACCOUNT_FILE environment variable is defined
    if (!(Test-Path Env:RSC_SERVICE_ACCOUNT_FILE))
    {
        # RSC_SERVICE_ACCOUNT_FILE environment variable is not defined
        throw "Error: RSC_SERVICE_ACCOUNT_FILE environment variable is not defined"
    }

    # Retrieve the value of the RSC_SERVICE_ACCOUNT_FILE environment variable
    $path = [System.Environment]::GetEnvironmentVariable("RSC_SERVICE_ACCOUNT_FILE")

    # Check if the environment variable is empty
    if ([string]::IsNullOrEmpty($path))
    {
        # RSC_SA_FILE environment variable is empty
        throw "Error: RSC_SERVICE_ACCOUNT_FILE environment variable is empty"
    }

    # Return the value of the environment variable
    return $path
}

function Read-ServiceAccountFile
{
    param(
        [Parameter(Mandatory = $true)]
        [string]$Path
    )

    # Convert the JSON string to a hash table
    $hashTable = Get-Content -Path $Path -ErrorAction Stop | ConvertFrom-Json -ErrorAction Stop


    # Return the hash table
    return $hashTable
}

$global:serviceAccount = Read-ServiceAccountFile -Path (Get-ServiceAccountFile)
#Write-Output $global:serviceAccount ##Removed for security as it displays the client_secret on screen