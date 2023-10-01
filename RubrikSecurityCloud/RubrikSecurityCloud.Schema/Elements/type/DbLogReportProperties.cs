// DbLogReportProperties.cs
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
    #region DbLogReportProperties
    public class DbLogReportProperties: BaseType
    {
        #region members

        //      C# -> System.Boolean? EnableDelayNotification
        // GraphQL -> enableDelayNotification: Boolean! (scalar)
        [JsonProperty("enableDelayNotification")]
        public System.Boolean? EnableDelayNotification { get; set; }

        //      C# -> System.Int64? LogDelayNotificationFrequencyInMin
        // GraphQL -> logDelayNotificationFrequencyInMin: Long! (scalar)
        [JsonProperty("logDelayNotificationFrequencyInMin")]
        public System.Int64? LogDelayNotificationFrequencyInMin { get; set; }

        //      C# -> System.Int64? LogDelayThresholdInMin
        // GraphQL -> logDelayThresholdInMin: Long! (scalar)
        [JsonProperty("logDelayThresholdInMin")]
        public System.Int64? LogDelayThresholdInMin { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DbLogReportProperties";
    }

    public DbLogReportProperties Set(
        System.Boolean? EnableDelayNotification = null,
        System.Int64? LogDelayNotificationFrequencyInMin = null,
        System.Int64? LogDelayThresholdInMin = null
    ) 
    {
        if ( EnableDelayNotification != null ) {
            this.EnableDelayNotification = EnableDelayNotification;
        }
        if ( LogDelayNotificationFrequencyInMin != null ) {
            this.LogDelayNotificationFrequencyInMin = LogDelayNotificationFrequencyInMin;
        }
        if ( LogDelayThresholdInMin != null ) {
            this.LogDelayThresholdInMin = LogDelayThresholdInMin;
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
        //      C# -> System.Boolean? EnableDelayNotification
        // GraphQL -> enableDelayNotification: Boolean! (scalar)
        if (this.EnableDelayNotification != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableDelayNotification\n" ;
            } else {
                s += ind + "enableDelayNotification\n" ;
            }
        }
        //      C# -> System.Int64? LogDelayNotificationFrequencyInMin
        // GraphQL -> logDelayNotificationFrequencyInMin: Long! (scalar)
        if (this.LogDelayNotificationFrequencyInMin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logDelayNotificationFrequencyInMin\n" ;
            } else {
                s += ind + "logDelayNotificationFrequencyInMin\n" ;
            }
        }
        //      C# -> System.Int64? LogDelayThresholdInMin
        // GraphQL -> logDelayThresholdInMin: Long! (scalar)
        if (this.LogDelayThresholdInMin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logDelayThresholdInMin\n" ;
            } else {
                s += ind + "logDelayThresholdInMin\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? EnableDelayNotification
        // GraphQL -> enableDelayNotification: Boolean! (scalar)
        if (ec.Includes("enableDelayNotification",true))
        {
            if(this.EnableDelayNotification == null) {

                this.EnableDelayNotification = true;

            } else {


            }
        }
        else if (this.EnableDelayNotification != null && ec.Excludes("enableDelayNotification",true))
        {
            this.EnableDelayNotification = null;
        }
        //      C# -> System.Int64? LogDelayNotificationFrequencyInMin
        // GraphQL -> logDelayNotificationFrequencyInMin: Long! (scalar)
        if (ec.Includes("logDelayNotificationFrequencyInMin",true))
        {
            if(this.LogDelayNotificationFrequencyInMin == null) {

                this.LogDelayNotificationFrequencyInMin = new System.Int64();

            } else {


            }
        }
        else if (this.LogDelayNotificationFrequencyInMin != null && ec.Excludes("logDelayNotificationFrequencyInMin",true))
        {
            this.LogDelayNotificationFrequencyInMin = null;
        }
        //      C# -> System.Int64? LogDelayThresholdInMin
        // GraphQL -> logDelayThresholdInMin: Long! (scalar)
        if (ec.Includes("logDelayThresholdInMin",true))
        {
            if(this.LogDelayThresholdInMin == null) {

                this.LogDelayThresholdInMin = new System.Int64();

            } else {


            }
        }
        else if (this.LogDelayThresholdInMin != null && ec.Excludes("logDelayThresholdInMin",true))
        {
            this.LogDelayThresholdInMin = null;
        }
    }


    #endregion

    } // class DbLogReportProperties
    
    #endregion

    public static class ListDbLogReportPropertiesExtensions
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
            this List<DbLogReportProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DbLogReportProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DbLogReportProperties> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DbLogReportProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DbLogReportProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types