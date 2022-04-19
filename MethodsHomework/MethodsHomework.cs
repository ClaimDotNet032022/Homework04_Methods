
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsHomework
{
    [TestClass]
    public class MethodsHomework
    {
        [TestMethod]
        public void WritingMethods()
        {
            //READ ME
            // This test "WritingMethods is all about you taking the contracts below and
            // writing the methods needed to satisfy them.
            // You are NOT allowed to change any code in here at all. 
            // You are only allowed to write methods in the YourAnswers class below.


            YourAnswers.DoNothing();

            int shouldBe25 = YourAnswers.ReturnIntWithValue25();
            Grading.ReturnIntWithValue25(shouldBe25);

            int shouldBeAdded = YourAnswers.AddTwoNumbers(6, 10);
            Grading.AddTwoNumbers(shouldBeAdded);

            int valueToBeIncremented = 6;
            int incremented = YourAnswers.IncrementMe(valueToBeIncremented);
            Grading.IncrementMe(incremented);

            int valueToBeDecremented = 6;
            int decremented = YourAnswers.DecrementMe(valueToBeDecremented);
            Grading.DecrementMe(decremented);

            double valueToBeCasted = 27.6;
            int casted = YourAnswers.CastDoubleToInt(valueToBeCasted);
            Grading.CastDoubleToInt(casted);

            int valueToBeConverted = 19;
            double converted = YourAnswers.ConvertIntToDouble(valueToBeConverted);
            Grading.ConvertIntToDouble(converted);

            double valueToBeCastedIntoString = 27.6;
            string castedString = YourAnswers.CastMeIntoAString(valueToBeCastedIntoString);
            Grading.CastMeIntoAString(castedString);

            string valueToBeParsed = "27.6";
            double parsed = YourAnswers.ParseMeIntoADouble(valueToBeParsed);
            Grading.ParseMeIntoADouble(parsed);

            int max = YourAnswers.ReturnMaxIntValue();
            Grading.ReturnMaxIntValue(max);

            bool amITrue = YourAnswers.CheckIfIAmTrue(false);
            Grading.CheckIfIAmTrue(amITrue);

            int positiveAndEven = 2;
            bool result = YourAnswers.ReturnTrueOnlyIfIamBothPositiveAndEven(positiveAndEven);
            Grading.ReturnTrueOnlyIfIamBothPositiveAndEvenTrue(result);

            int positiveAndOdd = 3;
            result = YourAnswers.ReturnTrueOnlyIfIamBothPositiveAndEven(positiveAndOdd);
            Grading.ReturnTrueOnlyIfIamBothPositiveAndEvenFalse(result);

            int negativeAndEven = -2;
            result = YourAnswers.ReturnTrueOnlyIfIamBothPositiveAndEven(negativeAndEven);
            Grading.ReturnTrueOnlyIfIamBothPositiveAndEvenFalse(result);

            int negativeAndOdd = -3;
            result = YourAnswers.ReturnTrueOnlyIfIamBothPositiveAndEven(negativeAndOdd);
            Grading.ReturnTrueOnlyIfIamBothPositiveAndEvenFalse(result);

            int[] array = { 4, 5, 6, 8, 12, 17 };
            // Sum means to add the contents of the array all together.
            int sum = YourAnswers.SumTheContentsOfTheArray(array);
            Grading.SumTheContentsOfTheArray(sum);

            int[] array3 = { 4, 5, 6, 8, 12, 17 };
            int value = YourAnswers.GetThirdValue(array3);
            Grading.GetThirdValue(value);

            int length = YourAnswers.GetLengthOfArray(array3);
            Grading.GetLengthOfArray(length);

            int[] array4 = { 3, 3, 3, 3, 3, 3 };
            bool allValuesAre3 = YourAnswers.CheckAllValuesAre3(array4);
            Grading.CheckAllValuesAre3(allValuesAre3);

            int[] arraySwapped = YourAnswers.SwapFirstValueWithLastValue(array3);
            Grading.SwapFirstValueWithLastValue(arraySwapped);

        }

        [TestMethod]
        public void UsingMethods()
        {
            //READ ME
            // This test "UsingMethods" is all about discovering Methods on types you already know about.
            // This will help you learn to read Method contracts and use them appropriately.
            // This WILL require research of the types you are being asked about. You have not
            // seen many of them in class. Its important to be able to research a method youve not
            // seen before but need to use.
            // In this section you are allowed to add code that calls the necessary methods, but
            // do NOT change any of the existing code.
            List<int> ages = new List<int> { 15, 27, 43, 12, 19, 51 };

            // Find a method to reverse this list of ages.
            // hint, uses the dot operatore on ages. like ages.SomeMethod()
            
            ages.Reverse();
            
            Grading.ListIsReversed(ages);

            // find a method to add a value to the list ages at the end.
            int addMeIntoList = 12;
            ages.Add(addMeIntoList);
            
            Grading.TwelveWasAdded(ages);

            // find a method to add a value to the list at the front of the list ages, ie, the start of it, or first value.
            int addMeToTheListAtTheVeryFront = 1;
            ages.Insert(0, addMeToTheListAtTheVeryFront);
            Grading.OneWasAddedToTheFront(ages);

            // find a method to clear the list ages.
            ages.Clear();
            Grading.AgesIsNowEmpty(ages);

            // find a method to check if the double amount is negative.

            double amount = 29.3;
            // you must capture the result of the found method;
            bool isNegative = double.IsNegative(amount);
            Grading.AmountIsNotNegative(isNegative);

            // Find a method to tell you if the sentence contains the work fox
            string sentence = "The quick brown fox.";
            // you must capture the result of the found method;
            bool doesContaintFox = sentence.Contains("fox");
            Grading.ContainsFox(doesContaintFox);

            // Find a method to replace the word quick, with the word slow
            // you must capture the result of the found method;
            
            string newSentence = sentence.Replace("quick", "slow");
            Grading.ReplacedTheWord(newSentence);

            // Find a method to Convert this word to lowercase;
            string word = "UPPER";
            // you must capture the result of the found method;
            string lowered = word.ToLower();
            Grading.StringWasLowercased(lowered);

            // Find a method to Convert this word to lowercase;
            string needsSplit = "I,Need,These,Separate";
            // you must capture the result of the found method;
            string[] split = needsSplit.Split(",");
            Grading.StringWasSplit(split);

            

            // I hope by now you see the power of what the types already do for you.
        }
    }

    public class YourAnswers
    {
        //READ ME
        // You write all your methods here.

        public static void DoNothing() { }
        
        public static int ReturnIntWithValue25() { return 25; }

        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        public static int IncrementMe(int valueToBeIncremented)
        {
            int Incremented = ++valueToBeIncremented;
            return Incremented;
        }

        public static int DecrementMe(int valueToBeDecremented)
        {
            int Decremented = --valueToBeDecremented;
            return Decremented;
        }

        public static int CastDoubleToInt(double valueToBeCasted)
        {
            int casted = ((int) (valueToBeCasted));
            return casted;
        }

        public static double ConvertIntToDouble(int valueToBeConverted)
        {
            return Convert.ToDouble(valueToBeConverted);
        }

        public static string CastMeIntoAString(double valueToBeCastedIntoString)
        {
            string castedString = valueToBeCastedIntoString.ToString();
            return castedString;
        }

        public static double ParseMeIntoADouble(string valueToBeParsed)
        {
            double parsed = Convert.ToDouble(valueToBeParsed);
            return parsed;
        }

        public static int ReturnMaxIntValue(int max = 2147483647)
        {
            return max;
        }

        public static bool CheckIfIAmTrue(bool amITrue)
        {
            return amITrue;
        }
        
        public static bool ReturnTrueOnlyIfIamBothPositiveAndEven(int positiveAndEven)
        {
            if(positiveAndEven > 0 && positiveAndEven % 2 == 0)
            {
               return true;
            }
            else 
            { 
                return false; 
            }

        }

        public static int SumTheContentsOfTheArray(int[] array)
        {
            return array.Sum();            
        }

        public static int GetThirdValue(int[] array3)
        {
            return array3[2];
        }

        public static int GetLengthOfArray(int[] array3)
        {
            return array3.Length;
        }

        public static bool CheckAllValuesAre3(int[] array4)
        {
            foreach (int value in array4)
            {
                if (value != 3)
                {
                    return false;
                }

            }
            return true;
        }
        
        public static int[] SwapFirstValueWithLastValue(int[] array3)
        {
            int x = array3[0];
            int y = array3[5];
            array3[0] = y;
            array3[5] = x;
            return array3;
        }


       


    }




    public class Grading
    {
        // Don't change anything in the Grading block.

        static public void AddTwoNumbers(int result)
        {
            Assert.IsTrue(result == 16);
        }

        static public void ReturnIntWithValue25(int result)
        {
            Assert.IsTrue(result == 25);
        }

        static public void CastDoubleToInt(int result)
        {
            Assert.IsTrue(result == 27);
        }

        static public void ConvertIntToDouble(double result)
        {
            Assert.IsTrue(result == 19.0d);
        }

        static public void IncrementMe(int result)
        {
            Assert.IsTrue(result == 7);
        }

        static public void DecrementMe(int result)
        {
            Assert.IsTrue(result == 5);
        }

        static public void CastMeIntoAString(string result)
        {
            Assert.IsTrue(result == "27.6");
        }
        static public void ParseMeIntoADouble(double result)
        {
            Assert.IsTrue(result == 27.6);
        }

        static public void ReturnMaxIntValue(int result)
        {
            Assert.IsTrue(result == int.MaxValue);
        }

        static public void CheckIfIAmTrue(bool result)
        {
            Assert.IsTrue(result == false);
        }

        static public void ReturnTrueOnlyIfIamBothPositiveAndEvenTrue(bool result)
        {
            Assert.IsTrue(result == true);
        }

        static public void ReturnTrueOnlyIfIamBothPositiveAndEvenFalse(bool result)
        {
            Assert.IsTrue(result == false);
        }


        static public void SumTheContentsOfTheArray(int result)
        {
            Assert.IsTrue(result == 52);
        }

        static public void GetThirdValue(int result)
        {
            Assert.IsTrue(result == 6);
        }

        static public void GetLengthOfArray(int length)
        {
            Assert.IsTrue(length == 6);
        }

        static public void CheckAllValuesAre3(bool result)
        {
            Assert.IsTrue(result);
        }

        static public void SwapFirstValueWithLastValue(int[] array)
        {
            Assert.IsTrue(array[0] == 17);
            Assert.IsTrue(array[array.Length - 1] == 4);
        }

        static public void ListIsReversed(List<int> list)
        {
            List<int> reversed = new List<int> { 51, 19, 12, 43, 27, 15 };
            Assert.IsTrue(list.SequenceEqual(reversed));
        }

        static public void TwelveWasAdded(List<int> list)
        {
            Assert.IsTrue(12 == list[list.Count - 1]);
        }

        static public void OneWasAddedToTheFront(List<int> list)
        {
            Assert.IsTrue(list[0] == 1);
            Assert.IsTrue(list.Count == 8);
        }

        static public void AgesIsNowEmpty(List<int> list)
        {
            Assert.IsTrue(list.Count == 0);
        }

        static public void AmountIsNotNegative(bool result)
        {
            Assert.IsFalse(result);
        }
        static public void ContainsFox(bool result)
        {
            Assert.IsTrue(result);
        }

        static public void ReplacedTheWord(string replaces)
        {
            string sentence = "The slow brown fox.";
            Assert.IsTrue(replaces == sentence);
        }

        static public void StringWasLowercased(string replaces)
        {
            Assert.IsTrue(replaces == "upper");
        }

        static public void StringWasSplit(string[] replaces)
        {
            string[] split = { "I", "Need", "These", "Separate" };
            Assert.IsTrue(replaces.SequenceEqual(split));
        }

    }
}
