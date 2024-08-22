// FilesetTemplatePatchShareType.cs
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
    public enum FilesetTemplatePatchShareType
    {
        [EnumMember(Value = "FILESET_TEMPLATE_PATCH_SHARE_TYPE_NFS")]
        FILESET_TEMPLATE_PATCH_SHARE_TYPE_NFS,

        [EnumMember(Value = "FILESET_TEMPLATE_PATCH_SHARE_TYPE_SMB")]
        FILESET_TEMPLATE_PATCH_SHARE_TYPE_SMB,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum FilesetTemplatePatchShareType

} // namespace RubrikSecurityCloud.Types