# TestAnalyzer
A web application for vizualizing test results based on .trx files. This application is based on the 
work done by TestParser, see https://github.com/PhilipDaniels/TestParser.

## Usage




## Examples

Test TestParser
Download the test parser project from gitbub. Run
.\TestParser.exe /of:test.json "F:\Development\TestAnalyzer\TestResultsExample\*.trx"

## Issues & Planning

- Slow tests should include namespace so that test can be found
- Add page to view test run details for a assembly. Sort tests by namespace.
- Store 10 last test runs with long term data (only summaries)
- Store detailed data of the last test run (Summaries and test results)
- Handle branches!

 