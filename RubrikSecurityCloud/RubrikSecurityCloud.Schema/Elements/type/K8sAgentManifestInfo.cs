// K8sAgentManifestInfo.cs
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
    #region K8sAgentManifestInfo
    public class K8sAgentManifestInfo: BaseType
    {
        #region members

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? SignedUrl
        // GraphQL -> signedUrl: String! (scalar)
        [JsonProperty("signedUrl")]
        public System.String? SignedUrl { get; set; }


        #endregion

    #region methods

    public K8sAgentManifestInfo Set(
        System.String? ClusterId = null,
        System.String? SignedUrl = null
    ) 
    {
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( SignedUrl != null ) {
            this.SignedUrl = SignedUrl;
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
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            s += ind + "clusterId\n" ;
        }
        //      C# -> System.String? SignedUrl
        // GraphQL -> signedUrl: String! (scalar)
        if (this.SignedUrl != null) {
            s += ind + "signedUrl\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId", true))
        {
            this.ClusterId = "FETCH";
        }
        //      C# -> System.String? SignedUrl
        // GraphQL -> signedUrl: String! (scalar)
        if (this.SignedUrl == null && Exploration.Includes(parent + ".signedUrl", true))
        {
            this.SignedUrl = "FETCH";
        }
    }


    #endregion

    } // class K8sAgentManifestInfo
    
    #endregion

    public static class ListK8sAgentManifestInfoExtensions
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
            this List<K8sAgentManifestInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<K8sAgentManifestInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sAgentManifestInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types