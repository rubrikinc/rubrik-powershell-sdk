// FeaturePermission.cs
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
    #region FeaturePermission
    public class FeaturePermission: BaseType
    {
        #region members

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> System.String? PermissionJson
        // GraphQL -> permissionJson: String! (scalar)
        [JsonProperty("permissionJson")]
        public System.String? PermissionJson { get; set; }

        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        [JsonProperty("version")]
        public System.Int32? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FeaturePermission";
    }

    public FeaturePermission Set(
        CloudAccountFeature? Feature = null,
        System.String? PermissionJson = null,
        System.Int32? Version = null
    ) 
    {
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( PermissionJson != null ) {
            this.PermissionJson = PermissionJson;
        }
        if ( Version != null ) {
            this.Version = Version;
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
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            s += ind + "feature\n" ;
        }
        //      C# -> System.String? PermissionJson
        // GraphQL -> permissionJson: String! (scalar)
        if (this.PermissionJson != null) {
            s += ind + "permissionJson\n" ;
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature == null && Exploration.Includes(parent + ".feature", true))
        {
            this.Feature = new CloudAccountFeature();
        }
        //      C# -> System.String? PermissionJson
        // GraphQL -> permissionJson: String! (scalar)
        if (this.PermissionJson == null && Exploration.Includes(parent + ".permissionJson", true))
        {
            this.PermissionJson = "FETCH";
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = Int32.MinValue;
        }
    }


    #endregion

    } // class FeaturePermission
    
    #endregion

    public static class ListFeaturePermissionExtensions
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
            this List<FeaturePermission> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FeaturePermission> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FeaturePermission());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types