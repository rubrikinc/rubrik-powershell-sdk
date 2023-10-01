// FailoverClusterStatus.cs
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
    #region FailoverClusterStatus
    public class FailoverClusterStatus: BaseType
    {
        #region members

        //      C# -> FailoverClusterConnectivityStatus? Connectivity
        // GraphQL -> connectivity: FailoverClusterConnectivityStatus! (enum)
        [JsonProperty("connectivity")]
        public FailoverClusterConnectivityStatus? Connectivity { get; set; }

        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        [JsonProperty("timestampMillis")]
        public DateTime? TimestampMillis { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverClusterStatus";
    }

    public FailoverClusterStatus Set(
        FailoverClusterConnectivityStatus? Connectivity = null,
        DateTime? TimestampMillis = null
    ) 
    {
        if ( Connectivity != null ) {
            this.Connectivity = Connectivity;
        }
        if ( TimestampMillis != null ) {
            this.TimestampMillis = TimestampMillis;
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
        //      C# -> FailoverClusterConnectivityStatus? Connectivity
        // GraphQL -> connectivity: FailoverClusterConnectivityStatus! (enum)
        if (this.Connectivity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectivity\n" ;
            } else {
                s += ind + "connectivity\n" ;
            }
        }
        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        if (this.TimestampMillis != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestampMillis\n" ;
            } else {
                s += ind + "timestampMillis\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FailoverClusterConnectivityStatus? Connectivity
        // GraphQL -> connectivity: FailoverClusterConnectivityStatus! (enum)
        if (ec.Includes("connectivity",true))
        {
            if(this.Connectivity == null) {

                this.Connectivity = new FailoverClusterConnectivityStatus();

            } else {


            }
        }
        else if (this.Connectivity != null && ec.Excludes("connectivity",true))
        {
            this.Connectivity = null;
        }
        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        if (ec.Includes("timestampMillis",true))
        {
            if(this.TimestampMillis == null) {

                this.TimestampMillis = new DateTime();

            } else {


            }
        }
        else if (this.TimestampMillis != null && ec.Excludes("timestampMillis",true))
        {
            this.TimestampMillis = null;
        }
    }


    #endregion

    } // class FailoverClusterStatus
    
    #endregion

    public static class ListFailoverClusterStatusExtensions
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
            this List<FailoverClusterStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<FailoverClusterStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverClusterStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types