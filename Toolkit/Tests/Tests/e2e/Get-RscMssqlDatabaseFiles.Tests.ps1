BeforeAll {
    . "$PSScriptRoot\..\..\Utils\E2eTestInit.ps1"
}

Describe -Name 'Get-RscMssqlDatabaseFiles' -Tag 'Public' -Fixture{

    Context -Name 'Parameter Validation' {
        It -Name 'Parameter ID cannot be $null' -Test {
            { Get-RscMssqlDatabaseFiles -Id $null } |
                Should -Throw "Cannot validate argument on parameter 'Id'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
        It -Name 'Parameter ID cannot be empty' -Test {
            { Get-RscMssqlDatabaseFiles -Id '' } |
                Should -Throw "Cannot validate argument on parameter 'Id'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
        It -Name 'Parameter RecoveryDateTime cannot be $null' -Test {
            { Get-RscMssqlDatabaseFiles -RecoveryDateTime $null } |
                Should -Throw "Cannot process argument transformation on parameter 'RecoveryDateTime'. Cannot convert null to type `"System.DateTime`"."
        }        
    }
}
