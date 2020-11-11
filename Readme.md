# Summary
 This repository demonstrates how to use [BadMedicine](https://github.com/HicServices/BadMedicine) nuget package to generate custom EHR file formats (in this example we use XML).  In the example a single Biochemistry record is generated and written out to a file called `out.xml`.
 
# How it was done
 
 To follow this demo you will need [c# dotnet core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
 
 This repository was created using the following commands:
 
 ```
 dotnet new console
 dotnet add package HIC.BadMedicine
 ```
 
 Set [Program.cs to the following c# code](./Program.cs)
 
 
Build with:
 
```
dotnet build
```

Run with:
```
dotnet run
```

When run a new file out.xml should be generated e.g.
 
 ```xml
 <Record>
<Date>27/02/1994 00:17:16</Date>
<SampleType>Blood</SampleType>
<TestCode>eCOM</TestCode>
<Result>Blood</Result>
<Identifier>CC319477</Identifier>
<ReadCode>451E.</ReadCode>
</Record>
```
