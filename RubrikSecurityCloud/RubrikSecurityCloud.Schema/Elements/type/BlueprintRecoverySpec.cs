// BlueprintRecoverySpec.cs
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
    #region BlueprintRecoverySpec
    public class BlueprintRecoverySpec: BaseType
    {
        #region members

        //      C# -> PlanName? PlanType
        // GraphQL -> planType: PlanName! (enum)
        [JsonProperty("planType")]
        public PlanName? PlanType { get; set; }

        //      C# -> ResourceSpecType? ResourceSpecType
        // GraphQL -> resourceSpecType: ResourceSpecType (enum)
        [JsonProperty("resourceSpecType")]
        public ResourceSpecType? ResourceSpecType { get; set; }

        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: UUID (scalar)
        [JsonProperty("failoverId")]
        public System.String? FailoverId { get; set; }

        //      C# -> System.Boolean? IsPending
        // GraphQL -> isPending: Boolean! (scalar)
        [JsonProperty("isPending")]
        public System.Boolean? IsPending { get; set; }

        //      C# -> System.String? RecoverySpecId
        // GraphQL -> recoverySpecId: UUID! (scalar)
        [JsonProperty("recoverySpecId")]
        public System.String? RecoverySpecId { get; set; }

        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        [JsonProperty("userData")]
        public System.String? UserData { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> List<ChildRecoverySpecMap>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [ChildRecoverySpecMap!]! (type)
        [JsonProperty("childRecoverySpecs")]
        public List<ChildRecoverySpecMap>? ChildRecoverySpecs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BlueprintRecoverySpec";
    }

    public BlueprintRecoverySpec Set(
        PlanName? PlanType = null,
        ResourceSpecType? ResourceSpecType = null,
        System.String? FailoverId = null,
        System.Boolean? IsPending = null,
        System.String? RecoverySpecId = null,
        System.String? UserData = null,
        System.Int64? Version = null,
        List<ChildRecoverySpecMap>? ChildRecoverySpecs = null
    ) 
    {
        if ( PlanType != null ) {
            this.PlanType = PlanType;
        }
        if ( ResourceSpecType != null ) {
            this.ResourceSpecType = ResourceSpecType;
        }
        if ( FailoverId != null ) {
            this.FailoverId = FailoverId;
        }
        if ( IsPending != null ) {
            this.IsPending = IsPending;
        }
        if ( RecoverySpecId != null ) {
            this.RecoverySpecId = RecoverySpecId;
        }
        if ( UserData != null ) {
            this.UserData = UserData;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( ChildRecoverySpecs != null ) {
            this.ChildRecoverySpecs = ChildRecoverySpecs;
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
        //      C# -> PlanName? PlanType
        // GraphQL -> planType: PlanName! (enum)
        if (this.PlanType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "planType\n" ;
            } else {
                s += ind + "planType\n" ;
            }
        }
        //      C# -> ResourceSpecType? ResourceSpecType
        // GraphQL -> resourceSpecType: ResourceSpecType (enum)
        if (this.ResourceSpecType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceSpecType\n" ;
            } else {
                s += ind + "resourceSpecType\n" ;
            }
        }
        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: UUID (scalar)
        if (this.FailoverId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failoverId\n" ;
            } else {
                s += ind + "failoverId\n" ;
            }
        }
        //      C# -> System.Boolean? IsPending
        // GraphQL -> isPending: Boolean! (scalar)
        if (this.IsPending != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPending\n" ;
            } else {
                s += ind + "isPending\n" ;
            }
        }
        //      C# -> System.String? RecoverySpecId
        // GraphQL -> recoverySpecId: UUID! (scalar)
        if (this.RecoverySpecId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoverySpecId\n" ;
            } else {
                s += ind + "recoverySpecId\n" ;
            }
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        if (this.UserData != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userData\n" ;
            } else {
                s += ind + "userData\n" ;
            }
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<ChildRecoverySpecMap>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [ChildRecoverySpecMap!]! (type)
        if (this.ChildRecoverySpecs != null) {
            var fspec = this.ChildRecoverySpecs.AsFieldSpec(conf.Child("childRecoverySpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "childRecoverySpecs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PlanName? PlanType
        // GraphQL -> planType: PlanName! (enum)
        if (ec.Includes("planType",true))
        {
            if(this.PlanType == null) {

                this.PlanType = new PlanName();

            } else {


            }
        }
        else if (this.PlanType != null && ec.Excludes("planType",true))
        {
            this.PlanType = null;
        }
        //      C# -> ResourceSpecType? ResourceSpecType
        // GraphQL -> resourceSpecType: ResourceSpecType (enum)
        if (ec.Includes("resourceSpecType",true))
        {
            if(this.ResourceSpecType == null) {

                this.ResourceSpecType = new ResourceSpecType();

            } else {


            }
        }
        else if (this.ResourceSpecType != null && ec.Excludes("resourceSpecType",true))
        {
            this.ResourceSpecType = null;
        }
        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: UUID (scalar)
        if (ec.Includes("failoverId",true))
        {
            if(this.FailoverId == null) {

                this.FailoverId = "FETCH";

            } else {


            }
        }
        else if (this.FailoverId != null && ec.Excludes("failoverId",true))
        {
            this.FailoverId = null;
        }
        //      C# -> System.Boolean? IsPending
        // GraphQL -> isPending: Boolean! (scalar)
        if (ec.Includes("isPending",true))
        {
            if(this.IsPending == null) {

                this.IsPending = true;

            } else {


            }
        }
        else if (this.IsPending != null && ec.Excludes("isPending",true))
        {
            this.IsPending = null;
        }
        //      C# -> System.String? RecoverySpecId
        // GraphQL -> recoverySpecId: UUID! (scalar)
        if (ec.Includes("recoverySpecId",true))
        {
            if(this.RecoverySpecId == null) {

                this.RecoverySpecId = "FETCH";

            } else {


            }
        }
        else if (this.RecoverySpecId != null && ec.Excludes("recoverySpecId",true))
        {
            this.RecoverySpecId = null;
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        if (ec.Includes("userData",true))
        {
            if(this.UserData == null) {

                this.UserData = "FETCH";

            } else {


            }
        }
        else if (this.UserData != null && ec.Excludes("userData",true))
        {
            this.UserData = null;
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = new System.Int64();

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<ChildRecoverySpecMap>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [ChildRecoverySpecMap!]! (type)
        if (ec.Includes("childRecoverySpecs",false))
        {
            if(this.ChildRecoverySpecs == null) {

                this.ChildRecoverySpecs = new List<ChildRecoverySpecMap>();
                this.ChildRecoverySpecs.ApplyExploratoryFieldSpec(ec.NewChild("childRecoverySpecs"));

            } else {

                this.ChildRecoverySpecs.ApplyExploratoryFieldSpec(ec.NewChild("childRecoverySpecs"));

            }
        }
        else if (this.ChildRecoverySpecs != null && ec.Excludes("childRecoverySpecs",false))
        {
            this.ChildRecoverySpecs = null;
        }
    }


    #endregion

    } // class BlueprintRecoverySpec
    
    #endregion

    public static class ListBlueprintRecoverySpecExtensions
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
            this List<BlueprintRecoverySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BlueprintRecoverySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BlueprintRecoverySpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BlueprintRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BlueprintRecoverySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types