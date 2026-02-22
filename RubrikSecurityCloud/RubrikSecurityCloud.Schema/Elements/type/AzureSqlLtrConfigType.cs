// AzureSqlLtrConfigType.cs
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
    #region AzureSqlLtrConfigType
    public class AzureSqlLtrConfigType: BaseType
    {
        #region members

        //      C# -> AzureSqlLtrRetentionType? MonthlyBackupRetention
        // GraphQL -> monthlyBackupRetention: AzureSqlLtrRetentionType (type)
        [JsonProperty("monthlyBackupRetention")]
        public AzureSqlLtrRetentionType? MonthlyBackupRetention { get; set; }

        //      C# -> AzureSqlLtrRetentionType? WeeklyBackupRetention
        // GraphQL -> weeklyBackupRetention: AzureSqlLtrRetentionType (type)
        [JsonProperty("weeklyBackupRetention")]
        public AzureSqlLtrRetentionType? WeeklyBackupRetention { get; set; }

        //      C# -> AzureSqlYearlyLtrRetentionType? YearlyBackupRetention
        // GraphQL -> yearlyBackupRetention: AzureSqlYearlyLtrRetentionType (type)
        [JsonProperty("yearlyBackupRetention")]
        public AzureSqlYearlyLtrRetentionType? YearlyBackupRetention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureSqlLtrConfigType";
    }

    public AzureSqlLtrConfigType Set(
        AzureSqlLtrRetentionType? MonthlyBackupRetention = null,
        AzureSqlLtrRetentionType? WeeklyBackupRetention = null,
        AzureSqlYearlyLtrRetentionType? YearlyBackupRetention = null
    ) 
    {
        if ( MonthlyBackupRetention != null ) {
            this.MonthlyBackupRetention = MonthlyBackupRetention;
        }
        if ( WeeklyBackupRetention != null ) {
            this.WeeklyBackupRetention = WeeklyBackupRetention;
        }
        if ( YearlyBackupRetention != null ) {
            this.YearlyBackupRetention = YearlyBackupRetention;
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
        //      C# -> AzureSqlLtrRetentionType? MonthlyBackupRetention
        // GraphQL -> monthlyBackupRetention: AzureSqlLtrRetentionType (type)
        if (this.MonthlyBackupRetention != null) {
            var fspec = this.MonthlyBackupRetention.AsFieldSpec(conf.Child("monthlyBackupRetention"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "monthlyBackupRetention" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureSqlLtrRetentionType? WeeklyBackupRetention
        // GraphQL -> weeklyBackupRetention: AzureSqlLtrRetentionType (type)
        if (this.WeeklyBackupRetention != null) {
            var fspec = this.WeeklyBackupRetention.AsFieldSpec(conf.Child("weeklyBackupRetention"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "weeklyBackupRetention" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureSqlYearlyLtrRetentionType? YearlyBackupRetention
        // GraphQL -> yearlyBackupRetention: AzureSqlYearlyLtrRetentionType (type)
        if (this.YearlyBackupRetention != null) {
            var fspec = this.YearlyBackupRetention.AsFieldSpec(conf.Child("yearlyBackupRetention"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "yearlyBackupRetention" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureSqlLtrRetentionType? MonthlyBackupRetention
        // GraphQL -> monthlyBackupRetention: AzureSqlLtrRetentionType (type)
        if (ec.Includes("monthlyBackupRetention",false))
        {
            if(this.MonthlyBackupRetention == null) {

                this.MonthlyBackupRetention = new AzureSqlLtrRetentionType();
                this.MonthlyBackupRetention.ApplyExploratoryFieldSpec(ec.NewChild("monthlyBackupRetention"));

            } else {

                this.MonthlyBackupRetention.ApplyExploratoryFieldSpec(ec.NewChild("monthlyBackupRetention"));

            }
        }
        else if (this.MonthlyBackupRetention != null && ec.Excludes("monthlyBackupRetention",false))
        {
            this.MonthlyBackupRetention = null;
        }
        //      C# -> AzureSqlLtrRetentionType? WeeklyBackupRetention
        // GraphQL -> weeklyBackupRetention: AzureSqlLtrRetentionType (type)
        if (ec.Includes("weeklyBackupRetention",false))
        {
            if(this.WeeklyBackupRetention == null) {

                this.WeeklyBackupRetention = new AzureSqlLtrRetentionType();
                this.WeeklyBackupRetention.ApplyExploratoryFieldSpec(ec.NewChild("weeklyBackupRetention"));

            } else {

                this.WeeklyBackupRetention.ApplyExploratoryFieldSpec(ec.NewChild("weeklyBackupRetention"));

            }
        }
        else if (this.WeeklyBackupRetention != null && ec.Excludes("weeklyBackupRetention",false))
        {
            this.WeeklyBackupRetention = null;
        }
        //      C# -> AzureSqlYearlyLtrRetentionType? YearlyBackupRetention
        // GraphQL -> yearlyBackupRetention: AzureSqlYearlyLtrRetentionType (type)
        if (ec.Includes("yearlyBackupRetention",false))
        {
            if(this.YearlyBackupRetention == null) {

                this.YearlyBackupRetention = new AzureSqlYearlyLtrRetentionType();
                this.YearlyBackupRetention.ApplyExploratoryFieldSpec(ec.NewChild("yearlyBackupRetention"));

            } else {

                this.YearlyBackupRetention.ApplyExploratoryFieldSpec(ec.NewChild("yearlyBackupRetention"));

            }
        }
        else if (this.YearlyBackupRetention != null && ec.Excludes("yearlyBackupRetention",false))
        {
            this.YearlyBackupRetention = null;
        }
    }


    #endregion

    } // class AzureSqlLtrConfigType
    
    #endregion

    public static class ListAzureSqlLtrConfigTypeExtensions
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
            this List<AzureSqlLtrConfigType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureSqlLtrConfigType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureSqlLtrConfigType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSqlLtrConfigType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureSqlLtrConfigType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types