// SupportCasesSortField.cs
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
    public enum SupportCasesSortField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SORT_FIELD_CASE_NUMBER")]
        SORT_FIELD_CASE_NUMBER,

        [EnumMember(Value = "SORT_FIELD_CREATED_DATE")]
        SORT_FIELD_CREATED_DATE,

        [EnumMember(Value = "SORT_FIELD_PRIORITY")]
        SORT_FIELD_PRIORITY,

        [EnumMember(Value = "SORT_FIELD_STATUS")]
        SORT_FIELD_STATUS,

        [EnumMember(Value = "SORT_FIELD_SUBJECT")]
        SORT_FIELD_SUBJECT,

        [EnumMember(Value = "SORT_FIELD_TYPE")]
        SORT_FIELD_TYPE,

        [EnumMember(Value = "SORT_FIELD_UNSPECIFIED")]
        SORT_FIELD_UNSPECIFIED


    } // enum SupportCasesSortField

} // namespace RubrikSecurityCloud.Types