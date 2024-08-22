// ActiveDirectoryObjectType.cs
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
    public enum ActiveDirectoryObjectType
    {
        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_TYPE_BUILTIN_DOMAIN")]
        ACTIVE_DIRECTORY_OBJECT_TYPE_BUILTIN_DOMAIN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_TYPE_CHILD_DOMAIN")]
        ACTIVE_DIRECTORY_OBJECT_TYPE_CHILD_DOMAIN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_TYPE_COMPUTER")]
        ACTIVE_DIRECTORY_OBJECT_TYPE_COMPUTER,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_TYPE_CONTACT")]
        ACTIVE_DIRECTORY_OBJECT_TYPE_CONTACT,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_TYPE_CONTAINER")]
        ACTIVE_DIRECTORY_OBJECT_TYPE_CONTAINER,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_TYPE_DOMAIN_ROOT")]
        ACTIVE_DIRECTORY_OBJECT_TYPE_DOMAIN_ROOT,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_TYPE_GROUP")]
        ACTIVE_DIRECTORY_OBJECT_TYPE_GROUP,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_TYPE_GROUP_POLICY_OBJECT")]
        ACTIVE_DIRECTORY_OBJECT_TYPE_GROUP_POLICY_OBJECT,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_TYPE_MS_FVE_RECOVERY_INFORMATION")]
        ACTIVE_DIRECTORY_OBJECT_TYPE_MS_FVE_RECOVERY_INFORMATION,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_TYPE_ORGANIZATION_UNIT")]
        ACTIVE_DIRECTORY_OBJECT_TYPE_ORGANIZATION_UNIT,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_TYPE_UNKNOWN")]
        ACTIVE_DIRECTORY_OBJECT_TYPE_UNKNOWN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_TYPE_USER")]
        ACTIVE_DIRECTORY_OBJECT_TYPE_USER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ActiveDirectoryObjectType

} // namespace RubrikSecurityCloud.Types