// CdmDataGuardType.cs
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
    public enum CdmDataGuardType
    {
        [EnumMember(Value = "DATA_GUARD_TYPE_DATA_GUARD_GROUP")]
        DATA_GUARD_TYPE_DATA_GUARD_GROUP,

        [EnumMember(Value = "DATA_GUARD_TYPE_DATA_GUARD_MEMBER")]
        DATA_GUARD_TYPE_DATA_GUARD_MEMBER,

        [EnumMember(Value = "DATA_GUARD_TYPE_NON_DATA_GUARD")]
        DATA_GUARD_TYPE_NON_DATA_GUARD,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CdmDataGuardType

} // namespace RubrikSecurityCloud.Types