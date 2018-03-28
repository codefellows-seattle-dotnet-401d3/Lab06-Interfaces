# Lab06 Phil Werner

## Build A Zoo
A program that utilizes Interfaces to allow classes to do things. This program contains
two Interfaces, IFly and ISwim. There were also two new classes added, Water and Sky that
require a Interface type to be accepted. The ```Lion```, ```Duck``` and ```Penguin``` Classes
use the ```ISwim``` Interface. The ```Duck``` and ```Eagle``` Classes use the ```IFly```
Interface. See the Interface Example below for more information.

## Tools Used
Microsoft Visual Studio Community Version 15.5.7

C#

ASP.Net

xUnit

## Getting Started

Clone this repository to your local machine.
```
$ git clone 
```
Once downloaded, cd into the ```Lab06-Interfaces``` directory.
```
$ cd Lab06-Interfaces
```
The cd into ```BuildAZoo``` directory.
```
$ cd BuildAZoo
```
The cd into the second ```BuildAZoo``` directory.
```
$ cd BuildAZoo
```
Then run .NET build.
```
$ dotnet build
```
Once that is complete, run the program.
```
$ dotnet run
```
## Interface Examples
First we create a instance of ```Lion```:
```Classes.Lion sampleLion = new Classes.Lion()```

Then we create a instance of ```Water```:
```Classes.Water oasis = new Classes.Water()```

Then we pass our ```sampleLion``` object in to the ```Swim()``` method:
```oasis.Swim(sampleLion)```

The ```OUTPUT```: ```"A lion is swimming"```

## Diagram Of Inheritence and Interface

![Build A Zoo Diagram](https://github.com/philipwerner/Lab06-Interfaces/blob/master/BuildAZoo/BuildAZoo/Assets/BuildAZoo.jpg)
