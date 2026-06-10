// EmResourceType.cs
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
    public enum EmResourceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EM_RESOURCE_TYPE_AAD_APPLICATION")]
        EM_RESOURCE_TYPE_AAD_APPLICATION,

        [EnumMember(Value = "EM_RESOURCE_TYPE_AAD_GROUP")]
        EM_RESOURCE_TYPE_AAD_GROUP,

        [EnumMember(Value = "EM_RESOURCE_TYPE_DIRECTORY_ROLE")]
        EM_RESOURCE_TYPE_DIRECTORY_ROLE,

        [EnumMember(Value = "EM_RESOURCE_TYPE_OAUTH_APPLICATION")]
        EM_RESOURCE_TYPE_OAUTH_APPLICATION,

        [EnumMember(Value = "EM_RESOURCE_TYPE_SHAREPOINT_ONLINE")]
        EM_RESOURCE_TYPE_SHAREPOINT_ONLINE,

        [EnumMember(Value = "EM_RESOURCE_TYPE_UNSPECIFIED")]
        EM_RESOURCE_TYPE_UNSPECIFIED


    } // enum EmResourceType

} // namespace RubrikSecurityCloud.Types