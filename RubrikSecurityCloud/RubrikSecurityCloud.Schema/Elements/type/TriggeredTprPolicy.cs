// TriggeredTprPolicy.cs
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
    #region TriggeredTprPolicy
    public class TriggeredTprPolicy: BaseType
    {
        #region members

        //      C# -> TprPolicyStatus? Status
        // GraphQL -> status: TprPolicyStatus! (enum)
        [JsonProperty("status")]
        public TprPolicyStatus? Status { get; set; }

        //      C# -> List<System.String>? ApproverIds
        // GraphQL -> approverIds: [String!]! (scalar)
        [JsonProperty("approverIds")]
        public List<System.String>? ApproverIds { get; set; }

        //      C# -> System.Boolean? Archived
        // GraphQL -> archived: Boolean! (scalar)
        [JsonProperty("archived")]
        public System.Boolean? Archived { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? QuorumRequirement
        // GraphQL -> quorumRequirement: Int! (scalar)
        [JsonProperty("quorumRequirement")]
        public System.Int32? QuorumRequirement { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TriggeredTprPolicy";
    }

    public TriggeredTprPolicy Set(
        TprPolicyStatus? Status = null,
        List<System.String>? ApproverIds = null,
        System.Boolean? Archived = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? QuorumRequirement = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ApproverIds != null ) {
            this.ApproverIds = ApproverIds;
        }
        if ( Archived != null ) {
            this.Archived = Archived;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( QuorumRequirement != null ) {
            this.QuorumRequirement = QuorumRequirement;
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
        //      C# -> TprPolicyStatus? Status
        // GraphQL -> status: TprPolicyStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> List<System.String>? ApproverIds
        // GraphQL -> approverIds: [String!]! (scalar)
        if (this.ApproverIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "approverIds\n" ;
            } else {
                s += ind + "approverIds\n" ;
            }
        }
        //      C# -> System.Boolean? Archived
        // GraphQL -> archived: Boolean! (scalar)
        if (this.Archived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archived\n" ;
            } else {
                s += ind + "archived\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int32? QuorumRequirement
        // GraphQL -> quorumRequirement: Int! (scalar)
        if (this.QuorumRequirement != null) {
            if (conf.Flat) {
                s += conf.Prefix + "quorumRequirement\n" ;
            } else {
                s += ind + "quorumRequirement\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TprPolicyStatus? Status
        // GraphQL -> status: TprPolicyStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new TprPolicyStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> List<System.String>? ApproverIds
        // GraphQL -> approverIds: [String!]! (scalar)
        if (ec.Includes("approverIds",true))
        {
            if(this.ApproverIds == null) {

                this.ApproverIds = new List<System.String>();

            } else {


            }
        }
        else if (this.ApproverIds != null && ec.Excludes("approverIds",true))
        {
            this.ApproverIds = null;
        }
        //      C# -> System.Boolean? Archived
        // GraphQL -> archived: Boolean! (scalar)
        if (ec.Includes("archived",true))
        {
            if(this.Archived == null) {

                this.Archived = true;

            } else {


            }
        }
        else if (this.Archived != null && ec.Excludes("archived",true))
        {
            this.Archived = null;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Int32? QuorumRequirement
        // GraphQL -> quorumRequirement: Int! (scalar)
        if (ec.Includes("quorumRequirement",true))
        {
            if(this.QuorumRequirement == null) {

                this.QuorumRequirement = Int32.MinValue;

            } else {


            }
        }
        else if (this.QuorumRequirement != null && ec.Excludes("quorumRequirement",true))
        {
            this.QuorumRequirement = null;
        }
    }


    #endregion

    } // class TriggeredTprPolicy
    
    #endregion

    public static class ListTriggeredTprPolicyExtensions
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
            this List<TriggeredTprPolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TriggeredTprPolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TriggeredTprPolicy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TriggeredTprPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TriggeredTprPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types