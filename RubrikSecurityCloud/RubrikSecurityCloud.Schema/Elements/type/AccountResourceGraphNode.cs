// AccountResourceGraphNode.cs
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
    #region AccountResourceGraphNode
    public class AccountResourceGraphNode: BaseType
    {
        #region members

        //      C# -> System.String? AutoId
        // GraphQL -> autoId: ID! (scalar)
        [JsonProperty("autoId")]
        public System.String? AutoId { get; set; }

        //      C# -> System.Boolean? IsTagged
        // GraphQL -> isTagged: Boolean! (scalar)
        [JsonProperty("isTagged")]
        public System.Boolean? IsTagged { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? RelatedResourceIds
        // GraphQL -> relatedResourceIds: [ID!]! (scalar)
        [JsonProperty("relatedResourceIds")]
        public List<System.String>? RelatedResourceIds { get; set; }

        //      C# -> System.String? Uri
        // GraphQL -> uri: String! (scalar)
        [JsonProperty("uri")]
        public System.String? Uri { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AccountResourceGraphNode";
    }

    public AccountResourceGraphNode Set(
        System.String? AutoId = null,
        System.Boolean? IsTagged = null,
        System.String? Name = null,
        List<System.String>? RelatedResourceIds = null,
        System.String? Uri = null
    ) 
    {
        if ( AutoId != null ) {
            this.AutoId = AutoId;
        }
        if ( IsTagged != null ) {
            this.IsTagged = IsTagged;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RelatedResourceIds != null ) {
            this.RelatedResourceIds = RelatedResourceIds;
        }
        if ( Uri != null ) {
            this.Uri = Uri;
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
        //      C# -> System.String? AutoId
        // GraphQL -> autoId: ID! (scalar)
        if (this.AutoId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "autoId\n" ;
            } else {
                s += ind + "autoId\n" ;
            }
        }
        //      C# -> System.Boolean? IsTagged
        // GraphQL -> isTagged: Boolean! (scalar)
        if (this.IsTagged != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTagged\n" ;
            } else {
                s += ind + "isTagged\n" ;
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
        //      C# -> List<System.String>? RelatedResourceIds
        // GraphQL -> relatedResourceIds: [ID!]! (scalar)
        if (this.RelatedResourceIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relatedResourceIds\n" ;
            } else {
                s += ind + "relatedResourceIds\n" ;
            }
        }
        //      C# -> System.String? Uri
        // GraphQL -> uri: String! (scalar)
        if (this.Uri != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uri\n" ;
            } else {
                s += ind + "uri\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AutoId
        // GraphQL -> autoId: ID! (scalar)
        if (ec.Includes("autoId",true))
        {
            if(this.AutoId == null) {

                this.AutoId = "FETCH";

            } else {


            }
        }
        else if (this.AutoId != null && ec.Excludes("autoId",true))
        {
            this.AutoId = null;
        }
        //      C# -> System.Boolean? IsTagged
        // GraphQL -> isTagged: Boolean! (scalar)
        if (ec.Includes("isTagged",true))
        {
            if(this.IsTagged == null) {

                this.IsTagged = true;

            } else {


            }
        }
        else if (this.IsTagged != null && ec.Excludes("isTagged",true))
        {
            this.IsTagged = null;
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
        //      C# -> List<System.String>? RelatedResourceIds
        // GraphQL -> relatedResourceIds: [ID!]! (scalar)
        if (ec.Includes("relatedResourceIds",true))
        {
            if(this.RelatedResourceIds == null) {

                this.RelatedResourceIds = new List<System.String>();

            } else {


            }
        }
        else if (this.RelatedResourceIds != null && ec.Excludes("relatedResourceIds",true))
        {
            this.RelatedResourceIds = null;
        }
        //      C# -> System.String? Uri
        // GraphQL -> uri: String! (scalar)
        if (ec.Includes("uri",true))
        {
            if(this.Uri == null) {

                this.Uri = "FETCH";

            } else {


            }
        }
        else if (this.Uri != null && ec.Excludes("uri",true))
        {
            this.Uri = null;
        }
    }


    #endregion

    } // class AccountResourceGraphNode
    
    #endregion

    public static class ListAccountResourceGraphNodeExtensions
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
            this List<AccountResourceGraphNode> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AccountResourceGraphNode> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AccountResourceGraphNode> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AccountResourceGraphNode());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AccountResourceGraphNode> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types