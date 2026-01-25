// ExocomputeBundleStatus.cs
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
    public enum ExocomputeBundleStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BUNDLE_STATUS_LATEST")]
        BUNDLE_STATUS_LATEST,

        [EnumMember(Value = "BUNDLE_STATUS_OUTDATED")]
        BUNDLE_STATUS_OUTDATED,

        [EnumMember(Value = "BUNDLE_STATUS_UNKNOWN")]
        BUNDLE_STATUS_UNKNOWN,

        [EnumMember(Value = "BUNDLE_STATUS_UPDATE_REQUIRED")]
        BUNDLE_STATUS_UPDATE_REQUIRED


    } // enum ExocomputeBundleStatus

} // namespace RubrikSecurityCloud.Types