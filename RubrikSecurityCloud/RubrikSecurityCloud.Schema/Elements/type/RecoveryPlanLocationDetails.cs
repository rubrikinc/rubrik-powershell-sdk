// RecoveryPlanLocationDetails.cs
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
    #region RecoveryPlanLocationDetails
    public class RecoveryPlanLocationDetails: BaseType
    {
        #region members

        //      C# -> RecoveryPlanAwsAccount? AwsAccount
        // GraphQL -> awsAccount: RecoveryPlanAwsAccount (type)
        [JsonProperty("awsAccount")]
        public RecoveryPlanAwsAccount? AwsAccount { get; set; }

        //      C# -> RecoveryPlanAzureSubscription? AzureSubscription
        // GraphQL -> azureSubscription: RecoveryPlanAzureSubscription (type)
        [JsonProperty("azureSubscription")]
        public RecoveryPlanAzureSubscription? AzureSubscription { get; set; }

        //      C# -> RecoveryPlanCdmCluster? CdmCluster
        // GraphQL -> cdmCluster: RecoveryPlanCdmCluster (type)
        [JsonProperty("cdmCluster")]
        public RecoveryPlanCdmCluster? CdmCluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryPlanLocationDetails";
    }

    public RecoveryPlanLocationDetails Set(
        RecoveryPlanAwsAccount? AwsAccount = null,
        RecoveryPlanAzureSubscription? AzureSubscription = null,
        RecoveryPlanCdmCluster? CdmCluster = null
    ) 
    {
        if ( AwsAccount != null ) {
            this.AwsAccount = AwsAccount;
        }
        if ( AzureSubscription != null ) {
            this.AzureSubscription = AzureSubscription;
        }
        if ( CdmCluster != null ) {
            this.CdmCluster = CdmCluster;
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
        //      C# -> RecoveryPlanAwsAccount? AwsAccount
        // GraphQL -> awsAccount: RecoveryPlanAwsAccount (type)
        if (this.AwsAccount != null) {
            var fspec = this.AwsAccount.AsFieldSpec(conf.Child("awsAccount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsAccount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanAzureSubscription? AzureSubscription
        // GraphQL -> azureSubscription: RecoveryPlanAzureSubscription (type)
        if (this.AzureSubscription != null) {
            var fspec = this.AzureSubscription.AsFieldSpec(conf.Child("azureSubscription"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureSubscription" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanCdmCluster? CdmCluster
        // GraphQL -> cdmCluster: RecoveryPlanCdmCluster (type)
        if (this.CdmCluster != null) {
            var fspec = this.CdmCluster.AsFieldSpec(conf.Child("cdmCluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmCluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryPlanAwsAccount? AwsAccount
        // GraphQL -> awsAccount: RecoveryPlanAwsAccount (type)
        if (ec.Includes("awsAccount",false))
        {
            if(this.AwsAccount == null) {

                this.AwsAccount = new RecoveryPlanAwsAccount();
                this.AwsAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsAccount"));

            } else {

                this.AwsAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsAccount"));

            }
        }
        else if (this.AwsAccount != null && ec.Excludes("awsAccount",false))
        {
            this.AwsAccount = null;
        }
        //      C# -> RecoveryPlanAzureSubscription? AzureSubscription
        // GraphQL -> azureSubscription: RecoveryPlanAzureSubscription (type)
        if (ec.Includes("azureSubscription",false))
        {
            if(this.AzureSubscription == null) {

                this.AzureSubscription = new RecoveryPlanAzureSubscription();
                this.AzureSubscription.ApplyExploratoryFieldSpec(ec.NewChild("azureSubscription"));

            } else {

                this.AzureSubscription.ApplyExploratoryFieldSpec(ec.NewChild("azureSubscription"));

            }
        }
        else if (this.AzureSubscription != null && ec.Excludes("azureSubscription",false))
        {
            this.AzureSubscription = null;
        }
        //      C# -> RecoveryPlanCdmCluster? CdmCluster
        // GraphQL -> cdmCluster: RecoveryPlanCdmCluster (type)
        if (ec.Includes("cdmCluster",false))
        {
            if(this.CdmCluster == null) {

                this.CdmCluster = new RecoveryPlanCdmCluster();
                this.CdmCluster.ApplyExploratoryFieldSpec(ec.NewChild("cdmCluster"));

            } else {

                this.CdmCluster.ApplyExploratoryFieldSpec(ec.NewChild("cdmCluster"));

            }
        }
        else if (this.CdmCluster != null && ec.Excludes("cdmCluster",false))
        {
            this.CdmCluster = null;
        }
    }


    #endregion

    } // class RecoveryPlanLocationDetails
    
    #endregion

    public static class ListRecoveryPlanLocationDetailsExtensions
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
            this List<RecoveryPlanLocationDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryPlanLocationDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPlanLocationDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPlanLocationDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryPlanLocationDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types