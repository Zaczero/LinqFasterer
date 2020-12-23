# ![Logo](https://github.com/Zaczero/LinqFasterer/blob/master/resources/icon-24.png) LinqFasterer

[![Travis (.com)](https://img.shields.io/travis/com/Zaczero/LinqFasterer?style=for-the-badge)](https://travis-ci.com/github/Zaczero/LinqFasterer)
[![Codecov](https://img.shields.io/codecov/c/github/Zaczero/LinqFasterer?style=for-the-badge&token=22SJNO514P)](https://codecov.io/gh/Zaczero/LinqFasterer)

A set of fast LINQ-like extension methods for `Array[]`, `List<T>` and all other objects implementing `IList<T>` interface.
LinqFasterer is designed to work well alongside LINQ, rather than to replace it completely.
Under the hood LinqFasterer operates sorely on Array objects which grants it a significant performance advantage over Enumerable-based LINQ.

Please don't think about LinqFasterer as 1:1 replacement.
There are certain scenarios where the use of LINQ is still more appropriable.
For a short chain of LINQ methods ended with `ToArray()` or `ToList()` - LinqFasterer is usually a way to go.
In other cases switching to LinqFasterer may not be as beneficial or even hurt your performance.
It all depends on your use case.
Use your common sense and benchmark your code if needed.

To learn more please visit the [mastering performance](#-mastering-performance) section.

## 🏃‍♂️ Sample benchmark

*Windows 10 64-bit, AMD Ryzen 7 2700X, .NET 5.0, Random int[]*

|          Method |       N |             Mean |          Error |         StdDev | Ratio | RatioSD |
|---------------- |-------- |-----------------:|---------------:|---------------:|------:|--------:|
|   **MinLinq** |    **1000** |     **3,963.199 ns** |     **18.7389 ns** |     **11.1512 ns** |  **1.00** |    **0.00** |
| MinFaster |    1000 |     2,253.335 ns |     13.7441 ns |      9.0909 ns |  0.57 |    0.00 |
|           |         |                  |                |                |       |         |
|   **OrderByLinq** |    **1000** |      **91,037.91 ns** |       **546.676 ns** |     **361.592 ns** |  **1.00** |
| OrderByFaster |    1000 |       9,902.36 ns |        44.333 ns |      29.324 ns |  0.11 |
|               |         |                   |                  |                |       |
|   **SumLinq** |    **1000** |     **4,188.486 ns** |     **27.6469 ns** |     **18.2867 ns** |  **1.00** |
| SumFaster |    1000 |       521.019 ns |      5.4260 ns |      3.5890 ns |  0.12 |
|           |         |                  |                |                |       |
|   **WhereLinq** |    **1000** |     **3,126.54 ns** |      **40.825 ns** |     **27.003 ns** |  **1.00** |    **0.00** |
| WhereFaster |    1000 |     2,199.10 ns |      18.613 ns |     11.076 ns |  0.70 |    0.01 |

A full list of benchmarks can be found in the [benchmark master file](https://github.com/Zaczero/LinqFasterer/blob/master/Benchmarks.md).

---

* [Features](#%EF%B8%8F-features)
* [Installation](#%EF%B8%8F-installation)
* [Requirements](#-requirements)
* [Getting started](#-getting-started)
* [Mastering performance](#-mastering-performance)
* [Roadmap](#%EF%B8%8F-roadmap)
* [Support me](#-support-me)
* [Contact](#-contact)
* [License](#-license)

---

## ⬆️ Features

* Easy to use
* [High code coverage](https://codecov.io/gh/Zaczero/LinqFasterer)
* No dependencies
* #nullable

## 🌤️ Installation

### Install with NuGet (recommended)

`Install-Package LinqFasterer`

### Install with dotnet

`dotnet add PROJECT package LinqFasterer`

### Install manually

[Browse latest GitHub release](https://github.com/Zaczero/LinqFasterer/releases/latest)

## ⚓ Requirements

This library is currently compiled in two frameworks, **.NET Standard 2.0** and **.NET 5.0**.
When installing from a package manager a more appropriate version will be used.
The minimum .NET requirements are then as follows:

* .NET 5.0
* .NET Core 2.0
* .NET Framework 4.6.1
* Mono 5.4
* Xamarin.iOS 10.14
* Xamarin.Mac 3.8
* Xamarin.Android 8.0
* UWP 10.0.16299
* Unity 2018.1

Check out this [interactive .NET Standard compatibility table](https://dotnet.microsoft.com/platform/dotnet-standard#versions).

## 🏁 Getting started

It is stupid-simple to get started with LinqFasterer.
All the methods have a very similar if not the same structure as their LINQ-equivalents.
In most cases it is enough to simply append an `F` character to the method's name.

### Examples

* change `Min(...)` to `MinF(...)`
* change `OrderBy(...)` to `OrderByF(...)`
* change `Take(...)` to `TakeF(...)`

```cs
// use of LINQ, ~4200ns
var result1 = arrayWith1000Elements.Sum();

// use of LinqFasterer, ~520ns - 88% faster
var result2 = arrayWith1000Elements.SumF();
```

### ⚠️ Warning

Some methods will silently use an input sequence as the operating buffer **by default** to reduce memory allocations and improve performance.
As an example let's take the `ReverseF()` method which reverses an input sequence.
There are 2 ways of forcing a new sequence to be allocated and there is no performance difference between them.
You can use whichever version you prefer to.

```cs
// 1. by prepending .ToArrayF(true) method
var newArray1 = inputArray.ToArrayF(true).ReverseF();

// 2. by passing forceClone: true argument
var newArray2 = inputArray.ReverseF(forceClone: true);
```

A full list of methods where the `forceClone` argument is applicable:

* DistinctF
* ExceptF
* IntersectF
* OrderByF
* OrderByDescendingF
* ReverseF
* SkipF
* SkipLastF
* SkipWhileF
* TakeF
* TakeLastF
* TakeWhileF
* ToArrayF
* ToListF
* WhereF

**You don't have to remember this list** - that would be stupid and very unnecessary.
It is enough to follow a simple logic.
The `forceClone` argument is applicable on methods whose output is **guaranteed** to be of the same or smaller size than of an input sequence and the element's `Type` remains unchanged.

## 📗 Mastering performance

### 1) Understanding LINQ

If you know Python then it is easy to think about LINQ as generators.
All the operations are deferred until the very last moment and even then, only the required sequence elements are calculated.
Everything beyond that is ignored saving on CPU ticks and increasing performance.
As an example, let's take a look at the following LINQ code:

```cs
var result = input.Select(v => v * 15).Take(5).ToArray();
```

At a first glance it looks like we multiply each element of a sequence by 15 and then we keep the 5 leading elements - wrong!
LINQ is smart enough to figure out that a resulting sequence will be just 5 elements long.
It will multiply **only the first 5 elements** by 15 and ignore everything beyond.
The total number of multiplications is just 5 instead of `input.Length` - in contrary to what logic may tell us.

### 2) Understanding LinqFasterer

As previously mentioned, LinqFasterer operates sorely on Array objects.
Knowing that, to get the most out of this library, your code should also favor a use of arrays whenever applicable.
Whenever a non-array object is used as an input sequence it is internally casted onto a newly allocated array.
The following 2 lines of code are equivalent performance-wise *(notice how the input sequence is a list)*:

```cs
var result1 = inputList.SelectF(v => v * 15);
var result2 = inputList.ToArrayF().SelectF(v => v * 15);
```

Let's now reconsider the same code example as in the *Understanding LINQ* section but with LinqFasterer methods used instead:

```cs
var result = input.SelectF(v => v * 15).TakeF(5).ToArrayF();
```

This code will work exactly as you think it will.
At first, multiply each element of a sequence by 15 and then resize the whole sequence to keep only the very first 5 elements.
That's not very optimal as in oppose to LINQ - each element of an input sequence is calculated even if it is discarded in a very next step.
Let's rewrite this code into more LinqFasterer-friendly form:

```cs
var result = input.TakeF(5).SelectF(v => v * 15).ToArrayF();
```

Now the first step is to discard all unnecessary elements, that is, all with index 5 or higher.
And then, when the sequence is of size 5, multiply each element by 15.
The complexity is now equal to the one in LINQ's example.
And by running a short benchmark one can see that the overall performance is even greater.
All it took is some basic understanding of the methods in use and the minor code modification.

|                         Method |     N |          Mean |        Error |    Ratio |
|------------------------------- |------ |--------------:|-------------:|---------:|
|                  MasteringLinq | 50000 |     104.46 ns |     0.753 ns |     1.00 |
|          MasteringLinqFasterer | 50000 | 143,489.55 ns | 5,960.480 ns | 1,371.13 |
| MasteringLinqFastererRewritten | 50000 |      52.83 ns |     1.028 ns |     0.51 |

What you should remember from all of this is that by using LinqFasterer correctly you open your code to even greater performance.
By removing Enumerable calculations *(LINQ)* from your code you save on CPU ticks but become more susceptible to killing overall performance with just a few lines of code.
You gain a greater level of control over what happens with a sequence allowing you to master performance.
However, you also become fully responsible for making sure your code is well-optimized without any bottlenecks.

## 🗺️ Roadmap

### Release 2.1

* Additional non-LINQ extension methods
* .NET Standard 2.0 support

### Release 2.2

* Parallel support

### Release 2.3

* SIMD support

### Release 2.4

* SIMD+Parallel support

## Footer

### ☕ Support me

Making a small donation will enable me to spend even more time towards making this project better.
Send me an email afterwards and I will make sure to put you in the supporters section of the `README.md` file *(not yet present)*.

* Bitcoin :: `bc1qvhdxpwzcvfhyzlf5jd3xvm48tm5wm6d0xaq55z`
* Bitcoin Cash :: `qpclmw8ulcdqd2gd66ryepshn9dq8278tvmkpu6df6`
* Monero :: `4ABpPJchKYS8Nq9dPb8mr1NEEAHbKDr5aK777QZh2aSD7BJHdhkQn4RFQ3zNW2kytSXHXpimt57L9X9iin3uJjw93pCpKaJ`

### 📧 Contact

* Email: [kamil@monicz.pl](mailto:kamil@monicz.pl)
* PGP: [0x9D7BC5B97BB0A707](https://gist.github.com/Zaczero/158da01bfd5b6d236f2b8ceb62dd9698)

### 📃 License

* [Zaczero/LinqFasterer](https://github.com/Zaczero/LinqFasterer/blob/master/LICENSE)
