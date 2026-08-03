// EntraIdServicePrincipalMetadataProperties.cs
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
    #region EntraIdServicePrincipalMetadataProperties
 
    public class EntraIdServicePrincipalMetadataProperties: BaseType, PrincipalMetadata
    {
        #region members

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppOwnerOrgId
        // GraphQL -> appOwnerOrgId: String! (scalar)
        [JsonProperty("appOwnerOrgId")]
        public System.String? AppOwnerOrgId { get; set; }

        //      C# -> System.String? ApplicationTemplateId
        // GraphQL -> applicationTemplateId: String! (scalar)
        [JsonProperty("applicationTemplateId")]
        public System.String? ApplicationTemplateId { get; set; }

        //      C# -> System.Boolean? HasForbiddenRole
        // GraphQL -> hasForbiddenRole: Boolean! (scalar)
        [JsonProperty("hasForbiddenRole")]
        public System.Boolean? HasForbiddenRole { get; set; }

        //      C# -> System.Boolean? HasNoActiveUserOwner
        // GraphQL -> hasNoActiveUserOwner: Boolean! (scalar)
        [JsonProperty("hasNoActiveUserOwner")]
        public System.Boolean? HasNoActiveUserOwner { get; set; }

        //      C# -> System.String? Homepage
        // GraphQL -> homepage: String! (scalar)
        [JsonProperty("homepage")]
        public System.String? Homepage { get; set; }

        //      C# -> System.String? PublisherName
        // GraphQL -> publisherName: String! (scalar)
        [JsonProperty("publisherName")]
        public System.String? PublisherName { get; set; }

        //      C# -> List<EntraIdOwner>? AppOwners
        // GraphQL -> appOwners: [EntraIDOwner!]! (type)
        [JsonProperty("appOwners")]
        public List<EntraIdOwner>? AppOwners { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EntraIDServicePrincipalMetadataProperties";
    }

    public EntraIdServicePrincipalMetadataProperties Set(
        System.String? AppId = null,
        System.String? AppOwnerOrgId = null,
        System.String? ApplicationTemplateId = null,
        System.Boolean? HasForbiddenRole = null,
        System.Boolean? HasNoActiveUserOwner = null,
        System.String? Homepage = null,
        System.String? PublisherName = null,
        List<EntraIdOwner>? AppOwners = null
    ) 
    {
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( AppOwnerOrgId != null ) {
            this.AppOwnerOrgId = AppOwnerOrgId;
        }
        if ( ApplicationTemplateId != null ) {
            this.ApplicationTemplateId = ApplicationTemplateId;
        }
        if ( HasForbiddenRole != null ) {
            this.HasForbiddenRole = HasForbiddenRole;
        }
        if ( HasNoActiveUserOwner != null ) {
            this.HasNoActiveUserOwner = HasNoActiveUserOwner;
        }
        if ( Homepage != null ) {
            this.Homepage = Homepage;
        }
        if ( PublisherName != null ) {
            this.PublisherName = PublisherName;
        }
        if ( AppOwners != null ) {
            this.AppOwners = AppOwners;
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
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appId\n" ;
            } else {
                s += ind + "appId\n" ;
            }
        }
        //      C# -> System.String? AppOwnerOrgId
        // GraphQL -> appOwnerOrgId: String! (scalar)
        if (this.AppOwnerOrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appOwnerOrgId\n" ;
            } else {
                s += ind + "appOwnerOrgId\n" ;
            }
        }
        //      C# -> System.String? ApplicationTemplateId
        // GraphQL -> applicationTemplateId: String! (scalar)
        if (this.ApplicationTemplateId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationTemplateId\n" ;
            } else {
                s += ind + "applicationTemplateId\n" ;
            }
        }
        //      C# -> System.Boolean? HasForbiddenRole
        // GraphQL -> hasForbiddenRole: Boolean! (scalar)
        if (this.HasForbiddenRole != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasForbiddenRole\n" ;
            } else {
                s += ind + "hasForbiddenRole\n" ;
            }
        }
        //      C# -> System.Boolean? HasNoActiveUserOwner
        // GraphQL -> hasNoActiveUserOwner: Boolean! (scalar)
        if (this.HasNoActiveUserOwner != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasNoActiveUserOwner\n" ;
            } else {
                s += ind + "hasNoActiveUserOwner\n" ;
            }
        }
        //      C# -> System.String? Homepage
        // GraphQL -> homepage: String! (scalar)
        if (this.Homepage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "homepage\n" ;
            } else {
                s += ind + "homepage\n" ;
            }
        }
        //      C# -> System.String? PublisherName
        // GraphQL -> publisherName: String! (scalar)
        if (this.PublisherName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "publisherName\n" ;
            } else {
                s += ind + "publisherName\n" ;
            }
        }
        //      C# -> List<EntraIdOwner>? AppOwners
        // GraphQL -> appOwners: [EntraIDOwner!]! (type)
        if (this.AppOwners != null) {
            var fspec = this.AppOwners.AsFieldSpec(conf.Child("appOwners"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "appOwners" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (ec.Includes("appId",true))
        {
            if(this.AppId == null) {

                this.AppId = "FETCH";

            } else {


            }
        }
        else if (this.AppId != null && ec.Excludes("appId",true))
        {
            this.AppId = null;
        }
        //      C# -> System.String? AppOwnerOrgId
        // GraphQL -> appOwnerOrgId: String! (scalar)
        if (ec.Includes("appOwnerOrgId",true))
        {
            if(this.AppOwnerOrgId == null) {

                this.AppOwnerOrgId = "FETCH";

            } else {


            }
        }
        else if (this.AppOwnerOrgId != null && ec.Excludes("appOwnerOrgId",true))
        {
            this.AppOwnerOrgId = null;
        }
        //      C# -> System.String? ApplicationTemplateId
        // GraphQL -> applicationTemplateId: String! (scalar)
        if (ec.Includes("applicationTemplateId",true))
        {
            if(this.ApplicationTemplateId == null) {

                this.ApplicationTemplateId = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationTemplateId != null && ec.Excludes("applicationTemplateId",true))
        {
            this.ApplicationTemplateId = null;
        }
        //      C# -> System.Boolean? HasForbiddenRole
        // GraphQL -> hasForbiddenRole: Boolean! (scalar)
        if (ec.Includes("hasForbiddenRole",true))
        {
            if(this.HasForbiddenRole == null) {

                this.HasForbiddenRole = true;

            } else {


            }
        }
        else if (this.HasForbiddenRole != null && ec.Excludes("hasForbiddenRole",true))
        {
            this.HasForbiddenRole = null;
        }
        //      C# -> System.Boolean? HasNoActiveUserOwner
        // GraphQL -> hasNoActiveUserOwner: Boolean! (scalar)
        if (ec.Includes("hasNoActiveUserOwner",true))
        {
            if(this.HasNoActiveUserOwner == null) {

                this.HasNoActiveUserOwner = true;

            } else {


            }
        }
        else if (this.HasNoActiveUserOwner != null && ec.Excludes("hasNoActiveUserOwner",true))
        {
            this.HasNoActiveUserOwner = null;
        }
        //      C# -> System.String? Homepage
        // GraphQL -> homepage: String! (scalar)
        if (ec.Includes("homepage",true))
        {
            if(this.Homepage == null) {

                this.Homepage = "FETCH";

            } else {


            }
        }
        else if (this.Homepage != null && ec.Excludes("homepage",true))
        {
            this.Homepage = null;
        }
        //      C# -> System.String? PublisherName
        // GraphQL -> publisherName: String! (scalar)
        if (ec.Includes("publisherName",true))
        {
            if(this.PublisherName == null) {

                this.PublisherName = "FETCH";

            } else {


            }
        }
        else if (this.PublisherName != null && ec.Excludes("publisherName",true))
        {
            this.PublisherName = null;
        }
        //      C# -> List<EntraIdOwner>? AppOwners
        // GraphQL -> appOwners: [EntraIDOwner!]! (type)
        if (ec.Includes("appOwners",false))
        {
            if(this.AppOwners == null) {

                this.AppOwners = new List<EntraIdOwner>();
                this.AppOwners.ApplyExploratoryFieldSpec(ec.NewChild("appOwners"));

            } else {

                this.AppOwners.ApplyExploratoryFieldSpec(ec.NewChild("appOwners"));

            }
        }
        else if (this.AppOwners != null && ec.Excludes("appOwners",false))
        {
            this.AppOwners = null;
        }
    }


    #endregion

    } // class EntraIdServicePrincipalMetadataProperties
    
    #endregion

    public static class ListEntraIdServicePrincipalMetadataPropertiesExtensions
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
            this List<EntraIdServicePrincipalMetadataProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EntraIdServicePrincipalMetadataProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EntraIdServicePrincipalMetadataProperties> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EntraIdServicePrincipalMetadataProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EntraIdServicePrincipalMetadataProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types