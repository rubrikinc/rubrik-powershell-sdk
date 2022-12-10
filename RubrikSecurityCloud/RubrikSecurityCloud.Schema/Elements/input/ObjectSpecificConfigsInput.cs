// ObjectSpecificConfigsInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:26.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ObjectSpecificConfigsInput

    public class ObjectSpecificConfigsInput
    {
        #region members
        //      C# -> SapHanaConfigInput? SapHanaConfigInput
        // GraphQL -> sapHanaConfigInput: SapHanaConfigInput (input)
        [JsonProperty("sapHanaConfigInput")]
        public SapHanaConfigInput? SapHanaConfigInput { get; set; }

        //      C# -> AwsRdsConfigInput? AwsRdsConfigInput
        // GraphQL -> awsRdsConfigInput: AwsRdsConfigInput (input)
        [JsonProperty("awsRdsConfigInput")]
        public AwsRdsConfigInput? AwsRdsConfigInput { get; set; }

        //      C# -> VmwareVmConfigInput? VmwareVmConfigInput
        // GraphQL -> vmwareVmConfigInput: VmwareVmConfigInput (input)
        [JsonProperty("vmwareVmConfigInput")]
        public VmwareVmConfigInput? VmwareVmConfigInput { get; set; }

        //      C# -> AzureSqlDatabaseDbConfigInput? AzureSqlDatabaseDbConfigInput
        // GraphQL -> azureSqlDatabaseDbConfigInput: AzureSqlDatabaseDbConfigInput (input)
        [JsonProperty("azureSqlDatabaseDbConfigInput")]
        public AzureSqlDatabaseDbConfigInput? AzureSqlDatabaseDbConfigInput { get; set; }

        //      C# -> AzureSqlManagedInstanceDbConfigInput? AzureSqlManagedInstanceDbConfigInput
        // GraphQL -> azureSqlManagedInstanceDbConfigInput: AzureSqlManagedInstanceDbConfigInput (input)
        [JsonProperty("azureSqlManagedInstanceDbConfigInput")]
        public AzureSqlManagedInstanceDbConfigInput? AzureSqlManagedInstanceDbConfigInput { get; set; }

        //      C# -> Db2ConfigInput? Db2ConfigInput
        // GraphQL -> db2ConfigInput: Db2ConfigInput (input)
        [JsonProperty("db2ConfigInput")]
        public Db2ConfigInput? Db2ConfigInput { get; set; }

        //      C# -> MssqlConfigInput? MssqlConfigInput
        // GraphQL -> mssqlConfigInput: MssqlConfigInput (input)
        [JsonProperty("mssqlConfigInput")]
        public MssqlConfigInput? MssqlConfigInput { get; set; }

        //      C# -> OracleConfigInput? OracleConfigInput
        // GraphQL -> oracleConfigInput: OracleConfigInput (input)
        [JsonProperty("oracleConfigInput")]
        public OracleConfigInput? OracleConfigInput { get; set; }

        //      C# -> MongoConfigInput? MongoConfigInput
        // GraphQL -> mongoConfigInput: MongoConfigInput (input)
        [JsonProperty("mongoConfigInput")]
        public MongoConfigInput? MongoConfigInput { get; set; }

        //      C# -> AzureBlobConfigInput? AzureBlobConfigInput
        // GraphQL -> azureBlobConfigInput: AzureBlobConfigInput (input)
        [JsonProperty("azureBlobConfigInput")]
        public AzureBlobConfigInput? AzureBlobConfigInput { get; set; }

        //      C# -> AwsNativeS3SlaConfigInput? AwsNativeS3SlaConfigInput
        // GraphQL -> awsNativeS3SlaConfigInput: AwsNativeS3SlaConfigInput (input)
        [JsonProperty("awsNativeS3SlaConfigInput")]
        public AwsNativeS3SlaConfigInput? AwsNativeS3SlaConfigInput { get; set; }

        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class ObjectSpecificConfigsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types