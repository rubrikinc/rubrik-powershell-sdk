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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName != null) {
            s += ind + "fullName\n" ;
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId != null) {
            s += ind + "principalId\n" ;
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time != null) {
            s += ind + "time\n" ;
        }
        //      C# -> CountChange? CountChange
        // GraphQL -> countChange: CountChange (type)
        if (this.CountChange != null) {
            var fspec = this.CountChange.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "countChange {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RiskLevelChange? RiskLevelChange
        // GraphQL -> riskLevelChange: RiskLevelChange (type)
        if (this.RiskLevelChange != null) {
            var fspec = this.RiskLevelChange.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "riskLevelChange {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName == null && ec.Includes("fullName",true))
        {
            this.FullName = "FETCH";
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId == null && ec.Includes("principalId",true))
        {
            this.PrincipalId = "FETCH";
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time == null && ec.Includes("time",true))
        {
            this.Time = new DateTime();
        }
        //      C# -> CountChange? CountChange
        // GraphQL -> countChange: CountChange (type)
        if (this.CountChange == null && ec.Includes("countChange",false))
        {
            this.CountChange = new CountChange();
            this.CountChange.ApplyExploratoryFieldSpec(ec.NewChild("countChange"));
        }
        //      C# -> RiskLevelChange? RiskLevelChange
        // GraphQL -> riskLevelChange: RiskLevelChange (type)
        if (this.RiskLevelChange == null && ec.Includes("riskLevelChange",false))
        {
            this.RiskLevelChange = new RiskLevelChange();
            this.RiskLevelChange.ApplyExploratoryFieldSpec(ec.NewChild("riskLevelChange"));
        }
    }


    #endregion

    } // class PrincipalChange
    
    #endregion

    public static class ListPrincipalChangeExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<PrincipalChange> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<PrincipalChange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types