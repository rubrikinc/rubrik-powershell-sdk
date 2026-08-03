// AppAccessImpactEntry.cs
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
    #region AppAccessImpactEntry
    public class AppAccessImpactEntry: BaseType
    {
        #region members

        //      C# -> AppAccessImpactType? ImpactType
        // GraphQL -> impactType: AppAccessImpactType! (enum)
        [JsonProperty("impactType")]
        public AppAccessImpactType? ImpactType { get; set; }

        //      C# -> System.Int32? AppsCount
        // GraphQL -> appsCount: Int! (scalar)
        [JsonProperty("appsCount")]
        public System.Int32? AppsCount { get; set; }

        //      C# -> List<AppNode>? Apps
        // GraphQL -> apps: [AppNode!]! (type)
        [JsonProperty("apps")]
        public List<AppNode>? Apps { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AppAccessImpactEntry";
    }

    public AppAccessImpactEntry Set(
        AppAccessImpactType? ImpactType = null,
        System.Int32? AppsCount = null,
        List<AppNode>? Apps = null
    ) 
    {
        if ( ImpactType != null ) {
            this.ImpactType = ImpactType;
        }
        if ( AppsCount != null ) {
            this.AppsCount = AppsCount;
        }
        if ( Apps != null ) {
            this.Apps = Apps;
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
        //      C# -> AppAccessImpactType? ImpactType
        // GraphQL -> impactType: AppAccessImpactType! (enum)
        if (this.ImpactType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "impactType\n" ;
            } else {
                s += ind + "impactType\n" ;
            }
        }
        //      C# -> System.Int32? AppsCount
        // GraphQL -> appsCount: Int! (scalar)
        if (this.AppsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appsCount\n" ;
            } else {
                s += ind + "appsCount\n" ;
            }
        }
        //      C# -> List<AppNode>? Apps
        // GraphQL -> apps: [AppNode!]! (type)
        if (this.Apps != null) {
            var fspec = this.Apps.AsFieldSpec(conf.Child("apps"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "apps" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AppAccessImpactType? ImpactType
        // GraphQL -> impactType: AppAccessImpactType! (enum)
        if (ec.Includes("impactType",true))
        {
            if(this.ImpactType == null) {

                this.ImpactType = new AppAccessImpactType();

            } else {


            }
        }
        else if (this.ImpactType != null && ec.Excludes("impactType",true))
        {
            this.ImpactType = null;
        }
        //      C# -> System.Int32? AppsCount
        // GraphQL -> appsCount: Int! (scalar)
        if (ec.Includes("appsCount",true))
        {
            if(this.AppsCount == null) {

                this.AppsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AppsCount != null && ec.Excludes("appsCount",true))
        {
            this.AppsCount = null;
        }
        //      C# -> List<AppNode>? Apps
        // GraphQL -> apps: [AppNode!]! (type)
        if (ec.Includes("apps",false))
        {
            if(this.Apps == null) {

                this.Apps = new List<AppNode>();
                this.Apps.ApplyExploratoryFieldSpec(ec.NewChild("apps"));

            } else {

                this.Apps.ApplyExploratoryFieldSpec(ec.NewChild("apps"));

            }
        }
        else if (this.Apps != null && ec.Excludes("apps",false))
        {
            this.Apps = null;
        }
    }


    #endregion

    } // class AppAccessImpactEntry
    
    #endregion

    public static class ListAppAccessImpactEntryExtensions
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
            this List<AppAccessImpactEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AppAccessImpactEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AppAccessImpactEntry> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AppAccessImpactEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AppAccessImpactEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types