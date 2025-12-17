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
        # Get all SQL Hosts
        $data.sqlHosts = Get-RscMssqlInstance
        Write-Verbose "Found $($data.sqlHosts.Count) SQL Hosts"
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
                    Write-Verbose "Found $($data.sqlInstances.Count) SQL Instances on host $($data.sqlHost.name)"
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
            if ($data.sqlHost.cluster -eq $null) {
                Set-ItResult -Skipped -Because "SQL Host has no cluster"
                return
            }
            Write-Verbose "Testing cluster filter with cluster: $($data.sqlHost.cluster.name) (ID: $($data.sqlHost.cluster.id))"
            $objects = Get-RscMssqlInstance -HostName $data.sqlHost.name -Cluster $data.sqlHost.cluster
            Write-Verbose "Found $($objects.Count) instances on cluster"
            $objects | ForEach-Object {
                $_.cluster.id | Should -Be $data.sqlHost.cluster.id
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
