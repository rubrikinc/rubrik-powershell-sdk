// ConnectedThroughEnumType.cs
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
    public enum ConnectedThroughEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CDM")]
        CDM,

        [EnumMember(Value = "NAS_DA")]
        NAS_DA,

        [EnumMember(Value = "SRC_UNSPECIFIED")]
        SRC_UNSPECIFIED


    } // enum ConnectedThroughEnumType

} // namespace RubrikSecurityCloud.Types