// ChildRecoverySpecMap.cs
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
    #region ChildRecoverySpecMap
    public class ChildRecoverySpecMap: BaseType
    {
        #region members

        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec! (interface)
        [JsonProperty("recoverySpec")]
        public RecoverySpec? RecoverySpec { get; set; }

        //      C# -> SlaDomain? Sla
        // GraphQL -> sla: SlaDomain (interface)
        [JsonProperty("sla")]
        public SlaDomain? Sla { get; set; }

        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long (scalar)
        [JsonProperty("recoveryPoint")]
        public System.Int64? RecoveryPoint { get; set; }

        //      C# -> System.String? RecoverySpecFid
        // GraphQL -> recoverySpecFid: String! (scalar)
        [JsonProperty("recoverySpecFid")]
        public System.String? RecoverySpecFid { get; set; }

        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String (scalar)
        [JsonProperty("slaId")]
        public System.String? SlaId { get; set; }

        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        [JsonProperty("snappableFid")]
        public System.String? SnappableFid { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ChildRecoverySpecMap";
    }

    public ChildRecoverySpecMap Set(
        RecoverySpec? RecoverySpec = null,
        SlaDomain? Sla = null,
        System.Int64? RecoveryPoint = null,
        System.String? RecoverySpecFid = null,
        System.String? SlaId = null,
        System.String? SnappableFid = null,
        System.String? SnapshotId = null
    ) 
    {
        if ( RecoverySpec != null ) {
            this.RecoverySpec = RecoverySpec;
        }
        if ( Sla != null ) {
            this.Sla = Sla;
        }
        if ( RecoveryPoint != null ) {
            this.RecoveryPoint = RecoveryPoint;
        }
        if ( RecoverySpecFid != null ) {
            this.RecoverySpecFid = RecoverySpecFid;
        }
        if ( SlaId != null ) {
            this.SlaId = SlaId;
        }
        if ( SnappableFid != null ) {
            this.SnappableFid = SnappableFid;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
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
        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec! (interface)
        if (this.RecoverySpec != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.RecoverySpec, conf.Child("recoverySpec"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoverySpec" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? Sla
        // GraphQL -> sla: SlaDomain (interface)
        if (this.Sla != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.Sla, conf.Child("sla"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sla" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long (scalar)
        if (this.RecoveryPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPoint\n" ;
            } else {
                s += ind + "recoveryPoint\n" ;
            }
        }
        //      C# -> System.String? RecoverySpecFid
        // GraphQL -> recoverySpecFid: String! (scalar)
        if (this.RecoverySpecFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoverySpecFid\n" ;
            } else {
                s += ind + "recoverySpecFid\n" ;
            }
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String (scalar)
        if (this.SlaId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaId\n" ;
            } else {
                s += ind + "slaId\n" ;
            }
        }
        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        if (this.SnappableFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableFid\n" ;
            } else {
                s += ind + "snappableFid\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec! (interface)
        if (ec.Includes("recoverySpec",false))
        {
            if(this.RecoverySpec == null) {

                var impls = new List<RecoverySpec>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("recoverySpec"));
                this.RecoverySpec = (RecoverySpec)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<RecoverySpec>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("recoverySpec"));
                this.RecoverySpec = (RecoverySpec)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.RecoverySpec != null && ec.Excludes("recoverySpec",false))
        {
            this.RecoverySpec = null;
        }
        //      C# -> SlaDomain? Sla
        // GraphQL -> sla: SlaDomain (interface)
        if (ec.Includes("sla",false))
        {
            if(this.Sla == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("sla"));
                this.Sla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("sla"));
                this.Sla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Sla != null && ec.Excludes("sla",false))
        {
            this.Sla = null;
        }
        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long (scalar)
        if (ec.Includes("recoveryPoint",true))
        {
            if(this.RecoveryPoint == null) {

                this.RecoveryPoint = new System.Int64();

            } else {


            }
        }
        else if (this.RecoveryPoint != null && ec.Excludes("recoveryPoint",true))
        {
            this.RecoveryPoint = null;
        }
        //      C# -> System.String? RecoverySpecFid
        // GraphQL -> recoverySpecFid: String! (scalar)
        if (ec.Includes("recoverySpecFid",true))
        {
            if(this.RecoverySpecFid == null) {

                this.RecoverySpecFid = "FETCH";

            } else {


            }
        }
        else if (this.RecoverySpecFid != null && ec.Excludes("recoverySpecFid",true))
        {
            this.RecoverySpecFid = null;
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String (scalar)
        if (ec.Includes("slaId",true))
        {
            if(this.SlaId == null) {

                this.SlaId = "FETCH";

            } else {


            }
        }
        else if (this.SlaId != null && ec.Excludes("slaId",true))
        {
            this.SlaId = null;
        }
        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        if (ec.Includes("snappableFid",true))
        {
            if(this.SnappableFid == null) {

                this.SnappableFid = "FETCH";

            } else {


            }
        }
        else if (this.SnappableFid != null && ec.Excludes("snappableFid",true))
        {
            this.SnappableFid = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
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
    }


    #endregion

    } // class ChildRecoverySpecMap
    
    #endregion

    public static class ListChildRecoverySpecMapExtensions
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
            this List<ChildRecoverySpecMap> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ChildRecoverySpecMap> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ChildRecoverySpecMap> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ChildRecoverySpecMap());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ChildRecoverySpecMap> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types