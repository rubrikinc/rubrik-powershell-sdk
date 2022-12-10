// OnedriveSearchObjectType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:53.
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
    public enum OnedriveSearchObjectType
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "O365_FOLDER")]
        O365_FOLDER,

        [EnumMember(Value = "ONEDRIVE_FILE")]
        ONEDRIVE_FILE


    } // enum OnedriveSearchObjectType

} // namespace Rubrik.SecurityCloud.Types