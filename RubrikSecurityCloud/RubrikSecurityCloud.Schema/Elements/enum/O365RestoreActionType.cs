// O365RestoreActionType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:32.
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
    public enum O365RestoreActionType
    {
        [EnumMember(Value = "EXPORT_SNAPPABLE")]
        EXPORT_SNAPPABLE,

        [EnumMember(Value = "RESTORE_SNAPPABLE")]
        RESTORE_SNAPPABLE


    } // enum O365RestoreActionType

} // namespace Rubrik.SecurityCloud.Types