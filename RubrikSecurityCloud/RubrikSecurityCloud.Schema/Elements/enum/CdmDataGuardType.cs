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

namespace Rubrik.SecurityCloud.Types
{
    public enum CdmDataGuardType
    {
        [EnumMember(Value = "DATA_GUARD_TYPE_DATA_GUARD_GROUP")]
        DATA_GUARD_TYPE_DATA_GUARD_GROUP,

        [EnumMember(Value = "DATA_GUARD_TYPE_DATA_GUARD_MEMBER")]
        DATA_GUARD_TYPE_DATA_GUARD_MEMBER,

        [EnumMember(Value = "DATA_GUARD_TYPE_NON_DATA_GUARD")]
        DATA_GUARD_TYPE_NON_DATA_GUARD


    } // enum CdmDataGuardType

} // namespace Rubrik.SecurityCloud.Types