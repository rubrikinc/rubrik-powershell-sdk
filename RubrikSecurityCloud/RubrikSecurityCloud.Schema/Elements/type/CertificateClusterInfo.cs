// CertificateClusterInfo.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CertificateClusterInfo
    public class CertificateClusterInfo: BaseType
    {
        #region members

        //      C# -> System.String? CdmCertUuid
        // GraphQL -> cdmCertUuid: UUID! (scalar)
        [JsonProperty("cdmCertUuid")]
        public System.String? CdmCertUuid { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean! (scalar)
        [JsonProperty("isTrusted")]
        public System.Boolean? IsTrusted { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public CertificateClusterInfo Set(
        System.String? CdmCertUuid = null,
        System.String? ClusterUuid = null,
        System.Boolean? IsTrusted = null,
        System.String? Name = null
    ) 
    {
        if ( CdmCertUuid != null ) {
            this.CdmCertUuid = CdmCertUuid;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( IsTrusted != null ) {
            this.IsTrusted = IsTrusted;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> System.String? CdmCertUuid
        // GraphQL -> cdmCertUuid: UUID! (scalar)
        if (this.CdmCertUuid != null) {
            s += ind + "cdmCertUuid\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean! (scalar)
        if (this.IsTrusted != null) {
            s += ind + "isTrusted\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CdmCertUuid
        // GraphQL -> cdmCertUuid: UUID! (scalar)
        if (this.CdmCertUuid == null && Exploration.Includes(parent + ".cdmCertUuid", true))
        {
            this.CdmCertUuid = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean! (scalar)
        if (this.IsTrusted == null && Exploration.Includes(parent + ".isTrusted", true))
        {
            this.IsTrusted = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class CertificateClusterInfo
    
    #endregion

    public static class ListCertificateClusterInfoExtensions
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
            this List<CertificateClusterInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CertificateClusterInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CertificateClusterInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types