# Spark.NET
### Sparklines for C# application

After 1,5 years of @holman's release of [spark](https://github.com/holman/spark), I deciced to make a C# port. Meanwhile many corporate planning and legal meetings held and brownbags organized, Spark.NET is finally ready.

### Usage

Just import 
    
    using SparkNet;

and pass numbers

	Spark.Render(0, 30, 55, 80, 33, 150);
    (returns ▁▂▃▄▂█)

alternatively, you can pass `IList<double>` to `Render` method. It supports floating point numbers as well.

## Hack it!