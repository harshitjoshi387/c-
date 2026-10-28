// int[] arr={1,2,3,4};

// for(int i=0;i<arr.Length;i++){
//     Console.WriteLine(arr[i]);
// }

Console.WriteLine("enter the size of the array");
int s = int.Parse(Console.ReadLine());

int [] arr=new int[s];

for(int i=0;i<arr.Length;i++){
    Console.Write("enter number "+(i+1)+ ":");
    arr[i]=int.Parse(Console.ReadLine());
}

int sum=0;
for(int i=0; i<arr.Length;i++){
    sum +=arr[i];
}
Console.WriteLine("Sum = "+sum);
Console.WriteLine("Average ="+ (double)sum/arr.Length);