// MosaicVersionObjectVersionState.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:18.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum MosaicVersionObjectVersionState
    {
        [EnumMember(Value = "MOSAIC_VERSION_OBJECT_VERSION_STATE_DATA_COPIED")]
        MOSAIC_VERSION_OBJECT_VERSION_STATE_DATA_COPIED,

        [EnumMember(Value = "MOSAIC_VERSION_OBJECT_VERSION_STATE_REPLAYED")]
        MOSAIC_VERSION_OBJECT_VERSION_STATE_REPLAYED


    } // enum MosaicVersionObjectVersionState

} // namespace Rubrik.SecurityCloud.Types