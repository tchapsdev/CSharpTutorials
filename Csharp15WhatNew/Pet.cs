namespace Csharp15;
public record class Cat(string Name, string Description);
public record class Dog(string Name);
public record class Bird(string Name);

public union Pet(Cat, Dog, Bird);