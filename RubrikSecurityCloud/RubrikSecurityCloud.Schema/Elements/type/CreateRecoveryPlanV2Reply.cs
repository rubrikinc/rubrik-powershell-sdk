// CreateRecoveryPlanV2Reply.cs
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
    #region CreateRecoveryPlanV2Reply
    public class CreateRecoveryPlanV2Reply: BaseType
    {
        #region members

        //      C# -> System.String? RecoveryPlanId
        // GraphQL -> recoveryPlanId: UUID! (scalar)
        [JsonProperty("recoveryPlanId")]
        public System.String? RecoveryPlanId { get; set; }

        //      C# -> List<System.String>? RecoverySpecIds
        // GraphQL -> recoverySpecIds: [UUID!]! (scalar)
        [JsonProperty("recoverySpecIds")]
        public List<System.String>? RecoverySpecIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateRecoveryPlanV2Reply";
    }

    public CreateRecoveryPlanV2Reply Set(
        System.String? RecoveryPlanId = null,
        List<System.String>? RecoverySpecIds = null
    ) 
    {
        if ( RecoveryPlanId != null ) {
            this.RecoveryPlanId = RecoveryPlanId;
        }
        if ( RecoverySpecIds != null ) {
            this.RecoverySpecIds = RecoverySpecIds;
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
        //      C# -> System.String? RecoveryPlanId
        // GraphQL -> recoveryPlanId: UUID! (scalar)
        if (this.RecoveryPlanId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanId\n" ;
            } else {
                s += ind + "recoveryPlanId\n" ;
            }
        }
        //      C# -> List<System.String>? RecoverySpecIds
        // GraphQL -> recoverySpecIds: [UUID!]! (scalar)
        if (this.RecoverySpecIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoverySpecIds\n" ;
            } else {
                s += ind + "recoverySpecIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> List<System.String>? RecoverySpecIds
        // GraphQL -> recoverySpecIds: [UUID!]! (scalar)
        if (ec.Includes("recoverySpecIds",true))
        {
            if(this.RecoverySpecIds == null) {

                this.RecoverySpecIds = new List<System.String>();

            } else {


            }
        }
        else if (this.RecoverySpecIds != null && ec.Excludes("recoverySpecIds",true))
        {
            this.RecoverySpecIds = null;
        }
    }


    #endregion

    } // class CreateRecoveryPlanV2Reply
    
    #endregion

    public static class ListCreateRecoveryPlanV2ReplyExtensions
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
            this List<CreateRecoveryPlanV2Reply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CreateRecoveryPlanV2Reply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateRecoveryPlanV2Reply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateRecoveryPlanV2Reply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateRecoveryPlanV2Reply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types