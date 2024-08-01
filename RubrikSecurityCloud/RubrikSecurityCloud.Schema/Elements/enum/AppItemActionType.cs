// AppItemActionType.cs
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
    public enum AppItemActionType
    {
        [EnumMember(Value = "ACTION_TYPE_ADDED")]
        ACTION_TYPE_ADDED,

        [EnumMember(Value = "ACTION_TYPE_DELETED")]
        ACTION_TYPE_DELETED,

        [EnumMember(Value = "ACTION_TYPE_MODIFIED")]
        ACTION_TYPE_MODIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AppItemActionType

} // namespace RubrikSecurityCloud.Types