// OpenstackImageVisibilityType.cs
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
    public enum OpenstackImageVisibilityType
    {
        [EnumMember(Value = "COMMUNITY")]
        COMMUNITY,

        [EnumMember(Value = "PRIVATE")]
        PRIVATE,

        [EnumMember(Value = "PUBLIC")]
        PUBLIC,

        [EnumMember(Value = "SHARED")]
        SHARED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum OpenstackImageVisibilityType

} // namespace RubrikSecurityCloud.Types