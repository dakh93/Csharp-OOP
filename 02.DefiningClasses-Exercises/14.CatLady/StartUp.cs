using System;
using System.Linq;

namespace _14.CatLady
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(' ');

            Cat cat = new Cat();
            while (input.Length  > 1)
            {
                var type = input[0];
                var name = input[1];
                var parameter = double.Parse(input[2]);

                switch (type)
                {
                    case "Siamese":
                        Siamese siamese = new Siamese();

                        siamese.Name = name;
                        siamese.EarSize = parameter;

                        cat.Siamese.Add(siamese);
                        break;
                    case "Cymric":
                        Cymric cymric = new Cymric();

                        cymric.Name = name;
                        cymric.FurLenght = parameter;

                        cat.Cymric.Add(cymric);
                        break;
                    case "StreetExtraordinaire":
                        StreetExtraordinaire street = new StreetExtraordinaire();

                        street.Name = name;
                        street.DecibelsOfMeow = parameter;

                        cat.StreetExtraordinaire.Add(street);
                        break;
                }

                input = Console.ReadLine().Split(' ');
            }

            string catInfo = Console.ReadLine();

            if (cat.Cymric.Any(x => x.Name.Equals(catInfo)))
            {
                foreach (var currentCat in cat.Cymric)
                {
                    if (currentCat.Name == catInfo)
                    {
                        Console.WriteLine($"Cymric {catInfo} {currentCat.FurLenght:f2}");
                    }
                }
            }
            else if (cat.Siamese.Any(x => x.Name.Equals(catInfo)))
            {
                foreach (var currCat in cat.Siamese)
                {
                    if (currCat.Name.Equals(catInfo))
                    {
                        Console.WriteLine($"Siamese {currCat.Name} {currCat.EarSize}");
                    }
                }
            }
            else if (cat.StreetExtraordinaire.Any(x => x.Name.Equals(catInfo)))
            {
                foreach (var currCat in cat.StreetExtraordinaire)
                {
                    if (currCat.Name.Equals(catInfo))
                    {
                        Console.WriteLine($"StreetExtraordinaire {currCat.Name} {currCat.DecibelsOfMeow}");
                    }
                }
            }
        }
    }
}
