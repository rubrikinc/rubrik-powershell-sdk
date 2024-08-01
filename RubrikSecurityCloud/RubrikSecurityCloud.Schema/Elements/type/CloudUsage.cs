// CloudUsage.cs
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
    #region CloudUsage
 
    public class CloudUsage: BaseType, ProductUsage
    {
        #region members

        //      C# -> System.Int64? FrontEndBytesConsumed
        // GraphQL -> frontEndBytesConsumed: Long! (scalar)
        [JsonProperty("frontEndBytesConsumed")]
        public System.Int64? FrontEndBytesConsumed { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        //      C# -> CcesUsage? CcesUsage
        // GraphQL -> ccesUsage: CcesUsage (type)
        [JsonProperty("ccesUsage")]
        public CcesUsage? CcesUsage { get; set; }

        //      C# -> CnpUsage? CnpUsage
        // GraphQL -> cnpUsage: CnpUsage (type)
        [JsonProperty("cnpUsage")]
        public CnpUsage? CnpUsage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudUsage";
    }

    public CloudUsage Set(
        System.Int64? FrontEndBytesConsumed = null,
        DateTime? Timestamp = null,
        CcesUsage? CcesUsage = null,
        CnpUsage? CnpUsage = null
    ) 
    {
        if ( FrontEndBytesConsumed != null ) {
            this.FrontEndBytesConsumed = FrontEndBytesConsumed;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        if ( CcesUsage != null ) {
            this.CcesUsage = CcesUsage;
        }
        if ( CnpUsage != null ) {
            this.CnpUsage = CnpUsage;
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
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestamp\n" ;
            } else {
                s += ind + "timestamp\n" ;
            }
        }
        //      C# -> CcesUsage? CcesUsage
        // GraphQL -> ccesUsage: CcesUsage (type)
        if (this.CcesUsage != null) {
            var fspec = this.CcesUsage.AsFieldSpec(conf.Child("ccesUsage"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ccesUsage" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CnpUsage? CnpUsage
        // GraphQL -> cnpUsage: CnpUsage (type)
        if (this.CnpUsage != null) {
            var fspec = this.CnpUsage.AsFieldSpec(conf.Child("cnpUsage"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cnpUsage" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> CcesUsage? CcesUsage
        // GraphQL -> ccesUsage: CcesUsage (type)
        if (ec.Includes("ccesUsage",false))
        {
            if(this.CcesUsage == null) {

                this.CcesUsage = new CcesUsage();
                this.CcesUsage.ApplyExploratoryFieldSpec(ec.NewChild("ccesUsage"));

            } else {

                this.CcesUsage.ApplyExploratoryFieldSpec(ec.NewChild("ccesUsage"));

            }
        }
        else if (this.CcesUsage != null && ec.Excludes("ccesUsage",false))
        {
            this.CcesUsage = null;
        }
        //      C# -> CnpUsage? CnpUsage
        // GraphQL -> cnpUsage: CnpUsage (type)
        if (ec.Includes("cnpUsage",false))
        {
            if(this.CnpUsage == null) {

                this.CnpUsage = new CnpUsage();
                this.CnpUsage.ApplyExploratoryFieldSpec(ec.NewChild("cnpUsage"));

            } else {

                this.CnpUsage.ApplyExploratoryFieldSpec(ec.NewChild("cnpUsage"));

            }
        }
        else if (this.CnpUsage != null && ec.Excludes("cnpUsage",false))
        {
            this.CnpUsage = null;
        }
    }


    #endregion

    } // class CloudUsage
    
    #endregion

    public static class ListCloudUsageExtensions
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
            this List<CloudUsage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudUsage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudUsage> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudUsage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudUsage> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types