// TprRequestSummary.cs
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
    #region TprRequestSummary
    public class TprRequestSummary: BaseType
    {
        #region members

        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        [JsonProperty("status")]
        public TprReqStatus? Status { get; set; }

        //      C# -> TprRule? TriggeredTprRule
        // GraphQL -> triggeredTprRule: TprRule! (enum)
        [JsonProperty("triggeredTprRule")]
        public TprRule? TriggeredTprRule { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> System.String? RequestId
        // GraphQL -> requestId: UUID! (scalar)
        [JsonProperty("requestId")]
        public System.String? RequestId { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> AuthorizedOps? Operations
        // GraphQL -> operations: AuthorizedOps! (type)
        [JsonProperty("operations")]
        public AuthorizedOps? Operations { get; set; }

        //      C# -> UserSummary? Requester
        // GraphQL -> requester: UserSummary! (type)
        [JsonProperty("requester")]
        public UserSummary? Requester { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRequestSummary";
    }

    public TprRequestSummary Set(
        TprReqStatus? Status = null,
        TprRule? TriggeredTprRule = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        System.String? RequestId = null,
        DateTime? UpdatedAt = null,
        AuthorizedOps? Operations = null,
        UserSummary? Requester = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( TriggeredTprRule != null ) {
            this.TriggeredTprRule = TriggeredTprRule;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( OrgName != null ) {
            this.OrgName = OrgName;
        }
        if ( RequestId != null ) {
            this.RequestId = RequestId;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( Operations != null ) {
            this.Operations = Operations;
        }
        if ( Requester != null ) {
            this.Requester = Requester;
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
        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> TprRule? TriggeredTprRule
        // GraphQL -> triggeredTprRule: TprRule! (enum)
        if (this.TriggeredTprRule != null) {
            if (conf.Flat) {
                s += conf.Prefix + "triggeredTprRule\n" ;
            } else {
                s += ind + "triggeredTprRule\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (this.OrgName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgName\n" ;
            } else {
                s += ind + "orgName\n" ;
            }
        }
        //      C# -> System.String? RequestId
        // GraphQL -> requestId: UUID! (scalar)
        if (this.RequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requestId\n" ;
            } else {
                s += ind + "requestId\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        //      C# -> AuthorizedOps? Operations
        // GraphQL -> operations: AuthorizedOps! (type)
        if (this.Operations != null) {
            var fspec = this.Operations.AsFieldSpec(conf.Child("operations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "operations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> UserSummary? Requester
        // GraphQL -> requester: UserSummary! (type)
        if (this.Requester != null) {
            var fspec = this.Requester.AsFieldSpec(conf.Child("requester"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "requester" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new TprReqStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> TprRule? TriggeredTprRule
        // GraphQL -> triggeredTprRule: TprRule! (enum)
        if (ec.Includes("triggeredTprRule",true))
        {
            if(this.TriggeredTprRule == null) {

                this.TriggeredTprRule = new TprRule();

            } else {


            }
        }
        else if (this.TriggeredTprRule != null && ec.Excludes("triggeredTprRule",true))
        {
            this.TriggeredTprRule = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (ec.Includes("orgName",true))
        {
            if(this.OrgName == null) {

                this.OrgName = "FETCH";

            } else {


            }
        }
        else if (this.OrgName != null && ec.Excludes("orgName",true))
        {
            this.OrgName = null;
        }
        //      C# -> System.String? RequestId
        // GraphQL -> requestId: UUID! (scalar)
        if (ec.Includes("requestId",true))
        {
            if(this.RequestId == null) {

                this.RequestId = "FETCH";

            } else {


            }
        }
        else if (this.RequestId != null && ec.Excludes("requestId",true))
        {
            this.RequestId = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
        //      C# -> AuthorizedOps? Operations
        // GraphQL -> operations: AuthorizedOps! (type)
        if (ec.Includes("operations",false))
        {
            if(this.Operations == null) {

                this.Operations = new AuthorizedOps();
                this.Operations.ApplyExploratoryFieldSpec(ec.NewChild("operations"));

            } else {

                this.Operations.ApplyExploratoryFieldSpec(ec.NewChild("operations"));

            }
        }
        else if (this.Operations != null && ec.Excludes("operations",false))
        {
            this.Operations = null;
        }
        //      C# -> UserSummary? Requester
        // GraphQL -> requester: UserSummary! (type)
        if (ec.Includes("requester",false))
        {
            if(this.Requester == null) {

                this.Requester = new UserSummary();
                this.Requester.ApplyExploratoryFieldSpec(ec.NewChild("requester"));

            } else {

                this.Requester.ApplyExploratoryFieldSpec(ec.NewChild("requester"));

            }
        }
        else if (this.Requester != null && ec.Excludes("requester",false))
        {
            this.Requester = null;
        }
    }


    #endregion

    } // class TprRequestSummary
    
    #endregion

    public static class ListTprRequestSummaryExtensions
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
            this List<TprRequestSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprRequestSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprRequestSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types