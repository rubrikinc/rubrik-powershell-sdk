// AzureDevOpsOrgInfo.cs
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
    #region AzureDevOpsOrgInfo
    public class AzureDevOpsOrgInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsOnboarded
        // GraphQL -> isOnboarded: Boolean! (scalar)
        [JsonProperty("isOnboarded")]
        public System.Boolean? IsOnboarded { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? OrgUri
        // GraphQL -> orgUri: URL! (scalar)
        [JsonProperty("orgUri")]
        public System.String? OrgUri { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureDevOpsOrgInfo";
    }

    public AzureDevOpsOrgInfo Set(
        System.Boolean? IsOnboarded = null,
        System.String? Name = null,
        System.String? OrgId = null,
        System.String? OrgUri = null
    ) 
    {
        if ( IsOnboarded != null ) {
            this.IsOnboarded = IsOnboarded;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( OrgUri != null ) {
            this.OrgUri = OrgUri;
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
        //      C# -> System.Boolean? IsOnboarded
        // GraphQL -> isOnboarded: Boolean! (scalar)
        if (this.IsOnboarded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnboarded\n" ;
            } else {
                s += ind + "isOnboarded\n" ;
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
        //      C# -> System.String? OrgUri
        // GraphQL -> orgUri: URL! (scalar)
        if (this.OrgUri != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgUri\n" ;
            } else {
                s += ind + "orgUri\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsOnboarded
        // GraphQL -> isOnboarded: Boolean! (scalar)
        if (ec.Includes("isOnboarded",true))
        {
            if(this.IsOnboarded == null) {

                this.IsOnboarded = true;

            } else {


            }
        }
        else if (this.IsOnboarded != null && ec.Excludes("isOnboarded",true))
        {
            this.IsOnboarded = null;
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
        //      C# -> System.String? OrgUri
        // GraphQL -> orgUri: URL! (scalar)
        if (ec.Includes("orgUri",true))
        {
            if(this.OrgUri == null) {

                this.OrgUri = "FETCH";

            } else {


            }
        }
        else if (this.OrgUri != null && ec.Excludes("orgUri",true))
        {
            this.OrgUri = null;
        }
    }


    #endregion

    } // class AzureDevOpsOrgInfo
    
    #endregion

    public static class ListAzureDevOpsOrgInfoExtensions
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
            this List<AzureDevOpsOrgInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureDevOpsOrgInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureDevOpsOrgInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureDevOpsOrgInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureDevOpsOrgInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types