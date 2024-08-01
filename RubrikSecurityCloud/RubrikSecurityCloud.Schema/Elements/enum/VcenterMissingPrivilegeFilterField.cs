// VcenterMissingPrivilegeFilterField.cs
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
    public enum VcenterMissingPrivilegeFilterField
    {
        [EnumMember(Value = "ENTITY_TYPE")]
        ENTITY_TYPE,

        [EnumMember(Value = "FIELD_UNSPECIFIED")]
        FIELD_UNSPECIFIED,

        [EnumMember(Value = "INCLUDE_COUNT")]
        INCLUDE_COUNT,

        [EnumMember(Value = "ONLY_INCLUDE_ENTITIES_WITH_MISSING_PRIVILEGES")]
        ONLY_INCLUDE_ENTITIES_WITH_MISSING_PRIVILEGES,

        [EnumMember(Value = "SEARCH_BY_NAME")]
        SEARCH_BY_NAME,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum VcenterMissingPrivilegeFilterField

} // namespace RubrikSecurityCloud.Types