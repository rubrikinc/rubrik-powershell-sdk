// AttributeRecoveryMode.cs
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
    public enum AttributeRecoveryMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ATTRIBUTE_RECOVERY_MODE_MERGE")]
        ATTRIBUTE_RECOVERY_MODE_MERGE,

        [EnumMember(Value = "ATTRIBUTE_RECOVERY_MODE_OVERWRITE")]
        ATTRIBUTE_RECOVERY_MODE_OVERWRITE,

        [EnumMember(Value = "ATTRIBUTE_RECOVERY_MODE_UNSPECIFIED")]
        ATTRIBUTE_RECOVERY_MODE_UNSPECIFIED


    } // enum AttributeRecoveryMode

} // namespace RubrikSecurityCloud.Types