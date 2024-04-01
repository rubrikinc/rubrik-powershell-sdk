// PhoenixRolloutProgress.cs
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
    #region PhoenixRolloutProgress
    public class PhoenixRolloutProgress: BaseType
    {
        #region members

        //      C# -> System.Int32? NumEnabled
        // GraphQL -> numEnabled: Int! (scalar)
        [JsonProperty("numEnabled")]
        public System.Int32? NumEnabled { get; set; }

        //      C# -> System.Int32? NumInProcess
        // GraphQL -> numInProcess: Int! (scalar)
        [JsonProperty("numInProcess")]
        public System.Int32? NumInProcess { get; set; }

        //      C# -> System.Int32? NumIncompleteFirstFull
        // GraphQL -> numIncompleteFirstFull: Int! (scalar)
        [JsonProperty("numIncompleteFirstFull")]
        public System.Int32? NumIncompleteFirstFull { get; set; }

        //      C# -> System.Int32? NumNotEnabled
        // GraphQL -> numNotEnabled: Int! (scalar)
        [JsonProperty("numNotEnabled")]
        public System.Int32? NumNotEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PhoenixRolloutProgress";
    }

    public PhoenixRolloutProgress Set(
        System.Int32? NumEnabled = null,
        System.Int32? NumInProcess = null,
        System.Int32? NumIncompleteFirstFull = null,
        System.Int32? NumNotEnabled = null
    ) 
    {
        if ( NumEnabled != null ) {
            this.NumEnabled = NumEnabled;
        }
        if ( NumInProcess != null ) {
            this.NumInProcess = NumInProcess;
        }
        if ( NumIncompleteFirstFull != null ) {
            this.NumIncompleteFirstFull = NumIncompleteFirstFull;
        }
        if ( NumNotEnabled != null ) {
            this.NumNotEnabled = NumNotEnabled;
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
        //      C# -> System.Int32? NumEnabled
        // GraphQL -> numEnabled: Int! (scalar)
        if (this.NumEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numEnabled\n" ;
            } else {
                s += ind + "numEnabled\n" ;
            }
        }
        //      C# -> System.Int32? NumInProcess
        // GraphQL -> numInProcess: Int! (scalar)
        if (this.NumInProcess != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numInProcess\n" ;
            } else {
                s += ind + "numInProcess\n" ;
            }
        }
        //      C# -> System.Int32? NumIncompleteFirstFull
        // GraphQL -> numIncompleteFirstFull: Int! (scalar)
        if (this.NumIncompleteFirstFull != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numIncompleteFirstFull\n" ;
            } else {
                s += ind + "numIncompleteFirstFull\n" ;
            }
        }
        //      C# -> System.Int32? NumNotEnabled
        // GraphQL -> numNotEnabled: Int! (scalar)
        if (this.NumNotEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numNotEnabled\n" ;
            } else {
                s += ind + "numNotEnabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumEnabled
        // GraphQL -> numEnabled: Int! (scalar)
        if (ec.Includes("numEnabled",true))
        {
            if(this.NumEnabled == null) {

                this.NumEnabled = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumEnabled != null && ec.Excludes("numEnabled",true))
        {
            this.NumEnabled = null;
        }
        //      C# -> System.Int32? NumInProcess
        // GraphQL -> numInProcess: Int! (scalar)
        if (ec.Includes("numInProcess",true))
        {
            if(this.NumInProcess == null) {

                this.NumInProcess = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumInProcess != null && ec.Excludes("numInProcess",true))
        {
            this.NumInProcess = null;
        }
        //      C# -> System.Int32? NumIncompleteFirstFull
        // GraphQL -> numIncompleteFirstFull: Int! (scalar)
        if (ec.Includes("numIncompleteFirstFull",true))
        {
            if(this.NumIncompleteFirstFull == null) {

                this.NumIncompleteFirstFull = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumIncompleteFirstFull != null && ec.Excludes("numIncompleteFirstFull",true))
        {
            this.NumIncompleteFirstFull = null;
        }
        //      C# -> System.Int32? NumNotEnabled
        // GraphQL -> numNotEnabled: Int! (scalar)
        if (ec.Includes("numNotEnabled",true))
        {
            if(this.NumNotEnabled == null) {

                this.NumNotEnabled = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumNotEnabled != null && ec.Excludes("numNotEnabled",true))
        {
            this.NumNotEnabled = null;
        }
    }


    #endregion

    } // class PhoenixRolloutProgress
    
    #endregion

    public static class ListPhoenixRolloutProgressExtensions
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
            this List<PhoenixRolloutProgress> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PhoenixRolloutProgress> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PhoenixRolloutProgress> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PhoenixRolloutProgress());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PhoenixRolloutProgress> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types