// IdpMetadata.cs
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
    #region IdpMetadata
 
    public class IdpMetadata: BaseType, ResourceMetadataUnion
    {
        #region members

        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        [JsonProperty("idpType")]
        public IdpType? IdpType { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.String? DomainUniqueId
        // GraphQL -> domainUniqueId: String! (scalar)
        [JsonProperty("domainUniqueId")]
        public System.String? DomainUniqueId { get; set; }

        //      C# -> System.String? RootDomainId
        // GraphQL -> rootDomainId: String! (scalar)
        [JsonProperty("rootDomainId")]
        public System.String? RootDomainId { get; set; }

        //      C# -> System.String? RootDomainName
        // GraphQL -> rootDomainName: String! (scalar)
        [JsonProperty("rootDomainName")]
        public System.String? RootDomainName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdpMetadata";
    }

    public IdpMetadata Set(
        IdpType? IdpType = null,
        System.String? DomainName = null,
        System.String? DomainUniqueId = null,
        System.String? RootDomainId = null,
        System.String? RootDomainName = null
    ) 
    {
        if ( IdpType != null ) {
            this.IdpType = IdpType;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
        }
        if ( DomainUniqueId != null ) {
            this.DomainUniqueId = DomainUniqueId;
        }
        if ( RootDomainId != null ) {
            this.RootDomainId = RootDomainId;
        }
        if ( RootDomainName != null ) {
            this.RootDomainName = RootDomainName;
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
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (this.IdpType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "idpType\n" ;
            } else {
                s += ind + "idpType\n" ;
            }
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainName\n" ;
            } else {
                s += ind + "domainName\n" ;
            }
        }
        //      C# -> System.String? DomainUniqueId
        // GraphQL -> domainUniqueId: String! (scalar)
        if (this.DomainUniqueId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainUniqueId\n" ;
            } else {
                s += ind + "domainUniqueId\n" ;
            }
        }
        //      C# -> System.String? RootDomainId
        // GraphQL -> rootDomainId: String! (scalar)
        if (this.RootDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rootDomainId\n" ;
            } else {
                s += ind + "rootDomainId\n" ;
            }
        }
        //      C# -> System.String? RootDomainName
        // GraphQL -> rootDomainName: String! (scalar)
        if (this.RootDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rootDomainName\n" ;
            } else {
                s += ind + "rootDomainName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (ec.Includes("idpType",true))
        {
            if(this.IdpType == null) {

                this.IdpType = new IdpType();

            } else {


            }
        }
        else if (this.IdpType != null && ec.Excludes("idpType",true))
        {
            this.IdpType = null;
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (ec.Includes("domainName",true))
        {
            if(this.DomainName == null) {

                this.DomainName = "FETCH";

            } else {


            }
        }
        else if (this.DomainName != null && ec.Excludes("domainName",true))
        {
            this.DomainName = null;
        }
        //      C# -> System.String? DomainUniqueId
        // GraphQL -> domainUniqueId: String! (scalar)
        if (ec.Includes("domainUniqueId",true))
        {
            if(this.DomainUniqueId == null) {

                this.DomainUniqueId = "FETCH";

            } else {


            }
        }
        else if (this.DomainUniqueId != null && ec.Excludes("domainUniqueId",true))
        {
            this.DomainUniqueId = null;
        }
        //      C# -> System.String? RootDomainId
        // GraphQL -> rootDomainId: String! (scalar)
        if (ec.Includes("rootDomainId",true))
        {
            if(this.RootDomainId == null) {

                this.RootDomainId = "FETCH";

            } else {


            }
        }
        else if (this.RootDomainId != null && ec.Excludes("rootDomainId",true))
        {
            this.RootDomainId = null;
        }
        //      C# -> System.String? RootDomainName
        // GraphQL -> rootDomainName: String! (scalar)
        if (ec.Includes("rootDomainName",true))
        {
            if(this.RootDomainName == null) {

                this.RootDomainName = "FETCH";

            } else {


            }
        }
        else if (this.RootDomainName != null && ec.Excludes("rootDomainName",true))
        {
            this.RootDomainName = null;
        }
    }


    #endregion

    } // class IdpMetadata
    
    #endregion

    public static class ListIdpMetadataExtensions
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
            this List<IdpMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IdpMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IdpMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdpMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IdpMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types