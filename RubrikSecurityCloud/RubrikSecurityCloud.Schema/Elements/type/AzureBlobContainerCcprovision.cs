// AzureBlobContainerCcprovision.cs
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
    #region AzureBlobContainerCcprovision
    public class AzureBlobContainerCcprovision: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasImmutabilityPolicy
        // GraphQL -> hasImmutabilityPolicy: Boolean! (scalar)
        [JsonProperty("hasImmutabilityPolicy")]
        public System.Boolean? HasImmutabilityPolicy { get; set; }

        //      C# -> System.Boolean? IsImmutableStorageWithVersioningEnabled
        // GraphQL -> isImmutableStorageWithVersioningEnabled: Boolean! (scalar)
        [JsonProperty("isImmutableStorageWithVersioningEnabled")]
        public System.Boolean? IsImmutableStorageWithVersioningEnabled { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureBlobContainerCcprovision";
    }

    public AzureBlobContainerCcprovision Set(
        System.Boolean? HasImmutabilityPolicy = null,
        System.Boolean? IsImmutableStorageWithVersioningEnabled = null,
        System.String? Name = null
    ) 
    {
        if ( HasImmutabilityPolicy != null ) {
            this.HasImmutabilityPolicy = HasImmutabilityPolicy;
        }
        if ( IsImmutableStorageWithVersioningEnabled != null ) {
            this.IsImmutableStorageWithVersioningEnabled = IsImmutableStorageWithVersioningEnabled;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> System.Boolean? HasImmutabilityPolicy
        // GraphQL -> hasImmutabilityPolicy: Boolean! (scalar)
        if (this.HasImmutabilityPolicy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasImmutabilityPolicy\n" ;
            } else {
                s += ind + "hasImmutabilityPolicy\n" ;
            }
        }
        //      C# -> System.Boolean? IsImmutableStorageWithVersioningEnabled
        // GraphQL -> isImmutableStorageWithVersioningEnabled: Boolean! (scalar)
        if (this.IsImmutableStorageWithVersioningEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isImmutableStorageWithVersioningEnabled\n" ;
            } else {
                s += ind + "isImmutableStorageWithVersioningEnabled\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? HasImmutabilityPolicy
        // GraphQL -> hasImmutabilityPolicy: Boolean! (scalar)
        if (ec.Includes("hasImmutabilityPolicy",true))
        {
            if(this.HasImmutabilityPolicy == null) {

                this.HasImmutabilityPolicy = true;

            } else {


            }
        }
        else if (this.HasImmutabilityPolicy != null && ec.Excludes("hasImmutabilityPolicy",true))
        {
            this.HasImmutabilityPolicy = null;
        }
        //      C# -> System.Boolean? IsImmutableStorageWithVersioningEnabled
        // GraphQL -> isImmutableStorageWithVersioningEnabled: Boolean! (scalar)
        if (ec.Includes("isImmutableStorageWithVersioningEnabled",true))
        {
            if(this.IsImmutableStorageWithVersioningEnabled == null) {

                this.IsImmutableStorageWithVersioningEnabled = true;

            } else {


            }
        }
        else if (this.IsImmutableStorageWithVersioningEnabled != null && ec.Excludes("isImmutableStorageWithVersioningEnabled",true))
        {
            this.IsImmutableStorageWithVersioningEnabled = null;
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
    }


    #endregion

    } // class AzureBlobContainerCcprovision
    
    #endregion

    public static class ListAzureBlobContainerCcprovisionExtensions
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
            this List<AzureBlobContainerCcprovision> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureBlobContainerCcprovision> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureBlobContainerCcprovision> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureBlobContainerCcprovision());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureBlobContainerCcprovision> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types