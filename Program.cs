﻿using System;

class Program
{
    static void Main()
    {
        int[][] studentScores = new int[3][];
        studentScores[0] = new int[] { 85, 92, 78 };
        studentScores[1] = new int[] { 90, 87, 93, 89 };
        studentScores[2] = new int[] { 76, 88 };
        for (int i = 0; i < studentScores.Length; i++)
        {
            Console.Write("Student {0} scores: ", i + 1);
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                Console.Write(studentScores[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < studentScores.Length; i++)
        {
            double sum = 0;
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                sum += studentScores[i][j];
            }
            double average = sum / studentScores[i].Length;
            Console.WriteLine("Average score for student {0}: {1}", i + 1, average);
        }
        Console.WriteLine();
        double totalSum = 0;
        int totalScores = 0;
        for (int i = 0; i < studentScores.Length; i++)
        {
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                totalSum += studentScores[i][j];
                totalScores++;
            }
        }
        double totalAverage = totalSum / totalScores;
        Console.WriteLine("Average score for all students combined: {0}", totalAverage);
    }
}