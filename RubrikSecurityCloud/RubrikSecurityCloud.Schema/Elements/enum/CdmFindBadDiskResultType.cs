// CdmFindBadDiskResultType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:16.
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
    public enum CdmFindBadDiskResultType
    {
        [EnumMember(Value = "FIND_BAD_DISK_RESULT_ENUM_FAILED")]
        FIND_BAD_DISK_RESULT_ENUM_FAILED,

        [EnumMember(Value = "FIND_BAD_DISK_RESULT_ENUM_MISSING")]
        FIND_BAD_DISK_RESULT_ENUM_MISSING,

        [EnumMember(Value = "FIND_BAD_DISK_RESULT_ENUM_OKAY")]
        FIND_BAD_DISK_RESULT_ENUM_OKAY,

        [EnumMember(Value = "FIND_BAD_DISK_RESULT_ENUM_TURNED_OFF")]
        FIND_BAD_DISK_RESULT_ENUM_TURNED_OFF


    } // enum CdmFindBadDiskResultType

} // namespace Rubrik.SecurityCloud.Types