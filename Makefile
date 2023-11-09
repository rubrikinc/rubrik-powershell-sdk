.PHONY: default build build-debug build-nodocs clean test mock-test e2e-test
OUTPUT = ./Output
OUTPUT_RELEASE = ./Output.Release
PROJ_DIR = RubrikSecurityCloud/RubrikSecurityCloud.PowerShell
PROJ_OUTPUT = $(PROJ_DIR)/bin/Debug
PROJ_OUTPUT_RELEASE = $(PROJ_DIR)/bin/Release

default: clean build test
build: build-debug
release: build-release

build-debug:
	@echo "Building SDK. Mode: Debug, Docs: Yes"
	rm -rf $(PROJ_OUTPUT)
	dotnet build /p:GeneratePSDocs=true $(PROJ_DIR)
	rm -rf $(OUTPUT) && cp -a $(PROJ_OUTPUT) $(OUTPUT)
	cp $(OUTPUT)/net6.0/RubrikSecurityCloud.PowerShell.dll-Help.xml $(OUTPUT)/net472

build-release:
	@echo "Building SDK. Mode: Release, Docs: Yes"
	rm -rf $(PROJ_OUTPUT_RELEASE)
	dotnet build --configuration Release /p:GeneratePSDocs=true $(PROJ_DIR)
	rm -rf $(OUTPUT_RELEASE)
	cp -a $(PROJ_OUTPUT_RELEASE) $(OUTPUT_RELEASE)
	cp $(OUTPUT_RELEASE)/net6.0/RubrikSecurityCloud.PowerShell.dll-Help.xml $(OUTPUT_RELEASE)/net472

build-nodocs:
	@echo "Building SDK. Mode: Debug, Docs: No"
	rm -rf $(PROJ_OUTPUT)
	dotnet build $(PROJ_DIR)
	rm -rf $(OUTPUT) && cp -a $(PROJ_OUTPUT) $(OUTPUT)

# clean: removes all compiled files.
clean:
	$(MAKE) -C Tests clean
	rm -rf $(OUTPUT) $(OUTPUT_RELEASE)
	find . -iname "obj" -type d | xargs rm -rf
	find . -iname "bin" -type d | xargs rm -rf
	find . -iname "testResults.xml" -or -iname "tmp_help" | xargs rm -rf

test: 	
	@echo "Running SDK tests: (unit and e2e) x (Toolkit and Core)"
	# This runs both the Toolkit and SDK tests.
	$(MAKE) -C Tests test

e2e-test:
	@echo "Running SDK tests: (e2e) x (Toolkit and Core)"
	$(MAKE) -C Tests e2e-test
