// AnalyzerErrorCode.cs
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
    public enum AnalyzerErrorCode
    {
        [EnumMember(Value = "ANALYZER")]
        ANALYZER,

        [EnumMember(Value = "NOERROR")]
        NOERROR,

        [EnumMember(Value = "OTHER")]
        OTHER,

        [EnumMember(Value = "PARSING")]
        PARSING,

        [EnumMember(Value = "READING")]
        READING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AnalyzerErrorCode

} // namespace RubrikSecurityCloud.Types