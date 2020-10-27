This is the class library that will be deployed as lambda layer.

1. dotnet build --configuration release
2. copy `.\release\netstandard2.0\layer.dll` to `.\layer\` folder inside of `csharp` project