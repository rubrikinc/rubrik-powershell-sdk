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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ClusterTimezone> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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