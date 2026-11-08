// FeatureRegionState.cs
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
    public enum FeatureRegionState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FEATURE_REGION_STATE_CONNECTED")]
        FEATURE_REGION_STATE_CONNECTED,

        [EnumMember(Value = "FEATURE_REGION_STATE_NOT_CONNECTED")]
        FEATURE_REGION_STATE_NOT_CONNECTED


    } // enum FeatureRegionState

} // namespace RubrikSecurityCloud.Types