// CreateGuestCredentialReply.cs
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
    #region CreateGuestCredentialReply
    public class CreateGuestCredentialReply: BaseType
    {
        #region members

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Domain
        // GraphQL -> domain: String (scalar)
        [JsonProperty("domain")]
        public System.String? Domain { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> BaseGuestCredentialDetail? BaseGuestCredentialDetail
        // GraphQL -> baseGuestCredentialDetail: BaseGuestCredentialDetail (type)
        [JsonProperty("baseGuestCredentialDetail")]
        public BaseGuestCredentialDetail? BaseGuestCredentialDetail { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateGuestCredentialReply";
    }

    public CreateGuestCredentialReply Set(
        System.String? Description = null,
        System.String? Domain = null,
        System.String? Id = null,
        BaseGuestCredentialDetail? BaseGuestCredentialDetail = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Domain != null ) {
            this.Domain = Domain;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( BaseGuestCredentialDetail != null ) {
            this.BaseGuestCredentialDetail = BaseGuestCredentialDetail;
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
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.String? Domain
        // GraphQL -> domain: String (scalar)
        if (this.Domain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domain\n" ;
            } else {
                s += ind + "domain\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> BaseGuestCredentialDetail? BaseGuestCredentialDetail
        // GraphQL -> baseGuestCredentialDetail: BaseGuestCredentialDetail (type)
        if (this.BaseGuestCredentialDetail != null) {
            var fspec = this.BaseGuestCredentialDetail.AsFieldSpec(conf.Child("baseGuestCredentialDetail"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "baseGuestCredentialDetail {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
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
        //      C# -> System.String? Domain
        // GraphQL -> domain: String (scalar)
        if (ec.Includes("domain",true))
        {
            if(this.Domain == null) {

                this.Domain = "FETCH";

            } else {


            }
        }
        else if (this.Domain != null && ec.Excludes("domain",true))
        {
            this.Domain = null;
        }
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
        //      C# -> BaseGuestCredentialDetail? BaseGuestCredentialDetail
        // GraphQL -> baseGuestCredentialDetail: BaseGuestCredentialDetail (type)
        if (ec.Includes("baseGuestCredentialDetail",false))
        {
            if(this.BaseGuestCredentialDetail == null) {

                this.BaseGuestCredentialDetail = new BaseGuestCredentialDetail();
                this.BaseGuestCredentialDetail.ApplyExploratoryFieldSpec(ec.NewChild("baseGuestCredentialDetail"));

            } else {

                this.BaseGuestCredentialDetail.ApplyExploratoryFieldSpec(ec.NewChild("baseGuestCredentialDetail"));

            }
        }
        else if (this.BaseGuestCredentialDetail != null && ec.Excludes("baseGuestCredentialDetail",false))
        {
            this.BaseGuestCredentialDetail = null;
        }
    }


    #endregion

    } // class CreateGuestCredentialReply
    
    #endregion

    public static class ListCreateGuestCredentialReplyExtensions
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
            this List<CreateGuestCredentialReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CreateGuestCredentialReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateGuestCredentialReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateGuestCredentialReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateGuestCredentialReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types