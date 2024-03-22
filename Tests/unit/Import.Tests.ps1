. "$PSScriptRoot\..\UnitTestInit.ps1"

Describe -Name 'Verify correct import' -Fixture {
    It -Name "min version of PowerShell required by the module should be 5.0.0" {
        $module = Get-Module -Name RubrikSecurityCloud
        $expectedVersion = New-Object System.Version(5, 0, 0)
        $module.PowerShellVersion | Should -Be $expectedVersion
    }
    # Connect-Rsc should always be available
    It -Name 'Connect-Rsc exists' -Test {
        (Get-Command -Name Connect-Rsc -ErrorAction SilentlyContinue) | Out-String |
        Should -BeLikeExactly '*Connect-Rsc*'
    }
    # Disconnect-Rsc should always be available
    It -Name 'Disconnect-Rsc exists' -Test {
        (Get-Command -Name Disconnect-Rsc -ErrorAction SilentlyContinue) | Out-String |
        Should -BeLikeExactly '*Disconnect-Rsc*'
    }
    # Arbitrary command that should always be available
    It -Name 'Get-RscVsphereVm exists' -Test {
        (Get-Command -Name Get-RscVsphereVm -ErrorAction SilentlyContinue) | Out-String |
        Should -BeLikeExactly '*Get-RscVsphereVm*'
    }

    # Make sure exported command list is the same on PowerShell 7 and PowerShell 5
    It -Name 'Exported command list is the same on PowerShell 7 and PowerShell 5' -Test {
        # Determine if running on Windows
        $win = $false
        if ($PSVersionTable.PSVersion.Major -ge 6) {
            # PowerShell Core/7+
            $win = $IsWindows
        }
        else {
            # Windows PowerShell 5 ("Desktop PowerShell")
            $win = [System.Environment]::OSVersion.Platform -eq [System.PlatformID]::Win32NT
        }

        if (-not $win) {
            # Skip this test on non-Windows platforms
            Set-ItResult -Skipped -Because 'This test is only applicable on Windows'
            return
        }

        $sdkDir = Join-Path -Path $PSScriptRoot -ChildPath '..\..' -Resolve
        $psCommand = ". Utils/Import-RscModuleFromLocalOutputDir.ps1 -Quiet; Get-Command -Module RubrikSecurityCloud | Sort-Object Name | Select-Object -ExpandProperty Name"
        # Run the command on PowerShell 7
        $ps7OutFile = "get-command.powershell7.txt"
        Start-Process -WorkingDirectory $sdkDir -FilePath "pwsh" -ArgumentList "-NoProfile", "-Command", $psCommand -Wait -NoNewWindow -PassThru -RedirectStandardOutput $ps7OutFile
        # Run the command on PowerShell 5
        $ps5OutFile = "get-command.powershell5.txt"
        Start-Process -WorkingDirectory $sdkDir -FilePath "powershell" -ArgumentList "-NoProfile", "-Command", $psCommand -Wait -NoNewWindow -PassThru -RedirectStandardOutput $ps5OutFile
        # Compare the output
        $ps7Out = Get-Content -Path $ps7OutFile
        $ps5Out = Get-Content -Path $ps5OutFile
        $ps7Out | Should -Be $ps5Out
        # Clean up
        Remove-Item -Path $ps7OutFile
        Remove-Item -Path $ps5OutFile
    }
}
