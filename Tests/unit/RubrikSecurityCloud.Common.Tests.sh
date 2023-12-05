#!/bin/bash

echo "Running NUnit tests in RubrikSecurityCloud.Schema.Common.csproj"

cd $SPARK_REPO/src/rubrik/clients/sdks/rubrik-powershell-sdk/rubrik-powershell-sdk/RubrikSecurityCloud/RubrikSecurityCloud.Common.Tests/
dotnet test
