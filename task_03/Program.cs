int n = 10; 
int[] array = {2,5,7,9,11,43,12,45,78,99};
int i = 0;

while (i < n){
    if (array[i] % 2 == 0){
      Console.Write($"{array[i]} ");
    }
    i++;
}