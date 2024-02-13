// AwsCloudAccountFeatureVersion.cs
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
    #region AwsCloudAccountFeatureVersion
    public class AwsCloudAccountFeatureVersion: BaseType
    {
        #region members

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        [JsonProperty("version")]
        public System.Int32? Version { get; set; }

        //      C# -> List<PermissionsGroupWithVersion>? PermissionsGroupVersions
        // GraphQL -> permissionsGroupVersions: [PermissionsGroupWithVersion!]! (type)
        [JsonProperty("permissionsGroupVersions")]
        public List<PermissionsGroupWithVersion>? PermissionsGroupVersions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsCloudAccountFeatureVersion";
    }

    public AwsCloudAccountFeatureVersion Set(
        CloudAccountFeature? Feature = null,
        System.Int32? Version = null,
        List<PermissionsGroupWithVersion>? PermissionsGroupVersions = null
    ) 
    {
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( PermissionsGroupVersions != null ) {
            this.PermissionsGroupVersions = PermissionsGroupVersions;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            if (conf.Flat) {
                s += conf.Prefix + "feature\n" ;
            } else {
                s += ind + "feature\n" ;
            }
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<PermissionsGroupWithVersion>? PermissionsGroupVersions
        // GraphQL -> permissionsGroupVersions: [PermissionsGroupWithVersion!]! (type)
        if (this.PermissionsGroupVersions != null) {
            var fspec = this.PermissionsGroupVersions.AsFieldSpec(conf.Child("permissionsGroupVersions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "permissionsGroupVersions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (ec.Includes("feature",true))
        {
            if(this.Feature == null) {

                this.Feature = new CloudAccountFeature();

            } else {


            }
        }
        else if (this.Feature != null && ec.Excludes("feature",true))
        {
            this.Feature = null;
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = Int32.MinValue;

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<PermissionsGroupWithVersion>? PermissionsGroupVersions
        // GraphQL -> permissionsGroupVersions: [PermissionsGroupWithVersion!]! (type)
        if (ec.Includes("permissionsGroupVersions",false))
        {
            if(this.PermissionsGroupVersions == null) {

                this.PermissionsGroupVersions = new List<PermissionsGroupWithVersion>();
                this.PermissionsGroupVersions.ApplyExploratoryFieldSpec(ec.NewChild("permissionsGroupVersions"));

            } else {

                this.PermissionsGroupVersions.ApplyExploratoryFieldSpec(ec.NewChild("permissionsGroupVersions"));

            }
        }
        else if (this.PermissionsGroupVersions != null && ec.Excludes("permissionsGroupVersions",false))
        {
            this.PermissionsGroupVersions = null;
        }
    }


    #endregion

    } // class AwsCloudAccountFeatureVersion
    
    #endregion

    public static class ListAwsCloudAccountFeatureVersionExtensions
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
            this List<AwsCloudAccountFeatureVersion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AwsCloudAccountFeatureVersion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsCloudAccountFeatureVersion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCloudAccountFeatureVersion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsCloudAccountFeatureVersion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types