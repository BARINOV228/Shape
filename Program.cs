using shakillar;

Square mySquare = new Square(5);
Console.WriteLine("Площадь квадрата: " + mySquare.GetArea());

Rectangle myRectangle = new Rectangle(6, 3);
Console.WriteLine("Площадь прямоугольника: " + myRectangle.GetArea());

Rhombus myRhombus = new Rhombus(8, 6);
Console.WriteLine("Площадь ромба: " + myRhombus.GetArea());

Circle myCircle = new Circle(4);
Console.WriteLine("Площадь круга: " + myCircle.GetArea());

Console.ReadKey();