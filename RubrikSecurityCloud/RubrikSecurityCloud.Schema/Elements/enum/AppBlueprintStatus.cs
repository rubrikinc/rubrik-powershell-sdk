// AppBlueprintStatus.cs
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
    public enum AppBlueprintStatus
    {
        [EnumMember(Value = "Creating")]
        CREATING,

        [EnumMember(Value = "Deleted")]
        DELETED,

        [EnumMember(Value = "Deleting")]
        DELETING,

        [EnumMember(Value = "Ready")]
        READY,

        [EnumMember(Value = "Updating")]
        UPDATING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AppBlueprintStatus

} // namespace RubrikSecurityCloud.Types