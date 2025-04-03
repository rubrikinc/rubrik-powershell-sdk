// IgnoreClusterRemovalPrecheckReply.cs
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
    #region IgnoreClusterRemovalPrecheckReply
    public class IgnoreClusterRemovalPrecheckReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? CanIgnorePrecheck
        // GraphQL -> canIgnorePrecheck: Boolean! (scalar)
        [JsonProperty("canIgnorePrecheck")]
        public System.Boolean? CanIgnorePrecheck { get; set; }

        //      C# -> DateTime? IgnorePrecheckTime
        // GraphQL -> ignorePrecheckTime: DateTime (scalar)
        [JsonProperty("ignorePrecheckTime")]
        public DateTime? IgnorePrecheckTime { get; set; }

        //      C# -> System.Boolean? IsDisconnected
        // GraphQL -> isDisconnected: Boolean! (scalar)
        [JsonProperty("isDisconnected")]
        public System.Boolean? IsDisconnected { get; set; }

        //      C# -> DateTime? LastConnectionTime
        // GraphQL -> lastConnectionTime: DateTime (scalar)
        [JsonProperty("lastConnectionTime")]
        public DateTime? LastConnectionTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IgnoreClusterRemovalPrecheckReply";
    }

    public IgnoreClusterRemovalPrecheckReply Set(
        System.Boolean? CanIgnorePrecheck = null,
        DateTime? IgnorePrecheckTime = null,
        System.Boolean? IsDisconnected = null,
        DateTime? LastConnectionTime = null
    ) 
    {
        if ( CanIgnorePrecheck != null ) {
            this.CanIgnorePrecheck = CanIgnorePrecheck;
        }
        if ( IgnorePrecheckTime != null ) {
            this.IgnorePrecheckTime = IgnorePrecheckTime;
        }
        if ( IsDisconnected != null ) {
            this.IsDisconnected = IsDisconnected;
        }
        if ( LastConnectionTime != null ) {
            this.LastConnectionTime = LastConnectionTime;
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
        //      C# -> System.Boolean? CanIgnorePrecheck
        // GraphQL -> canIgnorePrecheck: Boolean! (scalar)
        if (this.CanIgnorePrecheck != null) {
            if (conf.Flat) {
                s += conf.Prefix + "canIgnorePrecheck\n" ;
            } else {
                s += ind + "canIgnorePrecheck\n" ;
            }
        }
        //      C# -> DateTime? IgnorePrecheckTime
        // GraphQL -> ignorePrecheckTime: DateTime (scalar)
        if (this.IgnorePrecheckTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ignorePrecheckTime\n" ;
            } else {
                s += ind + "ignorePrecheckTime\n" ;
            }
        }
        //      C# -> System.Boolean? IsDisconnected
        // GraphQL -> isDisconnected: Boolean! (scalar)
        if (this.IsDisconnected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDisconnected\n" ;
            } else {
                s += ind + "isDisconnected\n" ;
            }
        }
        //      C# -> DateTime? LastConnectionTime
        // GraphQL -> lastConnectionTime: DateTime (scalar)
        if (this.LastConnectionTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastConnectionTime\n" ;
            } else {
                s += ind + "lastConnectionTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? CanIgnorePrecheck
        // GraphQL -> canIgnorePrecheck: Boolean! (scalar)
        if (ec.Includes("canIgnorePrecheck",true))
        {
            if(this.CanIgnorePrecheck == null) {

                this.CanIgnorePrecheck = true;

            } else {


            }
        }
        else if (this.CanIgnorePrecheck != null && ec.Excludes("canIgnorePrecheck",true))
        {
            this.CanIgnorePrecheck = null;
        }
        //      C# -> DateTime? IgnorePrecheckTime
        // GraphQL -> ignorePrecheckTime: DateTime (scalar)
        if (ec.Includes("ignorePrecheckTime",true))
        {
            if(this.IgnorePrecheckTime == null) {

                this.IgnorePrecheckTime = new DateTime();

            } else {


            }
        }
        else if (this.IgnorePrecheckTime != null && ec.Excludes("ignorePrecheckTime",true))
        {
            this.IgnorePrecheckTime = null;
        }
        //      C# -> System.Boolean? IsDisconnected
        // GraphQL -> isDisconnected: Boolean! (scalar)
        if (ec.Includes("isDisconnected",true))
        {
            if(this.IsDisconnected == null) {

                this.IsDisconnected = true;

            } else {


            }
        }
        else if (this.IsDisconnected != null && ec.Excludes("isDisconnected",true))
        {
            this.IsDisconnected = null;
        }
        //      C# -> DateTime? LastConnectionTime
        // GraphQL -> lastConnectionTime: DateTime (scalar)
        if (ec.Includes("lastConnectionTime",true))
        {
            if(this.LastConnectionTime == null) {

                this.LastConnectionTime = new DateTime();

            } else {


            }
        }
        else if (this.LastConnectionTime != null && ec.Excludes("lastConnectionTime",true))
        {
            this.LastConnectionTime = null;
        }
    }


    #endregion

    } // class IgnoreClusterRemovalPrecheckReply
    
    #endregion

    public static class ListIgnoreClusterRemovalPrecheckReplyExtensions
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
            this List<IgnoreClusterRemovalPrecheckReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IgnoreClusterRemovalPrecheckReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IgnoreClusterRemovalPrecheckReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IgnoreClusterRemovalPrecheckReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IgnoreClusterRemovalPrecheckReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types