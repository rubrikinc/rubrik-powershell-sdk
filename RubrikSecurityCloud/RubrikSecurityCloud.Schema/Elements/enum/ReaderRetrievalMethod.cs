// ReaderRetrievalMethod.cs
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
    public enum ReaderRetrievalMethod
    {
        [EnumMember(Value = "OBJECT_LIST_AND_DETAILS")]
        OBJECT_LIST_AND_DETAILS,

        [EnumMember(Value = "OBJECT_LIST_ONLY")]
        OBJECT_LIST_ONLY,

        [EnumMember(Value = "UNKNOWN_RETRIEVAL_METHOD")]
        UNKNOWN_RETRIEVAL_METHOD,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ReaderRetrievalMethod

} // namespace RubrikSecurityCloud.Types