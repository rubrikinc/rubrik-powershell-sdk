// RestoreFailedItemsExportDisabledReason.cs
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
    public enum RestoreFailedItemsExportDisabledReason
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ITEMS_COUNT_LIMIT_EXCEEDED")]
        ITEMS_COUNT_LIMIT_EXCEEDED,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        [EnumMember(Value = "UNSUPPORTED_WORKLOAD_TYPE")]
        UNSUPPORTED_WORKLOAD_TYPE


    } // enum RestoreFailedItemsExportDisabledReason

} // namespace RubrikSecurityCloud.Types