// PolarisSnappableAuthorizedOperationsEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:09.
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
    public enum PolarisSnappableAuthorizedOperationsEnum
    {
        [EnumMember(Value = "DELETE_SNAPSHOT")]
        DELETE_SNAPSHOT,

        [EnumMember(Value = "DOWNLOAD")]
        DOWNLOAD,

        [EnumMember(Value = "EXPORT_SNAPSHOTS")]
        EXPORT_SNAPSHOTS,

        [EnumMember(Value = "MANAGE_PROTECTION")]
        MANAGE_PROTECTION,

        [EnumMember(Value = "RESTORE_TO_ORIGIN")]
        RESTORE_TO_ORIGIN,

        [EnumMember(Value = "TAKE_ON_DEMAND_SNAPSHOT")]
        TAKE_ON_DEMAND_SNAPSHOT,

        [EnumMember(Value = "VIEW_INVENTORY")]
        VIEW_INVENTORY


    } // enum PolarisSnappableAuthorizedOperationsEnum

} // namespace Rubrik.SecurityCloud.Types