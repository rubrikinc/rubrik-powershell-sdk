// RecoveryPlanRecoverySpecMap.cs
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
    #region RecoveryPlanRecoverySpecMap
    public class RecoveryPlanRecoverySpecMap: BaseType
    {
        #region members

        //      C# -> RecoverySpecTypeV2? RecoverySpecType
        // GraphQL -> recoverySpecType: RecoverySpecTypeV2 (enum)
        [JsonProperty("recoverySpecType")]
        public RecoverySpecTypeV2? RecoverySpecType { get; set; }

        //      C# -> RecoveryType? RecoveryType
        // GraphQL -> recoveryType: RecoveryType! (enum)
        [JsonProperty("recoveryType")]
        public RecoveryType? RecoveryType { get; set; }

        //      C# -> List<System.Int64>? PauseBetweenPriorityGroups
        // GraphQL -> pauseBetweenPriorityGroups: [Long!]! (scalar)
        [JsonProperty("pauseBetweenPriorityGroups")]
        public List<System.Int64>? PauseBetweenPriorityGroups { get; set; }

        //      C# -> System.String? RecoveryId
        // GraphQL -> recoveryId: String (scalar)
        [JsonProperty("recoveryId")]
        public System.String? RecoveryId { get; set; }

        //      C# -> System.String? RecoverySpecId
        // GraphQL -> recoverySpecId: String! (scalar)
        [JsonProperty("recoverySpecId")]
        public System.String? RecoverySpecId { get; set; }

        //      C# -> System.String? UserData
        // GraphQL -> userData: String! (scalar)
        [JsonProperty("userData")]
        public System.String? UserData { get; set; }

        //      C# -> List<ChildRecoverySpecMapV2>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [ChildRecoverySpecMapV2!]! (type)
        [JsonProperty("childRecoverySpecs")]
        public List<ChildRecoverySpecMapV2>? ChildRecoverySpecs { get; set; }

        //      C# -> RecoverySpecConfig? Config
        // GraphQL -> config: RecoverySpecConfig! (type)
        [JsonProperty("config")]
        public RecoverySpecConfig? Config { get; set; }

        //      C# -> RecoveryPlanLocation? SourceLocationInfo
        // GraphQL -> sourceLocationInfo: RecoveryPlanLocation (type)
        [JsonProperty("sourceLocationInfo")]
        public RecoveryPlanLocation? SourceLocationInfo { get; set; }

        //      C# -> RecoveryPlanLocation? TargetLocationInfo
        // GraphQL -> targetLocationInfo: RecoveryPlanLocation (type)
        [JsonProperty("targetLocationInfo")]
        public RecoveryPlanLocation? TargetLocationInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryPlanRecoverySpecMap";
    }

    public RecoveryPlanRecoverySpecMap Set(
        RecoverySpecTypeV2? RecoverySpecType = null,
        RecoveryType? RecoveryType = null,
        List<System.Int64>? PauseBetweenPriorityGroups = null,
        System.String? RecoveryId = null,
        System.String? RecoverySpecId = null,
        System.String? UserData = null,
        List<ChildRecoverySpecMapV2>? ChildRecoverySpecs = null,
        RecoverySpecConfig? Config = null,
        RecoveryPlanLocation? SourceLocationInfo = null,
        RecoveryPlanLocation? TargetLocationInfo = null
    ) 
    {
        if ( RecoverySpecType != null ) {
            this.RecoverySpecType = RecoverySpecType;
        }
        if ( RecoveryType != null ) {
            this.RecoveryType = RecoveryType;
        }
        if ( PauseBetweenPriorityGroups != null ) {
            this.PauseBetweenPriorityGroups = PauseBetweenPriorityGroups;
        }
        if ( RecoveryId != null ) {
            this.RecoveryId = RecoveryId;
        }
        if ( RecoverySpecId != null ) {
            this.RecoverySpecId = RecoverySpecId;
        }
        if ( UserData != null ) {
            this.UserData = UserData;
        }
        if ( ChildRecoverySpecs != null ) {
            this.ChildRecoverySpecs = ChildRecoverySpecs;
        }
        if ( Config != null ) {
            this.Config = Config;
        }
        if ( SourceLocationInfo != null ) {
            this.SourceLocationInfo = SourceLocationInfo;
        }
        if ( TargetLocationInfo != null ) {
            this.TargetLocationInfo = TargetLocationInfo;
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
        //      C# -> RecoverySpecTypeV2? RecoverySpecType
        // GraphQL -> recoverySpecType: RecoverySpecTypeV2 (enum)
        if (this.RecoverySpecType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoverySpecType\n" ;
            } else {
                s += ind + "recoverySpecType\n" ;
            }
        }
        //      C# -> RecoveryType? RecoveryType
        // GraphQL -> recoveryType: RecoveryType! (enum)
        if (this.RecoveryType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryType\n" ;
            } else {
                s += ind + "recoveryType\n" ;
            }
        }
        //      C# -> List<System.Int64>? PauseBetweenPriorityGroups
        // GraphQL -> pauseBetweenPriorityGroups: [Long!]! (scalar)
        if (this.PauseBetweenPriorityGroups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pauseBetweenPriorityGroups\n" ;
            } else {
                s += ind + "pauseBetweenPriorityGroups\n" ;
            }
        }
        //      C# -> System.String? RecoveryId
        // GraphQL -> recoveryId: String (scalar)
        if (this.RecoveryId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryId\n" ;
            } else {
                s += ind + "recoveryId\n" ;
            }
        }
        //      C# -> System.String? RecoverySpecId
        // GraphQL -> recoverySpecId: String! (scalar)
        if (this.RecoverySpecId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoverySpecId\n" ;
            } else {
                s += ind + "recoverySpecId\n" ;
            }
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String! (scalar)
        if (this.UserData != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userData\n" ;
            } else {
                s += ind + "userData\n" ;
            }
        }
        //      C# -> List<ChildRecoverySpecMapV2>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [ChildRecoverySpecMapV2!]! (type)
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
        //      C# -> RecoverySpecConfig? Config
        // GraphQL -> config: RecoverySpecConfig! (type)
        if (this.Config != null) {
            var fspec = this.Config.AsFieldSpec(conf.Child("config"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "config" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanLocation? SourceLocationInfo
        // GraphQL -> sourceLocationInfo: RecoveryPlanLocation (type)
        if (this.SourceLocationInfo != null) {
            var fspec = this.SourceLocationInfo.AsFieldSpec(conf.Child("sourceLocationInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceLocationInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanLocation? TargetLocationInfo
        // GraphQL -> targetLocationInfo: RecoveryPlanLocation (type)
        if (this.TargetLocationInfo != null) {
            var fspec = this.TargetLocationInfo.AsFieldSpec(conf.Child("targetLocationInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetLocationInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoverySpecTypeV2? RecoverySpecType
        // GraphQL -> recoverySpecType: RecoverySpecTypeV2 (enum)
        if (ec.Includes("recoverySpecType",true))
        {
            if(this.RecoverySpecType == null) {

                this.RecoverySpecType = new RecoverySpecTypeV2();

            } else {


            }
        }
        else if (this.RecoverySpecType != null && ec.Excludes("recoverySpecType",true))
        {
            this.RecoverySpecType = null;
        }
        //      C# -> RecoveryType? RecoveryType
        // GraphQL -> recoveryType: RecoveryType! (enum)
        if (ec.Includes("recoveryType",true))
        {
            if(this.RecoveryType == null) {

                this.RecoveryType = new RecoveryType();

            } else {


            }
        }
        else if (this.RecoveryType != null && ec.Excludes("recoveryType",true))
        {
            this.RecoveryType = null;
        }
        //      C# -> List<System.Int64>? PauseBetweenPriorityGroups
        // GraphQL -> pauseBetweenPriorityGroups: [Long!]! (scalar)
        if (ec.Includes("pauseBetweenPriorityGroups",true))
        {
            if(this.PauseBetweenPriorityGroups == null) {

                this.PauseBetweenPriorityGroups = new List<System.Int64>();

            } else {


            }
        }
        else if (this.PauseBetweenPriorityGroups != null && ec.Excludes("pauseBetweenPriorityGroups",true))
        {
            this.PauseBetweenPriorityGroups = null;
        }
        //      C# -> System.String? RecoveryId
        // GraphQL -> recoveryId: String (scalar)
        if (ec.Includes("recoveryId",true))
        {
            if(this.RecoveryId == null) {

                this.RecoveryId = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryId != null && ec.Excludes("recoveryId",true))
        {
            this.RecoveryId = null;
        }
        //      C# -> System.String? RecoverySpecId
        // GraphQL -> recoverySpecId: String! (scalar)
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
        // GraphQL -> userData: String! (scalar)
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
        //      C# -> List<ChildRecoverySpecMapV2>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [ChildRecoverySpecMapV2!]! (type)
        if (ec.Includes("childRecoverySpecs",false))
        {
            if(this.ChildRecoverySpecs == null) {

                this.ChildRecoverySpecs = new List<ChildRecoverySpecMapV2>();
                this.ChildRecoverySpecs.ApplyExploratoryFieldSpec(ec.NewChild("childRecoverySpecs"));

            } else {

                this.ChildRecoverySpecs.ApplyExploratoryFieldSpec(ec.NewChild("childRecoverySpecs"));

            }
        }
        else if (this.ChildRecoverySpecs != null && ec.Excludes("childRecoverySpecs",false))
        {
            this.ChildRecoverySpecs = null;
        }
        //      C# -> RecoverySpecConfig? Config
        // GraphQL -> config: RecoverySpecConfig! (type)
        if (ec.Includes("config",false))
        {
            if(this.Config == null) {

                this.Config = new RecoverySpecConfig();
                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            } else {

                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            }
        }
        else if (this.Config != null && ec.Excludes("config",false))
        {
            this.Config = null;
        }
        //      C# -> RecoveryPlanLocation? SourceLocationInfo
        // GraphQL -> sourceLocationInfo: RecoveryPlanLocation (type)
        if (ec.Includes("sourceLocationInfo",false))
        {
            if(this.SourceLocationInfo == null) {

                this.SourceLocationInfo = new RecoveryPlanLocation();
                this.SourceLocationInfo.ApplyExploratoryFieldSpec(ec.NewChild("sourceLocationInfo"));

            } else {

                this.SourceLocationInfo.ApplyExploratoryFieldSpec(ec.NewChild("sourceLocationInfo"));

            }
        }
        else if (this.SourceLocationInfo != null && ec.Excludes("sourceLocationInfo",false))
        {
            this.SourceLocationInfo = null;
        }
        //      C# -> RecoveryPlanLocation? TargetLocationInfo
        // GraphQL -> targetLocationInfo: RecoveryPlanLocation (type)
        if (ec.Includes("targetLocationInfo",false))
        {
            if(this.TargetLocationInfo == null) {

                this.TargetLocationInfo = new RecoveryPlanLocation();
                this.TargetLocationInfo.ApplyExploratoryFieldSpec(ec.NewChild("targetLocationInfo"));

            } else {

                this.TargetLocationInfo.ApplyExploratoryFieldSpec(ec.NewChild("targetLocationInfo"));

            }
        }
        else if (this.TargetLocationInfo != null && ec.Excludes("targetLocationInfo",false))
        {
            this.TargetLocationInfo = null;
        }
    }


    #endregion

    } // class RecoveryPlanRecoverySpecMap
    
    #endregion

    public static class ListRecoveryPlanRecoverySpecMapExtensions
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
            this List<RecoveryPlanRecoverySpecMap> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryPlanRecoverySpecMap> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPlanRecoverySpecMap> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPlanRecoverySpecMap());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryPlanRecoverySpecMap> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types