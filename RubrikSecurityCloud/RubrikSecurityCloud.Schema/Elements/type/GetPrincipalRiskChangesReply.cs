// GetPrincipalRiskChangesReply.cs
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
    #region GetPrincipalRiskChangesReply
    public class GetPrincipalRiskChangesReply: BaseType
    {
        #region members

        //      C# -> List<PrincipalChange>? PrincipalChanges
        // GraphQL -> principalChanges: [PrincipalChange!]! (type)
        [JsonProperty("principalChanges")]
        public List<PrincipalChange>? PrincipalChanges { get; set; }


        #endregion

    #region methods

    public GetPrincipalRiskChangesReply Set(
        List<PrincipalChange>? PrincipalChanges = null
    ) 
    {
        if ( PrincipalChanges != null ) {
            this.PrincipalChanges = PrincipalChanges;
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
        //      C# -> List<PrincipalChange>? PrincipalChanges
        // GraphQL -> principalChanges: [PrincipalChange!]! (type)
        if (this.PrincipalChanges != null) {
            s += ind + "principalChanges {\n" + this.PrincipalChanges.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<PrincipalChange>? PrincipalChanges
        // GraphQL -> principalChanges: [PrincipalChange!]! (type)
        if (this.PrincipalChanges == null && Exploration.Includes(parent + ".principalChanges"))
        {
            this.PrincipalChanges = new List<PrincipalChange>();
            this.PrincipalChanges.ApplyExploratoryFieldSpec(parent + ".principalChanges");
        }
    }


    #endregion

    } // class GetPrincipalRiskChangesReply
    
    #endregion

    public static class ListGetPrincipalRiskChangesReplyExtensions
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
            this List<GetPrincipalRiskChangesReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetPrincipalRiskChangesReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPrincipalRiskChangesReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types