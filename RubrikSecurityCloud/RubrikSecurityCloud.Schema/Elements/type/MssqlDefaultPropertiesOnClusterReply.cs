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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
            this List<MssqlDefaultPropertiesOnClusterReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MssqlDefaultPropertiesOnClusterReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDefaultPropertiesOnClusterReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDefaultPropertiesOnClusterReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlDefaultPropertiesOnClusterReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types