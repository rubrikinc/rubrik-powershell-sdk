// AzureAdAppSetupWarningType.cs
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
    public enum AzureAdAppSetupWarningType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "COMMERCIAL_TENANT_ON_RSC_FEDRAMP")]
        COMMERCIAL_TENANT_ON_RSC_FEDRAMP,

        [EnumMember(Value = "GCC_TENANT_ON_RSC_COMMERCIAL")]
        GCC_TENANT_ON_RSC_COMMERCIAL,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum AzureAdAppSetupWarningType

} // namespace RubrikSecurityCloud.Types