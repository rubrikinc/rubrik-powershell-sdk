// MvcProfile.cs
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
    #region MvcProfile
    public class MvcProfile: BaseType
    {
        #region members

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> List<System.String>? GroupIds
        // GraphQL -> groupIds: [UUID!]! (scalar)
        [JsonProperty("groupIds")]
        public List<System.String>? GroupIds { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> List<System.String>? SiteIds
        // GraphQL -> siteIds: [UUID!]! (scalar)
        [JsonProperty("siteIds")]
        public List<System.String>? SiteIds { get; set; }

        //      C# -> System.Int32? TotalUniqueUsers
        // GraphQL -> totalUniqueUsers: Int! (scalar)
        [JsonProperty("totalUniqueUsers")]
        public System.Int32? TotalUniqueUsers { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime! (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> List<System.String>? UserIds
        // GraphQL -> userIds: [UUID!]! (scalar)
        [JsonProperty("userIds")]
        public List<System.String>? UserIds { get; set; }

        //      C# -> MvcAnalysisJob? AnalysisJob
        // GraphQL -> analysisJob: MvcAnalysisJob (type)
        [JsonProperty("analysisJob")]
        public MvcAnalysisJob? AnalysisJob { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MvcProfile";
    }

    public MvcProfile Set(
        System.String? Description = null,
        List<System.String>? GroupIds = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? OrgId = null,
        List<System.String>? SiteIds = null,
        System.Int32? TotalUniqueUsers = null,
        DateTime? UpdatedAt = null,
        List<System.String>? UserIds = null,
        MvcAnalysisJob? AnalysisJob = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( GroupIds != null ) {
            this.GroupIds = GroupIds;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( SiteIds != null ) {
            this.SiteIds = SiteIds;
        }
        if ( TotalUniqueUsers != null ) {
            this.TotalUniqueUsers = TotalUniqueUsers;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( UserIds != null ) {
            this.UserIds = UserIds;
        }
        if ( AnalysisJob != null ) {
            this.AnalysisJob = AnalysisJob;
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
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> List<System.String>? GroupIds
        // GraphQL -> groupIds: [UUID!]! (scalar)
        if (this.GroupIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupIds\n" ;
            } else {
                s += ind + "groupIds\n" ;
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
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> List<System.String>? SiteIds
        // GraphQL -> siteIds: [UUID!]! (scalar)
        if (this.SiteIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "siteIds\n" ;
            } else {
                s += ind + "siteIds\n" ;
            }
        }
        //      C# -> System.Int32? TotalUniqueUsers
        // GraphQL -> totalUniqueUsers: Int! (scalar)
        if (this.TotalUniqueUsers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalUniqueUsers\n" ;
            } else {
                s += ind + "totalUniqueUsers\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime! (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        //      C# -> List<System.String>? UserIds
        // GraphQL -> userIds: [UUID!]! (scalar)
        if (this.UserIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userIds\n" ;
            } else {
                s += ind + "userIds\n" ;
            }
        }
        //      C# -> MvcAnalysisJob? AnalysisJob
        // GraphQL -> analysisJob: MvcAnalysisJob (type)
        if (this.AnalysisJob != null) {
            var fspec = this.AnalysisJob.AsFieldSpec(conf.Child("analysisJob"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analysisJob" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> List<System.String>? GroupIds
        // GraphQL -> groupIds: [UUID!]! (scalar)
        if (ec.Includes("groupIds",true))
        {
            if(this.GroupIds == null) {

                this.GroupIds = new List<System.String>();

            } else {


            }
        }
        else if (this.GroupIds != null && ec.Excludes("groupIds",true))
        {
            this.GroupIds = null;
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
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
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
        //      C# -> List<System.String>? SiteIds
        // GraphQL -> siteIds: [UUID!]! (scalar)
        if (ec.Includes("siteIds",true))
        {
            if(this.SiteIds == null) {

                this.SiteIds = new List<System.String>();

            } else {


            }
        }
        else if (this.SiteIds != null && ec.Excludes("siteIds",true))
        {
            this.SiteIds = null;
        }
        //      C# -> System.Int32? TotalUniqueUsers
        // GraphQL -> totalUniqueUsers: Int! (scalar)
        if (ec.Includes("totalUniqueUsers",true))
        {
            if(this.TotalUniqueUsers == null) {

                this.TotalUniqueUsers = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalUniqueUsers != null && ec.Excludes("totalUniqueUsers",true))
        {
            this.TotalUniqueUsers = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime! (scalar)
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
        //      C# -> List<System.String>? UserIds
        // GraphQL -> userIds: [UUID!]! (scalar)
        if (ec.Includes("userIds",true))
        {
            if(this.UserIds == null) {

                this.UserIds = new List<System.String>();

            } else {


            }
        }
        else if (this.UserIds != null && ec.Excludes("userIds",true))
        {
            this.UserIds = null;
        }
        //      C# -> MvcAnalysisJob? AnalysisJob
        // GraphQL -> analysisJob: MvcAnalysisJob (type)
        if (ec.Includes("analysisJob",false))
        {
            if(this.AnalysisJob == null) {

                this.AnalysisJob = new MvcAnalysisJob();
                this.AnalysisJob.ApplyExploratoryFieldSpec(ec.NewChild("analysisJob"));

            } else {

                this.AnalysisJob.ApplyExploratoryFieldSpec(ec.NewChild("analysisJob"));

            }
        }
        else if (this.AnalysisJob != null && ec.Excludes("analysisJob",false))
        {
            this.AnalysisJob = null;
        }
    }


    #endregion

    } // class MvcProfile
    
    #endregion

    public static class ListMvcProfileExtensions
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
            this List<MvcProfile> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MvcProfile> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MvcProfile> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MvcProfile());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MvcProfile> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types