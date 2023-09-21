.PHONY: default test unit-test e2e-test clean
default: test
test: unit-test e2e-test

unit-test:
	@echo "[Toolkit] Running PowerShell unit tests..."
	pwsh -c 'Invoke-Pester -CI ./unit'

e2e-test:
	@echo "[Toolkit] Running e2e tests..."
	pwsh -c 'Invoke-Pester -CI ./e2e'

clean:
	find . -iname testResults.xml | xargs rm -f
