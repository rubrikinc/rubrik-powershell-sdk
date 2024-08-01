// AzureAdObjectCommonSearchType.cs
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
    public enum AzureAdObjectCommonSearchType
    {
        [EnumMember(Value = "ID")]
        ID,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "ON_PREM_SYNC_STATUS")]
        ON_PREM_SYNC_STATUS,

        [EnumMember(Value = "SNAPSHOT_NUMBER")]
        SNAPSHOT_NUMBER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AzureAdObjectCommonSearchType

} // namespace RubrikSecurityCloud.Types