// AzureAdServicePrincipalEnumType.cs
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
    public enum AzureAdServicePrincipalEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SERVICE_PRINCIPAL_TYPE_APPLICATION")]
        SERVICE_PRINCIPAL_TYPE_APPLICATION,

        [EnumMember(Value = "SERVICE_PRINCIPAL_TYPE_LEGACY")]
        SERVICE_PRINCIPAL_TYPE_LEGACY,

        [EnumMember(Value = "SERVICE_PRINCIPAL_TYPE_MANAGED_IDENTITY")]
        SERVICE_PRINCIPAL_TYPE_MANAGED_IDENTITY,

        [EnumMember(Value = "SERVICE_PRINCIPAL_TYPE_UNKNOWN")]
        SERVICE_PRINCIPAL_TYPE_UNKNOWN


    } // enum AzureAdServicePrincipalEnumType

} // namespace RubrikSecurityCloud.Types