// SupportCaseStatusFilter.cs
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
    public enum SupportCaseStatusFilter
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SUPPORT_CASE_FILTER_CLOSED")]
        SUPPORT_CASE_FILTER_CLOSED,

        [EnumMember(Value = "SUPPORT_CASE_FILTER_OPEN")]
        SUPPORT_CASE_FILTER_OPEN,

        [EnumMember(Value = "SUPPORT_CASE_FILTER_UNSPECIFIED")]
        SUPPORT_CASE_FILTER_UNSPECIFIED


    } // enum SupportCaseStatusFilter

} // namespace RubrikSecurityCloud.Types