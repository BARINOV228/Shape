using shakillar;

Square<double> mySquare = new Square<double>(5);
Console.WriteLine("Площадь квадрата: " + mySquare.GetArea());

Rectangle<double> myRectangle = new Rectangle<double>(6, 3);
Console.WriteLine("Площадь прямоугольника: " + myRectangle.GetArea());

Rhombus<double> myRhombus = new Rhombus<double>(8, 6);
Console.WriteLine("Площадь ромба: " + myRhombus.GetArea());

Circle<double> myCircle = new Circle<double>(4);
Console.WriteLine("Площадь круга: " + myCircle.GetArea());

Console.WriteLine("Works");

Console.ReadKey();
