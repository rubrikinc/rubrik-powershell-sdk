// ShareTypeEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:32.
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
    public enum ShareTypeEnum
    {
        [EnumMember(Value = "NFS")]
        NFS,

        [EnumMember(Value = "NoShareType")]
        NO_SHARE_TYPE,

        [EnumMember(Value = "SMB")]
        SMB


    } // enum ShareTypeEnum

} // namespace Rubrik.SecurityCloud.Types