// EntraIdPrincipalMetadata.cs
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
    #region EntraIdPrincipalMetadata
 
    public class EntraIdPrincipalMetadata: BaseType, IdpSpecificMetadata
    {
        #region members

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        [JsonProperty("appName")]
        public System.String? AppName { get; set; }

        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        [JsonProperty("owner")]
        public System.String? Owner { get; set; }

        //      C# -> List<PrincipalApiPermissionGrant>? ApiPermissions
        // GraphQL -> apiPermissions: [PrincipalAPIPermissionGrant!]! (type)
        [JsonProperty("apiPermissions")]
        public List<PrincipalApiPermissionGrant>? ApiPermissions { get; set; }

        //      C# -> PrincipalMetadata? EntraIdPrincipalSpecificMetadata
        // GraphQL -> entraIdPrincipalSpecificMetadata: PrincipalMetadata (union)
        [JsonProperty("entraIdPrincipalSpecificMetadata")]
        public PrincipalMetadata? EntraIdPrincipalSpecificMetadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EntraIDPrincipalMetadata";
    }

    public EntraIdPrincipalMetadata Set(
        System.String? AppId = null,
        System.String? AppName = null,
        System.String? Owner = null,
        List<PrincipalApiPermissionGrant>? ApiPermissions = null,
        PrincipalMetadata? EntraIdPrincipalSpecificMetadata = null
    ) 
    {
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( AppName != null ) {
            this.AppName = AppName;
        }
        if ( Owner != null ) {
            this.Owner = Owner;
        }
        if ( ApiPermissions != null ) {
            this.ApiPermissions = ApiPermissions;
        }
        if ( EntraIdPrincipalSpecificMetadata != null ) {
            this.EntraIdPrincipalSpecificMetadata = EntraIdPrincipalSpecificMetadata;
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
        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        if (this.AppName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appName\n" ;
            } else {
                s += ind + "appName\n" ;
            }
        }
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (this.Owner != null) {
            if (conf.Flat) {
                s += conf.Prefix + "owner\n" ;
            } else {
                s += ind + "owner\n" ;
            }
        }
        //      C# -> List<PrincipalApiPermissionGrant>? ApiPermissions
        // GraphQL -> apiPermissions: [PrincipalAPIPermissionGrant!]! (type)
        if (this.ApiPermissions != null) {
            var fspec = this.ApiPermissions.AsFieldSpec(conf.Child("apiPermissions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "apiPermissions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalMetadata? EntraIdPrincipalSpecificMetadata
        // GraphQL -> entraIdPrincipalSpecificMetadata: PrincipalMetadata (union)
        if (this.EntraIdPrincipalSpecificMetadata != null) {
            var fspec = this.EntraIdPrincipalSpecificMetadata.AsFieldSpec(conf.Child("entraIdPrincipalSpecificMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "entraIdPrincipalSpecificMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        if (ec.Includes("appName",true))
        {
            if(this.AppName == null) {

                this.AppName = "FETCH";

            } else {


            }
        }
        else if (this.AppName != null && ec.Excludes("appName",true))
        {
            this.AppName = null;
        }
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (ec.Includes("owner",true))
        {
            if(this.Owner == null) {

                this.Owner = "FETCH";

            } else {


            }
        }
        else if (this.Owner != null && ec.Excludes("owner",true))
        {
            this.Owner = null;
        }
        //      C# -> List<PrincipalApiPermissionGrant>? ApiPermissions
        // GraphQL -> apiPermissions: [PrincipalAPIPermissionGrant!]! (type)
        if (ec.Includes("apiPermissions",false))
        {
            if(this.ApiPermissions == null) {

                this.ApiPermissions = new List<PrincipalApiPermissionGrant>();
                this.ApiPermissions.ApplyExploratoryFieldSpec(ec.NewChild("apiPermissions"));

            } else {

                this.ApiPermissions.ApplyExploratoryFieldSpec(ec.NewChild("apiPermissions"));

            }
        }
        else if (this.ApiPermissions != null && ec.Excludes("apiPermissions",false))
        {
            this.ApiPermissions = null;
        }
        //      C# -> PrincipalMetadata? EntraIdPrincipalSpecificMetadata
        // GraphQL -> entraIdPrincipalSpecificMetadata: PrincipalMetadata (union)
        if (ec.Includes("entraIdPrincipalSpecificMetadata",false))
        {
            if(this.EntraIdPrincipalSpecificMetadata == null) {

                var impls = new List<PrincipalMetadata>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("entraIdPrincipalSpecificMetadata"));
                this.EntraIdPrincipalSpecificMetadata = (PrincipalMetadata)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<PrincipalMetadata>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("entraIdPrincipalSpecificMetadata"));
                this.EntraIdPrincipalSpecificMetadata = (PrincipalMetadata)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.EntraIdPrincipalSpecificMetadata != null && ec.Excludes("entraIdPrincipalSpecificMetadata",false))
        {
            this.EntraIdPrincipalSpecificMetadata = null;
        }
    }


    #endregion

    } // class EntraIdPrincipalMetadata
    
    #endregion

    public static class ListEntraIdPrincipalMetadataExtensions
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
            this List<EntraIdPrincipalMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EntraIdPrincipalMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EntraIdPrincipalMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EntraIdPrincipalMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EntraIdPrincipalMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types