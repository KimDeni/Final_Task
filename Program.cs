string[] CreateNewArray(string []array){

    int counter = 0;

    for(int i = 0; i < array.Length; i++){
        if(array[i].Length <= 3){
            counter++;
        }
    }
    string[] newArrey = new string[counter];

    return newArrey;
}

string[] array = {"hello", "2", "world", ":-)", "hi", "help", "good", "we"};
string[] newArr = CreateNewArray(array);