& "$PSScriptRoot\..\..\Utils\import.ps1"
. "$PSScriptRoot\..\serviceaccount.ps1"

# TODO: SPARK-225907 fix this
return

Describe -Name 'Get-RscMssqlDatabase' -Tag 'Public' -Fixture{

    Context -Name 'Parameter Validation' {
        It -Name 'Parameter Name cannot be $null' -Test {
            { Get-RscMssqlDatabase -Name $null } |
                Should -Throw "Cannot validate argument on parameter 'Name'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
        It -Name 'Parameter Name cannot be empty' -Test {
            { Get-RscMssqlDatabase -Name '' } |
                Should -Throw "Cannot validate argument on parameter 'Name'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
        It -Name 'Parameter ID cannot be $null' -Test {
            { Get-RscMssqlDatabase -Id $null } |
                Should -Throw "Cannot validate argument on parameter 'Id'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
        It -Name 'Parameter ID cannot be empty' -Test {
            { Get-RscMssqlDatabase -Id '' } |
                Should -Throw "Cannot validate argument on parameter 'Id'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
        It -Name 'Parameters Id and Name cannot be simultaneously used' -Test {
            { Get-RscMssqlDatabase -Id fb32a9e0-de69-55df-a195-3aa134b221e8 -Name 'AdventureWorksLT2019' } |
                Should -Throw "Parameter set cannot be resolved using the specified named parameters. One or more parameters issued cannot be used together or an insufficient number of parameters were provided."
        }
    }
}
