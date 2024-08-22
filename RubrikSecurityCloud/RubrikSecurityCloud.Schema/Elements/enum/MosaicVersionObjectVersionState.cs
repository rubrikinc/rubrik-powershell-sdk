// MosaicVersionObjectVersionState.cs
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
    public enum MosaicVersionObjectVersionState
    {
        [EnumMember(Value = "MOSAIC_VERSION_OBJECT_VERSION_STATE_DATA_COPIED")]
        MOSAIC_VERSION_OBJECT_VERSION_STATE_DATA_COPIED,

        [EnumMember(Value = "MOSAIC_VERSION_OBJECT_VERSION_STATE_REPLAYED")]
        MOSAIC_VERSION_OBJECT_VERSION_STATE_REPLAYED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MosaicVersionObjectVersionState

} // namespace RubrikSecurityCloud.Types