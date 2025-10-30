// WanThrottleSettings.cs
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
    #region WanThrottleSettings
    public class WanThrottleSettings: BaseType
    {
        #region members

        //      C# -> System.Int64? DownLimit
        // GraphQL -> downLimit: Long! (scalar)
        [JsonProperty("downLimit")]
        public System.Int64? DownLimit { get; set; }

        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        [JsonProperty("enabled")]
        public System.Boolean? Enabled { get; set; }

        //      C# -> System.Int64? UpLimit
        // GraphQL -> upLimit: Long! (scalar)
        [JsonProperty("upLimit")]
        public System.Int64? UpLimit { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WanThrottleSettings";
    }

    public WanThrottleSettings Set(
        System.Int64? DownLimit = null,
        System.Boolean? Enabled = null,
        System.Int64? UpLimit = null
    ) 
    {
        if ( DownLimit != null ) {
            this.DownLimit = DownLimit;
        }
        if ( Enabled != null ) {
            this.Enabled = Enabled;
        }
        if ( UpLimit != null ) {
            this.UpLimit = UpLimit;
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
        //      C# -> System.Int64? DownLimit
        // GraphQL -> downLimit: Long! (scalar)
        if (this.DownLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downLimit\n" ;
            } else {
                s += ind + "downLimit\n" ;
            }
        }
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enabled\n" ;
            } else {
                s += ind + "enabled\n" ;
            }
        }
        //      C# -> System.Int64? UpLimit
        // GraphQL -> upLimit: Long! (scalar)
        if (this.UpLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upLimit\n" ;
            } else {
                s += ind + "upLimit\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? DownLimit
        // GraphQL -> downLimit: Long! (scalar)
        if (ec.Includes("downLimit",true))
        {
            if(this.DownLimit == null) {

                this.DownLimit = new System.Int64();

            } else {


            }
        }
        else if (this.DownLimit != null && ec.Excludes("downLimit",true))
        {
            this.DownLimit = null;
        }
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (ec.Includes("enabled",true))
        {
            if(this.Enabled == null) {

                this.Enabled = true;

            } else {


            }
        }
        else if (this.Enabled != null && ec.Excludes("enabled",true))
        {
            this.Enabled = null;
        }
        //      C# -> System.Int64? UpLimit
        // GraphQL -> upLimit: Long! (scalar)
        if (ec.Includes("upLimit",true))
        {
            if(this.UpLimit == null) {

                this.UpLimit = new System.Int64();

            } else {


            }
        }
        else if (this.UpLimit != null && ec.Excludes("upLimit",true))
        {
            this.UpLimit = null;
        }
    }


    #endregion

    } // class WanThrottleSettings
    
    #endregion

    public static class ListWanThrottleSettingsExtensions
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
            this List<WanThrottleSettings> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WanThrottleSettings> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WanThrottleSettings> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WanThrottleSettings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WanThrottleSettings> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types