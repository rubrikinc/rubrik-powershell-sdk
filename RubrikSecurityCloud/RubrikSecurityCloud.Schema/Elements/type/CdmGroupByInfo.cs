// CdmGroupByInfo.cs
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
    #region CdmGroupByInfo
    public class CdmGroupByInfo: BaseType
    {
        #region members

        //      C# -> DateTime? End
        // GraphQL -> end: DateTime (scalar)
        [JsonProperty("end")]
        public DateTime? End { get; set; }

        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        [JsonProperty("group")]
        public System.String? Group { get; set; }

        //      C# -> DateTime? Start
        // GraphQL -> start: DateTime (scalar)
        [JsonProperty("start")]
        public DateTime? Start { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmGroupByInfo";
    }

    public CdmGroupByInfo Set(
        DateTime? End = null,
        System.String? Group = null,
        DateTime? Start = null
    ) 
    {
        if ( End != null ) {
            this.End = End;
        }
        if ( Group != null ) {
            this.Group = Group;
        }
        if ( Start != null ) {
            this.Start = Start;
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
        //      C# -> DateTime? End
        // GraphQL -> end: DateTime (scalar)
        if (this.End != null) {
            s += ind + "end\n" ;
        }
        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        if (this.Group != null) {
            s += ind + "group\n" ;
        }
        //      C# -> DateTime? Start
        // GraphQL -> start: DateTime (scalar)
        if (this.Start != null) {
            s += ind + "start\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? End
        // GraphQL -> end: DateTime (scalar)
        if (this.End == null && ec.Includes("end",true))
        {
            this.End = new DateTime();
        }
        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        if (this.Group == null && ec.Includes("group",true))
        {
            this.Group = "FETCH";
        }
        //      C# -> DateTime? Start
        // GraphQL -> start: DateTime (scalar)
        if (this.Start == null && ec.Includes("start",true))
        {
            this.Start = new DateTime();
        }
    }


    #endregion

    } // class CdmGroupByInfo
    
    #endregion

    public static class ListCdmGroupByInfoExtensions
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
            this List<CdmGroupByInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmGroupByInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmGroupByInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmGroupByInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types