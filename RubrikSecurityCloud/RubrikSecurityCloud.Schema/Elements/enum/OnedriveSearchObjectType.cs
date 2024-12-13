// OnedriveSearchObjectType.cs
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
    public enum OnedriveSearchObjectType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "O365_FOLDER")]
        O365_FOLDER,

        [EnumMember(Value = "ONEDRIVE_FILE")]
        ONEDRIVE_FILE


    } // enum OnedriveSearchObjectType

} // namespace RubrikSecurityCloud.Types