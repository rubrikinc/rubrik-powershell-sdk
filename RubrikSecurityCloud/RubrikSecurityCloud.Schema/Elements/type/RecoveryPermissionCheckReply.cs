// RecoveryPermissionCheckReply.cs
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
    #region RecoveryPermissionCheckReply
    public class RecoveryPermissionCheckReply: BaseType
    {
        #region members

        //      C# -> List<RecoveryPermission>? Result
        // GraphQL -> result: [RecoveryPermission!]! (type)
        [JsonProperty("result")]
        public List<RecoveryPermission>? Result { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryPermissionCheckReply";
    }

    public RecoveryPermissionCheckReply Set(
        List<RecoveryPermission>? Result = null
    ) 
    {
        if ( Result != null ) {
            this.Result = Result;
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
        //      C# -> List<RecoveryPermission>? Result
        // GraphQL -> result: [RecoveryPermission!]! (type)
        if (this.Result != null) {
            var fspec = this.Result.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "result {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RecoveryPermission>? Result
        // GraphQL -> result: [RecoveryPermission!]! (type)
        if (this.Result == null && ec.Includes("result",false))
        {
            this.Result = new List<RecoveryPermission>();
            this.Result.ApplyExploratoryFieldSpec(ec.NewChild("result"));
        }
    }


    #endregion

    } // class RecoveryPermissionCheckReply
    
    #endregion

    public static class ListRecoveryPermissionCheckReplyExtensions
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
            this List<RecoveryPermissionCheckReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPermissionCheckReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPermissionCheckReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<RecoveryPermissionCheckReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types