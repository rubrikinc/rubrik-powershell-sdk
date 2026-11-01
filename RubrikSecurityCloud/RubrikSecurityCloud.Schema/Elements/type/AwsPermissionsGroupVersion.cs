// AwsPermissionsGroupVersion.cs
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
    #region AwsPermissionsGroupVersion
    public class AwsPermissionsGroupVersion: BaseType
    {
        #region members

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> PermissionsGroup? PermissionsGroup
        // GraphQL -> permissionsGroup: PermissionsGroup! (enum)
        [JsonProperty("permissionsGroup")]
        public PermissionsGroup? PermissionsGroup { get; set; }

        //      C# -> System.Int32? CurrentVersion
        // GraphQL -> currentVersion: Int (scalar)
        [JsonProperty("currentVersion")]
        public System.Int32? CurrentVersion { get; set; }

        //      C# -> System.Boolean? Held
        // GraphQL -> held: Boolean! (scalar)
        [JsonProperty("held")]
        public System.Boolean? Held { get; set; }

        //      C# -> System.Int32? LatestVersion
        // GraphQL -> latestVersion: Int (scalar)
        [JsonProperty("latestVersion")]
        public System.Int32? LatestVersion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsPermissionsGroupVersion";
    }

    public AwsPermissionsGroupVersion Set(
        CloudAccountFeature? Feature = null,
        PermissionsGroup? PermissionsGroup = null,
        System.Int32? CurrentVersion = null,
        System.Boolean? Held = null,
        System.Int32? LatestVersion = null
    ) 
    {
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( PermissionsGroup != null ) {
            this.PermissionsGroup = PermissionsGroup;
        }
        if ( CurrentVersion != null ) {
            this.CurrentVersion = CurrentVersion;
        }
        if ( Held != null ) {
            this.Held = Held;
        }
        if ( LatestVersion != null ) {
            this.LatestVersion = LatestVersion;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        //      C# -> PermissionsGroup? PermissionsGroup
        // GraphQL -> permissionsGroup: PermissionsGroup! (enum)
        if (this.PermissionsGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissionsGroup\n" ;
            } else {
                s += ind + "permissionsGroup\n" ;
            }
        }
        //      C# -> System.Int32? CurrentVersion
        // GraphQL -> currentVersion: Int (scalar)
        if (this.CurrentVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentVersion\n" ;
            } else {
                s += ind + "currentVersion\n" ;
            }
        }
        //      C# -> System.Boolean? Held
        // GraphQL -> held: Boolean! (scalar)
        if (this.Held != null) {
            if (conf.Flat) {
                s += conf.Prefix + "held\n" ;
            } else {
                s += ind + "held\n" ;
            }
        }
        //      C# -> System.Int32? LatestVersion
        // GraphQL -> latestVersion: Int (scalar)
        if (this.LatestVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestVersion\n" ;
            } else {
                s += ind + "latestVersion\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        //      C# -> PermissionsGroup? PermissionsGroup
        // GraphQL -> permissionsGroup: PermissionsGroup! (enum)
        if (ec.Includes("permissionsGroup",true))
        {
            if(this.PermissionsGroup == null) {

                this.PermissionsGroup = new PermissionsGroup();

            } else {


            }
        }
        else if (this.PermissionsGroup != null && ec.Excludes("permissionsGroup",true))
        {
            this.PermissionsGroup = null;
        }
        //      C# -> System.Int32? CurrentVersion
        // GraphQL -> currentVersion: Int (scalar)
        if (ec.Includes("currentVersion",true))
        {
            if(this.CurrentVersion == null) {

                this.CurrentVersion = Int32.MinValue;

            } else {


            }
        }
        else if (this.CurrentVersion != null && ec.Excludes("currentVersion",true))
        {
            this.CurrentVersion = null;
        }
        //      C# -> System.Boolean? Held
        // GraphQL -> held: Boolean! (scalar)
        if (ec.Includes("held",true))
        {
            if(this.Held == null) {

                this.Held = true;

            } else {


            }
        }
        else if (this.Held != null && ec.Excludes("held",true))
        {
            this.Held = null;
        }
        //      C# -> System.Int32? LatestVersion
        // GraphQL -> latestVersion: Int (scalar)
        if (ec.Includes("latestVersion",true))
        {
            if(this.LatestVersion == null) {

                this.LatestVersion = Int32.MinValue;

            } else {


            }
        }
        else if (this.LatestVersion != null && ec.Excludes("latestVersion",true))
        {
            this.LatestVersion = null;
        }
    }


    #endregion

    } // class AwsPermissionsGroupVersion
    
    #endregion

    public static class ListAwsPermissionsGroupVersionExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AwsPermissionsGroupVersion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsPermissionsGroupVersion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsPermissionsGroupVersion> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsPermissionsGroupVersion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsPermissionsGroupVersion> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types