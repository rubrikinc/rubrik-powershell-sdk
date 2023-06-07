<#
.SYNOPSIS
Run tests around sla domains
#>
BeforeAll {
    . "$PSScriptRoot\e2eInit.ps1"
}

Describe -Name 'Write-SlaDomain' -Tag 'Public' -Fixture{
    Context -Name 'Sla Creation' {
        It -Name 'Sla is created' -Test {
            $name="name"
            $description="description"
            $snapshotSchedule=@{
              "yearly"=@{
                "basicSchedule"=@{
                  "frequency"=1
                  "retention"=1
                  "retentionUnit"="YEARS"}
                "dayOfYear"="LAST_DAY"
                "yearStartMonth"="JANUARY"
              }
            }
            $objectTypes = @("MANAGED_VOLUME_OBJECT_TYPE")
            $reply = Write-SlaDomain -Name $name -Description $description -SnapshotSchedule $snapshotSchedule -ObjectTypes $objectTypes
            $reply.Id | Should -Not -BeNullOrEmpty
        }
    }
}
