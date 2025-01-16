BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        sqlHosts = $null
        sqlInstances = $null
    }
}

Describe -Name 'Get-RscMssqlInstance Tests' -Tag 'Public' -Fixture {

    It -Name 'retrieves SQL Hosts' -Test {
        $data.sqlHosts = Get-RscMssqlInstance
        $data.sqlHosts | Should -Not -BeNullOrEmpty
    }

    It -Name 'retrieves SQL Instances from a Host' -Test {
        $data.sqlInstances = Get-RscMssqlInstance -HostName $data.sqlHosts[0].name
        $data.sqlInstances | Should -Not -BeNullOrEmpty
    }


    Context -Name 'RSC SQL Host Count > 0' {
        BeforeEach {
            # Skip the tests if empty 
            if ($data.sqlHosts.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 MssqlInstance is needed"
                return
            }
        }

        It -Name 'retrieves single RscMssqlInstance by RSC ID' -Test {
            $object = Get-RscMssqlInstance -Id $data.sqlInstances[0].id
            $object.name | Should -Be $data.sqlInstances[0].name
            $object.id | Should -Be $data.sqlInstances[0].id
        }

        It -Name 'retrieves RscMssqlInstance by name' -Test {
            $object = Get-RscMssqlInstance -HostName $data.sqlHosts[0].name -Name $data.sqlInstances[0].name
            $object.name | Should -Be $data.sqlInstances[0].name
            $object.id | Should -Be $data.sqlInstances[0].id
        }

        It -Name 'filters by cluster' -Test {
            $objects = Get-RscMssqlInstance -HostName $data.sqlHosts[0].name -Cluster $data.sqlHosts[0].cluster
            $objects | ForEach-Object {
                $_.cluster.id | Should -Be $data.sqlHosts[0].cluster.id
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
