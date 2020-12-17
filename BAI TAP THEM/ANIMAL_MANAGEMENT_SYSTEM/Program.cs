using System;

namespace ANIMAL_MANAGEMENT_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourChoice;
            bool checkInput = false;
            IAnimal newAnimal;
            int ageOfAnimal;
            IAnimal[] animalList = new IAnimal[0];
            IAnimal[] terrestrialAnimals = new IAnimal[0];
            IAnimal[] marineAnimals = new IAnimal[0];

            while (true)
            {
                Menu();
                do
                {
                    Console.Write("Please select one opition from above: ");
                    checkInput = int.TryParse(Console.ReadLine(), out yourChoice);
                } while (!checkInput || yourChoice <= 0 || yourChoice > 8);

                switch (yourChoice)
                {
                    case 1:
                        newAnimal = new Crocodile(inputInformation(out ageOfAnimal), ageOfAnimal);
                        AddAnimalToList(newAnimal, ref animalList);
                        AddAnimalToList(newAnimal, ref terrestrialAnimals);
                        AddAnimalToList(newAnimal, ref marineAnimals);
                        break;
                    case 2:
                        newAnimal = new Cat(inputInformation(out ageOfAnimal), ageOfAnimal);
                        AddAnimalToList(newAnimal, ref animalList);
                        AddAnimalToList(newAnimal, ref terrestrialAnimals);
                        break;
                    case 3:
                        newAnimal = new Fish(inputInformation(out ageOfAnimal), ageOfAnimal);
                        AddAnimalToList(newAnimal, ref animalList);
                        AddAnimalToList(newAnimal, ref marineAnimals);
                        break;
                    case 4:
                        for (int i = 0; i < terrestrialAnimals.Length; i++)
                        {
                            Console.WriteLine(terrestrialAnimals[i].ToString());
                        }
                        break;
                    case 5:
                        for (int i = 0; i < marineAnimals.Length; i++)
                        {
                            Console.WriteLine(marineAnimals[i].ToString());
                        }
                        break;
                    case 6:
                        for (int i = 0; i < animalList.Length; i++)
                        {
                            Console.WriteLine(animalList[i].ToString());
                        }
                        break;
                    case 7:
                        int idToRemove;
                        do
                        {
                            Console.Write("Please enter id of animal you want to remove: ");
                            checkInput = int.TryParse(Console.ReadLine(), out idToRemove);
                        } while (!checkInput || idToRemove <= 0);
                        DeleteAnimal(idToRemove, ref animalList);
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                }



                }

        }

        static void Menu()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("ANIMAL MANAGEMENT SYSTEM\n");
            Console.WriteLine("1. Create a Crododile");
            Console.WriteLine("2. Create a Cat");
            Console.WriteLine("3. Create a Fish");
            Console.WriteLine("4. View Terrestrial Animals");
            Console.WriteLine("5. View Marine Animals");
            Console.WriteLine("6. View All Animals");
            Console.WriteLine("7. Delete Animals");
            Console.WriteLine("8. Exit");
        }

        static string FormatName(string nameInput)
        {
            //Remove space;
            while (nameInput.IndexOf("  ") != -1)
            {
                nameInput = nameInput.Replace("  ", " ");
            }
            nameInput = nameInput.ToLower();
            string[] nameSplitArray = nameInput.Split(" ");
            for (int i = 0; i < nameSplitArray.Length; i++)
            {
                char[] stringSplitToChar = nameSplitArray[i].ToCharArray();
                stringSplitToChar[0] = Char.ToUpper(stringSplitToChar[0]);
                nameSplitArray[i] = new string(stringSplitToChar);
            }
            nameInput = String.Join(" ", nameSplitArray);
            return nameInput;
        }

        static string inputInformation(out int age)
        {
            int inputAge;
            bool checkInput = false;

            Console.Write("Please enter name of new animal: ");
            string nameOfAnimal = Console.ReadLine();
            
            do
            {
                Console.Write("Please enter age of new animal: ");
                checkInput = int.TryParse(Console.ReadLine(), out inputAge);
            } while (!checkInput || inputAge <= 0);
            age = inputAge;
            return nameOfAnimal;
        }

        static void AddAnimalToList(IAnimal animal, ref IAnimal[] animaList)
        {
            Array.Resize(ref animaList, animaList.Length + 1);
            animaList[animaList.Length - 1] = animal;
        }

        static bool DeleteAnimal(int id, ref IAnimal[] animalList)
        {
            for (int i = 0; i < animalList.Length; i++)
            {
                if (animalList[i].Id == id)
                {
                    for (int j = i; j < animalList.Length - 1; j++)
                    {
                        animalList[j] = animalList[j + 1];
                    }
                    Array.Resize(ref animalList, animalList.Length - 1);
                    return false;
                }
            }
            return false;
        }
    }
}
