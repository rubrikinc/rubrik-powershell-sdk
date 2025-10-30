// ServiceAccountInfo.cs
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
    #region ServiceAccountInfo
    public class ServiceAccountInfo: BaseType
    {
        #region members

        //      C# -> System.String? AccessToken
        // GraphQL -> accessToken: String! (scalar)
        [JsonProperty("accessToken")]
        public System.String? AccessToken { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.Boolean? IsK8Serror
        // GraphQL -> isK8SError: Boolean (scalar)
        [JsonProperty("isK8SError")]
        public System.Boolean? IsK8Serror { get; set; }

        //      C# -> System.String? ServiceAccountName
        // GraphQL -> serviceAccountName: String! (scalar)
        [JsonProperty("serviceAccountName")]
        public System.String? ServiceAccountName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ServiceAccountInfo";
    }

    public ServiceAccountInfo Set(
        System.String? AccessToken = null,
        System.String? ClientId = null,
        System.Boolean? IsK8Serror = null,
        System.String? ServiceAccountName = null
    ) 
    {
        if ( AccessToken != null ) {
            this.AccessToken = AccessToken;
        }
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( IsK8Serror != null ) {
            this.IsK8Serror = IsK8Serror;
        }
        if ( ServiceAccountName != null ) {
            this.ServiceAccountName = ServiceAccountName;
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
        //      C# -> System.String? AccessToken
        // GraphQL -> accessToken: String! (scalar)
        if (this.AccessToken != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessToken\n" ;
            } else {
                s += ind + "accessToken\n" ;
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
        //      C# -> System.Boolean? IsK8Serror
        // GraphQL -> isK8SError: Boolean (scalar)
        if (this.IsK8Serror != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isK8SError\n" ;
            } else {
                s += ind + "isK8SError\n" ;
            }
        }
        //      C# -> System.String? ServiceAccountName
        // GraphQL -> serviceAccountName: String! (scalar)
        if (this.ServiceAccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serviceAccountName\n" ;
            } else {
                s += ind + "serviceAccountName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AccessToken
        // GraphQL -> accessToken: String! (scalar)
        if (ec.Includes("accessToken",true))
        {
            if(this.AccessToken == null) {

                this.AccessToken = "FETCH";

            } else {


            }
        }
        else if (this.AccessToken != null && ec.Excludes("accessToken",true))
        {
            this.AccessToken = null;
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
        //      C# -> System.Boolean? IsK8Serror
        // GraphQL -> isK8SError: Boolean (scalar)
        if (ec.Includes("isK8SError",true))
        {
            if(this.IsK8Serror == null) {

                this.IsK8Serror = true;

            } else {


            }
        }
        else if (this.IsK8Serror != null && ec.Excludes("isK8SError",true))
        {
            this.IsK8Serror = null;
        }
        //      C# -> System.String? ServiceAccountName
        // GraphQL -> serviceAccountName: String! (scalar)
        if (ec.Includes("serviceAccountName",true))
        {
            if(this.ServiceAccountName == null) {

                this.ServiceAccountName = "FETCH";

            } else {


            }
        }
        else if (this.ServiceAccountName != null && ec.Excludes("serviceAccountName",true))
        {
            this.ServiceAccountName = null;
        }
    }


    #endregion

    } // class ServiceAccountInfo
    
    #endregion

    public static class ListServiceAccountInfoExtensions
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
            this List<ServiceAccountInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ServiceAccountInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ServiceAccountInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ServiceAccountInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ServiceAccountInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types