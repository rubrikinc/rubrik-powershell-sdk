.PHONY: default test unit-test e2e-test clean
default: test
test: unit-test e2e-test

unit-test:
	@pwsh -c '../Utils/Run-PesterTests.ps1 ./unit'

e2e-test:
	@pwsh -c '../Utils/Run-PesterTests.ps1 ./e2e'

clean:
	find . -iname testResults.xml | xargs rm -f
