// WorkloadGroupByInfo.cs
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
    #region WorkloadGroupByInfo
    public class WorkloadGroupByInfo: BaseType
    {
        #region members

        //      C# -> WorkloadGroupByEnum? GroupByField
        // GraphQL -> groupByField: WorkloadGroupByEnum! (enum)
        [JsonProperty("groupByField")]
        public WorkloadGroupByEnum? GroupByField { get; set; }

        //      C# -> ObjectTypeEnum? GroupByObjectType
        // GraphQL -> groupByObjectType: ObjectTypeEnum (enum)
        [JsonProperty("groupByObjectType")]
        public ObjectTypeEnum? GroupByObjectType { get; set; }

        //      C# -> ProtectionStatusEnum? GroupByProtectionStatus
        // GraphQL -> groupByProtectionStatus: ProtectionStatusEnum (enum)
        [JsonProperty("groupByProtectionStatus")]
        public ProtectionStatusEnum? GroupByProtectionStatus { get; set; }

        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        [JsonProperty("groupByValue")]
        public System.String? GroupByValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadGroupByInfo";
    }

    public WorkloadGroupByInfo Set(
        WorkloadGroupByEnum? GroupByField = null,
        ObjectTypeEnum? GroupByObjectType = null,
        ProtectionStatusEnum? GroupByProtectionStatus = null,
        System.String? GroupByValue = null
    ) 
    {
        if ( GroupByField != null ) {
            this.GroupByField = GroupByField;
        }
        if ( GroupByObjectType != null ) {
            this.GroupByObjectType = GroupByObjectType;
        }
        if ( GroupByProtectionStatus != null ) {
            this.GroupByProtectionStatus = GroupByProtectionStatus;
        }
        if ( GroupByValue != null ) {
            this.GroupByValue = GroupByValue;
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
        //      C# -> WorkloadGroupByEnum? GroupByField
        // GraphQL -> groupByField: WorkloadGroupByEnum! (enum)
        if (this.GroupByField != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupByField\n" ;
            } else {
                s += ind + "groupByField\n" ;
            }
        }
        //      C# -> ObjectTypeEnum? GroupByObjectType
        // GraphQL -> groupByObjectType: ObjectTypeEnum (enum)
        if (this.GroupByObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupByObjectType\n" ;
            } else {
                s += ind + "groupByObjectType\n" ;
            }
        }
        //      C# -> ProtectionStatusEnum? GroupByProtectionStatus
        // GraphQL -> groupByProtectionStatus: ProtectionStatusEnum (enum)
        if (this.GroupByProtectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupByProtectionStatus\n" ;
            } else {
                s += ind + "groupByProtectionStatus\n" ;
            }
        }
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (this.GroupByValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupByValue\n" ;
            } else {
                s += ind + "groupByValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WorkloadGroupByEnum? GroupByField
        // GraphQL -> groupByField: WorkloadGroupByEnum! (enum)
        if (ec.Includes("groupByField",true))
        {
            if(this.GroupByField == null) {

                this.GroupByField = new WorkloadGroupByEnum();

            } else {


            }
        }
        else if (this.GroupByField != null && ec.Excludes("groupByField",true))
        {
            this.GroupByField = null;
        }
        //      C# -> ObjectTypeEnum? GroupByObjectType
        // GraphQL -> groupByObjectType: ObjectTypeEnum (enum)
        if (ec.Includes("groupByObjectType",true))
        {
            if(this.GroupByObjectType == null) {

                this.GroupByObjectType = new ObjectTypeEnum();

            } else {


            }
        }
        else if (this.GroupByObjectType != null && ec.Excludes("groupByObjectType",true))
        {
            this.GroupByObjectType = null;
        }
        //      C# -> ProtectionStatusEnum? GroupByProtectionStatus
        // GraphQL -> groupByProtectionStatus: ProtectionStatusEnum (enum)
        if (ec.Includes("groupByProtectionStatus",true))
        {
            if(this.GroupByProtectionStatus == null) {

                this.GroupByProtectionStatus = new ProtectionStatusEnum();

            } else {


            }
        }
        else if (this.GroupByProtectionStatus != null && ec.Excludes("groupByProtectionStatus",true))
        {
            this.GroupByProtectionStatus = null;
        }
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (ec.Includes("groupByValue",true))
        {
            if(this.GroupByValue == null) {

                this.GroupByValue = "FETCH";

            } else {


            }
        }
        else if (this.GroupByValue != null && ec.Excludes("groupByValue",true))
        {
            this.GroupByValue = null;
        }
    }


    #endregion

    } // class WorkloadGroupByInfo
    
    #endregion

    public static class ListWorkloadGroupByInfoExtensions
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
            this List<WorkloadGroupByInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadGroupByInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadGroupByInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadGroupByInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadGroupByInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types