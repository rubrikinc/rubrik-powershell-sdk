// AzureAdSnapshotRange.cs
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
    #region AzureAdSnapshotRange
    public class AzureAdSnapshotRange: BaseType
    {
        #region members

        //      C# -> AzureAdSnapshotDetails? From
        // GraphQL -> from: AzureAdSnapshotDetails! (type)
        [JsonProperty("from")]
        public AzureAdSnapshotDetails? From { get; set; }

        //      C# -> AzureAdSnapshotDetails? To
        // GraphQL -> to: AzureAdSnapshotDetails! (type)
        [JsonProperty("to")]
        public AzureAdSnapshotDetails? To { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdSnapshotRange";
    }

    public AzureAdSnapshotRange Set(
        AzureAdSnapshotDetails? From = null,
        AzureAdSnapshotDetails? To = null
    ) 
    {
        if ( From != null ) {
            this.From = From;
        }
        if ( To != null ) {
            this.To = To;
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
        //      C# -> AzureAdSnapshotDetails? From
        // GraphQL -> from: AzureAdSnapshotDetails! (type)
        if (this.From != null) {
            var fspec = this.From.AsFieldSpec(conf.Child("from"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "from" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdSnapshotDetails? To
        // GraphQL -> to: AzureAdSnapshotDetails! (type)
        if (this.To != null) {
            var fspec = this.To.AsFieldSpec(conf.Child("to"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "to" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdSnapshotDetails? From
        // GraphQL -> from: AzureAdSnapshotDetails! (type)
        if (ec.Includes("from",false))
        {
            if(this.From == null) {

                this.From = new AzureAdSnapshotDetails();
                this.From.ApplyExploratoryFieldSpec(ec.NewChild("from"));

            } else {

                this.From.ApplyExploratoryFieldSpec(ec.NewChild("from"));

            }
        }
        else if (this.From != null && ec.Excludes("from",false))
        {
            this.From = null;
        }
        //      C# -> AzureAdSnapshotDetails? To
        // GraphQL -> to: AzureAdSnapshotDetails! (type)
        if (ec.Includes("to",false))
        {
            if(this.To == null) {

                this.To = new AzureAdSnapshotDetails();
                this.To.ApplyExploratoryFieldSpec(ec.NewChild("to"));

            } else {

                this.To.ApplyExploratoryFieldSpec(ec.NewChild("to"));

            }
        }
        else if (this.To != null && ec.Excludes("to",false))
        {
            this.To = null;
        }
    }


    #endregion

    } // class AzureAdSnapshotRange
    
    #endregion

    public static class ListAzureAdSnapshotRangeExtensions
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
            this List<AzureAdSnapshotRange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdSnapshotRange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdSnapshotRange> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdSnapshotRange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdSnapshotRange> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types