// ActivityEntityType.cs
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
    public enum ActivityEntityType
    {
        [EnumMember(Value = "IDENTITY")]
        IDENTITY,

        [EnumMember(Value = "SYSTEM")]
        SYSTEM,

        [EnumMember(Value = "TENANT")]
        TENANT,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ActivityEntityType

} // namespace RubrikSecurityCloud.Types