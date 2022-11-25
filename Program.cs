#nullable disable


// объявляем два массива: один для ввода, второй для вывода
string[] arr = ArrInput();
string[] res = ResMethod(arr, 3);

//массив строк ввод
string[] ArrInput() {
    Console.Write("Постарайтесь ввести слова и/или цифры через пробел: ");
    return Console.ReadLine().Split(" ");
}

Console.Write($"[{string.Join(", ", arr)}] -> [{string.Join(", ", res)}]");

string[] ResMethod(string[] input, int b) {
    string[] output = new string[CountMethod(input, b)];

    for(int i = 0, a = 0; i < input.Length; i++) {
        if(input[i].Length <= b) {
            output[a] = input[i];
            a++;
        }
    }

    return output;
}
// счетчик
int CountMethod(string[] input, int b) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= b) {
            count++;
        }
    }

    return count;
}



