// SlaStatusFilterField.cs
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
    public enum SlaStatusFilterField
    {
        [EnumMember(Value = "CLUSTER_NAME")]
        CLUSTER_NAME,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "PAUSE_STATUS")]
        PAUSE_STATUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SlaStatusFilterField

} // namespace RubrikSecurityCloud.Types