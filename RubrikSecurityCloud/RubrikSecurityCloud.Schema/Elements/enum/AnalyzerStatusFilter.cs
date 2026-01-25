// AnalyzerStatusFilter.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Types
{
    public enum AnalyzerStatusFilter
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE_ANALYZERS")]
        ACTIVE_ANALYZERS,

        [EnumMember(Value = "ALL_ANALYZERS")]
        ALL_ANALYZERS,

        [EnumMember(Value = "INACTIVE_ANALYZERS")]
        INACTIVE_ANALYZERS


    } // enum AnalyzerStatusFilter

} // namespace RubrikSecurityCloud.Types