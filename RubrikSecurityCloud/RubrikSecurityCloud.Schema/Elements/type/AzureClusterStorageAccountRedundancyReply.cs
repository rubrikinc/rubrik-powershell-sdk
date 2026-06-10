// AzureClusterStorageAccountRedundancyReply.cs
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
    #region AzureClusterStorageAccountRedundancyReply
    public class AzureClusterStorageAccountRedundancyReply: BaseType
    {
        #region members

        //      C# -> AzureStorageAccountConversionStatus? ConversionStatus
        // GraphQL -> conversionStatus: AzureStorageAccountConversionStatus! (enum)
        [JsonProperty("conversionStatus")]
        public AzureStorageAccountConversionStatus? ConversionStatus { get; set; }

        //      C# -> AzureClusterStorageRedundancy? CurrentRedundancy
        // GraphQL -> currentRedundancy: AzureClusterStorageRedundancy! (enum)
        [JsonProperty("currentRedundancy")]
        public AzureClusterStorageRedundancy? CurrentRedundancy { get; set; }

        //      C# -> AzureClusterStorageRedundancy? TargetRedundancy
        // GraphQL -> targetRedundancy: AzureClusterStorageRedundancy (enum)
        [JsonProperty("targetRedundancy")]
        public AzureClusterStorageRedundancy? TargetRedundancy { get; set; }

        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        [JsonProperty("failureReason")]
        public System.String? FailureReason { get; set; }

        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        [JsonProperty("resourceGroup")]
        public System.String? ResourceGroup { get; set; }

        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        [JsonProperty("storageAccountName")]
        public System.String? StorageAccountName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureClusterStorageAccountRedundancyReply";
    }

    public AzureClusterStorageAccountRedundancyReply Set(
        AzureStorageAccountConversionStatus? ConversionStatus = null,
        AzureClusterStorageRedundancy? CurrentRedundancy = null,
        AzureClusterStorageRedundancy? TargetRedundancy = null,
        System.String? FailureReason = null,
        System.String? ResourceGroup = null,
        System.String? StorageAccountName = null
    ) 
    {
        if ( ConversionStatus != null ) {
            this.ConversionStatus = ConversionStatus;
        }
        if ( CurrentRedundancy != null ) {
            this.CurrentRedundancy = CurrentRedundancy;
        }
        if ( TargetRedundancy != null ) {
            this.TargetRedundancy = TargetRedundancy;
        }
        if ( FailureReason != null ) {
            this.FailureReason = FailureReason;
        }
        if ( ResourceGroup != null ) {
            this.ResourceGroup = ResourceGroup;
        }
        if ( StorageAccountName != null ) {
            this.StorageAccountName = StorageAccountName;
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
        //      C# -> AzureStorageAccountConversionStatus? ConversionStatus
        // GraphQL -> conversionStatus: AzureStorageAccountConversionStatus! (enum)
        if (this.ConversionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "conversionStatus\n" ;
            } else {
                s += ind + "conversionStatus\n" ;
            }
        }
        //      C# -> AzureClusterStorageRedundancy? CurrentRedundancy
        // GraphQL -> currentRedundancy: AzureClusterStorageRedundancy! (enum)
        if (this.CurrentRedundancy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentRedundancy\n" ;
            } else {
                s += ind + "currentRedundancy\n" ;
            }
        }
        //      C# -> AzureClusterStorageRedundancy? TargetRedundancy
        // GraphQL -> targetRedundancy: AzureClusterStorageRedundancy (enum)
        if (this.TargetRedundancy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetRedundancy\n" ;
            } else {
                s += ind + "targetRedundancy\n" ;
            }
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (this.FailureReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failureReason\n" ;
            } else {
                s += ind + "failureReason\n" ;
            }
        }
        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        if (this.ResourceGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceGroup\n" ;
            } else {
                s += ind + "resourceGroup\n" ;
            }
        }
        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        if (this.StorageAccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageAccountName\n" ;
            } else {
                s += ind + "storageAccountName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureStorageAccountConversionStatus? ConversionStatus
        // GraphQL -> conversionStatus: AzureStorageAccountConversionStatus! (enum)
        if (ec.Includes("conversionStatus",true))
        {
            if(this.ConversionStatus == null) {

                this.ConversionStatus = new AzureStorageAccountConversionStatus();

            } else {


            }
        }
        else if (this.ConversionStatus != null && ec.Excludes("conversionStatus",true))
        {
            this.ConversionStatus = null;
        }
        //      C# -> AzureClusterStorageRedundancy? CurrentRedundancy
        // GraphQL -> currentRedundancy: AzureClusterStorageRedundancy! (enum)
        if (ec.Includes("currentRedundancy",true))
        {
            if(this.CurrentRedundancy == null) {

                this.CurrentRedundancy = new AzureClusterStorageRedundancy();

            } else {


            }
        }
        else if (this.CurrentRedundancy != null && ec.Excludes("currentRedundancy",true))
        {
            this.CurrentRedundancy = null;
        }
        //      C# -> AzureClusterStorageRedundancy? TargetRedundancy
        // GraphQL -> targetRedundancy: AzureClusterStorageRedundancy (enum)
        if (ec.Includes("targetRedundancy",true))
        {
            if(this.TargetRedundancy == null) {

                this.TargetRedundancy = new AzureClusterStorageRedundancy();

            } else {


            }
        }
        else if (this.TargetRedundancy != null && ec.Excludes("targetRedundancy",true))
        {
            this.TargetRedundancy = null;
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (ec.Includes("failureReason",true))
        {
            if(this.FailureReason == null) {

                this.FailureReason = "FETCH";

            } else {


            }
        }
        else if (this.FailureReason != null && ec.Excludes("failureReason",true))
        {
            this.FailureReason = null;
        }
        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        if (ec.Includes("resourceGroup",true))
        {
            if(this.ResourceGroup == null) {

                this.ResourceGroup = "FETCH";

            } else {


            }
        }
        else if (this.ResourceGroup != null && ec.Excludes("resourceGroup",true))
        {
            this.ResourceGroup = null;
        }
        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        if (ec.Includes("storageAccountName",true))
        {
            if(this.StorageAccountName == null) {

                this.StorageAccountName = "FETCH";

            } else {


            }
        }
        else if (this.StorageAccountName != null && ec.Excludes("storageAccountName",true))
        {
            this.StorageAccountName = null;
        }
    }


    #endregion

    } // class AzureClusterStorageAccountRedundancyReply
    
    #endregion

    public static class ListAzureClusterStorageAccountRedundancyReplyExtensions
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
            this List<AzureClusterStorageAccountRedundancyReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureClusterStorageAccountRedundancyReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureClusterStorageAccountRedundancyReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureClusterStorageAccountRedundancyReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureClusterStorageAccountRedundancyReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types