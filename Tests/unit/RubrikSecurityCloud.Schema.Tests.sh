#!/bin/bash

echo "Running NUnit tests in RubrikSecurityCloud.Schema.Tests.csproj"

cd $SPARK_REPO/src/rubrik/clients/sdks/rubrik-powershell-sdk/rubrik-powershell-sdk/RubrikSecurityCloud/RubrikSecurityCloud.Schema.Tests/
dotnet test
