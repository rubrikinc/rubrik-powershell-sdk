// CdmKmipServerInfo.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region CdmKmipServerInfo
    public class CdmKmipServerInfo: BaseType
    {
        #region members

        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String! (scalar)
        [JsonProperty("certificateId")]
        public System.String? CertificateId { get; set; }

        //      C# -> System.String? CertificateName
        // GraphQL -> certificateName: String! (scalar)
        [JsonProperty("certificateName")]
        public System.String? CertificateName { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }


        #endregion

    #region methods

    public CdmKmipServerInfo Set(
        System.String? CertificateId = null,
        System.String? CertificateName = null,
        System.String? ClusterName = null,
        System.String? ClusterUuid = null
    ) 
    {
        if ( CertificateId != null ) {
            this.CertificateId = CertificateId;
        }
        if ( CertificateName != null ) {
            this.CertificateName = CertificateName;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String! (scalar)
        if (this.CertificateId != null) {
            s += ind + "certificateId\n" ;
        }
        //      C# -> System.String? CertificateName
        // GraphQL -> certificateName: String! (scalar)
        if (this.CertificateName != null) {
            s += ind + "certificateName\n" ;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            s += ind + "clusterName\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String! (scalar)
        if (this.CertificateId == null && Exploration.Includes(parent + ".certificateId", true))
        {
            this.CertificateId = "FETCH";
        }
        //      C# -> System.String? CertificateName
        // GraphQL -> certificateName: String! (scalar)
        if (this.CertificateName == null && Exploration.Includes(parent + ".certificateName", true))
        {
            this.CertificateName = "FETCH";
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName", true))
        {
            this.ClusterName = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
    }


    #endregion

    } // class CdmKmipServerInfo
    
    #endregion

    public static class ListCdmKmipServerInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<CdmKmipServerInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmKmipServerInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmKmipServerInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types