.PHONY: default test unit-test mock-test e2e-test 
default: test

SH_UNIT_TESTS = $(wildcard unit/*.sh)

pwsh-unit-test:
	@echo "Running PowerShell unit tests..."
	pwsh -c 'Invoke-Pester -CI ./unit'

sh-unit-test:
	@echo "Running DOTNET unit tests..."
	@for file in $(SH_UNIT_TESTS); do \
		echo "----> Running $$file"; \
		bash $$file; \
	done

unit-test: pwsh-unit-test sh-unit-test

mock-test:
	@echo "Mock tests: BYPASSED"

# e2e-test: run e2e tests.
e2e-test:
	@echo "Running e2e tests..."
	pwsh -c 'Invoke-Pester -CI ./e2e'


# test: run unit tests and mock tests.
test: unit-test mock-test
	# If the env var RSC_SERVICE_ACCOUNT_FILE is not empty, run e2e tests.
	@if [ -n "$(RSC_SERVICE_ACCOUNT_FILE)" ]; then \
		make e2e-test; \
	fi