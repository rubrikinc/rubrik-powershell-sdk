// RequiredPrivilegeEntityType.cs
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
    public enum RequiredPrivilegeEntityType
    {
        [EnumMember(Value = "REQUIRED_PRIVILEGE_ENTITY_TYPE_CLUSTER")]
        REQUIRED_PRIVILEGE_ENTITY_TYPE_CLUSTER,

        [EnumMember(Value = "REQUIRED_PRIVILEGE_ENTITY_TYPE_DATA_STORE")]
        REQUIRED_PRIVILEGE_ENTITY_TYPE_DATA_STORE,

        [EnumMember(Value = "REQUIRED_PRIVILEGE_ENTITY_TYPE_ES_XI_HOST")]
        REQUIRED_PRIVILEGE_ENTITY_TYPE_ES_XI_HOST,

        [EnumMember(Value = "REQUIRED_PRIVILEGE_ENTITY_TYPE_NETWORK")]
        REQUIRED_PRIVILEGE_ENTITY_TYPE_NETWORK,

        [EnumMember(Value = "REQUIRED_PRIVILEGE_ENTITY_TYPE_PROFILE_DRIVEN_STORAGE")]
        REQUIRED_PRIVILEGE_ENTITY_TYPE_PROFILE_DRIVEN_STORAGE,

        [EnumMember(Value = "REQUIRED_PRIVILEGE_ENTITY_TYPE_RESOURCE_POOL")]
        REQUIRED_PRIVILEGE_ENTITY_TYPE_RESOURCE_POOL,

        [EnumMember(Value = "REQUIRED_PRIVILEGE_ENTITY_TYPE_SESSION")]
        REQUIRED_PRIVILEGE_ENTITY_TYPE_SESSION,

        [EnumMember(Value = "REQUIRED_PRIVILEGE_ENTITY_TYPE_VM")]
        REQUIRED_PRIVILEGE_ENTITY_TYPE_VM,

        [EnumMember(Value = "REQUIRED_PRIVILEGE_ENTITY_TYPE_VM_FOLDER")]
        REQUIRED_PRIVILEGE_ENTITY_TYPE_VM_FOLDER,

        [EnumMember(Value = "REQUIRED_PRIVILEGE_ENTITY_TYPE_V_CENTER")]
        REQUIRED_PRIVILEGE_ENTITY_TYPE_V_CENTER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RequiredPrivilegeEntityType

} // namespace RubrikSecurityCloud.Types