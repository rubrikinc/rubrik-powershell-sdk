// CloudNativeLocTemplateType.cs
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
    public enum CloudNativeLocTemplateType
    {
        [EnumMember(Value = "INVALID")]
        INVALID,

        [EnumMember(Value = "SOURCE_REGION")]
        SOURCE_REGION,

        [EnumMember(Value = "SPECIFIC_REGION")]
        SPECIFIC_REGION


    } // enum CloudNativeLocTemplateType

} // namespace Rubrik.SecurityCloud.Types