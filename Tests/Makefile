.PHONY: default test unit-test mock-test e2e-test 
default: test

PWSH_UNIT_TESTS = $(wildcard unit/*.ps1)
SH_UNIT_TESTS = $(wildcard unit/*.sh)
E2E_TESTS = $(wildcard e2e/*.ps1)
MOCK_TESTS = $(wildcard mock/*.ps1)

pwsh-unit-test:
	@echo "Running PowerShell unit tests..."
	for file in $(PWSH_UNIT_TESTS); do \
		pwsh $$file; \
	done

sh-unit-test:
	@echo "Running DOTNET unit tests..."
	for file in $(SH_UNIT_TESTS); do \
		bash $$file; \
	done

unit-test: pwsh-unit-test sh-unit-test

mock-test:
	@echo "Running mock tests..."
	for file in $(MOCK_TESTS); do \
		echo "----> Running $$file"; \
		pwsh $$file; \
	done

# e2e-test: run e2e tests.
e2e-test:
	@echo "Running e2e tests..."
	for file in $(E2E_TESTS); do \
        pwsh $$file; \
    done

# test: run unit tests and mock tests.
test: unit-test mock-test
