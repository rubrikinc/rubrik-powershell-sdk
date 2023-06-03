// VappExportMode.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum VappExportMode
    {
        [EnumMember(Value = "VAPP_EXPORT_MODE_EXPORT_TO_NEW_VAPP")]
        VAPP_EXPORT_MODE_EXPORT_TO_NEW_VAPP,

        [EnumMember(Value = "VAPP_EXPORT_MODE_EXPORT_TO_TARGET_VAPP")]
        VAPP_EXPORT_MODE_EXPORT_TO_TARGET_VAPP


    } // enum VappExportMode

} // namespace Rubrik.SecurityCloud.Types