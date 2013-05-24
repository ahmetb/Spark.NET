# Spark.NET
### Sparklines for C# applications

After 1.5 years of @holman's release of [spark](https://github.com/holman/spark), I deciced to make a C# port. Meanwhile many planning and legal meetings are held and brownbags are organized. Now, Spark.NET is finally ready.

### Installation

Using [NuGet](https://nuget.org/) package manager, run the following command in the Package Manager Console

    PM> Install-Package Spark.NET

or alternativelty, right-click to your project in Visual Studio → Manage NuGet Packages → Search "Spark.NET" → click Install. Reference will be added to your project automatically.

### Usage

Just import the namespace
    
    using SparkNet;

and pass numbers

	Spark.Render(0, 30, 55, 80, 33, 150);
    (returns ▁▂▃▄▂█)

alternatively, you can pass `IList<double>` to `Render` method. It supports floating point numbers as well.

It does not work on cmd.exe and thus command line programs due to shitty old fonts inherited from late 80s, however it will work on window applications.

## Hack it!
