// PendingAction.cs
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
    #region PendingAction
    public class PendingAction: BaseType
    {
        #region members

        //      C# -> PendingActionStatus? Status
        // GraphQL -> status: PendingActionStatus! (enum)
        [JsonProperty("status")]
        public PendingActionStatus? Status { get; set; }

        //      C# -> System.String? ActionTypeStr
        // GraphQL -> actionTypeStr: String! (scalar)
        [JsonProperty("actionTypeStr")]
        public System.String? ActionTypeStr { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        [JsonProperty("info")]
        public System.String? Info { get; set; }

        //      C# -> System.String? PendingActionId
        // GraphQL -> pendingActionId: String! (scalar)
        [JsonProperty("pendingActionId")]
        public System.String? PendingActionId { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> PendingActionType? ActionType
        // GraphQL -> actionType: PendingActionType (type)
        [JsonProperty("actionType")]
        public PendingActionType? ActionType { get; set; }


        #endregion

    #region methods

    public PendingAction Set(
        PendingActionStatus? Status = null,
        System.String? ActionTypeStr = null,
        System.String? ClusterUuid = null,
        DateTime? CreatedAt = null,
        System.String? Description = null,
        System.String? Info = null,
        System.String? PendingActionId = null,
        DateTime? UpdatedAt = null,
        PendingActionType? ActionType = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ActionTypeStr != null ) {
            this.ActionTypeStr = ActionTypeStr;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Info != null ) {
            this.Info = Info;
        }
        if ( PendingActionId != null ) {
            this.PendingActionId = PendingActionId;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( ActionType != null ) {
            this.ActionType = ActionType;
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
        //      C# -> PendingActionStatus? Status
        // GraphQL -> status: PendingActionStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? ActionTypeStr
        // GraphQL -> actionTypeStr: String! (scalar)
        if (this.ActionTypeStr != null) {
            s += ind + "actionTypeStr\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            s += ind + "createdAt\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        if (this.Info != null) {
            s += ind + "info\n" ;
        }
        //      C# -> System.String? PendingActionId
        // GraphQL -> pendingActionId: String! (scalar)
        if (this.PendingActionId != null) {
            s += ind + "pendingActionId\n" ;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            s += ind + "updatedAt\n" ;
        }
        //      C# -> PendingActionType? ActionType
        // GraphQL -> actionType: PendingActionType (type)
        if (this.ActionType != null) {
            s += ind + "actionType {\n" + this.ActionType.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> PendingActionStatus? Status
        // GraphQL -> status: PendingActionStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new PendingActionStatus();
        }
        //      C# -> System.String? ActionTypeStr
        // GraphQL -> actionTypeStr: String! (scalar)
        if (this.ActionTypeStr == null && Exploration.Includes(parent + ".actionTypeStr", true))
        {
            this.ActionTypeStr = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt", true))
        {
            this.CreatedAt = new DateTime();
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        if (this.Info == null && Exploration.Includes(parent + ".info", true))
        {
            this.Info = "FETCH";
        }
        //      C# -> System.String? PendingActionId
        // GraphQL -> pendingActionId: String! (scalar)
        if (this.PendingActionId == null && Exploration.Includes(parent + ".pendingActionId", true))
        {
            this.PendingActionId = "FETCH";
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt == null && Exploration.Includes(parent + ".updatedAt", true))
        {
            this.UpdatedAt = new DateTime();
        }
        //      C# -> PendingActionType? ActionType
        // GraphQL -> actionType: PendingActionType (type)
        if (this.ActionType == null && Exploration.Includes(parent + ".actionType"))
        {
            this.ActionType = new PendingActionType();
            this.ActionType.ApplyExploratoryFieldSpec(parent + ".actionType");
        }
    }


    #endregion

    } // class PendingAction
    
    #endregion

    public static class ListPendingActionExtensions
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
            this List<PendingAction> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PendingAction> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PendingAction());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types