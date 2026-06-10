// QmcInitiatorPage.cs
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
    public enum QmcInitiatorPage
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "QMC_FILES")]
        QMC_FILES,

        [EnumMember(Value = "QMC_OBJECTS")]
        QMC_OBJECTS,

        [EnumMember(Value = "QMC_OBJECT_DETAILS")]
        QMC_OBJECT_DETAILS,

        [EnumMember(Value = "QMC_UNSPECIFIED")]
        QMC_UNSPECIFIED


    } // enum QmcInitiatorPage

} // namespace RubrikSecurityCloud.Types