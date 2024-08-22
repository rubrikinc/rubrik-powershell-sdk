// DlpConfigShareType.cs
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
    public enum DlpConfigShareType
    {
        [EnumMember(Value = "NFS")]
        NFS,

        [EnumMember(Value = "SHARE_TYPE_UNSPECIFIED")]
        SHARE_TYPE_UNSPECIFIED,

        [EnumMember(Value = "SMB")]
        SMB,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum DlpConfigShareType

} // namespace RubrikSecurityCloud.Types