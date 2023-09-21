.PHONY: default
default: all
all: build test

build:
	pwsh -c '. ./Utils/ToolkitDev -Quiet ; Update-RscToolkit'

test:
	$(MAKE) -C Tests

clean:
	$(MAKE) -C Tests clean
	find . -iname testResults.xml | xargs rm -f
	find ../Output/Toolkit -iname "*.bak" | xargs rm -f