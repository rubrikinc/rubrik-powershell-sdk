// FilesetTemplateCreateOperatingSystemType.cs
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
    public enum FilesetTemplateCreateOperatingSystemType
    {
        [EnumMember(Value = "FILESET_TEMPLATE_CREATE_OPERATING_SYSTEM_TYPE_UNIX_LIKE")]
        FILESET_TEMPLATE_CREATE_OPERATING_SYSTEM_TYPE_UNIX_LIKE,

        [EnumMember(Value = "FILESET_TEMPLATE_CREATE_OPERATING_SYSTEM_TYPE_WINDOWS")]
        FILESET_TEMPLATE_CREATE_OPERATING_SYSTEM_TYPE_WINDOWS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum FilesetTemplateCreateOperatingSystemType

} // namespace RubrikSecurityCloud.Types