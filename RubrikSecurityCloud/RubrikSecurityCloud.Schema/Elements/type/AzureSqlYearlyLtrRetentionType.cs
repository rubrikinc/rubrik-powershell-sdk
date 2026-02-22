// AzureSqlYearlyLtrRetentionType.cs
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
    #region AzureSqlYearlyLtrRetentionType
    public class AzureSqlYearlyLtrRetentionType: BaseType
    {
        #region members

        //      C# -> System.Int32? WeekOfYear
        // GraphQL -> weekOfYear: Int! (scalar)
        [JsonProperty("weekOfYear")]
        public System.Int32? WeekOfYear { get; set; }

        //      C# -> AzureSqlLtrRetentionType? LtrRetention
        // GraphQL -> ltrRetention: AzureSqlLtrRetentionType! (type)
        [JsonProperty("ltrRetention")]
        public AzureSqlLtrRetentionType? LtrRetention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureSqlYearlyLtrRetentionType";
    }

    public AzureSqlYearlyLtrRetentionType Set(
        System.Int32? WeekOfYear = null,
        AzureSqlLtrRetentionType? LtrRetention = null
    ) 
    {
        if ( WeekOfYear != null ) {
            this.WeekOfYear = WeekOfYear;
        }
        if ( LtrRetention != null ) {
            this.LtrRetention = LtrRetention;
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
        //      C# -> System.Int32? WeekOfYear
        // GraphQL -> weekOfYear: Int! (scalar)
        if (this.WeekOfYear != null) {
            if (conf.Flat) {
                s += conf.Prefix + "weekOfYear\n" ;
            } else {
                s += ind + "weekOfYear\n" ;
            }
        }
        //      C# -> AzureSqlLtrRetentionType? LtrRetention
        // GraphQL -> ltrRetention: AzureSqlLtrRetentionType! (type)
        if (this.LtrRetention != null) {
            var fspec = this.LtrRetention.AsFieldSpec(conf.Child("ltrRetention"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ltrRetention" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? WeekOfYear
        // GraphQL -> weekOfYear: Int! (scalar)
        if (ec.Includes("weekOfYear",true))
        {
            if(this.WeekOfYear == null) {

                this.WeekOfYear = Int32.MinValue;

            } else {


            }
        }
        else if (this.WeekOfYear != null && ec.Excludes("weekOfYear",true))
        {
            this.WeekOfYear = null;
        }
        //      C# -> AzureSqlLtrRetentionType? LtrRetention
        // GraphQL -> ltrRetention: AzureSqlLtrRetentionType! (type)
        if (ec.Includes("ltrRetention",false))
        {
            if(this.LtrRetention == null) {

                this.LtrRetention = new AzureSqlLtrRetentionType();
                this.LtrRetention.ApplyExploratoryFieldSpec(ec.NewChild("ltrRetention"));

            } else {

                this.LtrRetention.ApplyExploratoryFieldSpec(ec.NewChild("ltrRetention"));

            }
        }
        else if (this.LtrRetention != null && ec.Excludes("ltrRetention",false))
        {
            this.LtrRetention = null;
        }
    }


    #endregion

    } // class AzureSqlYearlyLtrRetentionType
    
    #endregion

    public static class ListAzureSqlYearlyLtrRetentionTypeExtensions
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
            this List<AzureSqlYearlyLtrRetentionType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureSqlYearlyLtrRetentionType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureSqlYearlyLtrRetentionType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSqlYearlyLtrRetentionType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureSqlYearlyLtrRetentionType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types