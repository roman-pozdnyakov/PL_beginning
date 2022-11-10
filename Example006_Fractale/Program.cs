Console.Clear();
// Console.SetCursorPosition(45,0);
// Console.WriteLine("*");

int xa = 45, ya = 1;
int xb = 1, yb = 45;
int xc = 90, yc = 45; 
Console.SetCursorPosition(xa,ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("*");
Console.SetCursorPosition(xc,yb);
Console.WriteLine("*");

int limit = 2000;
int count = 0;
int x = xa;
int y = ya;

int which0 = new Random().Next(1,3);
if (which0 == 1)
{
    x = (x + xc) / 2;
    y = (y + yc) / 2;
}
else
{
    x = (x + xb) / 2;
    y = (y + yb) / 2;
}

while(count < limit)
{
    int which = new Random().Next(1,4);
    if (which == 1)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (which == 2)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (which == 3)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("*");
    count++;
}