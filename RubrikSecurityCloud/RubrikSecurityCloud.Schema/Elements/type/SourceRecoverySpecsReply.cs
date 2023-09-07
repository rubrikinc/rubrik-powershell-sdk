// SourceRecoverySpecsReply.cs
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
    #region SourceRecoverySpecsReply
    public class SourceRecoverySpecsReply: BaseType
    {
        #region members

        //      C# -> List<SourceChildRecoverySpecMap>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [SourceChildRecoverySpecMap!]! (type)
        [JsonProperty("childRecoverySpecs")]
        public List<SourceChildRecoverySpecMap>? ChildRecoverySpecs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SourceRecoverySpecsReply";
    }

    public SourceRecoverySpecsReply Set(
        List<SourceChildRecoverySpecMap>? ChildRecoverySpecs = null
    ) 
    {
        if ( ChildRecoverySpecs != null ) {
            this.ChildRecoverySpecs = ChildRecoverySpecs;
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
        //      C# -> List<SourceChildRecoverySpecMap>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [SourceChildRecoverySpecMap!]! (type)
        if (this.ChildRecoverySpecs != null) {
            var fspec = this.ChildRecoverySpecs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "childRecoverySpecs {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SourceChildRecoverySpecMap>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [SourceChildRecoverySpecMap!]! (type)
        if (this.ChildRecoverySpecs == null && ec.Includes("childRecoverySpecs",false))
        {
            this.ChildRecoverySpecs = new List<SourceChildRecoverySpecMap>();
            this.ChildRecoverySpecs.ApplyExploratoryFieldSpec(ec.NewChild("childRecoverySpecs"));
        }
    }


    #endregion

    } // class SourceRecoverySpecsReply
    
    #endregion

    public static class ListSourceRecoverySpecsReplyExtensions
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
            this List<SourceRecoverySpecsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SourceRecoverySpecsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SourceRecoverySpecsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SourceRecoverySpecsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types