// O365Usage.cs
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
    #region O365Usage
 
    public class O365Usage: BaseType, ProductUsage
    {
        #region members

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        //      C# -> O365UsageDetails? TotalUsage
        // GraphQL -> totalUsage: O365UsageDetails (type)
        [JsonProperty("totalUsage")]
        public O365UsageDetails? TotalUsage { get; set; }

        //      C# -> List<O365PerSnappableUsage>? UsagePerSnappable
        // GraphQL -> usagePerSnappable: [O365PerSnappableUsage!]! (type)
        [JsonProperty("usagePerSnappable")]
        public List<O365PerSnappableUsage>? UsagePerSnappable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365Usage";
    }

    public O365Usage Set(
        DateTime? Timestamp = null,
        O365UsageDetails? TotalUsage = null,
        List<O365PerSnappableUsage>? UsagePerSnappable = null
    ) 
    {
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        if ( TotalUsage != null ) {
            this.TotalUsage = TotalUsage;
        }
        if ( UsagePerSnappable != null ) {
            this.UsagePerSnappable = UsagePerSnappable;
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
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestamp\n" ;
            } else {
                s += ind + "timestamp\n" ;
            }
        }
        //      C# -> O365UsageDetails? TotalUsage
        // GraphQL -> totalUsage: O365UsageDetails (type)
        if (this.TotalUsage != null) {
            var fspec = this.TotalUsage.AsFieldSpec(conf.Child("totalUsage"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalUsage" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<O365PerSnappableUsage>? UsagePerSnappable
        // GraphQL -> usagePerSnappable: [O365PerSnappableUsage!]! (type)
        if (this.UsagePerSnappable != null) {
            var fspec = this.UsagePerSnappable.AsFieldSpec(conf.Child("usagePerSnappable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "usagePerSnappable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (ec.Includes("timestamp",true))
        {
            if(this.Timestamp == null) {

                this.Timestamp = new DateTime();

            } else {


            }
        }
        else if (this.Timestamp != null && ec.Excludes("timestamp",true))
        {
            this.Timestamp = null;
        }
        //      C# -> O365UsageDetails? TotalUsage
        // GraphQL -> totalUsage: O365UsageDetails (type)
        if (ec.Includes("totalUsage",false))
        {
            if(this.TotalUsage == null) {

                this.TotalUsage = new O365UsageDetails();
                this.TotalUsage.ApplyExploratoryFieldSpec(ec.NewChild("totalUsage"));

            } else {

                this.TotalUsage.ApplyExploratoryFieldSpec(ec.NewChild("totalUsage"));

            }
        }
        else if (this.TotalUsage != null && ec.Excludes("totalUsage",false))
        {
            this.TotalUsage = null;
        }
        //      C# -> List<O365PerSnappableUsage>? UsagePerSnappable
        // GraphQL -> usagePerSnappable: [O365PerSnappableUsage!]! (type)
        if (ec.Includes("usagePerSnappable",false))
        {
            if(this.UsagePerSnappable == null) {

                this.UsagePerSnappable = new List<O365PerSnappableUsage>();
                this.UsagePerSnappable.ApplyExploratoryFieldSpec(ec.NewChild("usagePerSnappable"));

            } else {

                this.UsagePerSnappable.ApplyExploratoryFieldSpec(ec.NewChild("usagePerSnappable"));

            }
        }
        else if (this.UsagePerSnappable != null && ec.Excludes("usagePerSnappable",false))
        {
            this.UsagePerSnappable = null;
        }
    }


    #endregion

    } // class O365Usage
    
    #endregion

    public static class ListO365UsageExtensions
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
            this List<O365Usage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365Usage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365Usage> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365Usage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365Usage> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types