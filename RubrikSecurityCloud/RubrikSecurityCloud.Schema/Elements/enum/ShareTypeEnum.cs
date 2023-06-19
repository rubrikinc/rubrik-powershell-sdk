// ShareTypeEnum.cs
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
    public enum ShareTypeEnum
    {
        [EnumMember(Value = "NFS")]
        NFS,

        [EnumMember(Value = "NoShareType")]
        NO_SHARE_TYPE,

        [EnumMember(Value = "SMB")]
        SMB


    } // enum ShareTypeEnum

} // namespace RubrikSecurityCloud.Types