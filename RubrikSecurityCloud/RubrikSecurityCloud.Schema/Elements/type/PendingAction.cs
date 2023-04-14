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

namespace Rubrik.SecurityCloud.Types
{
    #region PendingAction
    public class PendingAction: IFragment
    {
        #region members
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

        //      C# -> PendingActionStatus? Status
        // GraphQL -> status: PendingActionStatus! (enum)
        [JsonProperty("status")]
        public PendingActionStatus? Status { get; set; }

        #endregion

    #region methods

    public PendingAction Set(
        System.String? ActionTypeStr = null,
        System.String? ClusterUuid = null,
        DateTime? CreatedAt = null,
        System.String? Description = null,
        System.String? Info = null,
        System.String? PendingActionId = null,
        DateTime? UpdatedAt = null,
        PendingActionType? ActionType = null,
        PendingActionStatus? Status = null
    ) 
    {
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
        if ( Status != null ) {
            this.Status = Status;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? ActionTypeStr
            // GraphQL -> actionTypeStr: String! (scalar)
            if (this.ActionTypeStr != null)
            {
                 s += ind + "actionTypeStr\n";

            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> DateTime? CreatedAt
            // GraphQL -> createdAt: DateTime (scalar)
            if (this.CreatedAt != null)
            {
                 s += ind + "createdAt\n";

            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> System.String? Info
            // GraphQL -> info: String! (scalar)
            if (this.Info != null)
            {
                 s += ind + "info\n";

            }
            //      C# -> System.String? PendingActionId
            // GraphQL -> pendingActionId: String! (scalar)
            if (this.PendingActionId != null)
            {
                 s += ind + "pendingActionId\n";

            }
            //      C# -> DateTime? UpdatedAt
            // GraphQL -> updatedAt: DateTime (scalar)
            if (this.UpdatedAt != null)
            {
                 s += ind + "updatedAt\n";

            }
            //      C# -> PendingActionType? ActionType
            // GraphQL -> actionType: PendingActionType (type)
            if (this.ActionType != null)
            {
                 s += ind + "actionType\n";

                 s += ind + "{\n" + 
                 this.ActionType.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PendingActionStatus? Status
            // GraphQL -> status: PendingActionStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ActionTypeStr
            // GraphQL -> actionTypeStr: String! (scalar)
            if (this.ActionTypeStr == null && Exploration.Includes(parent + ".actionTypeStr$"))
            {
                this.ActionTypeStr = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> DateTime? CreatedAt
            // GraphQL -> createdAt: DateTime (scalar)
            if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt$"))
            {
                this.CreatedAt = new DateTime();
            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> System.String? Info
            // GraphQL -> info: String! (scalar)
            if (this.Info == null && Exploration.Includes(parent + ".info$"))
            {
                this.Info = new System.String("FETCH");
            }
            //      C# -> System.String? PendingActionId
            // GraphQL -> pendingActionId: String! (scalar)
            if (this.PendingActionId == null && Exploration.Includes(parent + ".pendingActionId$"))
            {
                this.PendingActionId = new System.String("FETCH");
            }
            //      C# -> DateTime? UpdatedAt
            // GraphQL -> updatedAt: DateTime (scalar)
            if (this.UpdatedAt == null && Exploration.Includes(parent + ".updatedAt$"))
            {
                this.UpdatedAt = new DateTime();
            }
            //      C# -> PendingActionType? ActionType
            // GraphQL -> actionType: PendingActionType (type)
            if (this.ActionType == null && Exploration.Includes(parent + ".actionType"))
            {
                this.ActionType = new PendingActionType();
                this.ActionType.ApplyExploratoryFragment(parent + ".actionType");
            }
            //      C# -> PendingActionStatus? Status
            // GraphQL -> status: PendingActionStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new PendingActionStatus();
            }
        }


    #endregion

    } // class PendingAction
    #endregion

    public static class ListPendingActionExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<PendingAction> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PendingAction> list, 
            String parent = "")
        {
            var item = new PendingAction();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types