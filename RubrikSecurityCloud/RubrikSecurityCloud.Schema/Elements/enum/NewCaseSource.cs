// NewCaseSource.cs
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
    public enum NewCaseSource
    {
        [EnumMember(Value = "CASE_CATEGORY_UNSPECIFIED")]
        CASE_CATEGORY_UNSPECIFIED,

        [EnumMember(Value = "CYBER_EVENT_LOCKDOWN")]
        CYBER_EVENT_LOCKDOWN,

        [EnumMember(Value = "MIGRATION")]
        MIGRATION,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum NewCaseSource

} // namespace RubrikSecurityCloud.Types