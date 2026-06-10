// PolicyViolationSortField.cs
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
    public enum PolicyViolationSortField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SORT_ACCESSIBLE_OBJECTS")]
        SORT_ACCESSIBLE_OBJECTS,

        [EnumMember(Value = "SORT_CATEGORY")]
        SORT_CATEGORY,

        [EnumMember(Value = "SORT_DETECTION_TIME")]
        SORT_DETECTION_TIME,

        [EnumMember(Value = "SORT_EVENT_TIME")]
        SORT_EVENT_TIME,

        [EnumMember(Value = "SORT_FILES_AT_RISK")]
        SORT_FILES_AT_RISK,

        [EnumMember(Value = "SORT_HITS")]
        SORT_HITS,

        [EnumMember(Value = "SORT_IDENTITY_NAME")]
        SORT_IDENTITY_NAME,

        [EnumMember(Value = "SORT_IDENTITY_TYPE")]
        SORT_IDENTITY_TYPE,

        [EnumMember(Value = "SORT_NAME")]
        SORT_NAME,

        [EnumMember(Value = "SORT_ORIGIN")]
        SORT_ORIGIN,

        [EnumMember(Value = "SORT_SEVERITY")]
        SORT_SEVERITY,

        [EnumMember(Value = "SORT_SOURCE")]
        SORT_SOURCE,

        [EnumMember(Value = "SORT_STATUS")]
        SORT_STATUS,

        [EnumMember(Value = "SORT_TITLE")]
        SORT_TITLE,

        [EnumMember(Value = "SORT_TOTAL_HITS")]
        SORT_TOTAL_HITS,

        [EnumMember(Value = "SORT_TYPE")]
        SORT_TYPE,

        [EnumMember(Value = "SORT_UNSPECIFIED")]
        SORT_UNSPECIFIED,

        [EnumMember(Value = "SORT_UPDATE_TIME")]
        SORT_UPDATE_TIME


    } // enum PolicyViolationSortField

} // namespace RubrikSecurityCloud.Types