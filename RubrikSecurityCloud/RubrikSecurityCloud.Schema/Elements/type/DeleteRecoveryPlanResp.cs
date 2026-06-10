// DeleteRecoveryPlanResp.cs
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
    #region DeleteRecoveryPlanResp
    public class DeleteRecoveryPlanResp: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsDeletedSuccessfully
        // GraphQL -> isDeletedSuccessfully: Boolean! (scalar)
        [JsonProperty("isDeletedSuccessfully")]
        public System.Boolean? IsDeletedSuccessfully { get; set; }

        //      C# -> System.String? RecoveryPlanId
        // GraphQL -> recoveryPlanId: UUID! (scalar)
        [JsonProperty("recoveryPlanId")]
        public System.String? RecoveryPlanId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DeleteRecoveryPlanResp";
    }

    public DeleteRecoveryPlanResp Set(
        System.Boolean? IsDeletedSuccessfully = null,
        System.String? RecoveryPlanId = null
    ) 
    {
        if ( IsDeletedSuccessfully != null ) {
            this.IsDeletedSuccessfully = IsDeletedSuccessfully;
        }
        if ( RecoveryPlanId != null ) {
            this.RecoveryPlanId = RecoveryPlanId;
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
        //      C# -> System.Boolean? IsDeletedSuccessfully
        // GraphQL -> isDeletedSuccessfully: Boolean! (scalar)
        if (this.IsDeletedSuccessfully != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDeletedSuccessfully\n" ;
            } else {
                s += ind + "isDeletedSuccessfully\n" ;
            }
        }
        //      C# -> System.String? RecoveryPlanId
        // GraphQL -> recoveryPlanId: UUID! (scalar)
        if (this.RecoveryPlanId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanId\n" ;
            } else {
                s += ind + "recoveryPlanId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsDeletedSuccessfully
        // GraphQL -> isDeletedSuccessfully: Boolean! (scalar)
        if (ec.Includes("isDeletedSuccessfully",true))
        {
            if(this.IsDeletedSuccessfully == null) {

                this.IsDeletedSuccessfully = true;

            } else {


            }
        }
        else if (this.IsDeletedSuccessfully != null && ec.Excludes("isDeletedSuccessfully",true))
        {
            this.IsDeletedSuccessfully = null;
        }
        //      C# -> System.String? RecoveryPlanId
        // GraphQL -> recoveryPlanId: UUID! (scalar)
        if (ec.Includes("recoveryPlanId",true))
        {
            if(this.RecoveryPlanId == null) {

                this.RecoveryPlanId = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryPlanId != null && ec.Excludes("recoveryPlanId",true))
        {
            this.RecoveryPlanId = null;
        }
    }


    #endregion

    } // class DeleteRecoveryPlanResp
    
    #endregion

    public static class ListDeleteRecoveryPlanRespExtensions
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
            this List<DeleteRecoveryPlanResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DeleteRecoveryPlanResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DeleteRecoveryPlanResp> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DeleteRecoveryPlanResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DeleteRecoveryPlanResp> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types