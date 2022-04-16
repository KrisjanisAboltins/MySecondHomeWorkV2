
Console.WriteLine("Labdien!");
Console.OutputEncoding = System.Text.Encoding.UTF8;


string greeting = "Mani sauc Krišjānis,";
string greeting2 = "un Jūs skatāties manu otro majas darbu :).";

Console.WriteLine(greeting);
Console.WriteLine(greeting2);

// pavaicāt lietotāja vārdu
Console.WriteLine("Kā Tevi sauc?");

// sagaidīt lietotaja vārda ievadi
string userName = Console.ReadLine();

// sasveicināties ar lietotāju 
string userGreting = "Labdien," + userName + "!";
string userGreting2 = "Man prieks Tevi šeit redzēt.";

Console.WriteLine(userGreting);
Console.WriteLine(userGreting2);

// pavaicāt lietotāja vecumu
Console.WriteLine("Kāds ir Tavs vecums?");
Console.WriteLine(userName + ", lūdzu, ieraksti skaitli zemāk");

// sagaidīt lietoja vecuma ievadi
string userAgeText = Console.ReadLine();
int userAge = int.Parse(userAgeText);

//lietotāja dzimšanas gads
int userBirthYear = 2022 - userAge;
Console.WriteLine("Tu esi dzimis/usi " + userBirthYear);

//izvadīt lietotāja skaitli palielinātu par 1
int userAgeplus1 = userAge + 1;
Console.WriteLine("Nākamgad tev paliks " + userAgeplus1);

// vai lietotājs ir pilgadīgs
string Agged = "Tu esi pilngadīgs/a";
bool isLargerEqual = userAge >= 18;

Console.WriteLine(Agged);
Console.WriteLine(isLargerEqual);

Console.WriteLine();
Console.WriteLine("============================================================================");
Console.WriteLine();

// pajautāt lietotājam 1mo skaitli
string userGreeting3 = userName + ", vēlos Tev pajautāt dažus skaitļus";
Console.WriteLine(userGreeting3);
Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
// sagaidīt lietoja 1ma skaitļa ievadi
string FirstNumberText = Console.ReadLine();
int FirstNumber = int.Parse(FirstNumberText);

// pajautāt lietotājam 2ro skaitli
Console.WriteLine("Lūdzu, ievadi otro skaitli");
// sagaidīt lietoja 2ra skaitļa ievadi
string SecondNumberText = Console.ReadLine();
int SecondNumber = int.Parse(SecondNumberText);

// pajautāt lietotājam 3šo skaitli
Console.WriteLine("Lūdzu, ievadi trešo skaitli");
// sagaidīt lietoja 3šā skaitļa ievadi
string ThirdNumberText = Console.ReadLine();
int ThirdNumber = int.Parse(ThirdNumberText);

// pajautāt lietotājam 4to skaitli
Console.WriteLine("Lūdzu, ievadi ceturto skaitli");
// sagaidīt lietoja 4tā skaitļa ievadi
string FourNumberText = Console.ReadLine();
int FourthNumber = int.Parse(FourNumberText);

// pirmais max cipars
int FirstMaxNumber = Math.Max(FirstNumber, SecondNumber);
// otrais max cipars
int SecondMaxNumber = Math.Max(ThirdNumber, FourthNumber);
// trešais max cipars
int MaxNumber = Math.Max(FirstMaxNumber, SecondMaxNumber);

Console.WriteLine("-------------------------------------------------------------------");

// max ciparu parādīt
string MaxNumberText = userName + ", vai Tu zini, ka no Taviem nosauktajiem skaitļiem maksimālais skaitlis ir";
Console.WriteLine(MaxNumberText);
Console.WriteLine(MaxNumber);

// pirmais min cipara aprēkins
int FirstMinNumber = Math.Min(FirstNumber, SecondNumber);
int SecondMinNumber = Math.Min(ThirdNumber, FourthNumber);
int MinNumber = Math.Min(FirstMinNumber, SecondMinNumber);

// min ciparu parādīt
string MinNumberText = ", vai Tu zini, ka no Taviem nosauktajiem skaitļiem minimālais skaitlis ir";
Console.WriteLine(MinNumberText);
Console.WriteLine(MinNumber);

Console.WriteLine();
Console.WriteLine("============================================================================");
Console.WriteLine();

// atrādīt dalījuma atlikumu
string userGreeting4 = userName + ", vēlos Tev vēl pajautāt uzdot jautājumu. " +
    "Iedomājies skaitli no 10 līdz 20 ," +
    "pieņemsim, ka tas ir ābolu daudzums.";
Console.WriteLine(userGreeting4);
Console.WriteLine("Lūdzu, ievadi šo skaitli");
string AplleNumberText = Console.ReadLine();
int AplleNumber = int.Parse(AplleNumberText);

string userGreeting5 = userName + ", un tagd iedomājies skaitli no 2 līdz 5," +
    " pieņemsim, ka tas ir grozu daudzums, kuros vienādi jāsaliek āboli.";
Console.WriteLine(userGreeting5);
Console.WriteLine("Lūdzu, ievadi šo skaitli");
string BasketNumberText = Console.ReadLine();
int BasketNumber = int.Parse(BasketNumberText);

string Divide1 = "tad katrā grozā var ielikt";
int ApleinBasket1 = AplleNumber / BasketNumber;
string Divide2 = "ābolus, bet pāri paliks";
int ApleinBasket2 = AplleNumber % BasketNumber;
string Divide3 = "ābols";

Console.WriteLine(Divide1);
Console.WriteLine(ApleinBasket1);
Console.WriteLine(Divide2);
Console.WriteLine(ApleinBasket2);
Console.WriteLine(Divide3);

Console.WriteLine();
Console.WriteLine("============================================================================");
Console.WriteLine();

// pāra vai nepāra skaitlis
string greeting6 = "Labi, " + userName + ", nākamais jautājums";
Console.WriteLine(greeting6);

Console.WriteLine("Lūdzu, iedomājies vēl vienu skaitli");
string OddorEvenNumberText = Console.ReadLine();
int OddorEvenNumber = int.Parse(OddorEvenNumberText);

bool isEven = OddorEvenNumber % 2 == 0;
Console.WriteLine("skaitlis ir pāra skaitlis = " + isEven);
bool isOdd = OddorEvenNumber % 2 != 0;
Console.WriteLine("skaitlis ir nepāra skaitlis = " + isOdd);

Console.WriteLine();
Console.WriteLine("============================================================================");
Console.WriteLine();

// taisnstūra laukums
string greeting7 = userName + ", zemāk ir kalkulātors tainstūra laukuma aprēkināšanai";
Console.WriteLine(greeting7);

Console.WriteLine("Lūdzu, ievadi zemāk taisnstūra platumu");
string rectangleWidthText = Console.ReadLine();
double rectangleWidth = double.Parse(rectangleWidthText);

Console.WriteLine("Lūdzu, ievadi zemāk taisnstūŗa garumu");
string rectangleLenghText = Console.ReadLine();
double rectangleLenght = double.Parse(rectangleLenghText);

string rectangleResult = "taisnstūra laukums ir";
Console.WriteLine(rectangleResult);

Double rectangleArea = rectangleWidth * rectangleLenght;
Double rectangleAreaRounded = Math.Round(rectangleArea, 2);
Console.WriteLine(rectangleAreaRounded);


Console.WriteLine();
Console.WriteLine("============================================================================");
Console.WriteLine();

// taisnlenķa trīstūra laukums
string greeting8 = userName + ", zemāk ir kalkulātors taisnlenķa trīstūra laukuma aprēkināšanai";
Console.WriteLine(greeting8);

Console.WriteLine("Lūdzu, ievadi vienas malas garumu");
string triangleEdge1text = Console.ReadLine();
double triangleEdge1 = double.Parse(triangleEdge1text);

Console.WriteLine("Lūdzu, ievadi otras malas garumu");
string triangleEdge2text = Console.ReadLine();
Double triangleEdge2 = double.Parse(triangleEdge2text);

string TriagleResult = "trīstūra laukums ir";
Console.WriteLine(TriagleResult);

double triangleArea = triangleEdge1 * triangleEdge2 / 2;
Double triangleAreaRounded = Math.Round(triangleArea, 2);
Console.WriteLine(triangleAreaRounded);

Console.WriteLine();
Console.WriteLine("============================================================================");
Console.WriteLine();

// Interpolācija
Console.WriteLine("Labdien, lūdzu ievadi savu dzimšanas mēnesi (vārdiem)");
string birthMonth = Console.ReadLine();
Console.WriteLine("Lūdzu, ievadi savu dzimšanas datumu");
string birthDate = Console.ReadLine();

Console.WriteLine($"Tavs dzimšanas datums ir {userBirthYear} gada, {birthDate}. {birthMonth}");
