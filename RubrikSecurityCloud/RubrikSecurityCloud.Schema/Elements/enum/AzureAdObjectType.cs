// AzureAdObjectType.cs
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
    public enum AzureAdObjectType
    {
        [EnumMember(Value = "AZURE_AD_OBJECT_TYPE_UNKNOWN")]
        AZURE_AD_OBJECT_TYPE_UNKNOWN,

        [EnumMember(Value = "GROUP")]
        GROUP,

        [EnumMember(Value = "USER")]
        USER


    } // enum AzureAdObjectType

} // namespace RubrikSecurityCloud.Types