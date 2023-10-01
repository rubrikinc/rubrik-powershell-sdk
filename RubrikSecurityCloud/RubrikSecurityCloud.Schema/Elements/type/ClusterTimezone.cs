// ClusterTimezone.cs
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
    #region ClusterTimezone
    public class ClusterTimezone: BaseType
    {
        #region members

        //      C# -> ClusterTimezoneType? Timezone
        // GraphQL -> timezone: ClusterTimezoneType! (enum)
        [JsonProperty("timezone")]
        public ClusterTimezoneType? Timezone { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterTimezone";
    }

    public ClusterTimezone Set(
        ClusterTimezoneType? Timezone = null
    ) 
    {
        if ( Timezone != null ) {
            this.Timezone = Timezone;
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
        //      C# -> ClusterTimezoneType? Timezone
        // GraphQL -> timezone: ClusterTimezoneType! (enum)
        if (this.Timezone != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timezone\n" ;
            } else {
                s += ind + "timezone\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterTimezoneType? Timezone
        // GraphQL -> timezone: ClusterTimezoneType! (enum)
        if (ec.Includes("timezone",true))
        {
            if(this.Timezone == null) {

                this.Timezone = new ClusterTimezoneType();

            } else {


            }
        }
        else if (this.Timezone != null && ec.Excludes("timezone",true))
        {
            this.Timezone = null;
        }
    }


    #endregion

    } // class ClusterTimezone
    
    #endregion

    public static class ListClusterTimezoneExtensions
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
            this List<ClusterTimezone> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ClusterTimezone> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterTimezone> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterTimezone());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterTimezone> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types