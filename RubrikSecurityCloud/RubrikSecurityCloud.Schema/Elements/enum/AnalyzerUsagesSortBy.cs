// AnalyzerUsagesSortBy.cs
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
    public enum AnalyzerUsagesSortBy
    {
        [EnumMember(Value = "DATA_TYPE_HITS")]
        DATA_TYPE_HITS,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "SENSITIVITY")]
        SENSITIVITY,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AnalyzerUsagesSortBy

} // namespace RubrikSecurityCloud.Types