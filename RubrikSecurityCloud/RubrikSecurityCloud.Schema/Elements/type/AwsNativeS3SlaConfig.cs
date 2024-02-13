// AwsNativeS3SlaConfig.cs
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
    #region AwsNativeS3SlaConfig
    public class AwsNativeS3SlaConfig: BaseType
    {
        #region members

        //      C# -> System.String? ArchivalLocationId
        // GraphQL -> archivalLocationId: String! (scalar)
        [JsonProperty("archivalLocationId")]
        public System.String? ArchivalLocationId { get; set; }

        //      C# -> System.String? ArchivalLocationName
        // GraphQL -> archivalLocationName: String! (scalar)
        [JsonProperty("archivalLocationName")]
        public System.String? ArchivalLocationName { get; set; }

        //      C# -> System.Int32? ContinuousBackupRetentionInDays
        // GraphQL -> continuousBackupRetentionInDays: Int! (scalar)
        [JsonProperty("continuousBackupRetentionInDays")]
        public System.Int32? ContinuousBackupRetentionInDays { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsNativeS3SlaConfig";
    }

    public AwsNativeS3SlaConfig Set(
        System.String? ArchivalLocationId = null,
        System.String? ArchivalLocationName = null,
        System.Int32? ContinuousBackupRetentionInDays = null
    ) 
    {
        if ( ArchivalLocationId != null ) {
            this.ArchivalLocationId = ArchivalLocationId;
        }
        if ( ArchivalLocationName != null ) {
            this.ArchivalLocationName = ArchivalLocationName;
        }
        if ( ContinuousBackupRetentionInDays != null ) {
            this.ContinuousBackupRetentionInDays = ContinuousBackupRetentionInDays;
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
        //      C# -> System.String? ArchivalLocationId
        // GraphQL -> archivalLocationId: String! (scalar)
        if (this.ArchivalLocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalLocationId\n" ;
            } else {
                s += ind + "archivalLocationId\n" ;
            }
        }
        //      C# -> System.String? ArchivalLocationName
        // GraphQL -> archivalLocationName: String! (scalar)
        if (this.ArchivalLocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalLocationName\n" ;
            } else {
                s += ind + "archivalLocationName\n" ;
            }
        }
        //      C# -> System.Int32? ContinuousBackupRetentionInDays
        // GraphQL -> continuousBackupRetentionInDays: Int! (scalar)
        if (this.ContinuousBackupRetentionInDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "continuousBackupRetentionInDays\n" ;
            } else {
                s += ind + "continuousBackupRetentionInDays\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ArchivalLocationId
        // GraphQL -> archivalLocationId: String! (scalar)
        if (ec.Includes("archivalLocationId",true))
        {
            if(this.ArchivalLocationId == null) {

                this.ArchivalLocationId = "FETCH";

            } else {


            }
        }
        else if (this.ArchivalLocationId != null && ec.Excludes("archivalLocationId",true))
        {
            this.ArchivalLocationId = null;
        }
        //      C# -> System.String? ArchivalLocationName
        // GraphQL -> archivalLocationName: String! (scalar)
        if (ec.Includes("archivalLocationName",true))
        {
            if(this.ArchivalLocationName == null) {

                this.ArchivalLocationName = "FETCH";

            } else {


            }
        }
        else if (this.ArchivalLocationName != null && ec.Excludes("archivalLocationName",true))
        {
            this.ArchivalLocationName = null;
        }
        //      C# -> System.Int32? ContinuousBackupRetentionInDays
        // GraphQL -> continuousBackupRetentionInDays: Int! (scalar)
        if (ec.Includes("continuousBackupRetentionInDays",true))
        {
            if(this.ContinuousBackupRetentionInDays == null) {

                this.ContinuousBackupRetentionInDays = Int32.MinValue;

            } else {


            }
        }
        else if (this.ContinuousBackupRetentionInDays != null && ec.Excludes("continuousBackupRetentionInDays",true))
        {
            this.ContinuousBackupRetentionInDays = null;
        }
    }


    #endregion

    } // class AwsNativeS3SlaConfig
    
    #endregion

    public static class ListAwsNativeS3SlaConfigExtensions
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
            this List<AwsNativeS3SlaConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AwsNativeS3SlaConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeS3SlaConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeS3SlaConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsNativeS3SlaConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types