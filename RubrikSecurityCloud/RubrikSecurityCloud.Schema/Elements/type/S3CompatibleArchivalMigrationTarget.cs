// S3CompatibleArchivalMigrationTarget.cs
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
    #region S3CompatibleArchivalMigrationTarget
    public class S3CompatibleArchivalMigrationTarget: BaseType
    {
        #region members

        //      C# -> S3CompatibleSubType? Subtype
        // GraphQL -> subtype: S3CompatibleSubType! (enum)
        [JsonProperty("subtype")]
        public S3CompatibleSubType? Subtype { get; set; }

        //      C# -> System.String? BucketPrefix
        // GraphQL -> bucketPrefix: String! (scalar)
        [JsonProperty("bucketPrefix")]
        public System.String? BucketPrefix { get; set; }

        //      C# -> System.String? Endpoint
        // GraphQL -> endpoint: URL! (scalar)
        [JsonProperty("endpoint")]
        public System.String? Endpoint { get; set; }

        //      C# -> System.Int32? NumberOfBuckets
        // GraphQL -> numberOfBuckets: Int! (scalar)
        [JsonProperty("numberOfBuckets")]
        public System.Int32? NumberOfBuckets { get; set; }

        //      C# -> System.Boolean? UseSystemProxy
        // GraphQL -> useSystemProxy: Boolean! (scalar)
        [JsonProperty("useSystemProxy")]
        public System.Boolean? UseSystemProxy { get; set; }

        //      C# -> IbmCosDetailsOutput? IbmDetails
        // GraphQL -> ibmDetails: IbmCosDetailsOutput (type)
        [JsonProperty("ibmDetails")]
        public IbmCosDetailsOutput? IbmDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "S3CompatibleArchivalMigrationTarget";
    }

    public S3CompatibleArchivalMigrationTarget Set(
        S3CompatibleSubType? Subtype = null,
        System.String? BucketPrefix = null,
        System.String? Endpoint = null,
        System.Int32? NumberOfBuckets = null,
        System.Boolean? UseSystemProxy = null,
        IbmCosDetailsOutput? IbmDetails = null
    ) 
    {
        if ( Subtype != null ) {
            this.Subtype = Subtype;
        }
        if ( BucketPrefix != null ) {
            this.BucketPrefix = BucketPrefix;
        }
        if ( Endpoint != null ) {
            this.Endpoint = Endpoint;
        }
        if ( NumberOfBuckets != null ) {
            this.NumberOfBuckets = NumberOfBuckets;
        }
        if ( UseSystemProxy != null ) {
            this.UseSystemProxy = UseSystemProxy;
        }
        if ( IbmDetails != null ) {
            this.IbmDetails = IbmDetails;
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
        //      C# -> S3CompatibleSubType? Subtype
        // GraphQL -> subtype: S3CompatibleSubType! (enum)
        if (this.Subtype != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subtype\n" ;
            } else {
                s += ind + "subtype\n" ;
            }
        }
        //      C# -> System.String? BucketPrefix
        // GraphQL -> bucketPrefix: String! (scalar)
        if (this.BucketPrefix != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bucketPrefix\n" ;
            } else {
                s += ind + "bucketPrefix\n" ;
            }
        }
        //      C# -> System.String? Endpoint
        // GraphQL -> endpoint: URL! (scalar)
        if (this.Endpoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endpoint\n" ;
            } else {
                s += ind + "endpoint\n" ;
            }
        }
        //      C# -> System.Int32? NumberOfBuckets
        // GraphQL -> numberOfBuckets: Int! (scalar)
        if (this.NumberOfBuckets != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numberOfBuckets\n" ;
            } else {
                s += ind + "numberOfBuckets\n" ;
            }
        }
        //      C# -> System.Boolean? UseSystemProxy
        // GraphQL -> useSystemProxy: Boolean! (scalar)
        if (this.UseSystemProxy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "useSystemProxy\n" ;
            } else {
                s += ind + "useSystemProxy\n" ;
            }
        }
        //      C# -> IbmCosDetailsOutput? IbmDetails
        // GraphQL -> ibmDetails: IbmCosDetailsOutput (type)
        if (this.IbmDetails != null) {
            var fspec = this.IbmDetails.AsFieldSpec(conf.Child("ibmDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ibmDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> S3CompatibleSubType? Subtype
        // GraphQL -> subtype: S3CompatibleSubType! (enum)
        if (ec.Includes("subtype",true))
        {
            if(this.Subtype == null) {

                this.Subtype = new S3CompatibleSubType();

            } else {


            }
        }
        else if (this.Subtype != null && ec.Excludes("subtype",true))
        {
            this.Subtype = null;
        }
        //      C# -> System.String? BucketPrefix
        // GraphQL -> bucketPrefix: String! (scalar)
        if (ec.Includes("bucketPrefix",true))
        {
            if(this.BucketPrefix == null) {

                this.BucketPrefix = "FETCH";

            } else {


            }
        }
        else if (this.BucketPrefix != null && ec.Excludes("bucketPrefix",true))
        {
            this.BucketPrefix = null;
        }
        //      C# -> System.String? Endpoint
        // GraphQL -> endpoint: URL! (scalar)
        if (ec.Includes("endpoint",true))
        {
            if(this.Endpoint == null) {

                this.Endpoint = "FETCH";

            } else {


            }
        }
        else if (this.Endpoint != null && ec.Excludes("endpoint",true))
        {
            this.Endpoint = null;
        }
        //      C# -> System.Int32? NumberOfBuckets
        // GraphQL -> numberOfBuckets: Int! (scalar)
        if (ec.Includes("numberOfBuckets",true))
        {
            if(this.NumberOfBuckets == null) {

                this.NumberOfBuckets = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumberOfBuckets != null && ec.Excludes("numberOfBuckets",true))
        {
            this.NumberOfBuckets = null;
        }
        //      C# -> System.Boolean? UseSystemProxy
        // GraphQL -> useSystemProxy: Boolean! (scalar)
        if (ec.Includes("useSystemProxy",true))
        {
            if(this.UseSystemProxy == null) {

                this.UseSystemProxy = true;

            } else {


            }
        }
        else if (this.UseSystemProxy != null && ec.Excludes("useSystemProxy",true))
        {
            this.UseSystemProxy = null;
        }
        //      C# -> IbmCosDetailsOutput? IbmDetails
        // GraphQL -> ibmDetails: IbmCosDetailsOutput (type)
        if (ec.Includes("ibmDetails",false))
        {
            if(this.IbmDetails == null) {

                this.IbmDetails = new IbmCosDetailsOutput();
                this.IbmDetails.ApplyExploratoryFieldSpec(ec.NewChild("ibmDetails"));

            } else {

                this.IbmDetails.ApplyExploratoryFieldSpec(ec.NewChild("ibmDetails"));

            }
        }
        else if (this.IbmDetails != null && ec.Excludes("ibmDetails",false))
        {
            this.IbmDetails = null;
        }
    }


    #endregion

    } // class S3CompatibleArchivalMigrationTarget
    
    #endregion

    public static class ListS3CompatibleArchivalMigrationTargetExtensions
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
            this List<S3CompatibleArchivalMigrationTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<S3CompatibleArchivalMigrationTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<S3CompatibleArchivalMigrationTarget> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new S3CompatibleArchivalMigrationTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<S3CompatibleArchivalMigrationTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types