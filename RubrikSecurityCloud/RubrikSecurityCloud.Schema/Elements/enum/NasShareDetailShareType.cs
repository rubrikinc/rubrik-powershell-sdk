// NasShareDetailShareType.cs
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
    public enum NasShareDetailShareType
    {
        [EnumMember(Value = "NAS_SHARE_DETAIL_SHARE_TYPE_NFS")]
        NAS_SHARE_DETAIL_SHARE_TYPE_NFS,

        [EnumMember(Value = "NAS_SHARE_DETAIL_SHARE_TYPE_SMB")]
        NAS_SHARE_DETAIL_SHARE_TYPE_SMB,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum NasShareDetailShareType

} // namespace RubrikSecurityCloud.Types