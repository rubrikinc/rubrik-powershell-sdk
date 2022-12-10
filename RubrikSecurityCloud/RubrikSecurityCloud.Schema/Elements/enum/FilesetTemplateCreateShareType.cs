// FilesetTemplateCreateShareType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:25.
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
    public enum FilesetTemplateCreateShareType
    {
        [EnumMember(Value = "FILESET_TEMPLATE_CREATE_SHARE_TYPE_NFS")]
        FILESET_TEMPLATE_CREATE_SHARE_TYPE_NFS,

        [EnumMember(Value = "FILESET_TEMPLATE_CREATE_SHARE_TYPE_SMB")]
        FILESET_TEMPLATE_CREATE_SHARE_TYPE_SMB


    } // enum FilesetTemplateCreateShareType

} // namespace Rubrik.SecurityCloud.Types