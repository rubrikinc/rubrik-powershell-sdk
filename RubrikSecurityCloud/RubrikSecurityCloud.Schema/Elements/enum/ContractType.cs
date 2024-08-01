// ContractType.cs
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
    public enum ContractType
    {
        [EnumMember(Value = "CDM_REGISTRATION_HYBRID")]
        CDM_REGISTRATION_HYBRID,

        [EnumMember(Value = "CDM_REGISTRATION_LOD")]
        CDM_REGISTRATION_LOD,

        [EnumMember(Value = "CONTRACT_TYPE_UNSPECIFIED")]
        CONTRACT_TYPE_UNSPECIFIED,

        [EnumMember(Value = "LOGIN")]
        LOGIN,

        [EnumMember(Value = "M365_TRIAL")]
        M365_TRIAL,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ContractType

} // namespace RubrikSecurityCloud.Types