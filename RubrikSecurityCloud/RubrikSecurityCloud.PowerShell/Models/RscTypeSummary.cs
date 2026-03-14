using System;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Models
{
    /// <summary>
    /// Lightweight wrapper returned by Get-RscType -ListAvailable.
    /// Currently only holds a Name — could be extended with Kind
    /// (input/output/interface), IsInput, etc. to make -ListAvailable
    /// more useful without requiring a second call.
    ///
    /// Known issue: adds no value over a plain string today. Forces
    /// users to do $result.Name instead of getting strings directly.
    /// </summary>
    public class RscTypeSummary
    {
        public string Name { get; set; }
    }
}
