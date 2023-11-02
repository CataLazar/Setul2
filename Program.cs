// 1.  Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
// 2.  Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
// 3.  Calculati suma si produsul numerelor de la 1 la n. 
// 4.  Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar a. Se considera ca primul element
//     din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
// 5.  Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element
//     din secventa este pe pozitia 0. 
// 6.  Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
// 7.  Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
// 8.  Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: 
//     f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
// 9.  Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton
//     descrescatoare. 
// 10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
// 11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
// 12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup
//     ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0
//     raspunsul este 3. 
// 13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata
//     intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se
//     muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o
//     secventa crescatoare rotita. 
// 14. O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona
//     prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. 
// 15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator.
//     De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
// 16. O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica
//     prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se 
//     determine daca este o secventa bitonica rotita. 
// 17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca 
//     secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a 
//     parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este 
//     incorecta. 010100010110110100100111 

namespace Setul2{
    class Setul2{
        public static void Main(){
            int a, b;

            Console.WriteLine("------------- Ex1");
            Console.WriteLine("This method counts all even numbers in a series");
            a = getUserInput("how many numbers to read");
            evenNumbersEx1(a);

            Console.WriteLine("------------- Ex2");
            Console.WriteLine("This method counts all positive, negative and zero numbers in a series");
            a = getUserInput("how many numbers to read");
            signedNumbersEx2(a);

            Console.WriteLine("------------- Ex3");
            Console.WriteLine("This method calculates the sum and product of the first n numbers (WARNING: DO NOT USE HIGH NUMBERS)");
            a = getUserInput("up to which number to execute operations");
            sumAndProductEx3(a);

            Console.WriteLine("------------- Ex4");
            Console.WriteLine("This method finds the position of a number within a series");
            a = getUserInput("how many numbers to read");
            b = getUserInput("number to find");
            findPositionEx4(a, b);

            Console.WriteLine("------------- Ex5");
            Console.WriteLine("This method counts all numbers that are equal to their position in a series");
            a = getUserInput("how many numbers to read");
            equalToPositionEx5(a);

            Console.WriteLine("------------- Ex6");
            Console.WriteLine("This method determines whether a series is in rising order");
            a = getUserInput("how many numbers to read");
            risingSeriesEx6(a);

            Console.WriteLine("------------- Ex7");
            Console.WriteLine("This method finds the maximum and minimum in a series");
            a = getUserInput("how many numbers to read");
            minMaxEx7(a);

            Console.WriteLine("------------- Ex8");
            Console.WriteLine("This method calculates Fibonacci's series");
            a = getUserInput("number to calculate Fibonacci for");
            System.Console.WriteLine("Fibonacci(" + a + ") = " + fibonacciEx8(a));

            Console.WriteLine("------------- Ex9");
            Console.WriteLine("This method determines the monotony of a series");
            a = getUserInput("how many numbers to read");
            monotoneSeriesEx9(a);

            Console.WriteLine("------------- Ex10");
            Console.WriteLine("This method finds the longest sequence of identical numbers in a series");
            a = getUserInput("how many numbers to read");
            identicalSeriesEx10(a);

            Console.WriteLine("------------- Ex11");
            Console.WriteLine("This method calculates the sum of the inverse of all numbers up to n");
            a = getUserInput("how many numbers to read");
            inverseTotalEx11(a);

            Console.WriteLine("------------- Ex12");
            Console.WriteLine("This method counts all the non-zero sequences in a series");
            a = getUserInput("how many numbers to read");
            nonZeroSequencesEx12(a);

            Console.WriteLine("------------- Ex13");
            Console.WriteLine("This method determines whether a series can be in rising order by rotating it");
            a = getUserInput("how many numbers to read");
            rotatedRisingSeriesEx13(a);

            Console.WriteLine("------------- Ex14");
            Console.WriteLine("This method determines whether a series can be monotonous by rotating it");
            a = getUserInput("how many numbers to read");
            rotatedMonotoneSeriesEx14(a);

            Console.WriteLine("------------- Ex15");
            Console.WriteLine("This method determines whether a series is bitonic (rising then descending)");
            a = getUserInput("how many numbers to read");
            bitonicSeriesEx15(a);

            Console.WriteLine("------------- Ex16");
            Console.WriteLine("This method determines whether a series can be bitonic by rotating it");
            a = getUserInput("how many numbers to read");
            rotatedBitonicSeriesEx16(a);

            Console.WriteLine("------------- Ex17");
            Console.WriteLine("This method determines whether a string of parentheses (0 is open, 1 is closed) is valid");
            a = getUserInput("how many numbers to read");
            parenthesesEx17(a);
        }

        /// <summary>
        /// Get an integer as input from the user
        /// </summary>
        public static int getUserInput(string variableName){
            Console.Write("Enter a value for '" + variableName + "': ");
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Counts the even numbers inputted by the user
        /// </summary>
        public static void evenNumbersEx1(int n){
            int count = 0;
            for(int i = 1; i <= n; i++){
                System.Console.Write("Enter number #" + i + ": ");
                if (int.Parse(Console.ReadLine()) % 2 == 0)
                    count++;
            }
            System.Console.WriteLine("Even numbers inputted: " + count);
        }

        /// <summary>
        /// Counts all the positive/negative/zero numbers inputted by the user
        /// </summary>
        public static void signedNumbersEx2(int n){
            int countPos = 0, countNeg = 0, countZero = 0, input;
            for(int i = 1; i <= n; i++){
                System.Console.Write("Enter number #" + i + ": ");
                input = int.Parse(Console.ReadLine());
                if (input > 0)
                    countPos++;
                else if (input < 0)
                    countNeg++;
                else if (input == 0)
                    countZero++;
            }
            System.Console.WriteLine("Positive numbers inputted: " + countPos);
            System.Console.WriteLine("Negative numbers inputted: " + countNeg);
            System.Console.WriteLine("Zeroes inputted: " + countZero);
        }

        /// <summary>
        /// Calculate the sum and product of first n numbers;
        /// high values will cause an overflow due to the factorial
        /// </summary>
        public static void sumAndProductEx3(int n){
            long prod = 1;
            System.Console.WriteLine("Sum of first " + n + "numbers: " + (long)(n*(n+1)/2));
            for(int i = 1; i <= n; i++)
                prod *= i;
            System.Console.WriteLine("Product of first " + n + " numbers: " + prod);
        }

        /// <summary>
        /// Find the number 'a' in a set of numbers inputted by the user
        /// </summary>
        public static void findPositionEx4(int n, int a){
            int position = -1;
            bool found = false;
            for(int i = 0; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                if(int.Parse(Console.ReadLine()) == a && !found){
                    position = i;
                    found = true;
                }
            }
            System.Console.WriteLine("Number " + a + " is on position " + position);
        }

        /// <summary>
        /// Count the numbers that are equal to their position in the set
        /// </summary>
        public static void equalToPositionEx5(int n){
            int count = 0;
            for(int i = 0; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                if(int.Parse(Console.ReadLine()) == i)
                    count++;
            }
            System.Console.WriteLine("There are " + count + " numbers whose value is equal to their position");
        }

        /// <summary>
        /// Determine whether a series is in rising order
        /// </summary>
        public static void risingSeriesEx6(int n){
            int prev, current;
            bool rising = true;
            System.Console.Write("Enter number on position 0: ");
            prev = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                current = int.Parse(Console.ReadLine());
                if(current < prev)
                    rising = false;
                prev = current;
            }
            System.Console.WriteLine("The sequence is" + (rising ? "" : " not") + " in rising order");
        }

        /// <summary>
        /// Find the minimum and maximum in a set of numbers
        /// </summary>
        public static void minMaxEx7(int n){
            int min = int.MaxValue, max = int.MinValue, input;
            for(int i = 0; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                input = int.Parse(Console.ReadLine());
                if(input < min)
                    min = input;
                if(input > max)
                    max = input;
            }
            System.Console.WriteLine("The minimum is " + min + ", the maximum is " + max);
        }

        /// <summary>
        /// Calculate Fibonacci's sum for n
        /// </summary>
        public static int fibonacciEx8(int n){
            if(n == 0)
                return 0;
            if(n == 1)
                return 1;
            return fibonacciEx8(n-1) + fibonacciEx8(n-2);

            // return [(1/√5) * ( (1 + √5)/2 )^n - (1/√5) * ( (1 - √5)/2 )^n]
        }

        /// <summary>
        /// Determine whether a series is monotone (either rising or descending)
        /// </summary>
        public static void monotoneSeriesEx9(int n){
            int prev, current;
            bool rising = true, descending = true;
            System.Console.Write("Enter number on position 0: ");
            prev = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                current = int.Parse(Console.ReadLine());
                if(current < prev)
                    rising = false;
                if(current > prev)
                    descending = false;
                prev = current;
            }
            System.Console.WriteLine("The sequence is in " + (rising ? "rising" : (descending) ? "descending" : "random") + " order");
        }

        /// <summary>
        /// Find the longest series of identical numbers
        /// </summary>
        public static void identicalSeriesEx10(int n){
            int maxLength = 0, currentLength = 1, prev, current;
            System.Console.Write("Enter number on position 0: ");
            prev = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                current = int.Parse(Console.ReadLine());
                if(current == prev)
                    currentLength++;
                else
                    currentLength = 1;
                if(currentLength > maxLength)
                    maxLength = currentLength;
                prev = current;
            }
            System.Console.WriteLine("The longest identical series is " + maxLength + " numbers long");
        }

        /// <summary>
        /// Calculate the total of the inverses of numbers up to n
        /// </summary>
        public static void inverseTotalEx11(int n){
            double total = 0;
            for(int i = 0; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                total += (double)1/double.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("The total of the inverses is " + total);
        }

        /// <summary>
        /// Counts the non-zero sequences in a given series of numbers ("1 3 5 0 5 1 0 4" would return 3)
        /// </summary>
        public static void nonZeroSequencesEx12(int n){
            int sequences = 0, prev, current;
            System.Console.Write("Enter number on position 0: ");
            prev = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                current = int.Parse(Console.ReadLine());
                if(prev != 0 && current == 0)
                    sequences++;
                if(i == n-1 && current != 0)
                    sequences++;
                prev = current;
            }
            System.Console.WriteLine("Total amount of non-zero sequences: " + sequences);
        }

        /// <summary>
        /// Determines whether a series can be rising by cycling its elements
        /// </summary>
        /// <param name="n"></param>
        public static void rotatedRisingSeriesEx13(int n){
            int prev, current, first, strikes = 0;                             // 1 strike allowed ("3, 4, -> *10, 1* <-" is a strike) 
            System.Console.Write("Enter number on position 0: ");
            prev = int.Parse(Console.ReadLine());
            first = prev;
            for(int i = 1; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                current = int.Parse(Console.ReadLine());
                if(current < prev)
                    strikes++;
                prev = current;
            }
            
            System.Console.WriteLine("The sequence is" + ((strikes == 1 && first > prev) ? "" : " not") + " a rotated rising series");
        }

        /// <summary>
        /// Determines whether a series can be monotone by cycling its elements
        /// </summary>
        public static void rotatedMonotoneSeriesEx14(int n){
            int prev, current, first, strikesDescending = 0, strikesRising = 0;           // 1 strike allowed ("3, 4, -> *10, 1* <-" is a strike) 
            System.Console.Write("Enter number on position 0: ");
            prev = int.Parse(Console.ReadLine());
            first = prev;
            for(int i = 1; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                current = int.Parse(Console.ReadLine());
                if(current < prev)
                    strikesRising++;
                if(current > prev)
                    strikesDescending++;
                prev = current;
            }
            System.Console.WriteLine("The sequence is" + ((strikesRising == 1 && first > prev) || (strikesDescending == 1 && first < prev) ? "" : " not") + " a rotated monotone series");
        }

        /// <summary>
        /// Determines whether a series is bitonic (starts by ascending, then descends at some point)
        /// </summary>
        public static void bitonicSeriesEx15(int n){
            int prev, current;
            bool descending = false, isBitonic = true;
            System.Console.Write("Enter number on position 0: ");
            prev = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                current = int.Parse(Console.ReadLine());
                if(current < prev)
                    descending = true;                  // done rising, time to descend
                if(descending && i == 1)
                    isBitonic = false;                  // no rising, just descending -> not bitonic
                if (descending && current > prev)
                    isBitonic = false;                  // rising again after starting to descend -> not bitonic
                prev = current;
            }
            if(!descending)
                isBitonic = false;                      // only rising, no descending -> not bitonic
            System.Console.WriteLine("The sequence is" + (isBitonic ? "" : " not") + " a bitonic series");
        }

        /// <summary>
        /// Determine whether a series can be bitonic by cycling its elements
        /// </summary>
        public static void rotatedBitonicSeriesEx16(int n){
            int prev, current, changes = 0;
            bool descending = false;
            System.Console.Write("Enter number on position 0: ");
            prev = int.Parse(Console.ReadLine());
            System.Console.Write("Enter number on position 1: ");
            current = int.Parse(Console.ReadLine());
            descending = current < prev;
            for(int i = 2; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                current = int.Parse(Console.ReadLine());
                if(current > prev){
                    if(descending)
                        changes++;
                    descending = false;
                }
                if(current < prev){
                    if(!descending)
                        changes++;
                    descending = true;
                }
                prev = current;
            }
            System.Console.WriteLine("The sequence is " + (changes == 2 ? "" : "not") + " a rotated bitonic series");
        }

        /// <summary>
        /// Determines whether a string of parentheses is correctly closed
        /// </summary>
        public static void parenthesesEx17(int n){
            int input, currentNest = 0, maxNest = 0;
            bool isValidNest = true;
            for(int i = 0; i < n; i++){
                System.Console.Write("Enter number on position " + i + ": ");
                input = int.Parse(Console.ReadLine());
                if(input == 0)
                    currentNest++;
                else if(input == 1)
                    currentNest--;
                else {
                    i--;
                    continue;
                }
                if(currentNest > maxNest)
                    maxNest = currentNest;
                if(currentNest < 0)
                    isValidNest = false;
            }
            if(isValidNest && currentNest == 0)
                System.Console.WriteLine("The parentheses string is valid, with a max nest of " + maxNest);
            else
                System.Console.WriteLine("The parentheses string is invalid");
        }

    }
}