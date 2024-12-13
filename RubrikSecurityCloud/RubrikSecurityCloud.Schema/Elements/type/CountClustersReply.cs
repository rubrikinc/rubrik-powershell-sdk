// CountClustersReply.cs
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
    #region CountClustersReply
    public class CountClustersReply: BaseType
    {
        #region members

        //      C# -> System.Int32? DisconnectedClusters
        // GraphQL -> disconnectedClusters: Int! (scalar)
        [JsonProperty("disconnectedClusters")]
        public System.Int32? DisconnectedClusters { get; set; }

        //      C# -> System.Int32? FatalClusters
        // GraphQL -> fatalClusters: Int! (scalar)
        [JsonProperty("fatalClusters")]
        public System.Int32? FatalClusters { get; set; }

        //      C# -> System.Int32? OkClusters
        // GraphQL -> okClusters: Int! (scalar)
        [JsonProperty("okClusters")]
        public System.Int32? OkClusters { get; set; }

        //      C# -> System.Int32? TotalClusters
        // GraphQL -> totalClusters: Int! (scalar)
        [JsonProperty("totalClusters")]
        public System.Int32? TotalClusters { get; set; }

        //      C# -> System.Int32? WarningClusters
        // GraphQL -> warningClusters: Int! (scalar)
        [JsonProperty("warningClusters")]
        public System.Int32? WarningClusters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CountClustersReply";
    }

    public CountClustersReply Set(
        System.Int32? DisconnectedClusters = null,
        System.Int32? FatalClusters = null,
        System.Int32? OkClusters = null,
        System.Int32? TotalClusters = null,
        System.Int32? WarningClusters = null
    ) 
    {
        if ( DisconnectedClusters != null ) {
            this.DisconnectedClusters = DisconnectedClusters;
        }
        if ( FatalClusters != null ) {
            this.FatalClusters = FatalClusters;
        }
        if ( OkClusters != null ) {
            this.OkClusters = OkClusters;
        }
        if ( TotalClusters != null ) {
            this.TotalClusters = TotalClusters;
        }
        if ( WarningClusters != null ) {
            this.WarningClusters = WarningClusters;
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
        //      C# -> System.Int32? DisconnectedClusters
        // GraphQL -> disconnectedClusters: Int! (scalar)
        if (this.DisconnectedClusters != null) {
            if (conf.Flat) {
                s += conf.Prefix + "disconnectedClusters\n" ;
            } else {
                s += ind + "disconnectedClusters\n" ;
            }
        }
        //      C# -> System.Int32? FatalClusters
        // GraphQL -> fatalClusters: Int! (scalar)
        if (this.FatalClusters != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fatalClusters\n" ;
            } else {
                s += ind + "fatalClusters\n" ;
            }
        }
        //      C# -> System.Int32? OkClusters
        // GraphQL -> okClusters: Int! (scalar)
        if (this.OkClusters != null) {
            if (conf.Flat) {
                s += conf.Prefix + "okClusters\n" ;
            } else {
                s += ind + "okClusters\n" ;
            }
        }
        //      C# -> System.Int32? TotalClusters
        // GraphQL -> totalClusters: Int! (scalar)
        if (this.TotalClusters != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalClusters\n" ;
            } else {
                s += ind + "totalClusters\n" ;
            }
        }
        //      C# -> System.Int32? WarningClusters
        // GraphQL -> warningClusters: Int! (scalar)
        if (this.WarningClusters != null) {
            if (conf.Flat) {
                s += conf.Prefix + "warningClusters\n" ;
            } else {
                s += ind + "warningClusters\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? DisconnectedClusters
        // GraphQL -> disconnectedClusters: Int! (scalar)
        if (ec.Includes("disconnectedClusters",true))
        {
            if(this.DisconnectedClusters == null) {

                this.DisconnectedClusters = Int32.MinValue;

            } else {


            }
        }
        else if (this.DisconnectedClusters != null && ec.Excludes("disconnectedClusters",true))
        {
            this.DisconnectedClusters = null;
        }
        //      C# -> System.Int32? FatalClusters
        // GraphQL -> fatalClusters: Int! (scalar)
        if (ec.Includes("fatalClusters",true))
        {
            if(this.FatalClusters == null) {

                this.FatalClusters = Int32.MinValue;

            } else {


            }
        }
        else if (this.FatalClusters != null && ec.Excludes("fatalClusters",true))
        {
            this.FatalClusters = null;
        }
        //      C# -> System.Int32? OkClusters
        // GraphQL -> okClusters: Int! (scalar)
        if (ec.Includes("okClusters",true))
        {
            if(this.OkClusters == null) {

                this.OkClusters = Int32.MinValue;

            } else {


            }
        }
        else if (this.OkClusters != null && ec.Excludes("okClusters",true))
        {
            this.OkClusters = null;
        }
        //      C# -> System.Int32? TotalClusters
        // GraphQL -> totalClusters: Int! (scalar)
        if (ec.Includes("totalClusters",true))
        {
            if(this.TotalClusters == null) {

                this.TotalClusters = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalClusters != null && ec.Excludes("totalClusters",true))
        {
            this.TotalClusters = null;
        }
        //      C# -> System.Int32? WarningClusters
        // GraphQL -> warningClusters: Int! (scalar)
        if (ec.Includes("warningClusters",true))
        {
            if(this.WarningClusters == null) {

                this.WarningClusters = Int32.MinValue;

            } else {


            }
        }
        else if (this.WarningClusters != null && ec.Excludes("warningClusters",true))
        {
            this.WarningClusters = null;
        }
    }


    #endregion

    } // class CountClustersReply
    
    #endregion

    public static class ListCountClustersReplyExtensions
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
            this List<CountClustersReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CountClustersReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CountClustersReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CountClustersReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CountClustersReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types