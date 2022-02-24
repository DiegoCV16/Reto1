using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList team1 = new ArrayList();
            ArrayList team2 = new ArrayList();
            ArrayList team3 = new ArrayList();

            team1.addAtTail("Eli");
            team1.addAtTail("Jacqui");
            team1.addAtTail("Yael");
            team1.addAtTail("Migue");
            team1.addAtTail("Pando");

            team2.addAtFront("Christian");
            team2.addAtFront("Emi");
            team2.addAtFront("Diego");
            team2.addAtFront("Deniss");
            team2.addAtFront("Frozono");

            team3.addAtFront("Bruno");
            team3.addAtFront("Fer");
            team3.addAtFront("Claudia");
            team3.addAtFront("Santiago");
            team3.addAtFront("Noe");
            team3.addAtFront("Gaby");

            ArrayListIterator iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Jesús
            // Salomón
            // Yael

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Diego
            // Daniel
            // Cristian

            team1.remove(0);
            team1.addAtFront("Rebeca");
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes"); // debe imprimir "Team 1 tiene 3 integrantes"

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Rebeca
            // Salomón
            // Yael

            team2.remove(2);
            team2.addAtTail("Rita");
            Console.WriteLine("Team 2 tiene: " + team2.getSize() + " integrantes"); // debe imprimir "Team 2 tiene 3 integrantes"

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Diego
            // Daniel
            // Rita

            team3.remove(0);
            team3.remove(0); // El elemento no existe pero el programa no debe cerrarse por algún error

            team3.addAtTail("Isai");
            team3.addAtFront("Tadeo");

            Console.WriteLine("Team 3 tiene: " + team3.getSize() + " integrantes"); // debe imprimir "Team 3 tiene 2 integrantes"

            iterator = team3.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Tadeo
            // Isai

            if (team1.getAt(1).Equals("Salomón"))
            {
                team1.setAt(1, "Luis");
            }

            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes"); // debe imprimir "Team 1 tiene 3 integrantes"

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Rebeca
            // Luis
            // Yael
        }
    }
  }

