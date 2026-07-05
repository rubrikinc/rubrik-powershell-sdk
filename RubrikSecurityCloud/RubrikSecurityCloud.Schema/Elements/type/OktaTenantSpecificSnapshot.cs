// OktaTenantSpecificSnapshot.cs
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
    #region OktaTenantSpecificSnapshot
 
    public class OktaTenantSpecificSnapshot: BaseType, PolarisSpecificSnapshot
    {
        #region members

        //      C# -> System.Boolean? IsWorkflowSetUp
        // GraphQL -> isWorkflowSetUp: Boolean! (scalar)
        [JsonProperty("isWorkflowSetUp")]
        public System.Boolean? IsWorkflowSetUp { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? WorkflowProtectionFailureReason
        // GraphQL -> workflowProtectionFailureReason: String (scalar)
        [JsonProperty("workflowProtectionFailureReason")]
        public System.String? WorkflowProtectionFailureReason { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OktaTenantSpecificSnapshot";
    }

    public OktaTenantSpecificSnapshot Set(
        System.Boolean? IsWorkflowSetUp = null,
        System.String? SnapshotId = null,
        System.String? WorkflowProtectionFailureReason = null
    ) 
    {
        if ( IsWorkflowSetUp != null ) {
            this.IsWorkflowSetUp = IsWorkflowSetUp;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( WorkflowProtectionFailureReason != null ) {
            this.WorkflowProtectionFailureReason = WorkflowProtectionFailureReason;
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
        //      C# -> System.Boolean? IsWorkflowSetUp
        // GraphQL -> isWorkflowSetUp: Boolean! (scalar)
        if (this.IsWorkflowSetUp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isWorkflowSetUp\n" ;
            } else {
                s += ind + "isWorkflowSetUp\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.String? WorkflowProtectionFailureReason
        // GraphQL -> workflowProtectionFailureReason: String (scalar)
        if (this.WorkflowProtectionFailureReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workflowProtectionFailureReason\n" ;
            } else {
                s += ind + "workflowProtectionFailureReason\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsWorkflowSetUp
        // GraphQL -> isWorkflowSetUp: Boolean! (scalar)
        if (ec.Includes("isWorkflowSetUp",true))
        {
            if(this.IsWorkflowSetUp == null) {

                this.IsWorkflowSetUp = true;

            } else {


            }
        }
        else if (this.IsWorkflowSetUp != null && ec.Excludes("isWorkflowSetUp",true))
        {
            this.IsWorkflowSetUp = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.String? WorkflowProtectionFailureReason
        // GraphQL -> workflowProtectionFailureReason: String (scalar)
        if (ec.Includes("workflowProtectionFailureReason",true))
        {
            if(this.WorkflowProtectionFailureReason == null) {

                this.WorkflowProtectionFailureReason = "FETCH";

            } else {


            }
        }
        else if (this.WorkflowProtectionFailureReason != null && ec.Excludes("workflowProtectionFailureReason",true))
        {
            this.WorkflowProtectionFailureReason = null;
        }
    }


    #endregion

    } // class OktaTenantSpecificSnapshot
    
    #endregion

    public static class ListOktaTenantSpecificSnapshotExtensions
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
            this List<OktaTenantSpecificSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OktaTenantSpecificSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OktaTenantSpecificSnapshot> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OktaTenantSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OktaTenantSpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types