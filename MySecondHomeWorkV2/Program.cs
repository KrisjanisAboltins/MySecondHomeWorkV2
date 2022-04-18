
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
string agged = "Tu esi pilngadīgs/a";
bool isLargerEqual = userAge >= 18;

Console.WriteLine(agged);
Console.WriteLine(isLargerEqual);

Console.WriteLine();
Console.WriteLine("============================================================================");
Console.WriteLine();

// pajautāt lietotājam 1mo skaitli
string userGreeting3 = userName + ", vēlos Tev pajautāt dažus skaitļus";
Console.WriteLine(userGreeting3);
Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
// sagaidīt lietoja 1ma skaitļa ievadi
string firstNumberText = Console.ReadLine();
int firstNumber = int.Parse(firstNumberText);

// pajautāt lietotājam 2ro skaitli
Console.WriteLine("Lūdzu, ievadi otro skaitli");
// sagaidīt lietoja 2ra skaitļa ievadi
string secondNumberText = Console.ReadLine();
int secondNumber = int.Parse(secondNumberText);

// pajautāt lietotājam 3šo skaitli
Console.WriteLine("Lūdzu, ievadi trešo skaitli");
// sagaidīt lietoja 3šā skaitļa ievadi
string thirdNumberText = Console.ReadLine();
int thirdNumber = int.Parse(thirdNumberText);

// pajautāt lietotājam 4to skaitli
Console.WriteLine("Lūdzu, ievadi ceturto skaitli");
// sagaidīt lietoja 4tā skaitļa ievadi
string fourNumberText = Console.ReadLine();
int fourthNumber = int.Parse(fourNumberText);

// pirmais max cipars
int firstMaxNumber = Math.Max(firstNumber, secondNumber);
// otrais max cipars
int secondMaxNumber = Math.Max(thirdNumber, fourthNumber);
// trešais max cipars
int maxNumber = Math.Max(firstMaxNumber, secondMaxNumber);

Console.WriteLine("-------------------------------------------------------------------");

// max ciparu parādīt
string maxNumberText = userName + ", vai Tu zini, ka no Taviem nosauktajiem skaitļiem maksimālais skaitlis ir";
Console.WriteLine(maxNumberText);
Console.WriteLine(maxNumber);

// pirmais min cipara aprēkins
int firstMinNumber = Math.Min(firstNumber, secondNumber);
int secondMinNumber = Math.Min(thirdNumber, fourthNumber);
int minNumber = Math.Min(firstMinNumber, secondMinNumber);

// min ciparu parādīt
string minNumberText = ", vai Tu zini, ka no Taviem nosauktajiem skaitļiem minimālais skaitlis ir";
Console.WriteLine(minNumberText);
Console.WriteLine(minNumber);

Console.WriteLine();
Console.WriteLine("============================================================================");
Console.WriteLine();

// atrādīt dalījuma atlikumu
string userGreeting4 = userName + ", vēlos Tev vēl pajautāt uzdot jautājumu. " +
    "Iedomājies skaitli no 10 līdz 20 ," +
    "pieņemsim, ka tas ir ābolu daudzums.";
Console.WriteLine(userGreeting4);
Console.WriteLine("Lūdzu, ievadi šo skaitli");
string aplleNumberText = Console.ReadLine();
int aplleNumber = int.Parse(aplleNumberText);

string userGreeting5 = userName + ", un tagd iedomājies skaitli no 2 līdz 5," +
    " pieņemsim, ka tas ir grozu daudzums, kuros vienādi jāsaliek āboli.";
Console.WriteLine(userGreeting5);
Console.WriteLine("Lūdzu, ievadi šo skaitli");
string basketNumberText = Console.ReadLine();
int basketNumber = int.Parse(basketNumberText);

string divide1 = "tad katrā grozā var ielikt";
int apleinBasket1 = aplleNumber / basketNumber;
string divide2 = "ābolus, bet pāri paliks";
int apleinBasket2 = aplleNumber % basketNumber;
string divide3 = "ābols";

Console.WriteLine(divide1);
Console.WriteLine(apleinBasket1);
Console.WriteLine(divide2);
Console.WriteLine(apleinBasket2);
Console.WriteLine(divide3);

Console.WriteLine();
Console.WriteLine("============================================================================");
Console.WriteLine();

// pāra vai nepāra skaitlis
string greeting6 = "Labi, " + userName + ", nākamais jautājums";
Console.WriteLine(greeting6);

Console.WriteLine("Lūdzu, iedomājies vēl vienu skaitli");
string oddorEvenNumberText = Console.ReadLine();
int oddorEvenNumber = int.Parse(oddorEvenNumberText);

bool isEven = oddorEvenNumber % 2 == 0;
Console.WriteLine("skaitlis ir pāra skaitlis = " + isEven);
bool isOdd = oddorEvenNumber % 2 != 0;
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

string triagleResult = "trīstūra laukums ir";
Console.WriteLine(triagleResult);

double triangleArea = triangleEdge1 * triangleEdge2 / 2;
Double triangleAreaRounded = Math.Round(triangleArea, 2);
Console.WriteLine(triangleAreaRounded);

Console.WriteLine();
Console.WriteLine("============================================================================");
Console.WriteLine();

// Interpolācija
Console.WriteLine("Lūdzu ievadi savu dzimšanas mēnesi (vārdiem)");
string birthMonth = Console.ReadLine();
Console.WriteLine("Lūdzu, ievadi savu dzimšanas datumu");
string birthDate = Console.ReadLine();

Console.WriteLine($"Tavs dzimšanas datums ir {userBirthYear} gada, {birthDate}. {birthMonth}");

Console.WriteLine();
Console.WriteLine("============================================================================");
Console.WriteLine();

string thanks = userName + ", liels paldies,";
string thanks2 = "un foršu dienu :)!";

Console.WriteLine(thanks);
Console.WriteLine(thanks2);
