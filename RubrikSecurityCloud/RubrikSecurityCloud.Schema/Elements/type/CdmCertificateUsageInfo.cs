// CdmCertificateUsageInfo.cs
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
    #region CdmCertificateUsageInfo
    public class CdmCertificateUsageInfo: BaseType
    {
        #region members

        //      C# -> CdmCertificateUsage? Type
        // GraphQL -> type: CdmCertificateUsage! (enum)
        [JsonProperty("type")]
        public CdmCertificateUsage? Type { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }


        #endregion

    #region methods

    public CdmCertificateUsageInfo Set(
        CdmCertificateUsage? Type = null,
        System.String? ClusterName = null,
        System.String? ClusterUuid = null,
        System.String? Id = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Id != null ) {
            this.Id = Id;
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
        //      C# -> CdmCertificateUsage? Type
        // GraphQL -> type: CdmCertificateUsage! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CdmCertificateUsage? Type
        // GraphQL -> type: CdmCertificateUsage! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new CdmCertificateUsage();
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
    }


    #endregion

    } // class CdmCertificateUsageInfo
    
    #endregion

    public static class ListCdmCertificateUsageInfoExtensions
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
            this List<CdmCertificateUsageInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmCertificateUsageInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmCertificateUsageInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types