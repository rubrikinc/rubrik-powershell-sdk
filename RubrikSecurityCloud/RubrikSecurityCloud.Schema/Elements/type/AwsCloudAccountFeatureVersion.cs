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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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


        #endregion

    #region methods

    public AwsCloudAccountFeatureVersion Set(
        CloudAccountFeature? Feature = null,
        System.Int32? Version = null
    ) 
    {
        if ( Feature != null ) {
            this.Feature = Feature;
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
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = Int32.MinValue;
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsCloudAccountFeatureVersion> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCloudAccountFeatureVersion());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types