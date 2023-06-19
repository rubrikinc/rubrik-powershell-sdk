// CloudNativeLabelObjectType.cs
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
    public enum CloudNativeLabelObjectType
    {
        [EnumMember(Value = "GCP_DISK")]
        GCP_DISK,

        [EnumMember(Value = "GCP_GCE_INSTANCE")]
        GCP_GCE_INSTANCE


    } // enum CloudNativeLabelObjectType

} // namespace RubrikSecurityCloud.Types