# MonoGame-Project-Architecture

## Disclaimer: This is my Uni project. I created this repo to explain the project architecture to my team. If you find it helpfull great but don't fully rely on it.

> &#9888; I only added the project directory here. No code will be added to this project.

### The Architecture
```
.
├── LICENSE
├── README.md
├── TimeIsHoney
│   ├── Content
│   ├── Icon.bmp
│   ├── Icon.ico
│   ├── Program.cs
│   ├── TIH.Engine
│   ├── TIH.Engine.Test
│   ├── TIH.GameLogic
│   ├── TIHGame.cs
│   ├── TimeIsHoney.csproj
│   ├── app.manifest
│   ├── bin
│   └── obj
└── TimeIsHoney.sln
```
The above project tree shows the current tree and it'll evolve over time. TimeIsHoney is the project name. Inside the project directory there are some standard files that every MonoGame project have. However the Game1.cs class has been renamed to TIHGame.cs. There is also a new directory called `TIH.Engine`. This is the directory we'll talk about.<br />
`TIH.Engine` is the core of the project. It contains the very Core logic of the project. On top of the engine will base our game logic. The engine is like a general framework on top of which we can write any game. But in our case it's very specific to our project as we don't have enough time to develop a general purpose engine.

### Whats inside TIH.Engine directory?
```
.
├── Entities
├── Input
├── Pathfinding
├── Physics
├── Redering
├── Settings
├── WindowManager.cs
├── Windows
└── World
```
If we look inside the `TIH.Engine` directory there are other specific directories. Each directory will hold the code for a specific mechanism. For example Entities will only take care of all the entities we have in our project living and nonliving. Input will handle all input events. Physics is for physics engine and collision detection etc. Below you can see the whole tree for the engine.
```
.
├── Entities
│   ├── Entity.cs
│   ├── HoneybeeEntity.cs
│   ├── KillerbeeEntity.cs
│   ├── LarvabeeEntity.cs
│   ├── LivingEntity.cs
│   ├── ObjectEntities
│   ├── ObjectEntity.cs
│   ├── QueenbeeEntity.cs
│   ├── WaspEntity.cs
│   └── WorkerbeeEntity.cs
├── Input
│   ├── MouseButtonEvents.cs
│   ├── MouseEventHandler.cs
│   └── MouseMoveEvents.cs
├── Pathfinding
│   └── Path.cs
├── Physics
│   └── PhysicsEngine.cs
├── Redering
│   ├── Camera.cs
│   ├── ObjectRenderers
│   └── Renderer.cs
├── Settings
│   ├── MusicVolume.cs
│   ├── SoundEffectVolume.cs
│   ├── UserSettings.cs
│   └── WindowMode.cs
├── Windows
│   ├── AchievementsMenuWindow.cs
│   ├── FlowerPopupWindow.cs
│   ├── KitchenPopupWindow.cs
│   ├── LabPopupWindow.cs
│   ├── MainMenuWindow.cs
│   ├── MenuWindowArea.cs
│   ├── OptionsMenuWindow.cs
│   ├── PopupWindowArea.cs
│   ├── QueenPopupWindow.cs
│   ├── StatisticsMenuWindow.cs
│   └── Window.cs
└── World
    ├── Map.cs
    └── World.cs
```
In each class I've added docstrings to give you an idea what the class is for and what other classes and interfaces to be ihnerited in each one of them. For example in `Entity.cs` we'll define properties, getter and setters for each entity and it'll be inherited in each entity class. If we want to define Honeybee entity the class for that will look like following:
```csharp
using System;
namespace TimeIsHoney.TIH.Engine.Entities
{
    public class HoneybeeEntity : Entity
    {
        public HoneybeeEntity()
        {
        }
    }
}
```
It is also a good practice to use interfaces to define empty properties and methods. It is also considered good practice to start with a capital "I" to name interfaces. It'll allow you and others to know that this specific file is not a class but an interface. Following is an example code:
```csharp
interface ILivingEntity
{
    void entityMovement();
    void entityJump();
}
```
Everything defined in an interface are public. [Here](https://www.w3schools.com/cs/cs_interface.asp) you can read more about interfaces.<br/>
### What is Windows directory for you ask?
Windows directory is meant for windows, menus and popups. We might also want screens directory to handle screens. We might have load screen, menu screen, launch screen and the main game screen. But we'll see how our architecture evolves.

### What is TIH.Engine.Test for?
`TIH.Engine.Test` is used for testing the engine. We'll use unit tests to test the engine automatically. We'll never do testing manually &#128556; Imagine building the project, compiling and running the build and then manually testing everytime you make changes. So yeah, it's better to use unit tests. There are some unit testing frameworks for .Net but the popular ones are XUnit and NUnit. Following is a example of XUnit.<br/>
Here is their [github](https://github.com/xunit/xunit). You can install it through `nuget` inside your solution.
```csharp
using System;
using Xunit;

namespace DRYDemoLibraryTest
{
    public class EmployeeProcessorTest
    {
        [Theory]
        [InlineData("Jack", "Barker", "JackBark")]
        [InlineData("Tom", "Johnny", "TomxJohn")]
        [InlineData("Ng", "Li", "NgxxLixx")]
        public void GenerateEmployeeId_ShouldCalculate(string firstName, string lastName, string expectedStart)
        {
            // Arrange
            EmployeeProcessor processor = new EmployeeProcessor();

            // Act
            string actualStart = processor.GenerateEmployeeID(firstName, lastName).Substring(0, expectedStart.Length);

            // Assert
            Assert.Equal(expectedStart, actualStart);
        }
    }
}
```

### Now it's time for the main Game mechanics
So the main Game logic goes inside `TIH.GameLogic` directory. Inside this directory we'll write everything that has to do with pure game logic e.g displaying the main menu on the screen. Generating menu buttons, adding specific sprites for the buttons, adding hovers to buttons. Defining approriat methods for them e.g `Draw(), Update(), newGameButton(), loadGameButton(), quitGameButton()`. That's why we have `Menu` folder inside `TIH.GameLogic`. Following is the folder tree.
```
.
├── InputManager.cs
├── Menu
│   ├── Controles
│   │   └── Buttons.cs
│   └── States
│       ├── GameState.cs
│       ├── MenuState.cs
│       └── State.cs
├── ScreenManager.cs
└── WindowManager.cs
```
