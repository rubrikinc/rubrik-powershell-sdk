
.PHONY: default build build-client build-schema build-cmdlets clean

default: build

OUTPUT = ../Output
PSGALLERY_ROOT = ../../PSGallery
DOTNET_CLIENT_DIR = RubrikSecurityCloud.Client
DOTNET_SCHEMA_DIR = RubrikSecurityCloud.Schema
DOTNET_COMMON_DIR = RubrikSecurityCloud.Common
DOTNET_COMMON_TESTS_DIR = RubrikSecurityCloud.Common.Tests
DOTNET_CMDLETS_DIR = RubrikSecurityCloud.PowerShell
DOTNET_CMDLETS_RELEASE_BUILD_DIR = $(DOTNET_CMDLETS_DIR)/bin/Release/net6.0
SDK_VERSION = $(shell pwsh -Command "(Import-PowerShellDataFile $(DOTNET_CMDLETS_DIR)/RubrikSecurityCloud.psd1).ModuleVersion")
PSGALLERY_PUBLISH_DIR = $(PSGALLERY_ROOT)/RubrikSecurityCloud/$(SDK_VERSION)

build: build-common build-client build-schema build-cmdlets

build-common:
	dotnet build $(DOTNET_COMMON_DIR)/*.csproj
	mkdir -p $(OUTPUT)
	cp -av $(DOTNET_COMMON_DIR)/bin/Debug/netstandard2.1/* $(OUTPUT)

build-client:
	dotnet build $(DOTNET_CLIENT_DIR)/*.csproj
	mkdir -p $(OUTPUT)
	cp -av $(DOTNET_CLIENT_DIR)/bin/Debug/netstandard2.1/* $(OUTPUT)

build-schema:
	dotnet build $(DOTNET_SCHEMA_DIR)/*.csproj
	mkdir -p $(OUTPUT)
	cp -av $(DOTNET_SCHEMA_DIR)/bin/Debug/netstandard2.1/* $(OUTPUT)

build-cmdlets:
	dotnet build $(DOTNET_CMDLETS_DIR)/*.csproj
	mkdir -p $(OUTPUT)
	cp -av $(DOTNET_CMDLETS_DIR)/bin/Debug/net6.0/* $(OUTPUT)
	cp -v $(DOTNET_CMDLETS_DIR)/RubrikSecurityCloud.psd1 $(OUTPUT)

build-release:
	dotnet build $(DOTNET_CMDLETS_DIR)/*.csproj --configuration Release
	mkdir -p $(PSGALLERY_PUBLISH_DIR)
	cp -av $(DOTNET_CMDLETS_RELEASE_BUILD_DIR)/* $(PSGALLERY_PUBLISH_DIR)

clean:
	rm -rf $(OUTPUT)
	rm -rf $(PSGALLERY_PUBLISH_DIR)
	rm -rf $(DOTNET_SCHEMA_DIR)/bin
	rm -rf $(DOTNET_SCHEMA_DIR)/obj
	rm -rf $(DOTNET_COMMON_DIR)/bin
	rm -rf $(DOTNET_COMMON_DIR)/obj
	rm -rf $(DOTNET_COMMON_TESTS_DIR)/bin
	rm -rf $(DOTNET_COMMON_TESTS_DIR)/obj
	rm -rf $(DOTNET_CLIENT_DIR)/bin
	rm -rf $(DOTNET_CLIENT_DIR)/obj
	rm -rf $(DOTNET_CMDLETS_DIR)/bin
	rm -rf $(DOTNET_CMDLETS_DIR)/obj
