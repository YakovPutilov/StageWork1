//string[] stringMassive = ["Hello","2", "world", ":-)"];

string [] ReadStringArr(int leng){
    string[] newarr = new string [leng];
    for(int i=0; i<leng; i++){
    Console.WriteLine("Enter string #"+(i+1)+":");
    newarr[i] = Console.ReadLine();
    }
    return newarr;
}

void ShowArray(string[] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write(array[i]+", ");
    }
}
int Counter3letter(string[] arr){
    int count = 0;
    for(int i = 0; i<arr.Length; i++){
        if(arr[i].Length<=3){
            count++;
        }
    }
    return count;
}

string[] SelectString3(string[] arr, int count){
    string[] newarr = new string [count];
    int j = 0;
    for(int i = 0; i<arr.Length; i++){
        if(arr[i].Length<=3){
            newarr[j] = arr[i];
            j++;
        }
       
    }
    return newarr;
}

Console.WriteLine("Enter array size: ");
int leng = Convert.ToInt32(Console.ReadLine());
string [] stringMassive = ReadStringArr(leng);

int count = Counter3letter(stringMassive);
Console.WriteLine("______");
if (count>0){
    string [] ansArr = SelectString3(stringMassive, count);
    ShowArray(ansArr);
    Console.WriteLine(" ");
}
else{
    Console.WriteLine("' '");
}    