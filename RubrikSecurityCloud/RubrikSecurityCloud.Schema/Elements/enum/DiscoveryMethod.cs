// DiscoveryMethod.cs
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
    public enum DiscoveryMethod
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AUTO_DISCOVERY")]
        AUTO_DISCOVERY,

        [EnumMember(Value = "MANUALLY_SELECTED")]
        MANUALLY_SELECTED,

        [EnumMember(Value = "TAG_BASED")]
        TAG_BASED


    } // enum DiscoveryMethod

} // namespace RubrikSecurityCloud.Types