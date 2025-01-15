// ResetAfterRemoveType.cs
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
    public enum ResetAfterRemoveType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NO_RESET")]
        NO_RESET,

        [EnumMember(Value = "PRESERVE_HDDS")]
        PRESERVE_HDDS,

        [EnumMember(Value = "RESET_ALL")]
        RESET_ALL


    } // enum ResetAfterRemoveType

} // namespace RubrikSecurityCloud.Types