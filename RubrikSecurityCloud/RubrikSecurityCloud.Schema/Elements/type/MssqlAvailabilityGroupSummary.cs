// MssqlAvailabilityGroupSummary.cs
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
    #region MssqlAvailabilityGroupSummary
    public class MssqlAvailabilityGroupSummary: BaseType
    {
        #region members

        //      C# -> MssqlNonSlaProperties? MssqlNonSlaProperties
        // GraphQL -> mssqlNonSlaProperties: MssqlNonSlaProperties (type)
        [JsonProperty("mssqlNonSlaProperties")]
        public MssqlNonSlaProperties? MssqlNonSlaProperties { get; set; }

        //      C# -> MssqlSlaRelatedProperties? MssqlSlaRelatedProperties
        // GraphQL -> mssqlSlaRelatedProperties: MssqlSlaRelatedProperties (type)
        [JsonProperty("mssqlSlaRelatedProperties")]
        public MssqlSlaRelatedProperties? MssqlSlaRelatedProperties { get; set; }

        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        [JsonProperty("snappable")]
        public CdmWorkload? Snappable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlAvailabilityGroupSummary";
    }

    public MssqlAvailabilityGroupSummary Set(
        MssqlNonSlaProperties? MssqlNonSlaProperties = null,
        MssqlSlaRelatedProperties? MssqlSlaRelatedProperties = null,
        CdmWorkload? Snappable = null
    ) 
    {
        if ( MssqlNonSlaProperties != null ) {
            this.MssqlNonSlaProperties = MssqlNonSlaProperties;
        }
        if ( MssqlSlaRelatedProperties != null ) {
            this.MssqlSlaRelatedProperties = MssqlSlaRelatedProperties;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> MssqlNonSlaProperties? MssqlNonSlaProperties
        // GraphQL -> mssqlNonSlaProperties: MssqlNonSlaProperties (type)
        if (this.MssqlNonSlaProperties != null) {
            var fspec = this.MssqlNonSlaProperties.AsFieldSpec(conf.Child("mssqlNonSlaProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlNonSlaProperties {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlSlaRelatedProperties? MssqlSlaRelatedProperties
        // GraphQL -> mssqlSlaRelatedProperties: MssqlSlaRelatedProperties (type)
        if (this.MssqlSlaRelatedProperties != null) {
            var fspec = this.MssqlSlaRelatedProperties.AsFieldSpec(conf.Child("mssqlSlaRelatedProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlSlaRelatedProperties {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable != null) {
            var fspec = this.Snappable.AsFieldSpec(conf.Child("snappable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappable {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MssqlNonSlaProperties? MssqlNonSlaProperties
        // GraphQL -> mssqlNonSlaProperties: MssqlNonSlaProperties (type)
        if (ec.Includes("mssqlNonSlaProperties",false))
        {
            if(this.MssqlNonSlaProperties == null) {

                this.MssqlNonSlaProperties = new MssqlNonSlaProperties();
                this.MssqlNonSlaProperties.ApplyExploratoryFieldSpec(ec.NewChild("mssqlNonSlaProperties"));

            } else {

                this.MssqlNonSlaProperties.ApplyExploratoryFieldSpec(ec.NewChild("mssqlNonSlaProperties"));

            }
        }
        else if (this.MssqlNonSlaProperties != null && ec.Excludes("mssqlNonSlaProperties",false))
        {
            this.MssqlNonSlaProperties = null;
        }
        //      C# -> MssqlSlaRelatedProperties? MssqlSlaRelatedProperties
        // GraphQL -> mssqlSlaRelatedProperties: MssqlSlaRelatedProperties (type)
        if (ec.Includes("mssqlSlaRelatedProperties",false))
        {
            if(this.MssqlSlaRelatedProperties == null) {

                this.MssqlSlaRelatedProperties = new MssqlSlaRelatedProperties();
                this.MssqlSlaRelatedProperties.ApplyExploratoryFieldSpec(ec.NewChild("mssqlSlaRelatedProperties"));

            } else {

                this.MssqlSlaRelatedProperties.ApplyExploratoryFieldSpec(ec.NewChild("mssqlSlaRelatedProperties"));

            }
        }
        else if (this.MssqlSlaRelatedProperties != null && ec.Excludes("mssqlSlaRelatedProperties",false))
        {
            this.MssqlSlaRelatedProperties = null;
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (ec.Includes("snappable",false))
        {
            if(this.Snappable == null) {

                this.Snappable = new CdmWorkload();
                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            } else {

                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            }
        }
        else if (this.Snappable != null && ec.Excludes("snappable",false))
        {
            this.Snappable = null;
        }
    }


    #endregion

    } // class MssqlAvailabilityGroupSummary
    
    #endregion

    public static class ListMssqlAvailabilityGroupSummaryExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<MssqlAvailabilityGroupSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<MssqlAvailabilityGroupSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlAvailabilityGroupSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlAvailabilityGroupSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlAvailabilityGroupSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types