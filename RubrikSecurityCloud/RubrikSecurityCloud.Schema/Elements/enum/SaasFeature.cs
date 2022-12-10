// SaasFeature.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:55.
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
    public enum SaasFeature
    {
        [EnumMember(Value = "TYPE_AAD")]
        TYPE_AAD,

        [EnumMember(Value = "TYPE_CLOUD_DIRECT_HOSTED")]
        TYPE_CLOUD_DIRECT_HOSTED,

        [EnumMember(Value = "TYPE_M365")]
        TYPE_M365


    } // enum SaasFeature

} // namespace Rubrik.SecurityCloud.Types