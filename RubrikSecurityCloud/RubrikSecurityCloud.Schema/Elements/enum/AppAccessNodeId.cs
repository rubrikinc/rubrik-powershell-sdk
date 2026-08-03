// AppAccessNodeId.cs
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
    public enum AppAccessNodeId
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "APP_ACCESS_NODE_ID_DIRECT_APPLICATIONS")]
        APP_ACCESS_NODE_ID_DIRECT_APPLICATIONS,

        [EnumMember(Value = "APP_ACCESS_NODE_ID_IMPACTED_APPS_ACCESS_CHANGED")]
        APP_ACCESS_NODE_ID_IMPACTED_APPS_ACCESS_CHANGED,

        [EnumMember(Value = "APP_ACCESS_NODE_ID_IMPACTED_APPS_PATH_CHANGED")]
        APP_ACCESS_NODE_ID_IMPACTED_APPS_PATH_CHANGED,

        [EnumMember(Value = "APP_ACCESS_NODE_ID_IMPACTED_GROUPS")]
        APP_ACCESS_NODE_ID_IMPACTED_GROUPS,

        [EnumMember(Value = "APP_ACCESS_NODE_ID_INDIRECT_APPLICATIONS")]
        APP_ACCESS_NODE_ID_INDIRECT_APPLICATIONS,

        [EnumMember(Value = "APP_ACCESS_NODE_ID_INDIRECT_GROUPS")]
        APP_ACCESS_NODE_ID_INDIRECT_GROUPS,

        [EnumMember(Value = "APP_ACCESS_NODE_ID_UNSPECIFIED")]
        APP_ACCESS_NODE_ID_UNSPECIFIED,

        [EnumMember(Value = "APP_ACCESS_NODE_ID_USER")]
        APP_ACCESS_NODE_ID_USER


    } // enum AppAccessNodeId

} // namespace RubrikSecurityCloud.Types