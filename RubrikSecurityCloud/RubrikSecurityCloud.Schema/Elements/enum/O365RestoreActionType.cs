// O365RestoreActionType.cs
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
    public enum O365RestoreActionType
    {
        [EnumMember(Value = "EXPORT_FAILED_ITEMS_FOR_SNAPPABLE")]
        EXPORT_FAILED_ITEMS_FOR_SNAPPABLE,

        [EnumMember(Value = "EXPORT_SNAPPABLE")]
        EXPORT_SNAPPABLE,

        [EnumMember(Value = "INPLACE_RESTORE_SNAPPABLE")]
        INPLACE_RESTORE_SNAPPABLE,

        [EnumMember(Value = "RESTORE_SNAPPABLE")]
        RESTORE_SNAPPABLE


    } // enum O365RestoreActionType

} // namespace RubrikSecurityCloud.Types