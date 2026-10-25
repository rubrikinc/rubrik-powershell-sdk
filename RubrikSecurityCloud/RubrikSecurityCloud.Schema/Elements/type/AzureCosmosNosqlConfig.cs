// AzureCosmosNosqlConfig.cs
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
    #region AzureCosmosNosqlConfig
    public class AzureCosmosNosqlConfig: BaseType
    {
        #region members

        //      C# -> System.Int32? ContinuousBackupRetentionInDays
        // GraphQL -> continuousBackupRetentionInDays: Int! (scalar)
        [JsonProperty("continuousBackupRetentionInDays")]
        public System.Int32? ContinuousBackupRetentionInDays { get; set; }

        //      C# -> System.Boolean? ShouldChangeContinuousBackupRetention
        // GraphQL -> shouldChangeContinuousBackupRetention: Boolean! (scalar)
        [JsonProperty("shouldChangeContinuousBackupRetention")]
        public System.Boolean? ShouldChangeContinuousBackupRetention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureCosmosNosqlConfig";
    }

    public AzureCosmosNosqlConfig Set(
        System.Int32? ContinuousBackupRetentionInDays = null,
        System.Boolean? ShouldChangeContinuousBackupRetention = null
    ) 
    {
        if ( ContinuousBackupRetentionInDays != null ) {
            this.ContinuousBackupRetentionInDays = ContinuousBackupRetentionInDays;
        }
        if ( ShouldChangeContinuousBackupRetention != null ) {
            this.ShouldChangeContinuousBackupRetention = ShouldChangeContinuousBackupRetention;
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
        //      C# -> System.Int32? ContinuousBackupRetentionInDays
        // GraphQL -> continuousBackupRetentionInDays: Int! (scalar)
        if (this.ContinuousBackupRetentionInDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "continuousBackupRetentionInDays\n" ;
            } else {
                s += ind + "continuousBackupRetentionInDays\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldChangeContinuousBackupRetention
        // GraphQL -> shouldChangeContinuousBackupRetention: Boolean! (scalar)
        if (this.ShouldChangeContinuousBackupRetention != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldChangeContinuousBackupRetention\n" ;
            } else {
                s += ind + "shouldChangeContinuousBackupRetention\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? ContinuousBackupRetentionInDays
        // GraphQL -> continuousBackupRetentionInDays: Int! (scalar)
        if (ec.Includes("continuousBackupRetentionInDays",true))
        {
            if(this.ContinuousBackupRetentionInDays == null) {

                this.ContinuousBackupRetentionInDays = Int32.MinValue;

            } else {


            }
        }
        else if (this.ContinuousBackupRetentionInDays != null && ec.Excludes("continuousBackupRetentionInDays",true))
        {
            this.ContinuousBackupRetentionInDays = null;
        }
        //      C# -> System.Boolean? ShouldChangeContinuousBackupRetention
        // GraphQL -> shouldChangeContinuousBackupRetention: Boolean! (scalar)
        if (ec.Includes("shouldChangeContinuousBackupRetention",true))
        {
            if(this.ShouldChangeContinuousBackupRetention == null) {

                this.ShouldChangeContinuousBackupRetention = true;

            } else {


            }
        }
        else if (this.ShouldChangeContinuousBackupRetention != null && ec.Excludes("shouldChangeContinuousBackupRetention",true))
        {
            this.ShouldChangeContinuousBackupRetention = null;
        }
    }


    #endregion

    } // class AzureCosmosNosqlConfig
    
    #endregion

    public static class ListAzureCosmosNosqlConfigExtensions
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
            this List<AzureCosmosNosqlConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureCosmosNosqlConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureCosmosNosqlConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCosmosNosqlConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCosmosNosqlConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types