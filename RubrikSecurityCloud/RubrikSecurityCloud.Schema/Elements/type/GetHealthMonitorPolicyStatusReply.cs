// GetHealthMonitorPolicyStatusReply.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region GetHealthMonitorPolicyStatusReply
    public class GetHealthMonitorPolicyStatusReply: BaseType
    {
        #region members

        //      C# -> List<NodePolicyCheckResult>? Items
        // GraphQL -> items: [NodePolicyCheckResult!]! (type)
        [JsonProperty("items")]
        public List<NodePolicyCheckResult>? Items { get; set; }


        #endregion

    #region methods

    public GetHealthMonitorPolicyStatusReply Set(
        List<NodePolicyCheckResult>? Items = null
    ) 
    {
        if ( Items != null ) {
            this.Items = Items;
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
        //      C# -> List<NodePolicyCheckResult>? Items
        // GraphQL -> items: [NodePolicyCheckResult!]! (type)
        if (this.Items != null) {
            s += ind + "items {\n" + this.Items.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<NodePolicyCheckResult>? Items
        // GraphQL -> items: [NodePolicyCheckResult!]! (type)
        if (this.Items == null && Exploration.Includes(parent + ".items"))
        {
            this.Items = new List<NodePolicyCheckResult>();
            this.Items.ApplyExploratoryFieldSpec(parent + ".items");
        }
    }


    #endregion

    } // class GetHealthMonitorPolicyStatusReply
    
    #endregion

    public static class ListGetHealthMonitorPolicyStatusReplyExtensions
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
            this List<GetHealthMonitorPolicyStatusReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetHealthMonitorPolicyStatusReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetHealthMonitorPolicyStatusReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types