
using CodeStepByStep_CSharp.Basics;
using CodeStepByStep_CSharp.Arrays;
using CodeStepByStep_CSharp.Classes_and_Object;
using CodeStepByStep_CSharp.Classes_and_Object.Model;

/*     BASICS   
//NumberLoops.DisplayLoopOutput();
//EvenAverage.FindEvenNumberAverage();
//EvenSumMax.EvenSum();
//FearTheTree.DisplayTree();
//InchesToCentimeters.ConvertInchesToCentimeters();
//NumberSquare.DisplayNumberSquare(1, 5);
//PercentageGrade.ShowPercentageGrade();
//PrintProgram.DisplayPrintProgram();
//PrintTriangle.DisplayTriangle();
//Receipt.CalculateTotalReceipt();
//Receipt2.ComputeTotalMealCost();
//StanfordVsCal.StanforVsCal();
*/

/*     ARRAYS    
//ArrayMystery.Mystery(new int[] { 7, 3, 2, 0, 5 });
//Banish.BanishArrayNumbersRefactored(new int[] { 42, 3, 9, 42, 42, 0, 42, 9, 42, 42, 17, 8, 2222, 4, 9, 0, 1 }, new int[] { 42, 2222, 9 });
//CollapsePairs.RunCollapsePairs(new int[] { 7, 2, 8, 9, 4, 22, 7, 1, 9, 10 });
//Collapse.RunCollapse(new int[] { 7, 2, 8, 9, 4, 13, 7, 1, 9, 10 });
//Collapse.RunCollapse(new int[] { 7, 2, 8, 9, 4, 13, 7, 1, 9 });
//ComputeAverage.RunComputeAverage(new int[] { 1, -2, 4, -4, 9, -6, 16, -8, 25, -10 });
//Console.WriteLine(Contains.RunContains(new int[] { 1, 6, 2, 1, 4, 1, 2, 1, 8 }, new int[] { 1, 2, 1 }));
//Console.WriteLine(Contains.RunContains(new int[] { 1, 6, 2, 1, 4, 1, 2, 1, 8 }, new int[] { 1, 2, 2 }));
//CountDuplicates.RunCountDuplicate();
//Console.WriteLine($"Number of unique #'s: {CountUnique.CountUniqueNumbers(new int[] { 7, 7, 2, 2, 1, 2, 2, 7 })}");
//EvenBeforeOdd.RunEvenBeforeOdd(new int[] { 5, 2, 4, 9, 3, 6, 2, 1, 11, 1, 10, 4, 7, 3 });
//EvenBeforeOdd.RunEvenBeforeOdd(new int[] { 5, 2, 4, 9, 3, 6, 2, 1, 11, 1, 10, 4, 7, 3 });
//EvenBeforeOdd.RunEvenBefore Odd(new int[] { 1, 1, 1, 1, 1, 1, 1, 1 });
//EvenBeforeOdd.RunEvenBeforeOdd(new int[] { 2, 2, 2, 2, 2, 2, 2, 2 });
//Console.WriteLine($"Number in the middle of the array is: {FindMedian.RunFindMedian(new int[] { 5, 2, 4, 17, 55, 4, 3, 26, 18, 2, 17 })}");
//Console.WriteLine($"Number in the middle of the array is: {FindMedian.RunFindMedian(new int[] { 42, 37, 1, 97, 1, 2, 7, 42, 3, 25, 89, 15, 10, 29, 27 })}");
//Console.WriteLine($"The range between the smallest/largest #s is: {FindRange.RunFindRange(new int[] { 7 })}");
//Console.WriteLine($"The range between the smallest/largest #s is: {FindRange.RunFindRange(new int[] { 7,  9, 15, 17, 6 })}");
//Console.WriteLine($"The percentage of even #'s in the array is: {GetPercentEven.RunGetPercentEven(new int[] {6, 4, 6, 2, 9, 11, 5})}");
//int[] a1 = { 8, 9, 2, 1};
//int[] a2 = { 5, 7, 1, 2, 9, 8 };
//Console.WriteLine($"The values from array 2 reversed appear in the original array at least 2 times: {HasMirrorTwice.RunHasMirrorTwice(a1, a2)}");
//IndexOf.RunIndexOf();
//int[] array = { 3, 8, 10, 1, 9, 14, -3, 0, 14, 207, 56, 98, 12 };
//int[] array = { 17, 42, 3, 5, 5, 5, 8, 2, 4, 6, 1, 19 };
//int[] array = { };
//int[] array = { 1 };
//int[] array = { 10, 8, 7, 3, 2, 1 };
//Console.WriteLine($"Longest sorted values in array: {LongestSortedSequence.RunLongestSortedSequence(array)}");
//int[] array = { 8 };
//int[] array = { 17, 7, -1, 26, 3, 9 };
//Console.WriteLine($"Max value of array: {MaxValue.RunMaxValue(array)}");
//double[] array = { 2.0, 4.5, 6.5, 1.0 };
//double[] array = { };
//Console.WriteLine($"Mean of array: {Mean.RunMean(array)}");
//int[] array = { 3, 5, 0, 2, 2, -7, 0, 4 };
//NCopies.RunNCopies(array);
//int[] list = { 5, 7, 7, 7, 8, 22, 22, 23, 31, 35, 35, 40, 40, 40, 41 };
//int[] list = { 1, 2, 11, 17, 19, 20, 23, 24, 25, 26, 31, 34, 37, 40, 41 };
//int[] list = { }; 
//Console.WriteLine($"Unique values in array: {NumUnique.RunUnique(list)}");
//int[] array = {32, 5, 27, -3, 2598};
//PrintArrayElements.Print(array);
//string[] a = {"Madam", "raceCAR", "", "hi", "A", "Abba", "banana", "dog God", "STOP otto POTS", "Madame", "C#", "LevEL", "staTS"};
//RemovePalindromes.RunRemovePalindromes(a);
//Sieve.RunSieve();
//double[] list = { 1.5 };
//double[] list = { 1.5, 4.3, 7.0, 19.5, 25.1, 46.2 };
//double[] list = { 1.5, 4.3, 50.2, 7.0, 19.5, 25.1, 46.2 };
//double[] list = { 90.1, 1.5, 4.3, 50.2, 7.0, 19.5, 25.1, 46.2 };
//Console.WriteLine($"List is sorted: {Sorted.RunSorted(list)}");
//int[] list = { 18, 7, 4, 24, 11 };
//Split.RunSplit(list);
//Squared.RunSquared();
//string[] a = { "a", "bb", "c", "ddd", "ee", "f", "g" };
//string[] a = { "a", "bb", "c", "ddd", "ee", "f", "g", "h" };
//SwitchPairs.RunSwitchPairs(a);
*/

/* Classes and Object */

/* Bank Account
BankAccountModel jeffAccount = new BankAccountModel("jeff Checking Account");
BankAccount.Deposit(90.00M, jeffAccount);

BankAccountModel stephAccount = new BankAccountModel("Stephanie Checking Account");
BankAccount.Deposit(25.00M, stephAccount);

Console.WriteLine(jeffAccount.ToString());
Console.WriteLine(stephAccount.ToString());
BankAccount.Transfer(20.00M, jeffAccount, stephAccount);
BankAccount.Transfer(10.00M, jeffAccount, stephAccount);
BankAccount.Transfer(-1.00M, jeffAccount, stephAccount);
BankAccount.Transfer(39.00M, stephAccount, jeffAccount);
BankAccount.Transfer(50.00M, stephAccount, jeffAccount);
BankAccount.Transfer(1.00M, stephAccount, jeffAccount);
BankAccount.Transfer(88.00M, jeffAccount, stephAccount);
BankAccount.Transfer(1.00M, jeffAccount, stephAccount);
Console.WriteLine(jeffAccount.ToString());
Console.WriteLine(stephAccount.ToString());
*/

Circle circle = new Circle(2.0);
Console.WriteLine(circle.ToString());
