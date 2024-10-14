<#
.SYNOPSIS
Run tests specifically for Get-RscFileset
#>
BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
}


Describe -Name 'Get-RscFileset Tests' -Tag 'Public' -Fixture{
    #Fileset by  FilesetId tests
    Context -Name 'Id ParameterSet Validation'{
        It -Name 'FilesetId cannot be $null' -Test {
            { Get-RscFileset -FilesetId $null }|
            Should -Throw "Cannot validate argument on parameter 'FilesetId'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
    }

    Context -Name "Call with HostId" {

        It -Name "First 3 Windows Hosts from Get-RscHost" -Test {
            $hosts = Get-RscHost -OsType Windows -First 3
            # Bypass the test if there are no Windows hosts
            if ($hosts.Count -eq 0) {
                Skip "No Windows hosts found"
            }
            # for each host, get the filesets
            $hosts | ForEach-Object {
                $hostId = $_.Id
                Get-RscFileset -HostId $hostId
            }
        }
    }

    # TODO: SPARK-225906 fix this test
    return

    #Query tests
    Context -Name 'Query ParameterSet Validation' {

        It -Name 'Parameter HostId(alias Id) shoud accept value from pipeline' -Test{
            # TODO: SPARK-212380 Replace the static ID below with a mock test once the mock server has been fixed.
            { New-Object PSObject -Property @{"Id"="0058bb59-adc4-598e-972a-ecd702624c7a"} | Get-RscFileset } | 
                Should -Not -Throw
        }


        It -Name 'Parameter HostId(alias: Id) cannot be $null' -Test {
            { Get-RscFileset -HostId $null} |
                Should -Throw "Cannot validate argument on parameter 'HostId'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }

        It -Name 'Parameter HostId(alias: Id) cannot be empty' -Test {
            { Get-RscFileset -Id '' } |
                Should -Throw "Cannot validate argument on parameter 'HostId'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
    }
}
