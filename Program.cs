using Practika241123;
using System.Security.Cryptography.X509Certificates;

// 1Спроектируйте программу для построения генеалогического дерева.
// Учтите что у нас есть члены семьи у кого нет детей(дет).
// Есть члены семьи у кого дети есть (взрослые). Есть мужчины и женщины.
/*2Доработать предыдущий класс реализовав методы вывода родителей, детей, братьев/сестер (включая двоюродных), 
 * бабушеки дедушек. Подумайте как лучше реализовать данные методы.*/
// 3. Доработайте приложение генеалогического дерева таким образом чтобы программа выводила на экран близких родственников (жену/мужа).
//Продумайте способ более красивого вывода с использованием горизонтальных и вертикальных черточек.
// жена и родителей и детей


public class Program
{
    public static void Main(string[] args)
    {
        FamalyMembers GrandFatherFirst = new FamalyMembers()
        {
            FirstName = "Sergey",
            LastName = "Ivanov",
            Age = 49,
            Gender = Gender.man

        };
        FamalyMembers GrandFatherSecond = new FamalyMembers()
        {
            FirstName = "Ivan",
            LastName = "Gregoriev",
            Age = 56,
            Gender = Gender.man

        };
        FamalyMembers GrandMotherFirst = new FamalyMembers()
        {
            FirstName = "Sveta",
            LastName = "Gregoriev",
            Age = 61,
            Gender = Gender.woman
        };
        FamalyMembers GrandMotherSecond = new FamalyMembers()
        {
            FirstName = "Valentena",
            LastName = "Ivanova",
            Age = 70,
            Gender = Gender.woman
        };
        FamalyMembers Father = new FamalyMembers()
        {
            FirstName = "Anatoly",
            LastName = "Gregoriev",
            Age = 58,
            Gender = Gender.man,
            Father = GrandFatherFirst,
            Mother = GrandMotherFirst
        };
        FamalyMembers Mother = new FamalyMembers()
        {
            FirstName = "Lena",
            LastName = "Gregorieva",
            Age = 56,
            Gender = Gender.woman,
            Father = GrandFatherSecond,
            Mother = GrandMotherSecond
        };
        FamalyMembers Son = new FamalyMembers()
        {
            FirstName = "Kirril",
            LastName = "Gregoriev",
            Age = 18,
            Gender = Gender.man,
            Father = Father,
            Mother = Mother
        };
        Father.Spouse = Mother;
        Mother.Spouse = Father;

        FamilyInfo(Son);
        Console.ReadLine();

        //var GrandMothers = Son.GetGrandMotherName();

       // Console.WriteLine(GrandMothers[0]?.FirstName);
      //  Console.WriteLine(GrandMothers[1]?.FirstName);

        static void FamilyInfo(FamalyMembers members)
        {
            Console.WriteLine($"{members.FirstName} {members.LastName}");
            if ( members.Spouse != null )
            {
                string relaShip = members.Gender == Gender.man ? "Жена" : "Муж";
                Console.WriteLine($" ({relaShip}: {members.Spouse.FirstName} {members.Spouse.LastName})");
            }
            else
            {
                Console.WriteLine();
            }
            if( members.Father != null ) 
            {
                Console.WriteLine($"| Отец: {members.Father.FirstName} {members.Father.LastName}");
            }
            if ( members.Mother != null)
            {
                Console.WriteLine($"| Мать: {members.Mother.FirstName} {members.LastName}");
            }
            Console.WriteLine();
        }
    }
}








