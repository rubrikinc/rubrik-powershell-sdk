// ArchivalPerObjectInfoFilterField.cs
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
    public enum ArchivalPerObjectInfoFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FILTER_FIELD_UNSPECIFIED")]
        FILTER_FIELD_UNSPECIFIED,

        [EnumMember(Value = "OBJECT_NAME")]
        OBJECT_NAME,

        [EnumMember(Value = "OBJECT_STATUS")]
        OBJECT_STATUS,

        [EnumMember(Value = "OBJECT_TYPE")]
        OBJECT_TYPE,

        [EnumMember(Value = "SLA_DOMAIN")]
        SLA_DOMAIN


    } // enum ArchivalPerObjectInfoFilterField

} // namespace RubrikSecurityCloud.Types