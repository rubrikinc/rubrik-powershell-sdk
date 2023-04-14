
.PHONY: default build build-client build-schema build-cmdlets clean

default: build

OUTPUT = ../Output
DOTNET_CLIENT_DIR = RubrikSecurityCloud.Client
DOTNET_SCHEMA_DIR = RubrikSecurityCloud.Schema
DOTNET_SCHEMA_TESTS_DIR = RubrikSecurityCloud.Schema.Tests
DOTNET_CMDLETS_DIR = RubrikSecurityCloud.PowerShell

build: build-client build-schema build-cmdlets

build-client:
	dotnet build $(DOTNET_CLIENT_DIR)/*.csproj
	mkdir -p $(OUTPUT)
	cp -a $(DOTNET_CLIENT_DIR)/bin/Debug/netstandard2.1/* $(OUTPUT)

build-schema:
	dotnet build $(DOTNET_SCHEMA_DIR)/*.csproj
	mkdir -p $(OUTPUT)
	cp -a $(DOTNET_SCHEMA_DIR)/bin/Debug/netstandard2.1/* $(OUTPUT)

build-cmdlets:
	dotnet build $(DOTNET_CMDLETS_DIR)/*.csproj
	mkdir -p $(OUTPUT)
	cp -a $(DOTNET_CMDLETS_DIR)/bin/Debug/net6.0/* $(OUTPUT)
	cp $(DOTNET_CMDLETS_DIR)/RubrikSecurityCloud.psd1 $(OUTPUT)

clean:
	rm -rf $(OUTPUT)
	rm -rf $(DOTNET_SCHEMA_DIR)/bin
	rm -rf $(DOTNET_SCHEMA_DIR)/obj
	rm -rf $(DOTNET_SCHEMA_TESTS_DIR)/bin
	rm -rf $(DOTNET_SCHEMA_TESTS_DIR)/obj
	rm -rf $(DOTNET_CLIENT_DIR)/bin
	rm -rf $(DOTNET_CLIENT_DIR)/obj
	rm -rf $(DOTNET_CMDLETS_DIR)/bin
	rm -rf $(DOTNET_CMDLETS_DIR)/obj
