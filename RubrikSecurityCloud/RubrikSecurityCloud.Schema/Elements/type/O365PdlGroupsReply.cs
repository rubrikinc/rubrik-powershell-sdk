// O365PdlGroupsReply.cs
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
    #region O365PdlGroupsReply
    public class O365PdlGroupsReply: BaseType
    {
        #region members

        //      C# -> List<O365PdlGroup>? Groups
        // GraphQL -> groups: [O365PdlGroup!]! (type)
        [JsonProperty("groups")]
        public List<O365PdlGroup>? Groups { get; set; }


        #endregion

    #region methods

    public O365PdlGroupsReply Set(
        List<O365PdlGroup>? Groups = null
    ) 
    {
        if ( Groups != null ) {
            this.Groups = Groups;
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
        //      C# -> List<O365PdlGroup>? Groups
        // GraphQL -> groups: [O365PdlGroup!]! (type)
        if (this.Groups != null) {
            s += ind + "groups {\n" + this.Groups.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<O365PdlGroup>? Groups
        // GraphQL -> groups: [O365PdlGroup!]! (type)
        if (this.Groups == null && Exploration.Includes(parent + ".groups"))
        {
            this.Groups = new List<O365PdlGroup>();
            this.Groups.ApplyExploratoryFieldSpec(parent + ".groups");
        }
    }


    #endregion

    } // class O365PdlGroupsReply
    
    #endregion

    public static class ListO365PdlGroupsReplyExtensions
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
            this List<O365PdlGroupsReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365PdlGroupsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365PdlGroupsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types