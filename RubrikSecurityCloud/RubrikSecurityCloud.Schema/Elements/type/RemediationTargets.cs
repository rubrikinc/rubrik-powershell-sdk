// RemediationTargets.cs
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
    #region RemediationTargets
    public class RemediationTargets: BaseType
    {
        #region members

        //      C# -> RemediationTargetTypeEnum? TargetType
        // GraphQL -> targetType: RemediationTargetTypeEnum! (enum)
        [JsonProperty("targetType")]
        public RemediationTargetTypeEnum? TargetType { get; set; }

        //      C# -> List<System.String>? TargetIds
        // GraphQL -> targetIds: [String!]! (scalar)
        [JsonProperty("targetIds")]
        public List<System.String>? TargetIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RemediationTargets";
    }

    public RemediationTargets Set(
        RemediationTargetTypeEnum? TargetType = null,
        List<System.String>? TargetIds = null
    ) 
    {
        if ( TargetType != null ) {
            this.TargetType = TargetType;
        }
        if ( TargetIds != null ) {
            this.TargetIds = TargetIds;
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
        //      C# -> RemediationTargetTypeEnum? TargetType
        // GraphQL -> targetType: RemediationTargetTypeEnum! (enum)
        if (this.TargetType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetType\n" ;
            } else {
                s += ind + "targetType\n" ;
            }
        }
        //      C# -> List<System.String>? TargetIds
        // GraphQL -> targetIds: [String!]! (scalar)
        if (this.TargetIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIds\n" ;
            } else {
                s += ind + "targetIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RemediationTargetTypeEnum? TargetType
        // GraphQL -> targetType: RemediationTargetTypeEnum! (enum)
        if (ec.Includes("targetType",true))
        {
            if(this.TargetType == null) {

                this.TargetType = new RemediationTargetTypeEnum();

            } else {


            }
        }
        else if (this.TargetType != null && ec.Excludes("targetType",true))
        {
            this.TargetType = null;
        }
        //      C# -> List<System.String>? TargetIds
        // GraphQL -> targetIds: [String!]! (scalar)
        if (ec.Includes("targetIds",true))
        {
            if(this.TargetIds == null) {

                this.TargetIds = new List<System.String>();

            } else {


            }
        }
        else if (this.TargetIds != null && ec.Excludes("targetIds",true))
        {
            this.TargetIds = null;
        }
    }


    #endregion

    } // class RemediationTargets
    
    #endregion

    public static class ListRemediationTargetsExtensions
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
            this List<RemediationTargets> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RemediationTargets> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RemediationTargets> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RemediationTargets());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RemediationTargets> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types