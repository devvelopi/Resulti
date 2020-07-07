# Resulti
A simple library containing useful common result definitions and helpers

## Installation

```bash
dotnet add package Resulti.Core
```

## Usage

Very straightforward usage.

**Basic Result**
```c#
using Resulti.Core.Results;
using Resulti.Core.Util;
...

// Empty result 
new Result();

// Result with data
new Result<string>("Hello world");

// Result with object initialisation
new Result<int>(5) 
{
    Id = "ID-007",
    Status = ResultStatus.Success
}

...
```

**Http Result**
```c#
using Resulti.Core.Results;
using Resulti.Core.Util;
...

// Http result with object initialisation
var data = new List<int> {1, 2, 3};
new HttpResult<List<int>>(data) 
{
    Id = "ID-007",
    Status = ResultStatus.Success,
    HttpCode = 200,
    Count = data.Count
}

...
```

### Extensions Usage

There are a number of utility extensions similar to the 'builder' functions used to make building results more 
streamlined in the case where long running builds aren't required. All of the following can also be achieved with object initialisation.

```c#
// Sets the result to successful
new Result().Success();

// Sets the result to successful with data
new Result<long>().Success(10);

// Sets the result to failed 
new Result().Failure();

// Sets the result to failed and clears data
new Result<long>().Failure()

// Adds a basic notification to the result
new Result().AddNotification("Result happened!");

// Adds a full notification to the result
new Result().AddNotification("Display message", NotificationType.Warning, "Developer message", "CODE123");

// Chains a result in a builder
new Result().Success()
    .AddNotification("Was successful!")
    .AddNotification("But just a warning", NotificationType.Warning);
```