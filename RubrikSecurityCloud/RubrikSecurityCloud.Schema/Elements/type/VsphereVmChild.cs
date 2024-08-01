// VsphereVmChild.cs
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
    #region VsphereVmChild
 
    public class VsphereVmChild: BaseType, BlueprintChild
    {
        #region members

        //      C# -> ObjectTypeEnum? SnappableType
        // GraphQL -> snappableType: ObjectTypeEnum! (enum)
        [JsonProperty("snappableType")]
        public ObjectTypeEnum? SnappableType { get; set; }

        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec (interface)
        [JsonProperty("recoverySpec")]
        public RecoverySpec? RecoverySpec { get; set; }

        //      C# -> System.Int32? BootPriority
        // GraphQL -> bootPriority: Int! (scalar)
        [JsonProperty("bootPriority")]
        public System.Int32? BootPriority { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Int64? LastRecoveryPoint
        // GraphQL -> lastRecoveryPoint: Long (scalar)
        [JsonProperty("lastRecoveryPoint")]
        public System.Int64? LastRecoveryPoint { get; set; }

        //      C# -> VsphereBlueprintChildFailoverInstance? FailoverInstance
        // GraphQL -> failoverInstance: VsphereBlueprintChildFailoverInstance (type)
        [JsonProperty("failoverInstance")]
        public VsphereBlueprintChildFailoverInstance? FailoverInstance { get; set; }

        //      C# -> RpoLagInfo? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfo (type)
        [JsonProperty("localRpoLagInfo")]
        public RpoLagInfo? LocalRpoLagInfo { get; set; }

        //      C# -> ChildVmRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: ChildVmRecoveryInfo (type)
        [JsonProperty("recoveryInfo")]
        public ChildVmRecoveryInfo? RecoveryInfo { get; set; }

        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        [JsonProperty("remoteRpoLagInfo")]
        public RpoLagInfo? RemoteRpoLagInfo { get; set; }

        //      C# -> VmwareResourceSpec? ResourceSpec
        // GraphQL -> resourceSpec: VmwareResourceSpec (type)
        [JsonProperty("resourceSpec")]
        public VmwareResourceSpec? ResourceSpec { get; set; }

        //      C# -> VsphereVm? Snappable
        // GraphQL -> snappable: VsphereVm (type)
        [JsonProperty("snappable")]
        public VsphereVm? Snappable { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars RecoverySpec { get; set; }

        public RscGqlVars RecoveryInfo { get; set; }

        public RscGqlVars ResourceSpec { get; set; }


        public InlineVars() {
            Tuple<string, string>[] recoverySpecArgs = {
                    Tuple.Create("recoveryPoint", "Long"),
                };
            this.RecoverySpec =
                new RscGqlVars(null, recoverySpecArgs, null, true);
            Tuple<string, string>[] recoveryInfoArgs = {
                    Tuple.Create("clusterUuid", "UUID"),
                };
            this.RecoveryInfo =
                new RscGqlVars(null, recoveryInfoArgs, null, true);
            Tuple<string, string>[] resourceSpecArgs = {
                    Tuple.Create("recoveryPoint", "Long"),
                };
            this.ResourceSpec =
                new RscGqlVars(null, resourceSpecArgs, null, true);
        }
    }

    public VsphereVmChild()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "VSphereVmChild";
    }

    public VsphereVmChild Set(
        ObjectTypeEnum? SnappableType = null,
        RecoverySpec? RecoverySpec = null,
        System.Int32? BootPriority = null,
        System.String? Fid = null,
        System.Int64? LastRecoveryPoint = null,
        VsphereBlueprintChildFailoverInstance? FailoverInstance = null,
        RpoLagInfo? LocalRpoLagInfo = null,
        ChildVmRecoveryInfo? RecoveryInfo = null,
        RpoLagInfo? RemoteRpoLagInfo = null,
        VmwareResourceSpec? ResourceSpec = null,
        VsphereVm? Snappable = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( RecoverySpec != null ) {
            this.RecoverySpec = RecoverySpec;
        }
        if ( BootPriority != null ) {
            this.BootPriority = BootPriority;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( LastRecoveryPoint != null ) {
            this.LastRecoveryPoint = LastRecoveryPoint;
        }
        if ( FailoverInstance != null ) {
            this.FailoverInstance = FailoverInstance;
        }
        if ( LocalRpoLagInfo != null ) {
            this.LocalRpoLagInfo = LocalRpoLagInfo;
        }
        if ( RecoveryInfo != null ) {
            this.RecoveryInfo = RecoveryInfo;
        }
        if ( RemoteRpoLagInfo != null ) {
            this.RemoteRpoLagInfo = RemoteRpoLagInfo;
        }
        if ( ResourceSpec != null ) {
            this.ResourceSpec = ResourceSpec;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
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
        //      C# -> ObjectTypeEnum? SnappableType
        // GraphQL -> snappableType: ObjectTypeEnum! (enum)
        if (this.SnappableType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableType\n" ;
            } else {
                s += ind + "snappableType\n" ;
            }
        }
        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec (interface)
        if (this.RecoverySpec != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.RecoverySpec, conf.Child("recoverySpec"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoverySpec" + "\n(" + this.Vars.RecoverySpec.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.Int32? BootPriority
        // GraphQL -> bootPriority: Int! (scalar)
        if (this.BootPriority != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bootPriority\n" ;
            } else {
                s += ind + "bootPriority\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.Int64? LastRecoveryPoint
        // GraphQL -> lastRecoveryPoint: Long (scalar)
        if (this.LastRecoveryPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRecoveryPoint\n" ;
            } else {
                s += ind + "lastRecoveryPoint\n" ;
            }
        }
        //      C# -> VsphereBlueprintChildFailoverInstance? FailoverInstance
        // GraphQL -> failoverInstance: VsphereBlueprintChildFailoverInstance (type)
        if (this.FailoverInstance != null) {
            var fspec = this.FailoverInstance.AsFieldSpec(conf.Child("failoverInstance"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failoverInstance" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RpoLagInfo? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfo (type)
        if (this.LocalRpoLagInfo != null) {
            var fspec = this.LocalRpoLagInfo.AsFieldSpec(conf.Child("localRpoLagInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "localRpoLagInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ChildVmRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: ChildVmRecoveryInfo (type)
        if (this.RecoveryInfo != null) {
            var fspec = this.RecoveryInfo.AsFieldSpec(conf.Child("recoveryInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryInfo" + "\n(" + this.Vars.RecoveryInfo.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        if (this.RemoteRpoLagInfo != null) {
            var fspec = this.RemoteRpoLagInfo.AsFieldSpec(conf.Child("remoteRpoLagInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "remoteRpoLagInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmwareResourceSpec? ResourceSpec
        // GraphQL -> resourceSpec: VmwareResourceSpec (type)
        if (this.ResourceSpec != null) {
            var fspec = this.ResourceSpec.AsFieldSpec(conf.Child("resourceSpec"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resourceSpec" + "\n(" + this.Vars.ResourceSpec.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VsphereVm? Snappable
        // GraphQL -> snappable: VsphereVm (type)
        if (this.Snappable != null) {
            var fspec = this.Snappable.AsFieldSpec(conf.Child("snappable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ObjectTypeEnum? SnappableType
        // GraphQL -> snappableType: ObjectTypeEnum! (enum)
        if (ec.Includes("snappableType",true))
        {
            if(this.SnappableType == null) {

                this.SnappableType = new ObjectTypeEnum();

            } else {


            }
        }
        else if (this.SnappableType != null && ec.Excludes("snappableType",true))
        {
            this.SnappableType = null;
        }
        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec (interface)
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
        //      C# -> System.Int32? BootPriority
        // GraphQL -> bootPriority: Int! (scalar)
        if (ec.Includes("bootPriority",true))
        {
            if(this.BootPriority == null) {

                this.BootPriority = Int32.MinValue;

            } else {


            }
        }
        else if (this.BootPriority != null && ec.Excludes("bootPriority",true))
        {
            this.BootPriority = null;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.Int64? LastRecoveryPoint
        // GraphQL -> lastRecoveryPoint: Long (scalar)
        if (ec.Includes("lastRecoveryPoint",true))
        {
            if(this.LastRecoveryPoint == null) {

                this.LastRecoveryPoint = new System.Int64();

            } else {


            }
        }
        else if (this.LastRecoveryPoint != null && ec.Excludes("lastRecoveryPoint",true))
        {
            this.LastRecoveryPoint = null;
        }
        //      C# -> VsphereBlueprintChildFailoverInstance? FailoverInstance
        // GraphQL -> failoverInstance: VsphereBlueprintChildFailoverInstance (type)
        if (ec.Includes("failoverInstance",false))
        {
            if(this.FailoverInstance == null) {

                this.FailoverInstance = new VsphereBlueprintChildFailoverInstance();
                this.FailoverInstance.ApplyExploratoryFieldSpec(ec.NewChild("failoverInstance"));

            } else {

                this.FailoverInstance.ApplyExploratoryFieldSpec(ec.NewChild("failoverInstance"));

            }
        }
        else if (this.FailoverInstance != null && ec.Excludes("failoverInstance",false))
        {
            this.FailoverInstance = null;
        }
        //      C# -> RpoLagInfo? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfo (type)
        if (ec.Includes("localRpoLagInfo",false))
        {
            if(this.LocalRpoLagInfo == null) {

                this.LocalRpoLagInfo = new RpoLagInfo();
                this.LocalRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("localRpoLagInfo"));

            } else {

                this.LocalRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("localRpoLagInfo"));

            }
        }
        else if (this.LocalRpoLagInfo != null && ec.Excludes("localRpoLagInfo",false))
        {
            this.LocalRpoLagInfo = null;
        }
        //      C# -> ChildVmRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: ChildVmRecoveryInfo (type)
        if (ec.Includes("recoveryInfo",false))
        {
            if(this.RecoveryInfo == null) {

                this.RecoveryInfo = new ChildVmRecoveryInfo();
                this.RecoveryInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryInfo"));

            } else {

                this.RecoveryInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryInfo"));

            }
        }
        else if (this.RecoveryInfo != null && ec.Excludes("recoveryInfo",false))
        {
            this.RecoveryInfo = null;
        }
        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        if (ec.Includes("remoteRpoLagInfo",false))
        {
            if(this.RemoteRpoLagInfo == null) {

                this.RemoteRpoLagInfo = new RpoLagInfo();
                this.RemoteRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("remoteRpoLagInfo"));

            } else {

                this.RemoteRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("remoteRpoLagInfo"));

            }
        }
        else if (this.RemoteRpoLagInfo != null && ec.Excludes("remoteRpoLagInfo",false))
        {
            this.RemoteRpoLagInfo = null;
        }
        //      C# -> VmwareResourceSpec? ResourceSpec
        // GraphQL -> resourceSpec: VmwareResourceSpec (type)
        if (ec.Includes("resourceSpec",false))
        {
            if(this.ResourceSpec == null) {

                this.ResourceSpec = new VmwareResourceSpec();
                this.ResourceSpec.ApplyExploratoryFieldSpec(ec.NewChild("resourceSpec"));

            } else {

                this.ResourceSpec.ApplyExploratoryFieldSpec(ec.NewChild("resourceSpec"));

            }
        }
        else if (this.ResourceSpec != null && ec.Excludes("resourceSpec",false))
        {
            this.ResourceSpec = null;
        }
        //      C# -> VsphereVm? Snappable
        // GraphQL -> snappable: VsphereVm (type)
        if (ec.Includes("snappable",false))
        {
            if(this.Snappable == null) {

                this.Snappable = new VsphereVm();
                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            } else {

                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            }
        }
        else if (this.Snappable != null && ec.Excludes("snappable",false))
        {
            this.Snappable = null;
        }
    }


    #endregion

    } // class VsphereVmChild
    
    #endregion

    public static class ListVsphereVmChildExtensions
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
            this List<VsphereVmChild> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereVmChild> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereVmChild> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereVmChild());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereVmChild> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types