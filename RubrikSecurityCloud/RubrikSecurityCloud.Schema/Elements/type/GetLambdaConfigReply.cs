// GetLambdaConfigReply.cs
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
    #region GetLambdaConfigReply
    public class GetLambdaConfigReply: BaseType
    {
        #region members

        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        [JsonProperty("accountId")]
        public System.String? AccountId { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? DefaultDiffFmdUploadPrefix
        // GraphQL -> defaultDiffFmdUploadPrefix: String! (scalar)
        [JsonProperty("defaultDiffFmdUploadPrefix")]
        public System.String? DefaultDiffFmdUploadPrefix { get; set; }

        //      C# -> System.Boolean? EnableAutomaticFmdUpload
        // GraphQL -> enableAutomaticFmdUpload: Boolean! (scalar)
        [JsonProperty("enableAutomaticFmdUpload")]
        public System.Boolean? EnableAutomaticFmdUpload { get; set; }

        //      C# -> System.Boolean? EnableFmdUploadForAllResources
        // GraphQL -> enableFmdUploadForAllResources: Boolean! (scalar)
        [JsonProperty("enableFmdUploadForAllResources")]
        public System.Boolean? EnableFmdUploadForAllResources { get; set; }

        //      C# -> System.Boolean? IsThreatMonitoringEnabled
        // GraphQL -> isThreatMonitoringEnabled: Boolean! (scalar)
        [JsonProperty("isThreatMonitoringEnabled")]
        public System.Boolean? IsThreatMonitoringEnabled { get; set; }

        //      C# -> System.Int32? MaxSnapshotsToUploadAutomatically
        // GraphQL -> maxSnapshotsToUploadAutomatically: Int! (scalar)
        [JsonProperty("maxSnapshotsToUploadAutomatically")]
        public System.Int32? MaxSnapshotsToUploadAutomatically { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetLambdaConfigReply";
    }

    public GetLambdaConfigReply Set(
        System.String? AccountId = null,
        System.String? ClusterId = null,
        System.String? DefaultDiffFmdUploadPrefix = null,
        System.Boolean? EnableAutomaticFmdUpload = null,
        System.Boolean? EnableFmdUploadForAllResources = null,
        System.Boolean? IsThreatMonitoringEnabled = null,
        System.Int32? MaxSnapshotsToUploadAutomatically = null
    ) 
    {
        if ( AccountId != null ) {
            this.AccountId = AccountId;
        }
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( DefaultDiffFmdUploadPrefix != null ) {
            this.DefaultDiffFmdUploadPrefix = DefaultDiffFmdUploadPrefix;
        }
        if ( EnableAutomaticFmdUpload != null ) {
            this.EnableAutomaticFmdUpload = EnableAutomaticFmdUpload;
        }
        if ( EnableFmdUploadForAllResources != null ) {
            this.EnableFmdUploadForAllResources = EnableFmdUploadForAllResources;
        }
        if ( IsThreatMonitoringEnabled != null ) {
            this.IsThreatMonitoringEnabled = IsThreatMonitoringEnabled;
        }
        if ( MaxSnapshotsToUploadAutomatically != null ) {
            this.MaxSnapshotsToUploadAutomatically = MaxSnapshotsToUploadAutomatically;
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
        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        if (this.AccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountId\n" ;
            } else {
                s += ind + "accountId\n" ;
            }
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (this.ClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterId\n" ;
            } else {
                s += ind + "clusterId\n" ;
            }
        }
        //      C# -> System.String? DefaultDiffFmdUploadPrefix
        // GraphQL -> defaultDiffFmdUploadPrefix: String! (scalar)
        if (this.DefaultDiffFmdUploadPrefix != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultDiffFmdUploadPrefix\n" ;
            } else {
                s += ind + "defaultDiffFmdUploadPrefix\n" ;
            }
        }
        //      C# -> System.Boolean? EnableAutomaticFmdUpload
        // GraphQL -> enableAutomaticFmdUpload: Boolean! (scalar)
        if (this.EnableAutomaticFmdUpload != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableAutomaticFmdUpload\n" ;
            } else {
                s += ind + "enableAutomaticFmdUpload\n" ;
            }
        }
        //      C# -> System.Boolean? EnableFmdUploadForAllResources
        // GraphQL -> enableFmdUploadForAllResources: Boolean! (scalar)
        if (this.EnableFmdUploadForAllResources != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableFmdUploadForAllResources\n" ;
            } else {
                s += ind + "enableFmdUploadForAllResources\n" ;
            }
        }
        //      C# -> System.Boolean? IsThreatMonitoringEnabled
        // GraphQL -> isThreatMonitoringEnabled: Boolean! (scalar)
        if (this.IsThreatMonitoringEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isThreatMonitoringEnabled\n" ;
            } else {
                s += ind + "isThreatMonitoringEnabled\n" ;
            }
        }
        //      C# -> System.Int32? MaxSnapshotsToUploadAutomatically
        // GraphQL -> maxSnapshotsToUploadAutomatically: Int! (scalar)
        if (this.MaxSnapshotsToUploadAutomatically != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxSnapshotsToUploadAutomatically\n" ;
            } else {
                s += ind + "maxSnapshotsToUploadAutomatically\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        if (ec.Includes("accountId",true))
        {
            if(this.AccountId == null) {

                this.AccountId = "FETCH";

            } else {


            }
        }
        else if (this.AccountId != null && ec.Excludes("accountId",true))
        {
            this.AccountId = null;
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (ec.Includes("clusterId",true))
        {
            if(this.ClusterId == null) {

                this.ClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ClusterId != null && ec.Excludes("clusterId",true))
        {
            this.ClusterId = null;
        }
        //      C# -> System.String? DefaultDiffFmdUploadPrefix
        // GraphQL -> defaultDiffFmdUploadPrefix: String! (scalar)
        if (ec.Includes("defaultDiffFmdUploadPrefix",true))
        {
            if(this.DefaultDiffFmdUploadPrefix == null) {

                this.DefaultDiffFmdUploadPrefix = "FETCH";

            } else {


            }
        }
        else if (this.DefaultDiffFmdUploadPrefix != null && ec.Excludes("defaultDiffFmdUploadPrefix",true))
        {
            this.DefaultDiffFmdUploadPrefix = null;
        }
        //      C# -> System.Boolean? EnableAutomaticFmdUpload
        // GraphQL -> enableAutomaticFmdUpload: Boolean! (scalar)
        if (ec.Includes("enableAutomaticFmdUpload",true))
        {
            if(this.EnableAutomaticFmdUpload == null) {

                this.EnableAutomaticFmdUpload = true;

            } else {


            }
        }
        else if (this.EnableAutomaticFmdUpload != null && ec.Excludes("enableAutomaticFmdUpload",true))
        {
            this.EnableAutomaticFmdUpload = null;
        }
        //      C# -> System.Boolean? EnableFmdUploadForAllResources
        // GraphQL -> enableFmdUploadForAllResources: Boolean! (scalar)
        if (ec.Includes("enableFmdUploadForAllResources",true))
        {
            if(this.EnableFmdUploadForAllResources == null) {

                this.EnableFmdUploadForAllResources = true;

            } else {


            }
        }
        else if (this.EnableFmdUploadForAllResources != null && ec.Excludes("enableFmdUploadForAllResources",true))
        {
            this.EnableFmdUploadForAllResources = null;
        }
        //      C# -> System.Boolean? IsThreatMonitoringEnabled
        // GraphQL -> isThreatMonitoringEnabled: Boolean! (scalar)
        if (ec.Includes("isThreatMonitoringEnabled",true))
        {
            if(this.IsThreatMonitoringEnabled == null) {

                this.IsThreatMonitoringEnabled = true;

            } else {


            }
        }
        else if (this.IsThreatMonitoringEnabled != null && ec.Excludes("isThreatMonitoringEnabled",true))
        {
            this.IsThreatMonitoringEnabled = null;
        }
        //      C# -> System.Int32? MaxSnapshotsToUploadAutomatically
        // GraphQL -> maxSnapshotsToUploadAutomatically: Int! (scalar)
        if (ec.Includes("maxSnapshotsToUploadAutomatically",true))
        {
            if(this.MaxSnapshotsToUploadAutomatically == null) {

                this.MaxSnapshotsToUploadAutomatically = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxSnapshotsToUploadAutomatically != null && ec.Excludes("maxSnapshotsToUploadAutomatically",true))
        {
            this.MaxSnapshotsToUploadAutomatically = null;
        }
    }


    #endregion

    } // class GetLambdaConfigReply
    
    #endregion

    public static class ListGetLambdaConfigReplyExtensions
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
            this List<GetLambdaConfigReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GetLambdaConfigReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetLambdaConfigReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetLambdaConfigReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetLambdaConfigReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types