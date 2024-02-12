// CrossAccountSaType.cs
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
    #region CrossAccountSaType
    public class CrossAccountSaType: BaseType
    {
        #region members

        //      C# -> System.String? AccessTokenUrl
        // GraphQL -> accessTokenUrl: String! (scalar)
        [JsonProperty("accessTokenUrl")]
        public System.String? AccessTokenUrl { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        [JsonProperty("clientSecret")]
        public System.String? ClientSecret { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CrossAccountSaType";
    }

    public CrossAccountSaType Set(
        System.String? AccessTokenUrl = null,
        System.String? ClientId = null,
        System.String? ClientSecret = null
    ) 
    {
        if ( AccessTokenUrl != null ) {
            this.AccessTokenUrl = AccessTokenUrl;
        }
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( ClientSecret != null ) {
            this.ClientSecret = ClientSecret;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? AccessTokenUrl
        // GraphQL -> accessTokenUrl: String! (scalar)
        if (this.AccessTokenUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessTokenUrl\n" ;
            } else {
                s += ind + "accessTokenUrl\n" ;
            }
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientId\n" ;
            } else {
                s += ind + "clientId\n" ;
            }
        }
        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        if (this.ClientSecret != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientSecret\n" ;
            } else {
                s += ind + "clientSecret\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AccessTokenUrl
        // GraphQL -> accessTokenUrl: String! (scalar)
        if (ec.Includes("accessTokenUrl",true))
        {
            if(this.AccessTokenUrl == null) {

                this.AccessTokenUrl = "FETCH";

            } else {


            }
        }
        else if (this.AccessTokenUrl != null && ec.Excludes("accessTokenUrl",true))
        {
            this.AccessTokenUrl = null;
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (ec.Includes("clientId",true))
        {
            if(this.ClientId == null) {

                this.ClientId = "FETCH";

            } else {


            }
        }
        else if (this.ClientId != null && ec.Excludes("clientId",true))
        {
            this.ClientId = null;
        }
        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        if (ec.Includes("clientSecret",true))
        {
            if(this.ClientSecret == null) {

                this.ClientSecret = "FETCH";

            } else {


            }
        }
        else if (this.ClientSecret != null && ec.Excludes("clientSecret",true))
        {
            this.ClientSecret = null;
        }
    }


    #endregion

    } // class CrossAccountSaType
    
    #endregion

    public static class ListCrossAccountSaTypeExtensions
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
            this List<CrossAccountSaType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CrossAccountSaType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CrossAccountSaType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CrossAccountSaType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CrossAccountSaType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types