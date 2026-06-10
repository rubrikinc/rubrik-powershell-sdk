// SlaPurpose.cs
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
    public enum SlaPurpose
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BACKUP_AS_A_SERVICE")]
        BACKUP_AS_A_SERVICE,

        [EnumMember(Value = "GENERAL")]
        GENERAL


    } // enum SlaPurpose

} // namespace RubrikSecurityCloud.Types