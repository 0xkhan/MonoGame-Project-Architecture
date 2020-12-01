# MonoGame-Project-Architecture

## Disclaimer: This Project is my Uni project. I created this repo to explain the project architecture to my team. If you find it helpfull great but dont fully rely on it.

> I only added the project directory here.

## Now about the architecture
``````
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
``````
The above project tree shows the current tree and it'll evolve through time. TimeIsHoney is the project name. Inside the project directory there are some standard files that every MonoGame project have. However the Game1.cs class has been renamed to TIHGame.cs. There is also a new directory called TIH.Engine. This is the directory we'll talk about.
TIH.Engine is the core of the project. It contains the very Core logic of the project. On top of the engine will base our game logic. The engine is like a general framework on top of which we can write any game. But in our case it's very specific to our project as we don't have enough time to develop a general purpose engine.

