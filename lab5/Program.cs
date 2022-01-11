//Zadanie 1.
//int DlugoscNapisu(string napis)
//{
//    return napis.Length;
//}
//try
//{
//        DlugoscNapisu(null);
//}
//catch (NullReferenceException e)
//{
//        Console.WriteLine(e.StackTrace);
//        throw new Exception("Napis nie może być null!",e);
//}

//Zadanie 2.
//void Losowanie()
//{
//    Random rnd = new Random();
//    switch (rnd.Next(1,4))
//    {
//        case 1:
//            {
//                try
//                {

//                    throw new Exception();

//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine("Wyjatek 1");
//                }
//                break;
//            }

//        case 2:
//            {
//                try
//                {
//                    throw new Exception();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine("Wyjatek 2");
//                }
//                break;
//            }
//        case 3:
//            {
//                try
//                {
//                    throw new Exception();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine("Wyjatek 3");
//                }
//                break;
//            }
//    }
//}
//Losowanie();

//Zadanie 3.
//using lab5;
//void Zadanie3()
//{
//    try
//    {
//        throw new Exception1();
//    }
//    catch (Exception1 e)
//    {
//        throw new Exception2("Kolejny wyjątek");

//    }
//    catch (Exception2 e)
//    {
//        Console.WriteLine("Tak, mogą być obsłużone");
//    }
//}
//Zadanie3();

//Zadanie 4.
//using lab5;
//void Zadanie4()
//{
//    SomeClass someClassObj = new SomeClass();
//    int i = 1;
//    try
//    {
//        someClassObj.CanThrowException();
//        i++;
//        someClassObj.CanThrowException();
//        i++;
//        someClassObj.CanThrowException();
//        i++;
//        someClassObj.CanThrowException();
//        i++;
//        someClassObj.CanThrowException();
//        Console.WriteLine("Wyjątek nie wystąpił");
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine("Wyjątek wystąpił na " + i + " instrukcji");
//        Console.WriteLine(e.StackTrace);

//    }
//}
//Zadanie4();

//Zadanie 5.
using lab5;
Osoba o1 = new Osoba("Kuba", "Błaszczyk", 21);
Osoba o2 = new Osoba();
o1.Kopiuj(o1, o2);
Console.WriteLine("Osoba 2: " + o2.imie + " " + o2.nazwisko + " " + o2.wiek);

//Zadanie 6.
Osoba o3 = o2.Kopiuj2();
Console.WriteLine("Osoba 3: " + o3.imie + " " + o3.nazwisko + " " + o3.wiek);