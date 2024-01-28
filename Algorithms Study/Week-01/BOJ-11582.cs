using System;
using System.Text;

/* 백준 11582번 : 치킨 TOP N (https://www.acmicpc.net/problem/11582)
 
 *입력
첫 번째 줄에 치킨집의 개수 N(4 ≤ N ≤ 220)이 주어진다. N은 항상 2의 거듭제곱 꼴이다.
두 번째 줄에는 N개의 치킨집의 맛의 수치들이 빈칸을 구분으로 주어지며 이 값은 10억보다 작거나 같은 자연수 또는 0이다.
세 번째 줄에는 현재 정렬을 진행중인 회원들의 수 k(1 ≤ k < N)가 주어진다. k 또한 2의 거듭제곱 꼴이다.

 *출력
현재 단계에서 k명이 정렬을 진행한다고 할 때, 현재 단계가 완료한 상태를 출력하라.
 */

//병합정렬인데 => 분할 끝나고 정렬하며 병합이 아니라,  분할 하고 정렬, 분할 하고 정렬, 을 반복하는 컨셉
//              => 그중에서도 k 번째 단계에서 빠져 나와서 출력 하는게 목표 

public class BOJ11582
{
	static int N ; //치킨 집의 갯수 N
	static int[] score=new int[N]; // 치킨집 맛의 점수
	static int k; //회원들의 수 k

	public static void Solution() //Main()
	{
        GetInput();
        Solve();
        PrintOut();
	}

    //입력부
	static void GetInput()
	{
        N = int.Parse(Console.ReadLine()!);
        score = new int[N];
        string[] input = Console.ReadLine()!.Split();
        for (int i = 0; i < input.Length; i++)
        {
            score[i] = int.Parse(input[i]);
        }
        k = int.Parse(Console.ReadLine()!);
    }

    static void Solve()
    {
        
        while (N > 1)
        {
            N /= 2;
            for (int i=0; i<=N/2; i++)
            {
                int index = i * score.Length / N;
                int length = score.Length / N;
                Array.Sort(score, index , length);
            }
            if (k == N)
            {
                break;
            }  
        }
    }
    static void PrintOut()
    {
        Console.Write(string.Join(" ", score));
    }
}
