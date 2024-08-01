// PrincipalChange.cs
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
    #region PrincipalChange
    public class PrincipalChange: BaseType
    {
        #region members

        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        [JsonProperty("fullName")]
        public System.String? FullName { get; set; }

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        //      C# -> CountChange? CountChange
        // GraphQL -> countChange: CountChange (type)
        [JsonProperty("countChange")]
        public CountChange? CountChange { get; set; }

        //      C# -> RiskLevelChange? RiskLevelChange
        // GraphQL -> riskLevelChange: RiskLevelChange (type)
        [JsonProperty("riskLevelChange")]
        public RiskLevelChange? RiskLevelChange { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalChange";
    }

    public PrincipalChange Set(
        System.String? FullName = null,
        System.String? PrincipalId = null,
        DateTime? Time = null,
        CountChange? CountChange = null,
        RiskLevelChange? RiskLevelChange = null
    ) 
    {
        if ( FullName != null ) {
            this.FullName = FullName;
        }
        if ( PrincipalId != null ) {
            this.PrincipalId = PrincipalId;
        }
        if ( Time != null ) {
            this.Time = Time;
        }
        if ( CountChange != null ) {
            this.CountChange = CountChange;
        }
        if ( RiskLevelChange != null ) {
            this.RiskLevelChange = RiskLevelChange;
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
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fullName\n" ;
            } else {
                s += ind + "fullName\n" ;
            }
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalId\n" ;
            } else {
                s += ind + "principalId\n" ;
            }
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time != null) {
            if (conf.Flat) {
                s += conf.Prefix + "time\n" ;
            } else {
                s += ind + "time\n" ;
            }
        }
        //      C# -> CountChange? CountChange
        // GraphQL -> countChange: CountChange (type)
        if (this.CountChange != null) {
            var fspec = this.CountChange.AsFieldSpec(conf.Child("countChange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "countChange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RiskLevelChange? RiskLevelChange
        // GraphQL -> riskLevelChange: RiskLevelChange (type)
        if (this.RiskLevelChange != null) {
            var fspec = this.RiskLevelChange.AsFieldSpec(conf.Child("riskLevelChange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "riskLevelChange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (ec.Includes("fullName",true))
        {
            if(this.FullName == null) {

                this.FullName = "FETCH";

            } else {


            }
        }
        else if (this.FullName != null && ec.Excludes("fullName",true))
        {
            this.FullName = null;
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (ec.Includes("principalId",true))
        {
            if(this.PrincipalId == null) {

                this.PrincipalId = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalId != null && ec.Excludes("principalId",true))
        {
            this.PrincipalId = null;
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (ec.Includes("time",true))
        {
            if(this.Time == null) {

                this.Time = new DateTime();

            } else {


            }
        }
        else if (this.Time != null && ec.Excludes("time",true))
        {
            this.Time = null;
        }
        //      C# -> CountChange? CountChange
        // GraphQL -> countChange: CountChange (type)
        if (ec.Includes("countChange",false))
        {
            if(this.CountChange == null) {

                this.CountChange = new CountChange();
                this.CountChange.ApplyExploratoryFieldSpec(ec.NewChild("countChange"));

            } else {

                this.CountChange.ApplyExploratoryFieldSpec(ec.NewChild("countChange"));

            }
        }
        else if (this.CountChange != null && ec.Excludes("countChange",false))
        {
            this.CountChange = null;
        }
        //      C# -> RiskLevelChange? RiskLevelChange
        // GraphQL -> riskLevelChange: RiskLevelChange (type)
        if (ec.Includes("riskLevelChange",false))
        {
            if(this.RiskLevelChange == null) {

                this.RiskLevelChange = new RiskLevelChange();
                this.RiskLevelChange.ApplyExploratoryFieldSpec(ec.NewChild("riskLevelChange"));

            } else {

                this.RiskLevelChange.ApplyExploratoryFieldSpec(ec.NewChild("riskLevelChange"));

            }
        }
        else if (this.RiskLevelChange != null && ec.Excludes("riskLevelChange",false))
        {
            this.RiskLevelChange = null;
        }
    }


    #endregion

    } // class PrincipalChange
    
    #endregion

    public static class ListPrincipalChangeExtensions
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
            this List<PrincipalChange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrincipalChange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalChange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalChange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrincipalChange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types