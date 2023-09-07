// EndDateRecurrenceRange.cs
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
    #region EndDateRecurrenceRange
    public class EndDateRecurrenceRange: BaseType
    {
        #region members

        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime! (scalar)
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime! (scalar)
        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EndDateRecurrenceRange";
    }

    public EndDateRecurrenceRange Set(
        DateTime? EndDate = null,
        DateTime? StartDate = null
    ) 
    {
        if ( EndDate != null ) {
            this.EndDate = EndDate;
        }
        if ( StartDate != null ) {
            this.StartDate = StartDate;
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
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime! (scalar)
        if (this.EndDate != null) {
            s += ind + "endDate\n" ;
        }
        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime! (scalar)
        if (this.StartDate != null) {
            s += ind + "startDate\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime! (scalar)
        if (this.EndDate == null && ec.Includes("endDate",true))
        {
            this.EndDate = new DateTime();
        }
        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime! (scalar)
        if (this.StartDate == null && ec.Includes("startDate",true))
        {
            this.StartDate = new DateTime();
        }
    }


    #endregion

    } // class EndDateRecurrenceRange
    
    #endregion

    public static class ListEndDateRecurrenceRangeExtensions
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
            this List<EndDateRecurrenceRange> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<EndDateRecurrenceRange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EndDateRecurrenceRange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<EndDateRecurrenceRange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types