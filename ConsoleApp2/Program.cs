

//int[] numbers2 = new int[4];
//int[] numbers3 = new int[4] { 6, 7, 8, 9};
//int[] numbers4 = new int[] { 10, 11, 12, 13 };
//int[] numbers = { 1, 2, 3, 4, 43};
//int sum = 0;
//for(int i=0;i<numbers.Length;i++)
//{
//    sum+=numbers[i];
//}
//string[] bb103 = { "Narmine", "Narmin", "Aysu" };


//for(int i=0;i<bb103.Length;i++)
//{
//    if(bb103[i]=="Aysu")
//    {
//        Console.WriteLine("Beli var");
//        Console.WriteLine("indexi " +i);
//        break;
//    }
//}

//string word = "Salam";
//string[] bb = { "Narmine", "Narmin", "Aysu",word };

//for(int i=word.Length-1;i>=0;i--)
//{
//    if(word[i]=='S')
//    {
//        continue;
//    }
//    Console.WriteLine(word[i]);
//}


//int[] arr = { 1, 4, 2, 5, 19, 45 };
//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//}
//Console.WriteLine(sum/arr.Length);


//int[,] arr = { 
//    { 1, 2, 3, 4 },
//    {5,6,7,8},
//};

//for(int i = 0; i < arr.GetLength(0); i++)
//{
//    for(int j=0;j<arr.GetLength(1);j++)
//    {
//        Console.WriteLine(arr[i,j]);
//    }
//}
//Console.WriteLine(arr.Rank);


int n = 17;
int donguSayi = 0;
if(n>2)
{
    bool check = false;
    for(int i=2;i*i<=n;i++)
    {
        donguSayi++;
        if(n%i==0)
        {
            check = true;
            break;
        }
    }
    if(check)
    {
        Console.WriteLine("murekkebdir");
    }
    else
    {
        Console.WriteLine("sadedir");
    }
    Console.WriteLine("Dongu sayi "+donguSayi);





}
else
{
    Console.WriteLine("ne sade nede murekkeb deyil");
}









