// UpdateInsightStateReply.cs
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
    #region UpdateInsightStateReply
    public class UpdateInsightStateReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsInsightDismissed
        // GraphQL -> isInsightDismissed: Boolean! (scalar)
        [JsonProperty("isInsightDismissed")]
        public System.Boolean? IsInsightDismissed { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateInsightStateReply";
    }

    public UpdateInsightStateReply Set(
        System.Boolean? IsInsightDismissed = null
    ) 
    {
        if ( IsInsightDismissed != null ) {
            this.IsInsightDismissed = IsInsightDismissed;
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
        //      C# -> System.Boolean? IsInsightDismissed
        // GraphQL -> isInsightDismissed: Boolean! (scalar)
        if (this.IsInsightDismissed != null) {
            s += ind + "isInsightDismissed\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsInsightDismissed
        // GraphQL -> isInsightDismissed: Boolean! (scalar)
        if (this.IsInsightDismissed == null && ec.Includes("isInsightDismissed",true))
        {
            this.IsInsightDismissed = true;
        }
    }


    #endregion

    } // class UpdateInsightStateReply
    
    #endregion

    public static class ListUpdateInsightStateReplyExtensions
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
            this List<UpdateInsightStateReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateInsightStateReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateInsightStateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateInsightStateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types