// HypervLiveMountSortByField.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:37.
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
    public enum HypervLiveMountSortByField
    {
        [EnumMember(Value = "CLUSTER_NAME")]
        CLUSTER_NAME,

        [EnumMember(Value = "CREATION_DATE")]
        CREATION_DATE,

        [EnumMember(Value = "MOUNT_NAME")]
        MOUNT_NAME,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum HypervLiveMountSortByField

} // namespace Rubrik.SecurityCloud.Types