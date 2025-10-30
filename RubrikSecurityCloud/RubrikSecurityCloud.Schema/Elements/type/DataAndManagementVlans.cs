// DataAndManagementVlans.cs
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
    #region DataAndManagementVlans
    public class DataAndManagementVlans: BaseType
    {
        #region members

        //      C# -> System.Int32? DataVlan
        // GraphQL -> dataVlan: Int (scalar)
        [JsonProperty("dataVlan")]
        public System.Int32? DataVlan { get; set; }

        //      C# -> System.Int32? ManagementVlan
        // GraphQL -> managementVlan: Int (scalar)
        [JsonProperty("managementVlan")]
        public System.Int32? ManagementVlan { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataAndManagementVlans";
    }

    public DataAndManagementVlans Set(
        System.Int32? DataVlan = null,
        System.Int32? ManagementVlan = null
    ) 
    {
        if ( DataVlan != null ) {
            this.DataVlan = DataVlan;
        }
        if ( ManagementVlan != null ) {
            this.ManagementVlan = ManagementVlan;
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
        //      C# -> System.Int32? DataVlan
        // GraphQL -> dataVlan: Int (scalar)
        if (this.DataVlan != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataVlan\n" ;
            } else {
                s += ind + "dataVlan\n" ;
            }
        }
        //      C# -> System.Int32? ManagementVlan
        // GraphQL -> managementVlan: Int (scalar)
        if (this.ManagementVlan != null) {
            if (conf.Flat) {
                s += conf.Prefix + "managementVlan\n" ;
            } else {
                s += ind + "managementVlan\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? DataVlan
        // GraphQL -> dataVlan: Int (scalar)
        if (ec.Includes("dataVlan",true))
        {
            if(this.DataVlan == null) {

                this.DataVlan = Int32.MinValue;

            } else {


            }
        }
        else if (this.DataVlan != null && ec.Excludes("dataVlan",true))
        {
            this.DataVlan = null;
        }
        //      C# -> System.Int32? ManagementVlan
        // GraphQL -> managementVlan: Int (scalar)
        if (ec.Includes("managementVlan",true))
        {
            if(this.ManagementVlan == null) {

                this.ManagementVlan = Int32.MinValue;

            } else {


            }
        }
        else if (this.ManagementVlan != null && ec.Excludes("managementVlan",true))
        {
            this.ManagementVlan = null;
        }
    }


    #endregion

    } // class DataAndManagementVlans
    
    #endregion

    public static class ListDataAndManagementVlansExtensions
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
            this List<DataAndManagementVlans> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DataAndManagementVlans> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DataAndManagementVlans> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataAndManagementVlans());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DataAndManagementVlans> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types