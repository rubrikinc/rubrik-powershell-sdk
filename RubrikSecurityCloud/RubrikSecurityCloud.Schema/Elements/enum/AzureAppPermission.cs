// AzureAppPermission.cs
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
    public enum AzureAppPermission
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_APP_PERMISSION_UNSPECIFIED")]
        AZURE_APP_PERMISSION_UNSPECIFIED,

        [EnumMember(Value = "AZURE_GRAPH_GROUP_RW")]
        AZURE_GRAPH_GROUP_RW,

        [EnumMember(Value = "AZURE_SQL_IMPERSONATION")]
        AZURE_SQL_IMPERSONATION,

        [EnumMember(Value = "AZURE_STORAGE_IMPERSONATION")]
        AZURE_STORAGE_IMPERSONATION


    } // enum AzureAppPermission

} // namespace RubrikSecurityCloud.Types