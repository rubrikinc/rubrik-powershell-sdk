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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? CloudTargetId
        // GraphQL -> cloudTargetId: String! (scalar)
        if (this.CloudTargetId != null) {
            s += ind + "cloudTargetId\n" ;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId != null) {
            s += ind + "policyId\n" ;
        }
        //      C# -> System.String? RelationshipId
        // GraphQL -> relationshipId: String! (scalar)
        if (this.RelationshipId != null) {
            s += ind + "relationshipId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CloudTargetId
        // GraphQL -> cloudTargetId: String! (scalar)
        if (this.CloudTargetId == null && Exploration.Includes(parent + ".cloudTargetId", true))
        {
            this.CloudTargetId = "FETCH";
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId == null && Exploration.Includes(parent + ".policyId", true))
        {
            this.PolicyId = "FETCH";
        }
        //      C# -> System.String? RelationshipId
        // GraphQL -> relationshipId: String! (scalar)
        if (this.RelationshipId == null && Exploration.Includes(parent + ".relationshipId", true))
        {
            this.RelationshipId = "FETCH";
        }
    }


    #endregion

    } // class CreateSnapMirrorCloudRelationshipReply
    
    #endregion

    public static class ListCreateSnapMirrorCloudRelationshipReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<CreateSnapMirrorCloudRelationshipReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateSnapMirrorCloudRelationshipReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateSnapMirrorCloudRelationshipReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types