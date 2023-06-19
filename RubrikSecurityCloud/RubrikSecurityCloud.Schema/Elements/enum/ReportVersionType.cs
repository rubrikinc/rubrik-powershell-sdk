// ReportVersionType.cs
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
    public enum ReportVersionType
    {
        [EnumMember(Value = "NG_REPORT")]
        NG_REPORT,

        [EnumMember(Value = "NG_REPORT_ALPHA")]
        NG_REPORT_ALPHA,

        [EnumMember(Value = "OLD_REPORT")]
        OLD_REPORT


    } // enum ReportVersionType

} // namespace RubrikSecurityCloud.Types