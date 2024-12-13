// MosaicRecoverableRangeRequestSourceType.cs
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
    public enum MosaicRecoverableRangeRequestSourceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MOSAIC_RECOVERABLE_RANGE_REQUEST_SOURCE_TYPE_CASSANDRA")]
        MOSAIC_RECOVERABLE_RANGE_REQUEST_SOURCE_TYPE_CASSANDRA,

        [EnumMember(Value = "MOSAIC_RECOVERABLE_RANGE_REQUEST_SOURCE_TYPE_MONGO")]
        MOSAIC_RECOVERABLE_RANGE_REQUEST_SOURCE_TYPE_MONGO


    } // enum MosaicRecoverableRangeRequestSourceType

} // namespace RubrikSecurityCloud.Types