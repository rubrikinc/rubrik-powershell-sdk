// CdmMonthlyDaySpecification.cs
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
    #region CdmMonthlyDaySpecification
    public class CdmMonthlyDaySpecification: BaseType
    {
        #region members

        //      C# -> System.Int32? DateOffset
        // GraphQL -> dateOffset: Int (scalar)
        [JsonProperty("dateOffset")]
        public System.Int32? DateOffset { get; set; }

        //      C# -> DayOfWeekInMonth? DayOfWeekInMonth
        // GraphQL -> dayOfWeekInMonth: DayOfWeekInMonth (type)
        [JsonProperty("dayOfWeekInMonth")]
        public DayOfWeekInMonth? DayOfWeekInMonth { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmMonthlyDaySpecification";
    }

    public CdmMonthlyDaySpecification Set(
        System.Int32? DateOffset = null,
        DayOfWeekInMonth? DayOfWeekInMonth = null
    ) 
    {
        if ( DateOffset != null ) {
            this.DateOffset = DateOffset;
        }
        if ( DayOfWeekInMonth != null ) {
            this.DayOfWeekInMonth = DayOfWeekInMonth;
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
        //      C# -> System.Int32? DateOffset
        // GraphQL -> dateOffset: Int (scalar)
        if (this.DateOffset != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dateOffset\n" ;
            } else {
                s += ind + "dateOffset\n" ;
            }
        }
        //      C# -> DayOfWeekInMonth? DayOfWeekInMonth
        // GraphQL -> dayOfWeekInMonth: DayOfWeekInMonth (type)
        if (this.DayOfWeekInMonth != null) {
            var fspec = this.DayOfWeekInMonth.AsFieldSpec(conf.Child("dayOfWeekInMonth"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dayOfWeekInMonth" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? DateOffset
        // GraphQL -> dateOffset: Int (scalar)
        if (ec.Includes("dateOffset",true))
        {
            if(this.DateOffset == null) {

                this.DateOffset = Int32.MinValue;

            } else {


            }
        }
        else if (this.DateOffset != null && ec.Excludes("dateOffset",true))
        {
            this.DateOffset = null;
        }
        //      C# -> DayOfWeekInMonth? DayOfWeekInMonth
        // GraphQL -> dayOfWeekInMonth: DayOfWeekInMonth (type)
        if (ec.Includes("dayOfWeekInMonth",false))
        {
            if(this.DayOfWeekInMonth == null) {

                this.DayOfWeekInMonth = new DayOfWeekInMonth();
                this.DayOfWeekInMonth.ApplyExploratoryFieldSpec(ec.NewChild("dayOfWeekInMonth"));

            } else {

                this.DayOfWeekInMonth.ApplyExploratoryFieldSpec(ec.NewChild("dayOfWeekInMonth"));

            }
        }
        else if (this.DayOfWeekInMonth != null && ec.Excludes("dayOfWeekInMonth",false))
        {
            this.DayOfWeekInMonth = null;
        }
    }


    #endregion

    } // class CdmMonthlyDaySpecification
    
    #endregion

    public static class ListCdmMonthlyDaySpecificationExtensions
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
            this List<CdmMonthlyDaySpecification> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmMonthlyDaySpecification> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmMonthlyDaySpecification> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmMonthlyDaySpecification());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmMonthlyDaySpecification> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types