// O365PdlGroup.cs
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
    #region O365PdlGroup
    public class O365PdlGroup: BaseType
    {
        #region members

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID! (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> O365PdlAndWorkloadPair? PdlAndWorkload
        // GraphQL -> pdlAndWorkload: O365PdlAndWorkloadPair! (type)
        [JsonProperty("pdlAndWorkload")]
        public O365PdlAndWorkloadPair? PdlAndWorkload { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365PdlGroup";
    }

    public O365PdlGroup Set(
        System.String? GroupId = null,
        O365PdlAndWorkloadPair? PdlAndWorkload = null
    ) 
    {
        if ( GroupId != null ) {
            this.GroupId = GroupId;
        }
        if ( PdlAndWorkload != null ) {
            this.PdlAndWorkload = PdlAndWorkload;
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
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID! (scalar)
        if (this.GroupId != null) {
            s += ind + "groupId\n" ;
        }
        //      C# -> O365PdlAndWorkloadPair? PdlAndWorkload
        // GraphQL -> pdlAndWorkload: O365PdlAndWorkloadPair! (type)
        if (this.PdlAndWorkload != null) {
            var fspec = this.PdlAndWorkload.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pdlAndWorkload {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID! (scalar)
        if (this.GroupId == null && ec.Includes("groupId",true))
        {
            this.GroupId = "FETCH";
        }
        //      C# -> O365PdlAndWorkloadPair? PdlAndWorkload
        // GraphQL -> pdlAndWorkload: O365PdlAndWorkloadPair! (type)
        if (this.PdlAndWorkload == null && ec.Includes("pdlAndWorkload",false))
        {
            this.PdlAndWorkload = new O365PdlAndWorkloadPair();
            this.PdlAndWorkload.ApplyExploratoryFieldSpec(ec.NewChild("pdlAndWorkload"));
        }
    }


    #endregion

    } // class O365PdlGroup
    
    #endregion

    public static class ListO365PdlGroupExtensions
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
            this List<O365PdlGroup> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365PdlGroup> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365PdlGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365PdlGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types