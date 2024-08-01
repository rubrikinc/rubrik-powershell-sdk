// CreateSnapMirrorCloudRelationshipReply.cs
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
    #region CreateSnapMirrorCloudRelationshipReply
    public class CreateSnapMirrorCloudRelationshipReply: BaseType
    {
        #region members

        //      C# -> System.String? CloudTargetId
        // GraphQL -> cloudTargetId: String! (scalar)
        [JsonProperty("cloudTargetId")]
        public System.String? CloudTargetId { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> System.String? RelationshipId
        // GraphQL -> relationshipId: String! (scalar)
        [JsonProperty("relationshipId")]
        public System.String? RelationshipId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateSnapMirrorCloudRelationshipReply";
    }

    public CreateSnapMirrorCloudRelationshipReply Set(
        System.String? CloudTargetId = null,
        System.String? PolicyId = null,
        System.String? RelationshipId = null
    ) 
    {
        if ( CloudTargetId != null ) {
            this.CloudTargetId = CloudTargetId;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
        }
        if ( RelationshipId != null ) {
            this.RelationshipId = RelationshipId;
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
        //      C# -> System.String? CloudTargetId
        // GraphQL -> cloudTargetId: String! (scalar)
        if (this.CloudTargetId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudTargetId\n" ;
            } else {
                s += ind + "cloudTargetId\n" ;
            }
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyId\n" ;
            } else {
                s += ind + "policyId\n" ;
            }
        }
        //      C# -> System.String? RelationshipId
        // GraphQL -> relationshipId: String! (scalar)
        if (this.RelationshipId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relationshipId\n" ;
            } else {
                s += ind + "relationshipId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CloudTargetId
        // GraphQL -> cloudTargetId: String! (scalar)
        if (ec.Includes("cloudTargetId",true))
        {
            if(this.CloudTargetId == null) {

                this.CloudTargetId = "FETCH";

            } else {


            }
        }
        else if (this.CloudTargetId != null && ec.Excludes("cloudTargetId",true))
        {
            this.CloudTargetId = null;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (ec.Includes("policyId",true))
        {
            if(this.PolicyId == null) {

                this.PolicyId = "FETCH";

            } else {


            }
        }
        else if (this.PolicyId != null && ec.Excludes("policyId",true))
        {
            this.PolicyId = null;
        }
        //      C# -> System.String? RelationshipId
        // GraphQL -> relationshipId: String! (scalar)
        if (ec.Includes("relationshipId",true))
        {
            if(this.RelationshipId == null) {

                this.RelationshipId = "FETCH";

            } else {


            }
        }
        else if (this.RelationshipId != null && ec.Excludes("relationshipId",true))
        {
            this.RelationshipId = null;
        }
    }


    #endregion

    } // class CreateSnapMirrorCloudRelationshipReply
    
    #endregion

    public static class ListCreateSnapMirrorCloudRelationshipReplyExtensions
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
            this List<CreateSnapMirrorCloudRelationshipReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CreateSnapMirrorCloudRelationshipReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateSnapMirrorCloudRelationshipReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateSnapMirrorCloudRelationshipReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateSnapMirrorCloudRelationshipReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types