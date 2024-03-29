﻿using System;
/* 백준 4779번 : 칸토어집합(https://www.acmicpc.net/problem/4779)

다음과 같은 과정을 통해서 칸토어 집합의 근사를 만들어보자.
1. -가 3N개 있는 문자열에서 시작한다.

2. 문자열을 3등분 한 뒤, 가운데 문자열을 공백으로 바꾼다. 이렇게 하면, 선(문자열) 2개가 남는다.

3. 이제 각 선(문자열)을 3등분 하고, 가운데 문자열을 공백으로 바꾼다. 이 과정은 모든 선의 길이가 1일때 까지 계속 한다.
 * 
 */


public class BOJ4779
{
	public void Solution() //근데 제출하면 오답 뜸
	{
		int x;
		while(true)
		{
			try
			{
                x = int.Parse(Console.ReadLine());
			}
			catch
			{
				break;
			}
			Cantor(x);
			Console.WriteLine();
		}
	}

	public void Cantor(int? x)
	{
		if(x == 0)
		{
			Console.Write("-");
			return;
		}
		//출력 - 공백 -출력 의 순으로 이뤄짐
		Cantor(x - 1);
		//공백의 수 => 3^(n-1)회,  
        double length = Math.Pow(3, (double)(x - 1));
        for (int i = 0; i < length; i++)
		{
			Console.Write(" ");
		}
		Cantor(x - 1);
	}
}
