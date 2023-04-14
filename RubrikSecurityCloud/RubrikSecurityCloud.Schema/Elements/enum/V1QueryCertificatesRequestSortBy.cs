// V1QueryCertificatesRequestSortBy.cs
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
    public enum V1QueryCertificatesRequestSortBy
    {
        [EnumMember(Value = "V1_QUERY_CERTIFICATES_REQUEST_SORT_BY_DESCRIPTION")]
        V1_QUERY_CERTIFICATES_REQUEST_SORT_BY_DESCRIPTION,

        [EnumMember(Value = "V1_QUERY_CERTIFICATES_REQUEST_SORT_BY_EXPIRATION")]
        V1_QUERY_CERTIFICATES_REQUEST_SORT_BY_EXPIRATION,

        [EnumMember(Value = "V1_QUERY_CERTIFICATES_REQUEST_SORT_BY_HAS_KEY")]
        V1_QUERY_CERTIFICATES_REQUEST_SORT_BY_HAS_KEY,

        [EnumMember(Value = "V1_QUERY_CERTIFICATES_REQUEST_SORT_BY_NAME")]
        V1_QUERY_CERTIFICATES_REQUEST_SORT_BY_NAME


    } // enum V1QueryCertificatesRequestSortBy

} // namespace Rubrik.SecurityCloud.Types