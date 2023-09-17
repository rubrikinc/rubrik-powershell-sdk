// ListIntegrationsReply.cs
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
    #region ListIntegrationsReply
    public class ListIntegrationsReply: BaseType
    {
        #region members

        //      C# -> List<Integration>? Integrations
        // GraphQL -> integrations: [Integration!]! (type)
        [JsonProperty("integrations")]
        public List<Integration>? Integrations { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ListIntegrationsReply";
    }

    public ListIntegrationsReply Set(
        List<Integration>? Integrations = null
    ) 
    {
        if ( Integrations != null ) {
            this.Integrations = Integrations;
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
        //      C# -> List<Integration>? Integrations
        // GraphQL -> integrations: [Integration!]! (type)
        if (this.Integrations != null) {
            var fspec = this.Integrations.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "integrations {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Integration>? Integrations
        // GraphQL -> integrations: [Integration!]! (type)
        if (this.Integrations == null && ec.Includes("integrations",false))
        {
            this.Integrations = new List<Integration>();
            this.Integrations.ApplyExploratoryFieldSpec(ec.NewChild("integrations"));
        }
    }


    #endregion

    } // class ListIntegrationsReply
    
    #endregion

    public static class ListListIntegrationsReplyExtensions
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
            this List<ListIntegrationsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ListIntegrationsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ListIntegrationsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ListIntegrationsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types