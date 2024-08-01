// CreateNasShareInputShareType.cs
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
    public enum CreateNasShareInputShareType
    {
        [EnumMember(Value = "CREATE_NAS_SHARE_INPUT_SHARE_TYPE_NFS")]
        CREATE_NAS_SHARE_INPUT_SHARE_TYPE_NFS,

        [EnumMember(Value = "CREATE_NAS_SHARE_INPUT_SHARE_TYPE_SMB")]
        CREATE_NAS_SHARE_INPUT_SHARE_TYPE_SMB,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CreateNasShareInputShareType

} // namespace RubrikSecurityCloud.Types