// RecoveryPlanChildV2.cs
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
    #region RecoveryPlanChildV2
    public class RecoveryPlanChildV2: BaseType
    {
        #region members

        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType! (enum)
        [JsonProperty("workloadType")]
        public ManagedObjectType? WorkloadType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> RecoveryCoverage? LocalRecoveryCoverage
        // GraphQL -> localRecoveryCoverage: RecoveryCoverage (type)
        [JsonProperty("localRecoveryCoverage")]
        public RecoveryCoverage? LocalRecoveryCoverage { get; set; }

        //      C# -> RpoLagInfoV2? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfoV2 (type)
        [JsonProperty("localRpoLagInfo")]
        public RpoLagInfoV2? LocalRpoLagInfo { get; set; }

        //      C# -> RecoveryCoverage? RemoteRecoveryCoverage
        // GraphQL -> remoteRecoveryCoverage: RecoveryCoverage (type)
        [JsonProperty("remoteRecoveryCoverage")]
        public RecoveryCoverage? RemoteRecoveryCoverage { get; set; }

        //      C# -> RpoLagInfoV2? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfoV2 (type)
        [JsonProperty("remoteRpoLagInfo")]
        public RpoLagInfoV2? RemoteRpoLagInfo { get; set; }

        //      C# -> WorkloadResourceSpec? ResourceSpec
        // GraphQL -> resourceSpec: WorkloadResourceSpec (type)
        [JsonProperty("resourceSpec")]
        public WorkloadResourceSpec? ResourceSpec { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars ResourceSpec { get; set; }


        public InlineVars() {
            Tuple<string, string>[] resourceSpecArgs = {
                    Tuple.Create("recoveryPoint", "Long"),
                };
            this.ResourceSpec =
                new RscGqlVars(null, resourceSpecArgs, null, true);
        }
    }

    public RecoveryPlanChildV2()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "RecoveryPlanChildV2";
    }

    public RecoveryPlanChildV2 Set(
        ManagedObjectType? WorkloadType = null,
        System.String? Id = null,
        RecoveryCoverage? LocalRecoveryCoverage = null,
        RpoLagInfoV2? LocalRpoLagInfo = null,
        RecoveryCoverage? RemoteRecoveryCoverage = null,
        RpoLagInfoV2? RemoteRpoLagInfo = null,
        WorkloadResourceSpec? ResourceSpec = null
    ) 
    {
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LocalRecoveryCoverage != null ) {
            this.LocalRecoveryCoverage = LocalRecoveryCoverage;
        }
        if ( LocalRpoLagInfo != null ) {
            this.LocalRpoLagInfo = LocalRpoLagInfo;
        }
        if ( RemoteRecoveryCoverage != null ) {
            this.RemoteRecoveryCoverage = RemoteRecoveryCoverage;
        }
        if ( RemoteRpoLagInfo != null ) {
            this.RemoteRpoLagInfo = RemoteRpoLagInfo;
        }
        if ( ResourceSpec != null ) {
            this.ResourceSpec = ResourceSpec;
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
        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType! (enum)
        if (this.WorkloadType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadType\n" ;
            } else {
                s += ind + "workloadType\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> RecoveryCoverage? LocalRecoveryCoverage
        // GraphQL -> localRecoveryCoverage: RecoveryCoverage (type)
        if (this.LocalRecoveryCoverage != null) {
            var fspec = this.LocalRecoveryCoverage.AsFieldSpec(conf.Child("localRecoveryCoverage"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "localRecoveryCoverage" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RpoLagInfoV2? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfoV2 (type)
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
        //      C# -> RecoveryCoverage? RemoteRecoveryCoverage
        // GraphQL -> remoteRecoveryCoverage: RecoveryCoverage (type)
        if (this.RemoteRecoveryCoverage != null) {
            var fspec = this.RemoteRecoveryCoverage.AsFieldSpec(conf.Child("remoteRecoveryCoverage"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "remoteRecoveryCoverage" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RpoLagInfoV2? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfoV2 (type)
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
        //      C# -> WorkloadResourceSpec? ResourceSpec
        // GraphQL -> resourceSpec: WorkloadResourceSpec (type)
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType! (enum)
        if (ec.Includes("workloadType",true))
        {
            if(this.WorkloadType == null) {

                this.WorkloadType = new ManagedObjectType();

            } else {


            }
        }
        else if (this.WorkloadType != null && ec.Excludes("workloadType",true))
        {
            this.WorkloadType = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> RecoveryCoverage? LocalRecoveryCoverage
        // GraphQL -> localRecoveryCoverage: RecoveryCoverage (type)
        if (ec.Includes("localRecoveryCoverage",false))
        {
            if(this.LocalRecoveryCoverage == null) {

                this.LocalRecoveryCoverage = new RecoveryCoverage();
                this.LocalRecoveryCoverage.ApplyExploratoryFieldSpec(ec.NewChild("localRecoveryCoverage"));

            } else {

                this.LocalRecoveryCoverage.ApplyExploratoryFieldSpec(ec.NewChild("localRecoveryCoverage"));

            }
        }
        else if (this.LocalRecoveryCoverage != null && ec.Excludes("localRecoveryCoverage",false))
        {
            this.LocalRecoveryCoverage = null;
        }
        //      C# -> RpoLagInfoV2? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfoV2 (type)
        if (ec.Includes("localRpoLagInfo",false))
        {
            if(this.LocalRpoLagInfo == null) {

                this.LocalRpoLagInfo = new RpoLagInfoV2();
                this.LocalRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("localRpoLagInfo"));

            } else {

                this.LocalRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("localRpoLagInfo"));

            }
        }
        else if (this.LocalRpoLagInfo != null && ec.Excludes("localRpoLagInfo",false))
        {
            this.LocalRpoLagInfo = null;
        }
        //      C# -> RecoveryCoverage? RemoteRecoveryCoverage
        // GraphQL -> remoteRecoveryCoverage: RecoveryCoverage (type)
        if (ec.Includes("remoteRecoveryCoverage",false))
        {
            if(this.RemoteRecoveryCoverage == null) {

                this.RemoteRecoveryCoverage = new RecoveryCoverage();
                this.RemoteRecoveryCoverage.ApplyExploratoryFieldSpec(ec.NewChild("remoteRecoveryCoverage"));

            } else {

                this.RemoteRecoveryCoverage.ApplyExploratoryFieldSpec(ec.NewChild("remoteRecoveryCoverage"));

            }
        }
        else if (this.RemoteRecoveryCoverage != null && ec.Excludes("remoteRecoveryCoverage",false))
        {
            this.RemoteRecoveryCoverage = null;
        }
        //      C# -> RpoLagInfoV2? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfoV2 (type)
        if (ec.Includes("remoteRpoLagInfo",false))
        {
            if(this.RemoteRpoLagInfo == null) {

                this.RemoteRpoLagInfo = new RpoLagInfoV2();
                this.RemoteRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("remoteRpoLagInfo"));

            } else {

                this.RemoteRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("remoteRpoLagInfo"));

            }
        }
        else if (this.RemoteRpoLagInfo != null && ec.Excludes("remoteRpoLagInfo",false))
        {
            this.RemoteRpoLagInfo = null;
        }
        //      C# -> WorkloadResourceSpec? ResourceSpec
        // GraphQL -> resourceSpec: WorkloadResourceSpec (type)
        if (ec.Includes("resourceSpec",false))
        {
            if(this.ResourceSpec == null) {

                this.ResourceSpec = new WorkloadResourceSpec();
                this.ResourceSpec.ApplyExploratoryFieldSpec(ec.NewChild("resourceSpec"));

            } else {

                this.ResourceSpec.ApplyExploratoryFieldSpec(ec.NewChild("resourceSpec"));

            }
        }
        else if (this.ResourceSpec != null && ec.Excludes("resourceSpec",false))
        {
            this.ResourceSpec = null;
        }
    }


    #endregion

    } // class RecoveryPlanChildV2
    
    #endregion

    public static class ListRecoveryPlanChildV2Extensions
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
            this List<RecoveryPlanChildV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryPlanChildV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPlanChildV2> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPlanChildV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryPlanChildV2> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types