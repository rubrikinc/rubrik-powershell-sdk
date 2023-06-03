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

namespace Rubrik.SecurityCloud.Types
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
        LOGIN


    } // enum ContractType

} // namespace Rubrik.SecurityCloud.Types