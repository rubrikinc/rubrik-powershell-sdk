// EmIncompatibleObjectType.cs
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
    public enum EmIncompatibleObjectType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EM_INCOMPATIBLE_OBJECT_TYPE_ACCESS_PACKAGE")]
        EM_INCOMPATIBLE_OBJECT_TYPE_ACCESS_PACKAGE,

        [EnumMember(Value = "EM_INCOMPATIBLE_OBJECT_TYPE_GROUP")]
        EM_INCOMPATIBLE_OBJECT_TYPE_GROUP,

        [EnumMember(Value = "EM_INCOMPATIBLE_OBJECT_TYPE_UNSPECIFIED")]
        EM_INCOMPATIBLE_OBJECT_TYPE_UNSPECIFIED


    } // enum EmIncompatibleObjectType

} // namespace RubrikSecurityCloud.Types