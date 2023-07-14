RMDIR /S /Q TestResults

RMDIR /S /Q CoverageReport

dotnet test --collect:"XPlat Code Coverage" -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Format=cobertura

reportgenerator -reports:TestResults\*\coverage.cobertura.xml -targetdir:CoverageReport

::start chrome %CD%\CoverageReport\index.html

pause