//using List.ArrayList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List.list.ArrayList;

namespace List.list.ArrayList
{
    internal class Main2
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("ArrayList: \n");
            metodo(new ArrayList<String>(), new ArrayList<String>(), new ArrayList<String>());
            Console.WriteLine("***********************************");
            Console.WriteLine("LinkedList: \n");
            metodo(new LinkedList<String>(), new LinkedList<String>(), new LinkedList<String>());
        }

        public static void metodo(List<String> team1, List<String> team2, List<String> team3)
        {

            team1.addAtTail("Daniel");
            team1.addAtTail("Rodrigo");
            team1.addAtTail("Javier");

            team2.addAtFront("Gerardo");
            team2.addAtFront("Miguel");
            team2.addAtFront("Sango");

            team3.addAtFront("Huizar");

            Iterator<String> iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            team1.remove(0);
            team1.addAtFront("Alan");
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes");

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            team2.remove(2);
            team2.addAtFront("David");
            Console.WriteLine("Team 2 tiene: " + team2.getSize() + " integrantes");

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            team3.remove(0);
            team3.remove(0); //El elemento no existe pero el programa no debe cerrarse por algún error

            team3.addAtTail("Humberto");
            team3.addAtFront("Octa");

            Console.WriteLine("Team 3 tiene: " + team3.getSize() + " integrantes");

            iterator = team3.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            if (team1.getAt(1) == ("Rodrigo"))
            {
                team1.setAt(1, "Luigi");
            }

            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes");

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }
        }
    }
}
