// FutureLegalHoldInfo.cs
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
    #region FutureLegalHoldInfo
    public class FutureLegalHoldInfo: BaseType
    {
        #region members

        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        //      C# -> LegalHoldInfo? HoldConfig
        // GraphQL -> holdConfig: LegalHoldInfo (type)
        [JsonProperty("holdConfig")]
        public LegalHoldInfo? HoldConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FutureLegalHoldInfo";
    }

    public FutureLegalHoldInfo Set(
        DateTime? EndDate = null,
        LegalHoldInfo? HoldConfig = null
    ) 
    {
        if ( EndDate != null ) {
            this.EndDate = EndDate;
        }
        if ( HoldConfig != null ) {
            this.HoldConfig = HoldConfig;
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
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        if (this.EndDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endDate\n" ;
            } else {
                s += ind + "endDate\n" ;
            }
        }
        //      C# -> LegalHoldInfo? HoldConfig
        // GraphQL -> holdConfig: LegalHoldInfo (type)
        if (this.HoldConfig != null) {
            var fspec = this.HoldConfig.AsFieldSpec(conf.Child("holdConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "holdConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        if (ec.Includes("endDate",true))
        {
            if(this.EndDate == null) {

                this.EndDate = new DateTime();

            } else {


            }
        }
        else if (this.EndDate != null && ec.Excludes("endDate",true))
        {
            this.EndDate = null;
        }
        //      C# -> LegalHoldInfo? HoldConfig
        // GraphQL -> holdConfig: LegalHoldInfo (type)
        if (ec.Includes("holdConfig",false))
        {
            if(this.HoldConfig == null) {

                this.HoldConfig = new LegalHoldInfo();
                this.HoldConfig.ApplyExploratoryFieldSpec(ec.NewChild("holdConfig"));

            } else {

                this.HoldConfig.ApplyExploratoryFieldSpec(ec.NewChild("holdConfig"));

            }
        }
        else if (this.HoldConfig != null && ec.Excludes("holdConfig",false))
        {
            this.HoldConfig = null;
        }
    }


    #endregion

    } // class FutureLegalHoldInfo
    
    #endregion

    public static class ListFutureLegalHoldInfoExtensions
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
            this List<FutureLegalHoldInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FutureLegalHoldInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FutureLegalHoldInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FutureLegalHoldInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FutureLegalHoldInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types