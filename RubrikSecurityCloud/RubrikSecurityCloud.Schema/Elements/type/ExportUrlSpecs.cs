// ExportUrlSpecs.cs
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
    #region ExportUrlSpecs
    public class ExportUrlSpecs: BaseType
    {
        #region members

        //      C# -> O365RestoreActionType? ActionType
        // GraphQL -> actionType: O365RestoreActionType! (enum)
        [JsonProperty("actionType")]
        public O365RestoreActionType? ActionType { get; set; }

        //      C# -> System.String? BlobName
        // GraphQL -> blobName: String! (scalar)
        [JsonProperty("blobName")]
        public System.String? BlobName { get; set; }

        //      C# -> System.String? BlobSasUri
        // GraphQL -> blobSasUri: String! (scalar)
        [JsonProperty("blobSasUri")]
        public System.String? BlobSasUri { get; set; }

        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        [JsonProperty("polarisAccount")]
        public System.String? PolarisAccount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExportUrlSpecs";
    }

    public ExportUrlSpecs Set(
        O365RestoreActionType? ActionType = null,
        System.String? BlobName = null,
        System.String? BlobSasUri = null,
        System.String? PolarisAccount = null
    ) 
    {
        if ( ActionType != null ) {
            this.ActionType = ActionType;
        }
        if ( BlobName != null ) {
            this.BlobName = BlobName;
        }
        if ( BlobSasUri != null ) {
            this.BlobSasUri = BlobSasUri;
        }
        if ( PolarisAccount != null ) {
            this.PolarisAccount = PolarisAccount;
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
        //      C# -> O365RestoreActionType? ActionType
        // GraphQL -> actionType: O365RestoreActionType! (enum)
        if (this.ActionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actionType\n" ;
            } else {
                s += ind + "actionType\n" ;
            }
        }
        //      C# -> System.String? BlobName
        // GraphQL -> blobName: String! (scalar)
        if (this.BlobName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "blobName\n" ;
            } else {
                s += ind + "blobName\n" ;
            }
        }
        //      C# -> System.String? BlobSasUri
        // GraphQL -> blobSasUri: String! (scalar)
        if (this.BlobSasUri != null) {
            if (conf.Flat) {
                s += conf.Prefix + "blobSasUri\n" ;
            } else {
                s += ind + "blobSasUri\n" ;
            }
        }
        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        if (this.PolarisAccount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "polarisAccount\n" ;
            } else {
                s += ind + "polarisAccount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> O365RestoreActionType? ActionType
        // GraphQL -> actionType: O365RestoreActionType! (enum)
        if (ec.Includes("actionType",true))
        {
            if(this.ActionType == null) {

                this.ActionType = new O365RestoreActionType();

            } else {


            }
        }
        else if (this.ActionType != null && ec.Excludes("actionType",true))
        {
            this.ActionType = null;
        }
        //      C# -> System.String? BlobName
        // GraphQL -> blobName: String! (scalar)
        if (ec.Includes("blobName",true))
        {
            if(this.BlobName == null) {

                this.BlobName = "FETCH";

            } else {


            }
        }
        else if (this.BlobName != null && ec.Excludes("blobName",true))
        {
            this.BlobName = null;
        }
        //      C# -> System.String? BlobSasUri
        // GraphQL -> blobSasUri: String! (scalar)
        if (ec.Includes("blobSasUri",true))
        {
            if(this.BlobSasUri == null) {

                this.BlobSasUri = "FETCH";

            } else {


            }
        }
        else if (this.BlobSasUri != null && ec.Excludes("blobSasUri",true))
        {
            this.BlobSasUri = null;
        }
        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        if (ec.Includes("polarisAccount",true))
        {
            if(this.PolarisAccount == null) {

                this.PolarisAccount = "FETCH";

            } else {


            }
        }
        else if (this.PolarisAccount != null && ec.Excludes("polarisAccount",true))
        {
            this.PolarisAccount = null;
        }
    }


    #endregion

    } // class ExportUrlSpecs
    
    #endregion

    public static class ListExportUrlSpecsExtensions
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
            this List<ExportUrlSpecs> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ExportUrlSpecs> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ExportUrlSpecs> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExportUrlSpecs());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ExportUrlSpecs> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types