// GetCrossAccountClustersFilterField.cs
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
    public enum GetCrossAccountClustersFilterField
    {
        [EnumMember(Value = "CLUSTER_NAME")]
        CLUSTER_NAME,

        [EnumMember(Value = "FILTER_FIELD_UNSPECIFIED")]
        FILTER_FIELD_UNSPECIFIED,

        [EnumMember(Value = "ORG_ID")]
        ORG_ID,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum GetCrossAccountClustersFilterField

} // namespace RubrikSecurityCloud.Types