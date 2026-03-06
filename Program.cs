using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        //1. 큐 생성 (문자열을 담는 큐)
        Queue<string> printerQueue = new();

        //2. 문서 추가 (Enqueue)
        printerQueue.Enqueue("보고서.pdf");
        printerQueue.Enqueue("사진.jpg");
        printerQueue.Enqueue("발표자료.pptx");

        Console.WriteLine($"현재 대기 중인 문서 수: {printerQueue.Count}");
        Console.WriteLine($"첫 번째 문서: {printerQueue.Peek()}");

        //3. 문서 출력 (Dequeue)
//        while (printerQueue.Count > 0)
//        {
//            string currentDoc = printerQueue.Dequeue();
//            Console.WriteLine($"현재 출력 중인 문서: {currentDoc}");
//        }

        Console.WriteLine($"현재 대기 중인 문서 수: {printerQueue.Count}");

        // 4. 큐 순회 (foreach)
        Console.WriteLine("\n--- 큐 순회 ---");
        foreach (string doc in printerQueue)
        {
            Console.WriteLine(doc);
        }

        Console.WriteLine($"현재 대기 중인 문서 수: {printerQueue.Count}");

        // 5. 큐 비우기 (Clear)
        //printerQueue.Clear();
        //Console.WriteLine($"현재 대기 중인 문서 수: {printerQueue.Count}");

        // 6. 큐에 요소가 있는지 확인 (Contains)
        // Console.WriteLine($"'사진.jpg'가 큐에 있나요? {printerQueue.Contains("사진.jpg")}");

        // 다차원 배열, 가변 배열 (Jagged Array)
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        Console.WriteLine($"전체 배열의 길이 : {jaggedArray.Length}");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine($"배열 {i}의 길이 : {jaggedArray[i].Length}");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }

        Hashtable ht = new Hashtable();
        ht["book"] = "책";
        ht["pen"] = "펜";
        ht["apple"] = "사과";

        Console.WriteLine(ht["apple"]);
    }
}

