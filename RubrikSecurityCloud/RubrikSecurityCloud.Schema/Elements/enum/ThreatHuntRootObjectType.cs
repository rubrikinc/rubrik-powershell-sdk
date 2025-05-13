// ThreatHuntRootObjectType.cs
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
    public enum ThreatHuntRootObjectType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_NATIVE_ACCOUNT")]
        AWS_NATIVE_ACCOUNT,

        [EnumMember(Value = "AZURE_NATIVE_SUBSCRIPTION")]
        AZURE_NATIVE_SUBSCRIPTION,

        [EnumMember(Value = "CDM_CLUSTER")]
        CDM_CLUSTER,

        [EnumMember(Value = "M365_SUBSCRIPTION")]
        M365_SUBSCRIPTION


    } // enum ThreatHuntRootObjectType

} // namespace RubrikSecurityCloud.Types