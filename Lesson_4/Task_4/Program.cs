using LiskovSubstitution.Vehicles;

// A plane has an engine, and is able to fly
Plane plane = new Plane();
plane.Fly();
plane.StartEngine();

// A car cannot fly, CS1061 if attempted
Car car = new Car();
// car.Fly();
car.StartEngine();

// Same for motorcycle
Motorcycle motorcycle = new Motorcycle();
// motorcycle.Fly();
motorcycle.StartEngine();
