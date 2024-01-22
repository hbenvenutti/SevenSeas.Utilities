# SevenSeas.Utilities.Validation

![Static Badge](https://img.shields.io/badge/.NET-8-blue)
![Nuget](https://img.shields.io/nuget/v/SevenSeas.Utilities.Validation)
![GitHub License](https://img.shields.io/github/license/hbenvenutti/SevenSeas.Utilities)
![GitHub repo size](https://img.shields.io/github/repo-size/hbenvenutti/SevenSeas.Utilities)
[![built with Codeium](https://codeium.com/badges/main)](https://codeium.com/badges/main)

# Dependency Injection

You can add the annotation validation filter by using the 
`AddSevenSeasValidation()` method.

```csharp
    services.AddControllers(options => 
    {
        options.AddSevenSeasValidation()
    });
```
