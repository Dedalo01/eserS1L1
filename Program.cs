namespace eserS1L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta bestAthlete = new Atleta("Marco", 323);


            Console.WriteLine($"{bestAthlete.Name} is our fastest athlete, he's only {bestAthlete.Age} old!");
            Console.WriteLine();

            Dipendente superDipendente = new Dipendente("Alessandro", 32, "Microsoft");
            superDipendente.Age = 0;
            Console.WriteLine($"{superDipendente.Name}, di anni {superDipendente.Age}, ha appena ricevuto una promozione presso la compagnia {superDipendente.Company}");
            Console.WriteLine();

            Animale mucche = new Animale("mucche");

            Console.WriteLine($"Le {mucche.Name} fanno {Animale.Verso("mooooo")}");
            Console.WriteLine($"Ma una fa {Animale.Verso("moo")} {Animale.Verso("moooo")}!!!!!!");
            Console.WriteLine();

            Veicolo nissanGT = new Veicolo("Nissan", "GT-R", 190, 230);

            nissanGT.CaratteristicheVeicolo();
            Console.WriteLine();

            string provaMetodo = "Questa auto è velocissima! " + nissanGT.MassimaVelocita();
            Console.WriteLine(provaMetodo);


            Console.ReadKey();
        }
    }




    public class Atleta
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (age == 0)
                {
                    age = 30;

                }
                else
                {
                    age = value;
                }
            }
        }

        public Atleta(string name, int age)
        {
            this.name = name;
            this.age = age;

        }
    }

    public class Dipendente
    {
        private string name;
        private int age;
        private string company;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (age <= 0)
                {
                    age = 1;
                }
                else
                {
                    age = value;
                }
            }
        }


        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public Dipendente(string name, int age, string company)
        {
            this.name = name;
            this.age = age;
            this.company = company;

        }
    }

    public class Animale
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animale(string name)
        {
            this.name = name;


        }

        public static string Verso(string verso)
        {
            return verso.ToUpper();
        }

    }

    public class Veicolo
    {
        private string brand;
        private string model;
        private int horsePower;
        private int topSpeed;

        public Veicolo(string brand, string model, int horsePower, int topSpeed)
        {
            this.brand = brand;
            this.model = model;
            this.horsePower = horsePower;
            this.topSpeed = topSpeed;
        }

        public string Brand
        {
            get { return brand; }
            set
            {
                if (brand == "") { brand = "missing brand"; }
                else
                {
                    brand = value;
                }
            }
        }
        public string Model
        {
            get { return model.ToUpper(); }
            set
            {
                if (model == "") { model = "Generic"; }
                else
                {
                    model = value;
                }
            }
        }

        public string HorsePower
        {
            get { return horsePower + "CV"; }
        }

        public string TopSpeed
        {
            get { return topSpeed + "Km/h"; }
        }

        public string MassimaVelocita()
        {
            return "LA MASSIMA VELOCITA' E' " + TopSpeed;
        }

        public void CaratteristicheVeicolo()
        {
            Console.WriteLine($"Ecco l'auto selezionata:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Horse Power: {HorsePower}");
            Console.WriteLine($"Top Speed: {TopSpeed}");
        }

    }

}