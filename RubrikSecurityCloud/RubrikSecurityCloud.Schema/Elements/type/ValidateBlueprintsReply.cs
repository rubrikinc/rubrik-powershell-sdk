// ValidateBlueprintsReply.cs
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
    #region ValidateBlueprintsReply
    public class ValidateBlueprintsReply: BaseType
    {
        #region members

        //      C# -> List<ValidateBlueprintReply>? BlueprintStatus
        // GraphQL -> blueprintStatus: [ValidateBlueprintReply!]! (type)
        [JsonProperty("blueprintStatus")]
        public List<ValidateBlueprintReply>? BlueprintStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidateBlueprintsReply";
    }

    public ValidateBlueprintsReply Set(
        List<ValidateBlueprintReply>? BlueprintStatus = null
    ) 
    {
        if ( BlueprintStatus != null ) {
            this.BlueprintStatus = BlueprintStatus;
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
        //      C# -> List<ValidateBlueprintReply>? BlueprintStatus
        // GraphQL -> blueprintStatus: [ValidateBlueprintReply!]! (type)
        if (this.BlueprintStatus != null) {
            var fspec = this.BlueprintStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "blueprintStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ValidateBlueprintReply>? BlueprintStatus
        // GraphQL -> blueprintStatus: [ValidateBlueprintReply!]! (type)
        if (this.BlueprintStatus == null && ec.Includes("blueprintStatus",false))
        {
            this.BlueprintStatus = new List<ValidateBlueprintReply>();
            this.BlueprintStatus.ApplyExploratoryFieldSpec(ec.NewChild("blueprintStatus"));
        }
    }


    #endregion

    } // class ValidateBlueprintsReply
    
    #endregion

    public static class ListValidateBlueprintsReplyExtensions
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
            this List<ValidateBlueprintsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValidateBlueprintsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateBlueprintsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ValidateBlueprintsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types