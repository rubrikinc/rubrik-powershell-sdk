// GcpCloudAccountProjectForOauth.cs
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
    #region GcpCloudAccountProjectForOauth
    public class GcpCloudAccountProjectForOauth: BaseType
    {
        #region members

        //      C# -> CredentialsManagedBy? CredentialsManagedBy
        // GraphQL -> credentialsManagedBy: CredentialsManagedBy! (enum)
        [JsonProperty("credentialsManagedBy")]
        public CredentialsManagedBy? CredentialsManagedBy { get; set; }

        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!] (scalar)
        [JsonProperty("missingPermissions")]
        public List<System.String>? MissingPermissions { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        [JsonProperty("projectId")]
        public System.String? ProjectId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpCloudAccountProjectForOauth";
    }

    public GcpCloudAccountProjectForOauth Set(
        CredentialsManagedBy? CredentialsManagedBy = null,
        List<System.String>? MissingPermissions = null,
        System.String? Name = null,
        System.String? ProjectId = null
    ) 
    {
        if ( CredentialsManagedBy != null ) {
            this.CredentialsManagedBy = CredentialsManagedBy;
        }
        if ( MissingPermissions != null ) {
            this.MissingPermissions = MissingPermissions;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ProjectId != null ) {
            this.ProjectId = ProjectId;
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
        //      C# -> CredentialsManagedBy? CredentialsManagedBy
        // GraphQL -> credentialsManagedBy: CredentialsManagedBy! (enum)
        if (this.CredentialsManagedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "credentialsManagedBy\n" ;
            } else {
                s += ind + "credentialsManagedBy\n" ;
            }
        }
        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!] (scalar)
        if (this.MissingPermissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "missingPermissions\n" ;
            } else {
                s += ind + "missingPermissions\n" ;
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
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "projectId\n" ;
            } else {
                s += ind + "projectId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CredentialsManagedBy? CredentialsManagedBy
        // GraphQL -> credentialsManagedBy: CredentialsManagedBy! (enum)
        if (ec.Includes("credentialsManagedBy",true))
        {
            if(this.CredentialsManagedBy == null) {

                this.CredentialsManagedBy = new CredentialsManagedBy();

            } else {


            }
        }
        else if (this.CredentialsManagedBy != null && ec.Excludes("credentialsManagedBy",true))
        {
            this.CredentialsManagedBy = null;
        }
        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!] (scalar)
        if (ec.Includes("missingPermissions",true))
        {
            if(this.MissingPermissions == null) {

                this.MissingPermissions = new List<System.String>();

            } else {


            }
        }
        else if (this.MissingPermissions != null && ec.Excludes("missingPermissions",true))
        {
            this.MissingPermissions = null;
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
    }


    #endregion

    } // class GcpCloudAccountProjectForOauth
    
    #endregion

    public static class ListGcpCloudAccountProjectForOauthExtensions
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
            this List<GcpCloudAccountProjectForOauth> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpCloudAccountProjectForOauth> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountProjectForOauth> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountProjectForOauth());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpCloudAccountProjectForOauth> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types