using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002HW
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMan clarkKent = new SuperMan("Clark Kent", 19, 899999);
            SpiderMan petterParker = new SpiderMan("Petter Parker", 18, 8.7);
            Flash berryAllen = new Flash("Berry Allen", 16, 100.9);

            ISuperHero[] superHeroes = new ISuperHero[3];
            superHeroes[0] = clarkKent;
            superHeroes[1] = petterParker;
            superHeroes[2] = berryAllen;

            ISuperHero[] superHeroesSograim =
            {
                clarkKent, petterParker, berryAllen
            };

            ISuperHero[] superHeroesSograimNew =
            {
                new SuperMan("Clark Kent", 19, 899999),
                new SpiderMan("Petter Parker", 18, 8.7),
                new Flash("Berry Allen", 16, 100.9)
            };

            foreach (ISuperHero hero in superHeroes) // LINQ
            {
                ActivateHero( hero );
            }


        }

        static void ActivateHero(ISuperHero superHero)
        {
            superHero.ActivateSuperPowers();
        }

        static void IdentifyHero(ISuperHero hero)
        {
            if (hero is SuperMan)
            {
                Console.WriteLine("Got superman!!");
            }
            else if (hero is SpiderMan)
            {
                Console.WriteLine("Spiderman detected!");
            }
            else if (hero is Flash)
            {
                Console.WriteLine("Flash here!");
            }
            else
            {
                Console.WriteLine($"Got : {hero.GetType()}");
            }
        }

        static void GetMoreHeroData(ISuperHero hero)
        {
            SuperMan superman = hero as SuperMan;
            if (superman != null)
            {
                Console.WriteLine(superman.Speed);
            }
            else
            {
                SpiderMan spiderMan = hero as SpiderMan;
                if (spiderMan != null)
                {
                    Console.WriteLine(spiderMan.WebLeft);
                }
                else
                {
                    Flash flash = hero as Flash;
                    if (flash != null)
                    {
                        Console.WriteLine(flash.Voltage);
                    }
                    else
                    {
                        Console.WriteLine("Hero not recognized!");
                    }
                }
            }
        }

        static ISuperHero CreateHero(string hero)
        {
            switch (hero)
            {
                case "Flash":
                    return new Flash("Berry Allen", 16, 100.9);
                case "SuperMan":
                    return new SuperMan("Clark Kent", 19, 899999);
                case "SpiderMan":
                    return new SpiderMan("Petter Parker", 18, 8.7);
                default:
                    return null;
            }
        }
    }
}
