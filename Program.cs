// See https://aka.ms/new-console-template for more information

//Ask the user for an x value and y value. These are coordinate of the enemy relative to the watchtower's location

//using the image *in the book*, if statements, and relational operators, display a message about what direction the enemy is
//coming from. For example, "The enemy is to the northwest!" or "The enemy is here!

/*
 *      x < 0       x=0        x > 0
 * 
 * y < 0   NW        N          NE
 * 
 * y = 0   W         !          E
 * 
 * y > 0   SW        S          SE
 * 
*/

Console.Write("What is the X coordinate?! ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the Y coordinate?! ");
int y = Convert.ToInt32(Console.ReadLine());

if (y < 0 && x < 0  )
    Console.WriteLine("The enemy is North West");
if (y < 0 && x == 0)
    Console.WriteLine("The enemy is North");
if (y < 0 && x > 0)
    Console.WriteLine("The enemy is North East");
if (y == 0 && x < 0)
    Console.WriteLine("The enemy is West");
if (y == 0 && x == 0)
    Console.WriteLine("The enemy is Here!!");
if (y == 0 && x > 0)
    Console.WriteLine("The enemy is East");
if ( y > 0 && x < 0)
    Console.WriteLine("The enemy is South West");
if (y > 0 && x == 0)
    Console.WriteLine("The enemy is South");
if (y > 0 && x > 0)
    Console.WriteLine("The enemy is South East");
























