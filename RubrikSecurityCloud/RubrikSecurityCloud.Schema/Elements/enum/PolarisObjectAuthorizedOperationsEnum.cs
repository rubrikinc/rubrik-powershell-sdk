// PolarisObjectAuthorizedOperationsEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:08.
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
    public enum PolarisObjectAuthorizedOperationsEnum
    {
        [EnumMember(Value = "MANAGE_DATA_SOURCE")]
        MANAGE_DATA_SOURCE,

        [EnumMember(Value = "MANAGE_PROTECTION")]
        MANAGE_PROTECTION,

        [EnumMember(Value = "REFRESH_DATA_SOURCE")]
        REFRESH_DATA_SOURCE,

        [EnumMember(Value = "VIEW_INVENTORY")]
        VIEW_INVENTORY


    } // enum PolarisObjectAuthorizedOperationsEnum

} // namespace Rubrik.SecurityCloud.Types