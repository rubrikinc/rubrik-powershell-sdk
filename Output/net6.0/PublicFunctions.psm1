$Public = @(Get-ChildItem -Path $PSSCriptRoot\Public\*.psm1 -ErrorAction SilentlyContinue)

Foreach ($import in @($Public))
{
    Try
    {
        Write-Output("Importing $($import.fullname)")
        Import-Module $import.fullname
    }
    Catch
    {
        Write-Error -Message "Failed to import function $($import.fullname): $_"
    }
}
Export-ModuleMember -Function $Public.Basename -Alias *

$Extensions = @(Get-ChildItem -Path $PSSCriptRoot\Extensions\*.psm1 -ErrorAction SilentlyContinue)

Foreach ($import in @($Extensions))
{
    Try
    {
        Write-Output("Importing extension$($import.fullname)")
        Import-Module $import.fullname
    }
    Catch
    {
        Write-Error -Message "Failed to import extension function $($import.fullname): $_"
    }
}
Export-ModuleMember -Function $Extensions.Basename -Alias *
