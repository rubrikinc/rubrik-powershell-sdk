// AzureKeyVaultKeyState.cs
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
    public enum AzureKeyVaultKeyState
    {
        [EnumMember(Value = "CURRENT_KEY_TYPE")]
        CURRENT_KEY_TYPE,

        [EnumMember(Value = "IN_USE_KEY_TYPE")]
        IN_USE_KEY_TYPE,

        [EnumMember(Value = "KEY_STATE_TYPE_UNSPECIFIED")]
        KEY_STATE_TYPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AzureKeyVaultKeyState

} // namespace RubrikSecurityCloud.Types