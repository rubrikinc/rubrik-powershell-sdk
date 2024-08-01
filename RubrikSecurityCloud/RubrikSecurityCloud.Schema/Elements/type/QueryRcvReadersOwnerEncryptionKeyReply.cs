// QueryRcvReadersOwnerEncryptionKeyReply.cs
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
    #region QueryRcvReadersOwnerEncryptionKeyReply
    public class QueryRcvReadersOwnerEncryptionKeyReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? OwnerExists
        // GraphQL -> ownerExists: Boolean! (scalar)
        [JsonProperty("ownerExists")]
        public System.Boolean? OwnerExists { get; set; }

        //      C# -> RcvOwnerArchivalLocationEncryptionKey? OwnerEncryptionKeyDetails
        // GraphQL -> ownerEncryptionKeyDetails: RcvOwnerArchivalLocationEncryptionKey! (type)
        [JsonProperty("ownerEncryptionKeyDetails")]
        public RcvOwnerArchivalLocationEncryptionKey? OwnerEncryptionKeyDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "QueryRCVReadersOwnerEncryptionKeyReply";
    }

    public QueryRcvReadersOwnerEncryptionKeyReply Set(
        System.Boolean? OwnerExists = null,
        RcvOwnerArchivalLocationEncryptionKey? OwnerEncryptionKeyDetails = null
    ) 
    {
        if ( OwnerExists != null ) {
            this.OwnerExists = OwnerExists;
        }
        if ( OwnerEncryptionKeyDetails != null ) {
            this.OwnerEncryptionKeyDetails = OwnerEncryptionKeyDetails;
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
        //      C# -> System.Boolean? OwnerExists
        // GraphQL -> ownerExists: Boolean! (scalar)
        if (this.OwnerExists != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ownerExists\n" ;
            } else {
                s += ind + "ownerExists\n" ;
            }
        }
        //      C# -> RcvOwnerArchivalLocationEncryptionKey? OwnerEncryptionKeyDetails
        // GraphQL -> ownerEncryptionKeyDetails: RcvOwnerArchivalLocationEncryptionKey! (type)
        if (this.OwnerEncryptionKeyDetails != null) {
            var fspec = this.OwnerEncryptionKeyDetails.AsFieldSpec(conf.Child("ownerEncryptionKeyDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ownerEncryptionKeyDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? OwnerExists
        // GraphQL -> ownerExists: Boolean! (scalar)
        if (ec.Includes("ownerExists",true))
        {
            if(this.OwnerExists == null) {

                this.OwnerExists = true;

            } else {


            }
        }
        else if (this.OwnerExists != null && ec.Excludes("ownerExists",true))
        {
            this.OwnerExists = null;
        }
        //      C# -> RcvOwnerArchivalLocationEncryptionKey? OwnerEncryptionKeyDetails
        // GraphQL -> ownerEncryptionKeyDetails: RcvOwnerArchivalLocationEncryptionKey! (type)
        if (ec.Includes("ownerEncryptionKeyDetails",false))
        {
            if(this.OwnerEncryptionKeyDetails == null) {

                this.OwnerEncryptionKeyDetails = new RcvOwnerArchivalLocationEncryptionKey();
                this.OwnerEncryptionKeyDetails.ApplyExploratoryFieldSpec(ec.NewChild("ownerEncryptionKeyDetails"));

            } else {

                this.OwnerEncryptionKeyDetails.ApplyExploratoryFieldSpec(ec.NewChild("ownerEncryptionKeyDetails"));

            }
        }
        else if (this.OwnerEncryptionKeyDetails != null && ec.Excludes("ownerEncryptionKeyDetails",false))
        {
            this.OwnerEncryptionKeyDetails = null;
        }
    }


    #endregion

    } // class QueryRcvReadersOwnerEncryptionKeyReply
    
    #endregion

    public static class ListQueryRcvReadersOwnerEncryptionKeyReplyExtensions
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
            this List<QueryRcvReadersOwnerEncryptionKeyReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<QueryRcvReadersOwnerEncryptionKeyReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<QueryRcvReadersOwnerEncryptionKeyReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new QueryRcvReadersOwnerEncryptionKeyReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<QueryRcvReadersOwnerEncryptionKeyReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types