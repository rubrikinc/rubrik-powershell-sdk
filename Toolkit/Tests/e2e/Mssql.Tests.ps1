BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
    $Global:diag = New-E2eDiagnostics -Topic "Mssql"
    $Global:data = @{
        databases    = $null
        sqlHosts     = $null
        sqlHost      = $null
        sqlInstances = $null
        logShipping  = $null
    }
}

Describe -Name 'Mssql' -Tag 'E2E' -Fixture {

    # --- Availability Groups ---

    Context 'Availability Groups' {
        It 'creates an AvailabilityGroup query' {
            $query = Get-RscMssqlAvailabilityGroup -AsQuery
            $query | Should -BeOfType [RubrikSecurityCloud.RscQuery]
            Add-E2eDiagnosticEntry $diag "AvailabilityGroup AsQuery" "pass" "Query created"
        }
    }

    # --- Linked Availability Groups ---

    Context 'Linked Availability Groups' {
        It 'creates a LinkedAvailabilityGroup query' {
            $query = Get-RscMssqlLinkedAvailabilityGroup -AsQuery
            $query | Should -BeOfType [RubrikSecurityCloud.RscQuery]
            Add-E2eDiagnosticEntry $diag "LinkedAvailabilityGroup AsQuery" "pass" "Query created"
        }
    }

    # --- Databases ---

    Context 'List Databases' {
        It 'lists MSSQL databases' {
            $data.databases = Get-RscMssqlDatabase
            if (@($data.databases).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List Databases" "skip" "None found"
                Set-ItResult -Skipped -Because "No MSSQL databases found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List Databases" "pass" "Found $(@($data.databases).Count)"
        }
    }

    Context 'Retrieve Database by Id' {
        It 'retrieves database by Id' {
            if (-not $data.databases -or @($data.databases).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve Database by Id" "skip" "No databases"
                Set-ItResult -Skipped -Because "No databases"
                return
            }
            $db = Get-RscMssqlDatabase -Id $data.databases[0].id
            $db.id | Should -Be $data.databases[0].id
            $db.name | Should -Be $data.databases[0].name
            Add-E2eDiagnosticEntry $diag "Retrieve Database by Id" "pass" "'$($db.name)'"
        }
    }

    Context 'Retrieve Database by Name' {
        It 'retrieves databases by name' {
            if (-not $data.databases -or @($data.databases).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve Database by Name" "skip" "No databases"
                Set-ItResult -Skipped -Because "No databases"
                return
            }
            $results = Get-RscMssqlDatabase -Name $data.databases[0].name
            $results[0].id | Should -Be $data.databases[0].id
            $results[0].name | Should -Be $data.databases[0].name
            Add-E2eDiagnosticEntry $diag "Retrieve Database by Name" "pass" "'$($data.databases[0].name)'"
        }
    }

    # --- Instances ---

    Context 'List SQL Hosts' {
        It 'lists SQL hosts' {
            $data.sqlHosts = Get-RscMssqlInstance
            if (@($data.sqlHosts).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List SQL Hosts" "skip" "None found"
                Set-ItResult -Skipped -Because "No SQL hosts found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List SQL Hosts" "pass" "Found $(@($data.sqlHosts).Count)"
        }
    }

    Context 'SQL Instance Operations' {
        It 'retrieves SQL instances from a host' {
            if (-not $data.sqlHosts -or @($data.sqlHosts).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve Instances from Host" "skip" "No SQL hosts"
                Set-ItResult -Skipped -Because "No SQL hosts"
                return
            }
            $found = $false
            foreach ($h in $data.sqlHosts) {
                $data.sqlInstances = Get-RscMssqlInstance -HostName $h.name
                if (@($data.sqlInstances).Count -gt 0) {
                    $data.sqlHost = $h
                    $found = $true
                    break
                }
            }
            $found | Should -Be $true
            Add-E2eDiagnosticEntry $diag "Retrieve Instances from Host" "pass" "Found $(@($data.sqlInstances).Count) on '$($data.sqlHost.name)'"
        }

        It 'retrieves instance by Id' {
            if (-not $data.sqlInstances -or @($data.sqlInstances).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve Instance by Id" "skip" "No instances"
                Set-ItResult -Skipped -Because "No instances"
                return
            }
            $obj = Get-RscMssqlInstance -Id $data.sqlInstances[0].id
            $obj.id | Should -Be $data.sqlInstances[0].id
            $obj.name | Should -Be $data.sqlInstances[0].name
            Add-E2eDiagnosticEntry $diag "Retrieve Instance by Id" "pass" "'$($obj.name)'"
        }

        It 'retrieves instance by name' {
            if (-not $data.sqlInstances -or @($data.sqlInstances).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve Instance by Name" "skip" "No instances"
                Set-ItResult -Skipped -Because "No instances"
                return
            }
            $obj = Get-RscMssqlInstance -HostName $data.sqlHost.name -Name $data.sqlInstances[0].name
            if ($obj -is [array]) { $obj = $obj[0] }
            $obj.id | Should -Be $data.sqlInstances[0].id
            $obj.name | Should -Be $data.sqlInstances[0].name
            Add-E2eDiagnosticEntry $diag "Retrieve Instance by Name" "pass" "'$($obj.name)'"
        }

        It 'filters by cluster' {
            if (-not $data.sqlHost -or $null -eq $data.sqlHost.cluster) {
                Add-E2eDiagnosticEntry $diag "Filter Instance by Cluster" "skip" "No cluster info"
                Set-ItResult -Skipped -Because "SQL Host has no cluster"
                return
            }
            $objects = Get-RscMssqlInstance -HostName $data.sqlHost.name -Cluster $data.sqlHost.cluster
            $objects | ForEach-Object {
                $_.cluster.id | Should -Be $data.sqlHost.cluster.id
            }
            Add-E2eDiagnosticEntry $diag "Filter Instance by Cluster" "pass" "Cluster '$($data.sqlHost.cluster.name)'"
        }

        It 'filters out relics and replicas' {
            if (-not $data.sqlHosts -or @($data.sqlHosts).Count -le 1) {
                Add-E2eDiagnosticEntry $diag "Filter Relics/Replicas" "skip" "Need >1 hosts"
                Set-ItResult -Skipped -Because "Need more than 1 host to test filtering"
                return
            }
            $objects = Get-RscMssqlInstance -Relic:$false -Replica:$false
            $objects.Count | Should -BeLessThan $data.sqlHosts.Count
            Add-E2eDiagnosticEntry $diag "Filter Relics/Replicas" "pass" "Filtered to $($objects.Count)"
        }
    }

    # --- Log Shipping ---

    Context 'List Log Shipping Targets' {
        It 'lists log shipping targets' {
            $data.logShipping = Get-RscMssqlLogShipping
            if (@($data.logShipping).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List Log Shipping" "skip" "None found"
                Set-ItResult -Skipped -Because "No log shipping targets found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List Log Shipping" "pass" "Found $(@($data.logShipping).Count)"
        }
    }

    Context 'Log Shipping Operations' {
        It 'retrieves log shipping target by Id' {
            if (-not $data.logShipping -or @($data.logShipping).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve LogShipping by Id" "skip" "No targets"
                Set-ItResult -Skipped -Because "No targets"
                return
            }
            $ls = Get-RscMssqlLogShipping -Id $data.logShipping[0].id
            $ls.id | Should -Be $data.logShipping[0].id
            Add-E2eDiagnosticEntry $diag "Retrieve LogShipping by Id" "pass" "Id '$($ls.id)'"
        }

        It 'retrieves log shipping target using filters' {
            if (-not $data.logShipping -or @($data.logShipping).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve LogShipping by Filters" "skip" "No targets"
                Set-ItResult -Skipped -Because "No targets"
                return
            }
            $primaryDb = Get-RscMssqlDatabase -Id $data.logShipping[0].primaryDatabase.Id
            $ls = Get-RscMssqlLogShipping -PrimaryDatabase $primaryDb -SecondaryDatabaseName $data.logShipping[0].SecondaryDatabase.name
            $ls.id | Should -Be $data.logShipping[0].id
            Add-E2eDiagnosticEntry $diag "Retrieve LogShipping by Filters" "pass" "Matched"
        }
    }
}

AfterAll {
    Save-E2eDiagnostics $diag
}
