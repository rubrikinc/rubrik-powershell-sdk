// MssqlDefaultPropertiesOnClusterReply.cs
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
    #region MssqlDefaultPropertiesOnClusterReply
    public class MssqlDefaultPropertiesOnClusterReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? CbtStatus
        // GraphQL -> cbtStatus: Boolean! (scalar)
        [JsonProperty("cbtStatus")]
        public System.Boolean? CbtStatus { get; set; }

        //      C# -> System.Int64? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Long! (scalar)
        [JsonProperty("logBackupFrequencyInSeconds")]
        public System.Int64? LogBackupFrequencyInSeconds { get; set; }

        //      C# -> System.Int32? LogRetentionTimeInHours
        // GraphQL -> logRetentionTimeInHours: Int (scalar)
        [JsonProperty("logRetentionTimeInHours")]
        public System.Int32? LogRetentionTimeInHours { get; set; }

        //      C# -> System.Boolean? ShouldUseDefaultBackupLocation
        // GraphQL -> shouldUseDefaultBackupLocation: Boolean (scalar)
        [JsonProperty("shouldUseDefaultBackupLocation")]
        public System.Boolean? ShouldUseDefaultBackupLocation { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlDefaultPropertiesOnClusterReply";
    }

    public MssqlDefaultPropertiesOnClusterReply Set(
        System.Boolean? CbtStatus = null,
        System.Int64? LogBackupFrequencyInSeconds = null,
        System.Int32? LogRetentionTimeInHours = null,
        System.Boolean? ShouldUseDefaultBackupLocation = null
    ) 
    {
        if ( CbtStatus != null ) {
            this.CbtStatus = CbtStatus;
        }
        if ( LogBackupFrequencyInSeconds != null ) {
            this.LogBackupFrequencyInSeconds = LogBackupFrequencyInSeconds;
        }
        if ( LogRetentionTimeInHours != null ) {
            this.LogRetentionTimeInHours = LogRetentionTimeInHours;
        }
        if ( ShouldUseDefaultBackupLocation != null ) {
            this.ShouldUseDefaultBackupLocation = ShouldUseDefaultBackupLocation;
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
        //      C# -> System.Boolean? CbtStatus
        // GraphQL -> cbtStatus: Boolean! (scalar)
        if (this.CbtStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cbtStatus\n" ;
            } else {
                s += ind + "cbtStatus\n" ;
            }
        }
        //      C# -> System.Int64? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Long! (scalar)
        if (this.LogBackupFrequencyInSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupFrequencyInSeconds\n" ;
            } else {
                s += ind + "logBackupFrequencyInSeconds\n" ;
            }
        }
        //      C# -> System.Int32? LogRetentionTimeInHours
        // GraphQL -> logRetentionTimeInHours: Int (scalar)
        if (this.LogRetentionTimeInHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logRetentionTimeInHours\n" ;
            } else {
                s += ind + "logRetentionTimeInHours\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldUseDefaultBackupLocation
        // GraphQL -> shouldUseDefaultBackupLocation: Boolean (scalar)
        if (this.ShouldUseDefaultBackupLocation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldUseDefaultBackupLocation\n" ;
            } else {
                s += ind + "shouldUseDefaultBackupLocation\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? CbtStatus
        // GraphQL -> cbtStatus: Boolean! (scalar)
        if (ec.Includes("cbtStatus",true))
        {
            if(this.CbtStatus == null) {

                this.CbtStatus = true;

            } else {


            }
        }
        else if (this.CbtStatus != null && ec.Excludes("cbtStatus",true))
        {
            this.CbtStatus = null;
        }
        //      C# -> System.Int64? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Long! (scalar)
        if (ec.Includes("logBackupFrequencyInSeconds",true))
        {
            if(this.LogBackupFrequencyInSeconds == null) {

                this.LogBackupFrequencyInSeconds = new System.Int64();

            } else {


            }
        }
        else if (this.LogBackupFrequencyInSeconds != null && ec.Excludes("logBackupFrequencyInSeconds",true))
        {
            this.LogBackupFrequencyInSeconds = null;
        }
        //      C# -> System.Int32? LogRetentionTimeInHours
        // GraphQL -> logRetentionTimeInHours: Int (scalar)
        if (ec.Includes("logRetentionTimeInHours",true))
        {
            if(this.LogRetentionTimeInHours == null) {

                this.LogRetentionTimeInHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogRetentionTimeInHours != null && ec.Excludes("logRetentionTimeInHours",true))
        {
            this.LogRetentionTimeInHours = null;
        }
        //      C# -> System.Boolean? ShouldUseDefaultBackupLocation
        // GraphQL -> shouldUseDefaultBackupLocation: Boolean (scalar)
        if (ec.Includes("shouldUseDefaultBackupLocation",true))
        {
            if(this.ShouldUseDefaultBackupLocation == null) {

                this.ShouldUseDefaultBackupLocation = true;

            } else {


            }
        }
        else if (this.ShouldUseDefaultBackupLocation != null && ec.Excludes("shouldUseDefaultBackupLocation",true))
        {
            this.ShouldUseDefaultBackupLocation = null;
        }
    }


    #endregion

    } // class MssqlDefaultPropertiesOnClusterReply
    
    #endregion

    public static class ListMssqlDefaultPropertiesOnClusterReplyExtensions
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
            this List<MssqlDefaultPropertiesOnClusterReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<MssqlDefaultPropertiesOnClusterReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDefaultPropertiesOnClusterReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDefaultPropertiesOnClusterReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlDefaultPropertiesOnClusterReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types