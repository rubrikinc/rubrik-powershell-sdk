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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "pendingAction";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> PendingActionStatus? Status
        // GraphQL -> status: PendingActionStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? ActionTypeStr
        // GraphQL -> actionTypeStr: String! (scalar)
        if (this.ActionTypeStr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actionTypeStr\n" ;
            } else {
                s += ind + "actionTypeStr\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        if (this.Info != null) {
            if (conf.Flat) {
                s += conf.Prefix + "info\n" ;
            } else {
                s += ind + "info\n" ;
            }
        }
        //      C# -> System.String? PendingActionId
        // GraphQL -> pendingActionId: String! (scalar)
        if (this.PendingActionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingActionId\n" ;
            } else {
                s += ind + "pendingActionId\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        //      C# -> PendingActionType? ActionType
        // GraphQL -> actionType: PendingActionType (type)
        if (this.ActionType != null) {
            var fspec = this.ActionType.AsFieldSpec(conf.Child("actionType"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "actionType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PendingActionStatus? Status
        // GraphQL -> status: PendingActionStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new PendingActionStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? ActionTypeStr
        // GraphQL -> actionTypeStr: String! (scalar)
        if (ec.Includes("actionTypeStr",true))
        {
            if(this.ActionTypeStr == null) {

                this.ActionTypeStr = "FETCH";

            } else {


            }
        }
        else if (this.ActionTypeStr != null && ec.Excludes("actionTypeStr",true))
        {
            this.ActionTypeStr = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        if (ec.Includes("info",true))
        {
            if(this.Info == null) {

                this.Info = "FETCH";

            } else {


            }
        }
        else if (this.Info != null && ec.Excludes("info",true))
        {
            this.Info = null;
        }
        //      C# -> System.String? PendingActionId
        // GraphQL -> pendingActionId: String! (scalar)
        if (ec.Includes("pendingActionId",true))
        {
            if(this.PendingActionId == null) {

                this.PendingActionId = "FETCH";

            } else {


            }
        }
        else if (this.PendingActionId != null && ec.Excludes("pendingActionId",true))
        {
            this.PendingActionId = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
        //      C# -> PendingActionType? ActionType
        // GraphQL -> actionType: PendingActionType (type)
        if (ec.Includes("actionType",false))
        {
            if(this.ActionType == null) {

                this.ActionType = new PendingActionType();
                this.ActionType.ApplyExploratoryFieldSpec(ec.NewChild("actionType"));

            } else {

                this.ActionType.ApplyExploratoryFieldSpec(ec.NewChild("actionType"));

            }
        }
        else if (this.ActionType != null && ec.Excludes("actionType",false))
        {
            this.ActionType = null;
        }
    }


    #endregion

    } // class PendingAction
    
    #endregion

    public static class ListPendingActionExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<PendingAction> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PendingAction> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PendingAction> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PendingAction());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PendingAction> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types