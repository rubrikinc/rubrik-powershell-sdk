// KmipServerKeyAssignmentInfoSortBy.cs
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
    public enum KmipServerKeyAssignmentInfoSortBy
    {
        [EnumMember(Value = "KMIP_SERVER_KEY_BY_CERTIFICATE_NAME")]
        KMIP_SERVER_KEY_BY_CERTIFICATE_NAME,

        [EnumMember(Value = "KMIP_SERVER_KEY_BY_CLUSTER_NAME")]
        KMIP_SERVER_KEY_BY_CLUSTER_NAME,

        [EnumMember(Value = "KMIP_SERVER_KEY_SORT_BY_UNSPECIFIED")]
        KMIP_SERVER_KEY_SORT_BY_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum KmipServerKeyAssignmentInfoSortBy

} // namespace RubrikSecurityCloud.Types