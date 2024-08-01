// CcpClusterType.cs
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
    public enum CcpClusterType
    {
        [EnumMember(Value = "CLOUD")]
        CLOUD,

        [EnumMember(Value = "ON_PREM")]
        ON_PREM,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CcpClusterType

} // namespace RubrikSecurityCloud.Types