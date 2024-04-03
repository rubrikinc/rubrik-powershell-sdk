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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
                    s += ind + "baseGuestCredentialDetail" + " " + "{\n" + fspec + ind + "}\n" ;
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
            this List<CreateGuestCredentialReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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