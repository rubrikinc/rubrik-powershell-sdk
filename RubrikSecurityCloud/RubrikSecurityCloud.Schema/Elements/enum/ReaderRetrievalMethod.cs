// ReaderRetrievalMethod.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:12.
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
    public enum ReaderRetrievalMethod
    {
        [EnumMember(Value = "OBJECT_LIST_AND_DETAILS")]
        OBJECT_LIST_AND_DETAILS,

        [EnumMember(Value = "OBJECT_LIST_ONLY")]
        OBJECT_LIST_ONLY,

        [EnumMember(Value = "UNKNOWN_RETRIEVAL_METHOD")]
        UNKNOWN_RETRIEVAL_METHOD


    } // enum ReaderRetrievalMethod

} // namespace Rubrik.SecurityCloud.Types