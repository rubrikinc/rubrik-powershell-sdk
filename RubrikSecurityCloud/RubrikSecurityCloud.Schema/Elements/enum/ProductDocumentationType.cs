// ProductDocumentationType.cs
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
    public enum ProductDocumentationType
    {
        [EnumMember(Value = "CONCEPT")]
        CONCEPT,

        [EnumMember(Value = "REFERENCE")]
        REFERENCE,

        [EnumMember(Value = "TASK")]
        TASK,

        [EnumMember(Value = "TYPE_UNSPECIFIED")]
        TYPE_UNSPECIFIED


    } // enum ProductDocumentationType

} // namespace Rubrik.SecurityCloud.Types