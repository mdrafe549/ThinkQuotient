//Created By Sayed Md Rafe
// C# program to find third Largest element in an array


using System;
class GFG {

static void thirdLargest(int[] arr, int arr_size)
{
	/* There should be atleast three elements */
	if (arr_size < 3)
	{
		Console.Write(" Invalid Input ");
		return;
		
	}

	int first = arr[0], second = int.MinValue,third = int.MinValue;

	// Traverse array elements to find the third Largest
	for (int i = 1; i < arr_size; i++)
	{
		
		if (arr[i] > first) {
			third = second;
			second = first;
			first = arr[i];
		}
		
	
		else if (arr[i] > second) {
			third = second;
			second = arr[i];
		}
		
		else if (arr[i] > third) {
			third = arr[i];
		}
	}

	Console.Write("The Third Largest element is : "+ third);
}

public static void Main() {
		int[] arr = {12, 13, 1, 10, 34, 16};
		int n = arr.Length;
		thirdLargest(arr, n);
	}
}

