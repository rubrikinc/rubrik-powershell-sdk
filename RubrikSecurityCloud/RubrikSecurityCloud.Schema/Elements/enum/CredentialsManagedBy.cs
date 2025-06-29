// CredentialsManagedBy.cs
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
    public enum CredentialsManagedBy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CUSTOMER_MANAGED_GLOBAL")]
        CUSTOMER_MANAGED_GLOBAL,

        [EnumMember(Value = "CUSTOMER_MANAGED_PROJECT")]
        CUSTOMER_MANAGED_PROJECT,

        [EnumMember(Value = "RUBRIK_MANAGED")]
        RUBRIK_MANAGED,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum CredentialsManagedBy

} // namespace RubrikSecurityCloud.Types