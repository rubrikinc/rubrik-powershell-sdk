// PolarisReportSchemaConfig.cs
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
    #region PolarisReportSchemaConfig
    public class PolarisReportSchemaConfig: BaseType
    {
        #region members

        //      C# -> System.String? ChartTitle
        // GraphQL -> chartTitle: String! (scalar)
        [JsonProperty("chartTitle")]
        public System.String? ChartTitle { get; set; }

        //      C# -> System.String? DefaultName
        // GraphQL -> defaultName: String! (scalar)
        [JsonProperty("defaultName")]
        public System.String? DefaultName { get; set; }

        //      C# -> System.String? TableTitle
        // GraphQL -> tableTitle: String! (scalar)
        [JsonProperty("tableTitle")]
        public System.String? TableTitle { get; set; }


        #endregion

    #region methods

    public PolarisReportSchemaConfig Set(
        System.String? ChartTitle = null,
        System.String? DefaultName = null,
        System.String? TableTitle = null
    ) 
    {
        if ( ChartTitle != null ) {
            this.ChartTitle = ChartTitle;
        }
        if ( DefaultName != null ) {
            this.DefaultName = DefaultName;
        }
        if ( TableTitle != null ) {
            this.TableTitle = TableTitle;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? ChartTitle
        // GraphQL -> chartTitle: String! (scalar)
        if (this.ChartTitle != null) {
            s += ind + "chartTitle\n" ;
        }
        //      C# -> System.String? DefaultName
        // GraphQL -> defaultName: String! (scalar)
        if (this.DefaultName != null) {
            s += ind + "defaultName\n" ;
        }
        //      C# -> System.String? TableTitle
        // GraphQL -> tableTitle: String! (scalar)
        if (this.TableTitle != null) {
            s += ind + "tableTitle\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ChartTitle
        // GraphQL -> chartTitle: String! (scalar)
        if (this.ChartTitle == null && Exploration.Includes(parent + ".chartTitle", true))
        {
            this.ChartTitle = "FETCH";
        }
        //      C# -> System.String? DefaultName
        // GraphQL -> defaultName: String! (scalar)
        if (this.DefaultName == null && Exploration.Includes(parent + ".defaultName", true))
        {
            this.DefaultName = "FETCH";
        }
        //      C# -> System.String? TableTitle
        // GraphQL -> tableTitle: String! (scalar)
        if (this.TableTitle == null && Exploration.Includes(parent + ".tableTitle", true))
        {
            this.TableTitle = "FETCH";
        }
    }


    #endregion

    } // class PolarisReportSchemaConfig
    
    #endregion

    public static class ListPolarisReportSchemaConfigExtensions
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
            this List<PolarisReportSchemaConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolarisReportSchemaConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportSchemaConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types