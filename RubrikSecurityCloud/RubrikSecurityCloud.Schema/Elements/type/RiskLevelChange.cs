// RiskLevelChange.cs
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
    #region RiskLevelChange
    public class RiskLevelChange: BaseType
    {
        #region members

        //      C# -> RiskLevelType? From
        // GraphQL -> from: RiskLevelType! (enum)
        [JsonProperty("from")]
        public RiskLevelType? From { get; set; }

        //      C# -> RiskLevelType? To
        // GraphQL -> to: RiskLevelType! (enum)
        [JsonProperty("to")]
        public RiskLevelType? To { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RiskLevelChange";
    }

    public RiskLevelChange Set(
        RiskLevelType? From = null,
        RiskLevelType? To = null
    ) 
    {
        if ( From != null ) {
            this.From = From;
        }
        if ( To != null ) {
            this.To = To;
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
        //      C# -> RiskLevelType? From
        // GraphQL -> from: RiskLevelType! (enum)
        if (this.From != null) {
            if (conf.Flat) {
                s += conf.Prefix + "from\n" ;
            } else {
                s += ind + "from\n" ;
            }
        }
        //      C# -> RiskLevelType? To
        // GraphQL -> to: RiskLevelType! (enum)
        if (this.To != null) {
            if (conf.Flat) {
                s += conf.Prefix + "to\n" ;
            } else {
                s += ind + "to\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RiskLevelType? From
        // GraphQL -> from: RiskLevelType! (enum)
        if (ec.Includes("from",true))
        {
            if(this.From == null) {

                this.From = new RiskLevelType();

            } else {


            }
        }
        else if (this.From != null && ec.Excludes("from",true))
        {
            this.From = null;
        }
        //      C# -> RiskLevelType? To
        // GraphQL -> to: RiskLevelType! (enum)
        if (ec.Includes("to",true))
        {
            if(this.To == null) {

                this.To = new RiskLevelType();

            } else {


            }
        }
        else if (this.To != null && ec.Excludes("to",true))
        {
            this.To = null;
        }
    }


    #endregion

    } // class RiskLevelChange
    
    #endregion

    public static class ListRiskLevelChangeExtensions
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
            this List<RiskLevelChange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RiskLevelChange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RiskLevelChange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RiskLevelChange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RiskLevelChange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types