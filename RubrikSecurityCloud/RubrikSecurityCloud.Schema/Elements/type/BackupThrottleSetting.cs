// BackupThrottleSetting.cs
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
    #region BackupThrottleSetting
    public class BackupThrottleSetting: BaseType
    {
        #region members

        //      C# -> System.Boolean? EnableThrottling
        // GraphQL -> enableThrottling: Boolean! (scalar)
        [JsonProperty("enableThrottling")]
        public System.Boolean? EnableThrottling { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> VmwareThrottlingSettings? VmwareThrottlingSettings
        // GraphQL -> vmwareThrottlingSettings: VmwareThrottlingSettings (type)
        [JsonProperty("vmwareThrottlingSettings")]
        public VmwareThrottlingSettings? VmwareThrottlingSettings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BackupThrottleSetting";
    }

    public BackupThrottleSetting Set(
        System.Boolean? EnableThrottling = null,
        Cluster? Cluster = null,
        VmwareThrottlingSettings? VmwareThrottlingSettings = null
    ) 
    {
        if ( EnableThrottling != null ) {
            this.EnableThrottling = EnableThrottling;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( VmwareThrottlingSettings != null ) {
            this.VmwareThrottlingSettings = VmwareThrottlingSettings;
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
        //      C# -> System.Boolean? EnableThrottling
        // GraphQL -> enableThrottling: Boolean! (scalar)
        if (this.EnableThrottling != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableThrottling\n" ;
            } else {
                s += ind + "enableThrottling\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmwareThrottlingSettings? VmwareThrottlingSettings
        // GraphQL -> vmwareThrottlingSettings: VmwareThrottlingSettings (type)
        if (this.VmwareThrottlingSettings != null) {
            var fspec = this.VmwareThrottlingSettings.AsFieldSpec(conf.Child("vmwareThrottlingSettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmwareThrottlingSettings" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? EnableThrottling
        // GraphQL -> enableThrottling: Boolean! (scalar)
        if (ec.Includes("enableThrottling",true))
        {
            if(this.EnableThrottling == null) {

                this.EnableThrottling = true;

            } else {


            }
        }
        else if (this.EnableThrottling != null && ec.Excludes("enableThrottling",true))
        {
            this.EnableThrottling = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> VmwareThrottlingSettings? VmwareThrottlingSettings
        // GraphQL -> vmwareThrottlingSettings: VmwareThrottlingSettings (type)
        if (ec.Includes("vmwareThrottlingSettings",false))
        {
            if(this.VmwareThrottlingSettings == null) {

                this.VmwareThrottlingSettings = new VmwareThrottlingSettings();
                this.VmwareThrottlingSettings.ApplyExploratoryFieldSpec(ec.NewChild("vmwareThrottlingSettings"));

            } else {

                this.VmwareThrottlingSettings.ApplyExploratoryFieldSpec(ec.NewChild("vmwareThrottlingSettings"));

            }
        }
        else if (this.VmwareThrottlingSettings != null && ec.Excludes("vmwareThrottlingSettings",false))
        {
            this.VmwareThrottlingSettings = null;
        }
    }


    #endregion

    } // class BackupThrottleSetting
    
    #endregion

    public static class ListBackupThrottleSettingExtensions
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
            this List<BackupThrottleSetting> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BackupThrottleSetting> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BackupThrottleSetting> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BackupThrottleSetting());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BackupThrottleSetting> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types