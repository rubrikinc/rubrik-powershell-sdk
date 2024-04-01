// GcpCloudAccountProject.cs
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
    #region GcpCloudAccountProject
    public class GcpCloudAccountProject: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String! (scalar)
        [JsonProperty("organizationName")]
        public System.String? OrganizationName { get; set; }

        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        [JsonProperty("projectId")]
        public System.String? ProjectId { get; set; }

        //      C# -> System.Int64? ProjectNumber
        // GraphQL -> projectNumber: Long! (scalar)
        [JsonProperty("projectNumber")]
        public System.Int64? ProjectNumber { get; set; }

        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        [JsonProperty("roleId")]
        public System.String? RoleId { get; set; }

        //      C# -> System.Boolean? UsesGlobalConfig
        // GraphQL -> usesGlobalConfig: Boolean! (scalar)
        [JsonProperty("usesGlobalConfig")]
        public System.Boolean? UsesGlobalConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpCloudAccountProject";
    }

    public GcpCloudAccountProject Set(
        System.String? Id = null,
        System.String? Name = null,
        System.String? OrganizationName = null,
        System.String? ProjectId = null,
        System.Int64? ProjectNumber = null,
        System.String? RoleId = null,
        System.Boolean? UsesGlobalConfig = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OrganizationName != null ) {
            this.OrganizationName = OrganizationName;
        }
        if ( ProjectId != null ) {
            this.ProjectId = ProjectId;
        }
        if ( ProjectNumber != null ) {
            this.ProjectNumber = ProjectNumber;
        }
        if ( RoleId != null ) {
            this.RoleId = RoleId;
        }
        if ( UsesGlobalConfig != null ) {
            this.UsesGlobalConfig = UsesGlobalConfig;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String! (scalar)
        if (this.OrganizationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "organizationName\n" ;
            } else {
                s += ind + "organizationName\n" ;
            }
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "projectId\n" ;
            } else {
                s += ind + "projectId\n" ;
            }
        }
        //      C# -> System.Int64? ProjectNumber
        // GraphQL -> projectNumber: Long! (scalar)
        if (this.ProjectNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "projectNumber\n" ;
            } else {
                s += ind + "projectNumber\n" ;
            }
        }
        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        if (this.RoleId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleId\n" ;
            } else {
                s += ind + "roleId\n" ;
            }
        }
        //      C# -> System.Boolean? UsesGlobalConfig
        // GraphQL -> usesGlobalConfig: Boolean! (scalar)
        if (this.UsesGlobalConfig != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usesGlobalConfig\n" ;
            } else {
                s += ind + "usesGlobalConfig\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String! (scalar)
        if (ec.Includes("organizationName",true))
        {
            if(this.OrganizationName == null) {

                this.OrganizationName = "FETCH";

            } else {


            }
        }
        else if (this.OrganizationName != null && ec.Excludes("organizationName",true))
        {
            this.OrganizationName = null;
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (ec.Includes("projectId",true))
        {
            if(this.ProjectId == null) {

                this.ProjectId = "FETCH";

            } else {


            }
        }
        else if (this.ProjectId != null && ec.Excludes("projectId",true))
        {
            this.ProjectId = null;
        }
        //      C# -> System.Int64? ProjectNumber
        // GraphQL -> projectNumber: Long! (scalar)
        if (ec.Includes("projectNumber",true))
        {
            if(this.ProjectNumber == null) {

                this.ProjectNumber = new System.Int64();

            } else {


            }
        }
        else if (this.ProjectNumber != null && ec.Excludes("projectNumber",true))
        {
            this.ProjectNumber = null;
        }
        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        if (ec.Includes("roleId",true))
        {
            if(this.RoleId == null) {

                this.RoleId = "FETCH";

            } else {


            }
        }
        else if (this.RoleId != null && ec.Excludes("roleId",true))
        {
            this.RoleId = null;
        }
        //      C# -> System.Boolean? UsesGlobalConfig
        // GraphQL -> usesGlobalConfig: Boolean! (scalar)
        if (ec.Includes("usesGlobalConfig",true))
        {
            if(this.UsesGlobalConfig == null) {

                this.UsesGlobalConfig = true;

            } else {


            }
        }
        else if (this.UsesGlobalConfig != null && ec.Excludes("usesGlobalConfig",true))
        {
            this.UsesGlobalConfig = null;
        }
    }


    #endregion

    } // class GcpCloudAccountProject
    
    #endregion

    public static class ListGcpCloudAccountProjectExtensions
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
            this List<GcpCloudAccountProject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpCloudAccountProject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountProject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountProject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpCloudAccountProject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types