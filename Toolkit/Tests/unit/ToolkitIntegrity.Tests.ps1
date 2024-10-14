<#
.SYNOPSIS
Basic tests to check that the Toolkit is intact
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name "Toolkit Integrity Tests" -Fixture {

    It -Name 'Toolkit' -Test {
        # Check that toolkit directories exist and are readable
        foreach ($property in ($Toolkit.PSObject.Properties | Where-Object { $_.Name -like '*Dir' })) {
            $directoryPath = $property.Value
            $directoryPath | Should -Exist
            { Get-ChildItem -Path $directoryPath } | Should -Not -Throw
        }

        # Check public scripts
        $publicFiles = Get-ChildItem -Path $Toolkit.PublicDir -Filter "*.ps1"
        foreach ($file in $publicFiles) {

            # For all .ps1 files in $Toolkit.PublicDir, check that they are
            # syntactically correct: <VERB>-Rsc<NOUN>.ps1
            # where <VERB> is a valid PowerShell verb and <NOUN> is anything

            # Exceptions:
            if ($file.name -eq "Remove-NullProperties.ps1") {
                continue
            }
            # Extract the verb:
            $verb = $file.BaseName.Split('-')[0]
            $validVerbs = (Get-Verb).Verb
            $verb | Should -BeIn $validVerbs
            $file.name | Should -Match "^[a-zA-Z]+-Rsc[a-zA-Z0-9]+\.ps1$"

            # Check that the file can be loaded without error or side effects
            { . $file.FullName } | Should -Not -Throw
        }
    }
}
