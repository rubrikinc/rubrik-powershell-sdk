// RecoveryPlanPermissionCheckReply.cs
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
    #region RecoveryPlanPermissionCheckReply
    public class RecoveryPlanPermissionCheckReply: BaseType
    {
        #region members

        //      C# -> List<RecoveryPlanPermission>? Result
        // GraphQL -> result: [RecoveryPlanPermission!]! (type)
        [JsonProperty("result")]
        public List<RecoveryPlanPermission>? Result { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryPlanPermissionCheckReply";
    }

    public RecoveryPlanPermissionCheckReply Set(
        List<RecoveryPlanPermission>? Result = null
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
        //      C# -> List<RecoveryPlanPermission>? Result
        // GraphQL -> result: [RecoveryPlanPermission!]! (type)
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
        //      C# -> List<RecoveryPlanPermission>? Result
        // GraphQL -> result: [RecoveryPlanPermission!]! (type)
        if (this.Result == null && ec.Includes("result",false))
        {
            this.Result = new List<RecoveryPlanPermission>();
            this.Result.ApplyExploratoryFieldSpec(ec.NewChild("result"));
        }
    }


    #endregion

    } // class RecoveryPlanPermissionCheckReply
    
    #endregion

    public static class ListRecoveryPlanPermissionCheckReplyExtensions
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
            this List<RecoveryPlanPermissionCheckReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPlanPermissionCheckReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPlanPermissionCheckReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<RecoveryPlanPermissionCheckReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types