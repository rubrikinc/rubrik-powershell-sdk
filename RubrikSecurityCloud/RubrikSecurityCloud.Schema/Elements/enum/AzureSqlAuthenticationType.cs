// AzureSqlAuthenticationType.cs
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
    public enum AzureSqlAuthenticationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AAD_ONLY")]
        AAD_ONLY,

        [EnumMember(Value = "AUTH_TYPE_UNSPECIFIED")]
        AUTH_TYPE_UNSPECIFIED,

        [EnumMember(Value = "SQL_AUTH_AND_AAD")]
        SQL_AUTH_AND_AAD,

        [EnumMember(Value = "SQL_AUTH_ONLY")]
        SQL_AUTH_ONLY


    } // enum AzureSqlAuthenticationType

} // namespace RubrikSecurityCloud.Types