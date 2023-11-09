#
# Load Core scripts and Toolkit scripts:
#

$CorePublic = @(Get-ChildItem -Path $PSSCriptRoot\Public\*.ps*1 -ErrorAction SilentlyContinue)
$ToolkitPublic = @(Get-ChildItem -Path $PSSCriptRoot\Toolkit\Public\*.ps*1 -ErrorAction SilentlyContinue)
$Public = $CorePublic + $ToolkitPublic
Foreach ($import in @($Public))
{
    Try
    {
        Write-Output("Importing module from file $($import.fullname)")
        Import-Module $import.fullname -ErrorAction Stop
    }
    Catch
    {
        Write-Error -Message "Failed to import file $($import.fullname): $_"
    }
}
Export-ModuleMember -Function $Public.Basename -Alias *
