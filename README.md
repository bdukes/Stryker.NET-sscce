Stryker.NET [SSCCE](http://www.sscce.org/)
==========================================

This repo is an example demonstrating [issue #1225](https://github.com/stryker-mutator/stryker-net/issues/1225).

Steps to Reproduce
------------------

1. `dotnet tool restore`
2. `dotnet test`
3. `dotnet stryker`

### Expected Results
Stryker.NET runs against the test.

### Actual Results
```
   _____ _              _               _   _ ______ _______    
  / ____| |            | |             | \ | |  ____|__   __|   
 | (___ | |_ _ __ _   _| | _____ _ __  |  \| | |__     | |      
  \___ \| __| '__| | | | |/ / _ \ '__| | . ` |  __|    | |      
  ____) | |_| |  | |_| |   <  __/ |    | |\  | |____   | |    
 |_____/ \__|_|   \__, |_|\_\___|_| (_)|_| \_|______|  |_|    
                   __/ |                                      
                  |___/                                       


Version: 3.8.0

[10:10:43 INF] Identifying projects to mutate in C:\inetpub\wwwroot\mutator.example2\StykerExample.sln. This can take a while.
[10:10:45 INF] Found 1 source projects
[10:10:45 INF] Found 1 test projects
[10:10:46 INF] Found project C:\inetpub\wwwroot\mutator.example2\StykerExample.Common\StykerExample.Common.csproj to mutate.
[10:10:46 INF] Time Elapsed 00:00:03.7356930
Unhandled exception.

The test project binaries could not be found at C:\inetpub\wwwroot\mutator.example2\tests\StykerExample.Common.Tests\bin\Any CPU\Debug\net7.0\StykerExample.Common.Tests.dll, exiting...
```
