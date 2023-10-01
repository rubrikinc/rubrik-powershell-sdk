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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime! (scalar)
        if (this.EndDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endDate\n" ;
            } else {
                s += ind + "endDate\n" ;
            }
        }
        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime! (scalar)
        if (this.StartDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startDate\n" ;
            } else {
                s += ind + "startDate\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime! (scalar)
        if (ec.Includes("endDate",true))
        {
            if(this.EndDate == null) {

                this.EndDate = new DateTime();

            } else {


            }
        }
        else if (this.EndDate != null && ec.Excludes("endDate",true))
        {
            this.EndDate = null;
        }
        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime! (scalar)
        if (ec.Includes("startDate",true))
        {
            if(this.StartDate == null) {

                this.StartDate = new DateTime();

            } else {


            }
        }
        else if (this.StartDate != null && ec.Excludes("startDate",true))
        {
            this.StartDate = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<EndDateRecurrenceRange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<EndDateRecurrenceRange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types