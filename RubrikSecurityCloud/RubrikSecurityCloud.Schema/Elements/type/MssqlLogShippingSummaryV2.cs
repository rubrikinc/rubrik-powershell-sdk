// MssqlLogShippingSummaryV2.cs
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
    #region MssqlLogShippingSummaryV2
    public class MssqlLogShippingSummaryV2: BaseType
    {
        #region members

        //      C# -> System.Int32? MakeupReseedLimit
        // GraphQL -> makeupReseedLimit: Int (scalar)
        [JsonProperty("makeupReseedLimit")]
        public System.Int32? MakeupReseedLimit { get; set; }

        //      C# -> MssqlLogShippingSummary? MssqlLogShippingSummary
        // GraphQL -> mssqlLogShippingSummary: MssqlLogShippingSummary (type)
        [JsonProperty("mssqlLogShippingSummary")]
        public MssqlLogShippingSummary? MssqlLogShippingSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlLogShippingSummaryV2";
    }

    public MssqlLogShippingSummaryV2 Set(
        System.Int32? MakeupReseedLimit = null,
        MssqlLogShippingSummary? MssqlLogShippingSummary = null
    ) 
    {
        if ( MakeupReseedLimit != null ) {
            this.MakeupReseedLimit = MakeupReseedLimit;
        }
        if ( MssqlLogShippingSummary != null ) {
            this.MssqlLogShippingSummary = MssqlLogShippingSummary;
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
        //      C# -> System.Int32? MakeupReseedLimit
        // GraphQL -> makeupReseedLimit: Int (scalar)
        if (this.MakeupReseedLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "makeupReseedLimit\n" ;
            } else {
                s += ind + "makeupReseedLimit\n" ;
            }
        }
        //      C# -> MssqlLogShippingSummary? MssqlLogShippingSummary
        // GraphQL -> mssqlLogShippingSummary: MssqlLogShippingSummary (type)
        if (this.MssqlLogShippingSummary != null) {
            var fspec = this.MssqlLogShippingSummary.AsFieldSpec(conf.Child("mssqlLogShippingSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlLogShippingSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? MakeupReseedLimit
        // GraphQL -> makeupReseedLimit: Int (scalar)
        if (ec.Includes("makeupReseedLimit",true))
        {
            if(this.MakeupReseedLimit == null) {

                this.MakeupReseedLimit = Int32.MinValue;

            } else {


            }
        }
        else if (this.MakeupReseedLimit != null && ec.Excludes("makeupReseedLimit",true))
        {
            this.MakeupReseedLimit = null;
        }
        //      C# -> MssqlLogShippingSummary? MssqlLogShippingSummary
        // GraphQL -> mssqlLogShippingSummary: MssqlLogShippingSummary (type)
        if (ec.Includes("mssqlLogShippingSummary",false))
        {
            if(this.MssqlLogShippingSummary == null) {

                this.MssqlLogShippingSummary = new MssqlLogShippingSummary();
                this.MssqlLogShippingSummary.ApplyExploratoryFieldSpec(ec.NewChild("mssqlLogShippingSummary"));

            } else {

                this.MssqlLogShippingSummary.ApplyExploratoryFieldSpec(ec.NewChild("mssqlLogShippingSummary"));

            }
        }
        else if (this.MssqlLogShippingSummary != null && ec.Excludes("mssqlLogShippingSummary",false))
        {
            this.MssqlLogShippingSummary = null;
        }
    }


    #endregion

    } // class MssqlLogShippingSummaryV2
    
    #endregion

    public static class ListMssqlLogShippingSummaryV2Extensions
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
            this List<MssqlLogShippingSummaryV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MssqlLogShippingSummaryV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlLogShippingSummaryV2> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlLogShippingSummaryV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlLogShippingSummaryV2> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types