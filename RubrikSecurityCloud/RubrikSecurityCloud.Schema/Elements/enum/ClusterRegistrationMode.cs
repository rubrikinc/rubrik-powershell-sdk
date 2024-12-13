// ClusterRegistrationMode.cs
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
    public enum ClusterRegistrationMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "HYBRID")]
        HYBRID,

        [EnumMember(Value = "LEGACY")]
        LEGACY,

        [EnumMember(Value = "LIFE_OF_DEVICE")]
        LIFE_OF_DEVICE,

        [EnumMember(Value = "NOT_REGISTERED")]
        NOT_REGISTERED


    } // enum ClusterRegistrationMode

} // namespace RubrikSecurityCloud.Types