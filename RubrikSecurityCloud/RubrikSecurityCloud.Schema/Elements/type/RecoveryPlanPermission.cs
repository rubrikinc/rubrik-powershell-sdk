// RecoveryPlanPermission.cs
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
    #region RecoveryPlanPermission
    public class RecoveryPlanPermission: BaseType
    {
        #region members

        //      C# -> List<DataTransferType>? AllowedDataTransferTypes
        // GraphQL -> allowedDataTransferTypes: [DataTransferType!]! (enum)
        [JsonProperty("allowedDataTransferTypes")]
        public List<DataTransferType>? AllowedDataTransferTypes { get; set; }

        //      C# -> List<VmwareRecoveryType>? AllowedRecoveryTypes
        // GraphQL -> allowedRecoveryTypes: [VmwareRecoveryType!]! (enum)
        [JsonProperty("allowedRecoveryTypes")]
        public List<VmwareRecoveryType>? AllowedRecoveryTypes { get; set; }

        //      C# -> System.Boolean? IsRecoverable
        // GraphQL -> isRecoverable: Boolean! (scalar)
        [JsonProperty("isRecoverable")]
        public System.Boolean? IsRecoverable { get; set; }

        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        [JsonProperty("isViewable")]
        public System.Boolean? IsViewable { get; set; }

        //      C# -> System.String? RecoveryPlanFid
        // GraphQL -> recoveryPlanFid: UUID! (scalar)
        [JsonProperty("recoveryPlanFid")]
        public System.String? RecoveryPlanFid { get; set; }

        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        [JsonProperty("recoveryPlanName")]
        public System.String? RecoveryPlanName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryPlanPermission";
    }

    public RecoveryPlanPermission Set(
        List<DataTransferType>? AllowedDataTransferTypes = null,
        List<VmwareRecoveryType>? AllowedRecoveryTypes = null,
        System.Boolean? IsRecoverable = null,
        System.Boolean? IsViewable = null,
        System.String? RecoveryPlanFid = null,
        System.String? RecoveryPlanName = null
    ) 
    {
        if ( AllowedDataTransferTypes != null ) {
            this.AllowedDataTransferTypes = AllowedDataTransferTypes;
        }
        if ( AllowedRecoveryTypes != null ) {
            this.AllowedRecoveryTypes = AllowedRecoveryTypes;
        }
        if ( IsRecoverable != null ) {
            this.IsRecoverable = IsRecoverable;
        }
        if ( IsViewable != null ) {
            this.IsViewable = IsViewable;
        }
        if ( RecoveryPlanFid != null ) {
            this.RecoveryPlanFid = RecoveryPlanFid;
        }
        if ( RecoveryPlanName != null ) {
            this.RecoveryPlanName = RecoveryPlanName;
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
        //      C# -> List<DataTransferType>? AllowedDataTransferTypes
        // GraphQL -> allowedDataTransferTypes: [DataTransferType!]! (enum)
        if (this.AllowedDataTransferTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowedDataTransferTypes\n" ;
            } else {
                s += ind + "allowedDataTransferTypes\n" ;
            }
        }
        //      C# -> List<VmwareRecoveryType>? AllowedRecoveryTypes
        // GraphQL -> allowedRecoveryTypes: [VmwareRecoveryType!]! (enum)
        if (this.AllowedRecoveryTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowedRecoveryTypes\n" ;
            } else {
                s += ind + "allowedRecoveryTypes\n" ;
            }
        }
        //      C# -> System.Boolean? IsRecoverable
        // GraphQL -> isRecoverable: Boolean! (scalar)
        if (this.IsRecoverable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRecoverable\n" ;
            } else {
                s += ind + "isRecoverable\n" ;
            }
        }
        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        if (this.IsViewable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isViewable\n" ;
            } else {
                s += ind + "isViewable\n" ;
            }
        }
        //      C# -> System.String? RecoveryPlanFid
        // GraphQL -> recoveryPlanFid: UUID! (scalar)
        if (this.RecoveryPlanFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanFid\n" ;
            } else {
                s += ind + "recoveryPlanFid\n" ;
            }
        }
        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        if (this.RecoveryPlanName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanName\n" ;
            } else {
                s += ind + "recoveryPlanName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<DataTransferType>? AllowedDataTransferTypes
        // GraphQL -> allowedDataTransferTypes: [DataTransferType!]! (enum)
        if (ec.Includes("allowedDataTransferTypes",true))
        {
            if(this.AllowedDataTransferTypes == null) {

                this.AllowedDataTransferTypes = new List<DataTransferType>();

            } else {


            }
        }
        else if (this.AllowedDataTransferTypes != null && ec.Excludes("allowedDataTransferTypes",true))
        {
            this.AllowedDataTransferTypes = null;
        }
        //      C# -> List<VmwareRecoveryType>? AllowedRecoveryTypes
        // GraphQL -> allowedRecoveryTypes: [VmwareRecoveryType!]! (enum)
        if (ec.Includes("allowedRecoveryTypes",true))
        {
            if(this.AllowedRecoveryTypes == null) {

                this.AllowedRecoveryTypes = new List<VmwareRecoveryType>();

            } else {


            }
        }
        else if (this.AllowedRecoveryTypes != null && ec.Excludes("allowedRecoveryTypes",true))
        {
            this.AllowedRecoveryTypes = null;
        }
        //      C# -> System.Boolean? IsRecoverable
        // GraphQL -> isRecoverable: Boolean! (scalar)
        if (ec.Includes("isRecoverable",true))
        {
            if(this.IsRecoverable == null) {

                this.IsRecoverable = true;

            } else {


            }
        }
        else if (this.IsRecoverable != null && ec.Excludes("isRecoverable",true))
        {
            this.IsRecoverable = null;
        }
        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        if (ec.Includes("isViewable",true))
        {
            if(this.IsViewable == null) {

                this.IsViewable = true;

            } else {


            }
        }
        else if (this.IsViewable != null && ec.Excludes("isViewable",true))
        {
            this.IsViewable = null;
        }
        //      C# -> System.String? RecoveryPlanFid
        // GraphQL -> recoveryPlanFid: UUID! (scalar)
        if (ec.Includes("recoveryPlanFid",true))
        {
            if(this.RecoveryPlanFid == null) {

                this.RecoveryPlanFid = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryPlanFid != null && ec.Excludes("recoveryPlanFid",true))
        {
            this.RecoveryPlanFid = null;
        }
        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        if (ec.Includes("recoveryPlanName",true))
        {
            if(this.RecoveryPlanName == null) {

                this.RecoveryPlanName = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryPlanName != null && ec.Excludes("recoveryPlanName",true))
        {
            this.RecoveryPlanName = null;
        }
    }


    #endregion

    } // class RecoveryPlanPermission
    
    #endregion

    public static class ListRecoveryPlanPermissionExtensions
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
            this List<RecoveryPlanPermission> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryPlanPermission> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPlanPermission> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPlanPermission());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryPlanPermission> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types