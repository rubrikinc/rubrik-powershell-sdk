// CnpUsage.cs
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
    #region CnpUsage
    public class CnpUsage: BaseType
    {
        #region members

        //      C# -> System.Int64? FrontEndBytesConsumed
        // GraphQL -> frontEndBytesConsumed: Long! (scalar)
        [JsonProperty("frontEndBytesConsumed")]
        public System.Int64? FrontEndBytesConsumed { get; set; }

        //      C# -> List<CnpCloudUsage>? PerCloudUsage
        // GraphQL -> perCloudUsage: [CnpCloudUsage!]! (type)
        [JsonProperty("perCloudUsage")]
        public List<CnpCloudUsage>? PerCloudUsage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CnpUsage";
    }

    public CnpUsage Set(
        System.Int64? FrontEndBytesConsumed = null,
        List<CnpCloudUsage>? PerCloudUsage = null
    ) 
    {
        if ( FrontEndBytesConsumed != null ) {
            this.FrontEndBytesConsumed = FrontEndBytesConsumed;
        }
        if ( PerCloudUsage != null ) {
            this.PerCloudUsage = PerCloudUsage;
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
        //      C# -> System.Int64? FrontEndBytesConsumed
        // GraphQL -> frontEndBytesConsumed: Long! (scalar)
        if (this.FrontEndBytesConsumed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frontEndBytesConsumed\n" ;
            } else {
                s += ind + "frontEndBytesConsumed\n" ;
            }
        }
        //      C# -> List<CnpCloudUsage>? PerCloudUsage
        // GraphQL -> perCloudUsage: [CnpCloudUsage!]! (type)
        if (this.PerCloudUsage != null) {
            var fspec = this.PerCloudUsage.AsFieldSpec(conf.Child("perCloudUsage"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "perCloudUsage" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? FrontEndBytesConsumed
        // GraphQL -> frontEndBytesConsumed: Long! (scalar)
        if (ec.Includes("frontEndBytesConsumed",true))
        {
            if(this.FrontEndBytesConsumed == null) {

                this.FrontEndBytesConsumed = new System.Int64();

            } else {


            }
        }
        else if (this.FrontEndBytesConsumed != null && ec.Excludes("frontEndBytesConsumed",true))
        {
            this.FrontEndBytesConsumed = null;
        }
        //      C# -> List<CnpCloudUsage>? PerCloudUsage
        // GraphQL -> perCloudUsage: [CnpCloudUsage!]! (type)
        if (ec.Includes("perCloudUsage",false))
        {
            if(this.PerCloudUsage == null) {

                this.PerCloudUsage = new List<CnpCloudUsage>();
                this.PerCloudUsage.ApplyExploratoryFieldSpec(ec.NewChild("perCloudUsage"));

            } else {

                this.PerCloudUsage.ApplyExploratoryFieldSpec(ec.NewChild("perCloudUsage"));

            }
        }
        else if (this.PerCloudUsage != null && ec.Excludes("perCloudUsage",false))
        {
            this.PerCloudUsage = null;
        }
    }


    #endregion

    } // class CnpUsage
    
    #endregion

    public static class ListCnpUsageExtensions
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
            this List<CnpUsage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CnpUsage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CnpUsage> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CnpUsage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CnpUsage> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types