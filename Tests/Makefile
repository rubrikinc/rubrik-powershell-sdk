.PHONY: default test pwsh-unit-test sh-unit-test unit-test e2e-test clean
default: test
test: unit-test e2e-test

SH_UNIT_TESTS = $(wildcard unit/*.sh)

pwsh-unit-test:
	@pwsh -c '../Toolkit/Utils/Run-PesterTests.ps1 ./unit'

sh-unit-test:
	@echo "[Core] Running DOTNET unit tests..."
	@for file in $(SH_UNIT_TESTS); do \
		echo "----> Running $$file"; \
		bash $$file; \
	done

unit-test: pwsh-unit-test sh-unit-test
	$(MAKE) -C ../Toolkit/Tests unit-test

pwsh-e2e-test:
	@pwsh -c '../Toolkit/Utils/Run-PesterTests.ps1 ./e2e'

e2e-test: pwsh-e2e-test
	$(MAKE) -C ../Toolkit/Tests e2e-test

clean:
	$(MAKE) -C ../Toolkit/Tests clean
	rm -rf testResults.xml
	if [ -d mock_api_server ]; then $(MAKE) -C mock_api_server clean ; fi
