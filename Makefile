.PHONY: default build build-debug build-nodocs build-verbose clean test

default: clean build test
build: build-debug
release: build-release

build-debug:
	pwsh -c "./Utils/Build-RscSdk.ps1 -NoClean -NoTests"

build-release:
	pwsh -c "./Utils/Build-RscSdk.ps1 -Release"

build-verbose:
	pwsh -c "./Utils/Build-RscSdk.ps1 -NoClean -NoTests -VerboseDocs"

build-nodocs:
	pwsh -c "./Utils/Build-RscSdk.ps1 -NoDocs"

clean:
	pwsh -c "./Utils/Clean-RscSdk.ps1"

test:
	pwsh -c "./Utils/Test-RscSdk.ps1"

test-toolkit:
	pwsh -c "./Utils/Test-RscSdk.ps1 -SkipCoreTests"
