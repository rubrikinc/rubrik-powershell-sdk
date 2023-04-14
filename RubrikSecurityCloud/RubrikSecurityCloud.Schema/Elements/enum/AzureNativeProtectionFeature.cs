// AzureNativeProtectionFeature.cs
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
    public enum AzureNativeProtectionFeature
    {
        [EnumMember(Value = "BLOB")]
        BLOB,

        [EnumMember(Value = "SQL_DB")]
        SQL_DB,

        [EnumMember(Value = "SQL_MI")]
        SQL_MI,

        [EnumMember(Value = "VM")]
        VM


    } // enum AzureNativeProtectionFeature

} // namespace Rubrik.SecurityCloud.Types