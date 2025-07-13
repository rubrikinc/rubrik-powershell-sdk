// CloudDirectSetWanThrottleSettingsReply.cs
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
    #region CloudDirectSetWanThrottleSettingsReply
    public class CloudDirectSetWanThrottleSettingsReply: BaseType
    {
        #region members

        //      C# -> System.Int64? DownLimitInBytes
        // GraphQL -> downLimitInBytes: Long! (scalar)
        [JsonProperty("downLimitInBytes")]
        public System.Int64? DownLimitInBytes { get; set; }

        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        [JsonProperty("enabled")]
        public System.Boolean? Enabled { get; set; }

        //      C# -> System.Int64? UpLimitInBytes
        // GraphQL -> upLimitInBytes: Long! (scalar)
        [JsonProperty("upLimitInBytes")]
        public System.Int64? UpLimitInBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectSetWanThrottleSettingsReply";
    }

    public CloudDirectSetWanThrottleSettingsReply Set(
        System.Int64? DownLimitInBytes = null,
        System.Boolean? Enabled = null,
        System.Int64? UpLimitInBytes = null
    ) 
    {
        if ( DownLimitInBytes != null ) {
            this.DownLimitInBytes = DownLimitInBytes;
        }
        if ( Enabled != null ) {
            this.Enabled = Enabled;
        }
        if ( UpLimitInBytes != null ) {
            this.UpLimitInBytes = UpLimitInBytes;
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
        //      C# -> System.Int64? DownLimitInBytes
        // GraphQL -> downLimitInBytes: Long! (scalar)
        if (this.DownLimitInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downLimitInBytes\n" ;
            } else {
                s += ind + "downLimitInBytes\n" ;
            }
        }
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enabled\n" ;
            } else {
                s += ind + "enabled\n" ;
            }
        }
        //      C# -> System.Int64? UpLimitInBytes
        // GraphQL -> upLimitInBytes: Long! (scalar)
        if (this.UpLimitInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upLimitInBytes\n" ;
            } else {
                s += ind + "upLimitInBytes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? DownLimitInBytes
        // GraphQL -> downLimitInBytes: Long! (scalar)
        if (ec.Includes("downLimitInBytes",true))
        {
            if(this.DownLimitInBytes == null) {

                this.DownLimitInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.DownLimitInBytes != null && ec.Excludes("downLimitInBytes",true))
        {
            this.DownLimitInBytes = null;
        }
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (ec.Includes("enabled",true))
        {
            if(this.Enabled == null) {

                this.Enabled = true;

            } else {


            }
        }
        else if (this.Enabled != null && ec.Excludes("enabled",true))
        {
            this.Enabled = null;
        }
        //      C# -> System.Int64? UpLimitInBytes
        // GraphQL -> upLimitInBytes: Long! (scalar)
        if (ec.Includes("upLimitInBytes",true))
        {
            if(this.UpLimitInBytes == null) {

                this.UpLimitInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.UpLimitInBytes != null && ec.Excludes("upLimitInBytes",true))
        {
            this.UpLimitInBytes = null;
        }
    }


    #endregion

    } // class CloudDirectSetWanThrottleSettingsReply
    
    #endregion

    public static class ListCloudDirectSetWanThrottleSettingsReplyExtensions
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
            this List<CloudDirectSetWanThrottleSettingsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectSetWanThrottleSettingsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectSetWanThrottleSettingsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectSetWanThrottleSettingsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectSetWanThrottleSettingsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types