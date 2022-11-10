string [] array1 = {"adsfsdfsdfsdf", "asdasffas", "afs", "as", "1", "10", "a1f"};

string [] DelString (string[] array)
{
    int newLength = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i].Length <= 3) {newLength += 1;}
    }

    string [] newArray = new string [newLength];
    int j = 0;
    for (int n = 0; n < array.Length; n ++)
    {
        if (array[n].Length <= 3) 
        {
            newArray[j] = array[n];
            j += 1;
        }
    }

    return newArray;
}


void PrintArray (string [] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i ++)
    {
        Console.Write(array[i] + ", ");
    }
}


string[] newArr = DelString(array1);
PrintArray(newArr);
