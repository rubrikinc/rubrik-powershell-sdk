BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        sqlHosts = $null
        sqlHost = $null
        sqlInstances = $null
    }
}

Describe -Name 'Get-RscMssqlInstance Tests' -Tag 'Public' -Fixture {

    It -Name 'retrieves SQL Hosts' -Test {
        $data.sqlHosts = Get-RscMssqlInstance
    }

    Context -Name 'RSC SQL Host Count > 0' {
        BeforeEach {
            # Skip the tests if empty 
            if ($data.sqlHosts.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 SQL host is needed"
                return
            }
        }

        It -Name 'retrieves SQL Instances from a Host' -Test {
            # At least one host in the deployment must have at least 1 instance
            $found = $false
            foreach( $h in $data.sqlHosts) {
                $data.sqlInstances = Get-RscMssqlInstance -HostName $h.name
                if ($data.sqlInstances.Count -gt 0) {
                    $data.sqlHost = $h
                    $found = $true
                    break
                }
            }
            $found | Should -Be $true
        }

        It -Name 'retrieves single RscMssqlInstance by RSC ID' -Test {
            $object = Get-RscMssqlInstance -Id $data.sqlInstances[0].id
            $object.name | Should -Be $data.sqlInstances[0].name
            $object.id | Should -Be $data.sqlInstances[0].id
        }

        It -Name 'retrieves RscMssqlInstance by name' -Test {
            $object = Get-RscMssqlInstance -HostName $data.sqlHost.name -Name $data.sqlInstances[0].name
            # if $object is an array, take the first one
            if ($object -is [array]) {
                $object = $object[0]
            }
            $object.name | Should -Be $data.sqlInstances[0].name
            $object.id | Should -Be $data.sqlInstances[0].id
        }

        It -Name 'filters by cluster' -Test {
            $objects = Get-RscMssqlInstance -HostName $data.sqlHost.name -Cluster $data.sqlHosts[0].cluster
            $objects | ForEach-Object {
                $_.cluster.id | Should -Be $data.sqlHostgs.cluster.id
            }
        }

        Context -Name 'RSC replica or relic count > 1' {
            It -Name 'filters out relics and replicas' -Test {
                $objects = Get-RscMssqlInstance -relic:$false -replica:$false
                $objects.count | Should -BeLessThan $data.sqlHosts.count
            }
        }
    }
}
