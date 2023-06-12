// K8sAppManifest.cs
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
    #region K8sAppManifest
    public class K8sAppManifest: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        [JsonProperty("isSuccessful")]
        public System.Boolean? IsSuccessful { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> AppManifestInfo? ToApply
        // GraphQL -> toApply: AppManifestInfo (type)
        [JsonProperty("toApply")]
        public AppManifestInfo? ToApply { get; set; }

        //      C# -> AppManifestInfo? ToDelete
        // GraphQL -> toDelete: AppManifestInfo (type)
        [JsonProperty("toDelete")]
        public AppManifestInfo? ToDelete { get; set; }


        #endregion

    #region methods

    public K8sAppManifest Set(
        System.Boolean? IsSuccessful = null,
        System.String? Version = null,
        AppManifestInfo? ToApply = null,
        AppManifestInfo? ToDelete = null
    ) 
    {
        if ( IsSuccessful != null ) {
            this.IsSuccessful = IsSuccessful;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( ToApply != null ) {
            this.ToApply = ToApply;
        }
        if ( ToDelete != null ) {
            this.ToDelete = ToDelete;
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
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (this.IsSuccessful != null) {
            s += ind + "isSuccessful\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> AppManifestInfo? ToApply
        // GraphQL -> toApply: AppManifestInfo (type)
        if (this.ToApply != null) {
            var fspec = this.ToApply.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "toApply {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AppManifestInfo? ToDelete
        // GraphQL -> toDelete: AppManifestInfo (type)
        if (this.ToDelete != null) {
            var fspec = this.ToDelete.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "toDelete {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (this.IsSuccessful == null && Exploration.Includes(parent + ".isSuccessful", true))
        {
            this.IsSuccessful = true;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = "FETCH";
        }
        //      C# -> AppManifestInfo? ToApply
        // GraphQL -> toApply: AppManifestInfo (type)
        if (this.ToApply == null && Exploration.Includes(parent + ".toApply"))
        {
            this.ToApply = new AppManifestInfo();
            this.ToApply.ApplyExploratoryFieldSpec(parent + ".toApply");
        }
        //      C# -> AppManifestInfo? ToDelete
        // GraphQL -> toDelete: AppManifestInfo (type)
        if (this.ToDelete == null && Exploration.Includes(parent + ".toDelete"))
        {
            this.ToDelete = new AppManifestInfo();
            this.ToDelete.ApplyExploratoryFieldSpec(parent + ".toDelete");
        }
    }


    #endregion

    } // class K8sAppManifest
    
    #endregion

    public static class ListK8sAppManifestExtensions
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
            this List<K8sAppManifest> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<K8sAppManifest> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sAppManifest());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types