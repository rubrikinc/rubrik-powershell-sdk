// RcvRedundancyConversionType.cs
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
    #region RcvRedundancyConversionType
    public class RcvRedundancyConversionType: BaseType
    {
        #region members

        //      C# -> RcvRedundancy? DestinationRedundancy
        // GraphQL -> destinationRedundancy: RcvRedundancy! (enum)
        [JsonProperty("destinationRedundancy")]
        public RcvRedundancy? DestinationRedundancy { get; set; }

        //      C# -> RcvRedundancyConversionStatus? Status
        // GraphQL -> status: RcvRedundancyConversionStatus! (enum)
        [JsonProperty("status")]
        public RcvRedundancyConversionStatus? Status { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvRedundancyConversionType";
    }

    public RcvRedundancyConversionType Set(
        RcvRedundancy? DestinationRedundancy = null,
        RcvRedundancyConversionStatus? Status = null,
        DateTime? CreatedAt = null
    ) 
    {
        if ( DestinationRedundancy != null ) {
            this.DestinationRedundancy = DestinationRedundancy;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
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
        //      C# -> RcvRedundancy? DestinationRedundancy
        // GraphQL -> destinationRedundancy: RcvRedundancy! (enum)
        if (this.DestinationRedundancy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "destinationRedundancy\n" ;
            } else {
                s += ind + "destinationRedundancy\n" ;
            }
        }
        //      C# -> RcvRedundancyConversionStatus? Status
        // GraphQL -> status: RcvRedundancyConversionStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RcvRedundancy? DestinationRedundancy
        // GraphQL -> destinationRedundancy: RcvRedundancy! (enum)
        if (ec.Includes("destinationRedundancy",true))
        {
            if(this.DestinationRedundancy == null) {

                this.DestinationRedundancy = new RcvRedundancy();

            } else {


            }
        }
        else if (this.DestinationRedundancy != null && ec.Excludes("destinationRedundancy",true))
        {
            this.DestinationRedundancy = null;
        }
        //      C# -> RcvRedundancyConversionStatus? Status
        // GraphQL -> status: RcvRedundancyConversionStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new RcvRedundancyConversionStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
    }


    #endregion

    } // class RcvRedundancyConversionType
    
    #endregion

    public static class ListRcvRedundancyConversionTypeExtensions
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
            this List<RcvRedundancyConversionType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvRedundancyConversionType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvRedundancyConversionType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvRedundancyConversionType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvRedundancyConversionType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types