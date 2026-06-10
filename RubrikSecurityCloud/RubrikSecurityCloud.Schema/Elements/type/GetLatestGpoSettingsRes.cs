// GetLatestGpoSettingsRes.cs
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
    #region GetLatestGpoSettingsRes
    public class GetLatestGpoSettingsRes: BaseType
    {
        #region members

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }

        //      C# -> System.String? UniformJson
        // GraphQL -> uniformJson: String! (scalar)
        [JsonProperty("uniformJson")]
        public System.String? UniformJson { get; set; }

        //      C# -> System.Int32? VersionNumber
        // GraphQL -> versionNumber: Int (scalar)
        [JsonProperty("versionNumber")]
        public System.Int32? VersionNumber { get; set; }

        //      C# -> ActiveDirectoryGpoSettingsData? GpoSettings
        // GraphQL -> gpoSettings: ActiveDirectoryGpoSettingsData (type)
        [JsonProperty("gpoSettings")]
        public ActiveDirectoryGpoSettingsData? GpoSettings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetLatestGpoSettingsRes";
    }

    public GetLatestGpoSettingsRes Set(
        DateTime? SnapshotTime = null,
        System.String? UniformJson = null,
        System.Int32? VersionNumber = null,
        ActiveDirectoryGpoSettingsData? GpoSettings = null
    ) 
    {
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
        }
        if ( UniformJson != null ) {
            this.UniformJson = UniformJson;
        }
        if ( VersionNumber != null ) {
            this.VersionNumber = VersionNumber;
        }
        if ( GpoSettings != null ) {
            this.GpoSettings = GpoSettings;
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
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTime\n" ;
            } else {
                s += ind + "snapshotTime\n" ;
            }
        }
        //      C# -> System.String? UniformJson
        // GraphQL -> uniformJson: String! (scalar)
        if (this.UniformJson != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uniformJson\n" ;
            } else {
                s += ind + "uniformJson\n" ;
            }
        }
        //      C# -> System.Int32? VersionNumber
        // GraphQL -> versionNumber: Int (scalar)
        if (this.VersionNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "versionNumber\n" ;
            } else {
                s += ind + "versionNumber\n" ;
            }
        }
        //      C# -> ActiveDirectoryGpoSettingsData? GpoSettings
        // GraphQL -> gpoSettings: ActiveDirectoryGpoSettingsData (type)
        if (this.GpoSettings != null) {
            var fspec = this.GpoSettings.AsFieldSpec(conf.Child("gpoSettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "gpoSettings" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (ec.Includes("snapshotTime",true))
        {
            if(this.SnapshotTime == null) {

                this.SnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotTime != null && ec.Excludes("snapshotTime",true))
        {
            this.SnapshotTime = null;
        }
        //      C# -> System.String? UniformJson
        // GraphQL -> uniformJson: String! (scalar)
        if (ec.Includes("uniformJson",true))
        {
            if(this.UniformJson == null) {

                this.UniformJson = "FETCH";

            } else {


            }
        }
        else if (this.UniformJson != null && ec.Excludes("uniformJson",true))
        {
            this.UniformJson = null;
        }
        //      C# -> System.Int32? VersionNumber
        // GraphQL -> versionNumber: Int (scalar)
        if (ec.Includes("versionNumber",true))
        {
            if(this.VersionNumber == null) {

                this.VersionNumber = Int32.MinValue;

            } else {


            }
        }
        else if (this.VersionNumber != null && ec.Excludes("versionNumber",true))
        {
            this.VersionNumber = null;
        }
        //      C# -> ActiveDirectoryGpoSettingsData? GpoSettings
        // GraphQL -> gpoSettings: ActiveDirectoryGpoSettingsData (type)
        if (ec.Includes("gpoSettings",false))
        {
            if(this.GpoSettings == null) {

                this.GpoSettings = new ActiveDirectoryGpoSettingsData();
                this.GpoSettings.ApplyExploratoryFieldSpec(ec.NewChild("gpoSettings"));

            } else {

                this.GpoSettings.ApplyExploratoryFieldSpec(ec.NewChild("gpoSettings"));

            }
        }
        else if (this.GpoSettings != null && ec.Excludes("gpoSettings",false))
        {
            this.GpoSettings = null;
        }
    }


    #endregion

    } // class GetLatestGpoSettingsRes
    
    #endregion

    public static class ListGetLatestGpoSettingsResExtensions
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
            this List<GetLatestGpoSettingsRes> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetLatestGpoSettingsRes> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetLatestGpoSettingsRes> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetLatestGpoSettingsRes());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetLatestGpoSettingsRes> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types