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
new Result<List<int>>(data) 
{
    Id = "ID-007",
    Status = ResultStatus.Success,
    HttpCode = 200,
    Count = data.Count
}

...
```