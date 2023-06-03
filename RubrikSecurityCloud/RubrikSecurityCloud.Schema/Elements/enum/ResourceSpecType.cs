// ResourceSpecType.cs
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
    public enum ResourceSpecType
    {
        [EnumMember(Value = "INSTANCE")]
        INSTANCE,

        [EnumMember(Value = "TEMPLATE")]
        TEMPLATE,

        [EnumMember(Value = "UNKNOWN_SPEC_TYPE")]
        UNKNOWN_SPEC_TYPE


    } // enum ResourceSpecType

} // namespace Rubrik.SecurityCloud.Types