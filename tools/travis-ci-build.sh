#!/bin/sh
echo "Executing MSBuild DLL begin command..."
dotnet ./tools/sonar/SonarScanner.MSBuild.dll begin /o:"andresdigiovanni-github" /k:"andresdigiovanni_ADN.Extensions" /d:sonar.cs.vstest.reportsPaths="**/TestResults/*.trx" /d:sonar.exclusions="**/bin/**/*,**/obj/**/*" /d:sonar.cs.opencover.reportsPaths="lcov.opencover.xml" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.verbose=true /d:sonar.login=${SONAR_TOKEN}
echo "Running build..."
dotnet build ./src/ADN.Extensions/
dotnet build ./tests/ADN.Extensions.Tests/
echo "Running tests..."
dotnet test ./tests/ADN.Extensions.Tests/ /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
echo "Executing MSBuild DLL end command..."
dotnet ./tools/sonar/SonarScanner.MSBuild.dll end /d:sonar.login=${SONAR_TOKEN}
