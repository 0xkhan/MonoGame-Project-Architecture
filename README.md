# MonoGame-Project-Architecture

## Disclaimer: This Project is my Uni project. I created this repo to explain the project architecture to my team. If you find it helpfull great but dont fully rely on it.

> I only added the project directory here.

## Now about the architecture
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
│   ├── TIHGame.cs
│   ├── TimeIsHoney.csproj
│   ├── app.manifest
│   ├── bin
│   └── obj
└── TimeIsHoney.sln
```
The above project tree shows the current tree and it'll evolve through time. TimeIsHoney is the project name. Inside the project directory there are some standard files that every MonoGame project have. However the Game1.cs class has been renamed to TIHGame.cs. There is also a new directory called TIH.Engine. This is the directory we'll talk about.<br />
TIH.Engine is the core of the project. It contains the very Core logic of the project. On top of the engine will base our game logic. The engine is like a general framework on top of which we can write any game. But in our case it's very specific to our project as we don't have enough time to develop a general purpose engine.
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
If we look inside the TIH.Engine directory there are other specific directories. Each directory will hold the code for a specific mechanism. For example Entities will only take care of all the entities we have in our project living and nonliving. Input will handle all input events. Physics is for physics engine and collision detection etc. Below you can see the whole tree for the engine.
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
├── WindowManager.cs
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
Everything defined in an interface are public. [Here](https://www.w3schools.com/cs/cs_interface.asp) you can read more about interfaces.

