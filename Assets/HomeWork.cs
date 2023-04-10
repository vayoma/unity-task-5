using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeWork : MonoBehaviour
{
    /// ����� ��������� ������� OnClick ������ "����� ������ ����� ��������� ���������"
    public void OnSumEvenNumbersInRange()
    {
        int min = 7;
        int max = 21;
        var want = 98;
        int got = SumEvenNumbersInRange(min, max);
        string message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"����� ������ ����� � ��������� �� {min} �� {max} ������������: {got} - {message}");
    }

    private int SumEvenNumbersInRange(int min, int max)
    {
        if (min % 2 != 0) min++;
        if (max % 2 != 0) max--;

        int sum = (min + max) / 2 * ((max - min) / 2 + 1);

        return sum;
    }

    /// ����� ��������� ������� OnClick ������ "����� ������ ����� � �������� �������"
    public void OnSumEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"����� ������ ����� � �������� �������: {got} - {message}");
    }

    private int SumEvenNumbersInArray(int[] array)
    {
        int sum = 0;
        foreach (int item in array)
        {
            if (item % 2 == 0) sum += item;
        }

        return sum;
    }

    /// ����� ��������� ������� OnClick ������ "����� ������� ��������� ����� � ������"
    public void OnFirstOccurrence()
    {
        // ������ ����, ����� ����������� � �������
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int value = 34;
        int want = 3;
        int got = FirstOccurrence(array, value);
        string message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"������ ������� ��������� ����� {value} � ������: {got} - {message}");

        // ������ ����, ����� �� ����������� � �������
        array = new int[] { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        value = 55;
        want = -1;
        got = FirstOccurrence(array, value);
        message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"������ ������� ��������� ����� {value} � ������: {got} - {message}");
    }

    private int FirstOccurrence(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value) return i;
        }
        return -1;
    }

    /// ����� ��������� ������� OnClick ������ "���������� �������"
    public void OnSelectionSort()
    {
        int[] originalArray = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        Debug.LogFormat("�������� ������ {0}", "[" + string.Join(",", originalArray) + "]");

        int[] sortedArray = SelectionSort((int[])originalArray.Clone());
        Debug.LogFormat("��������� ���������� {0}", "[" + string.Join(",", sortedArray) + "]");

        int[] expectedArray = { 10, 13, 15, 22, 26, 34, 34, 68, 71, 81 };
        Debug.Log(sortedArray.SequenceEqual(expectedArray) ? "��������� ������" : "��������� �� ������");
    }

    private int[] SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex]) minIndex = j;
            }
            int a = array[i];
            array[i] = array[minIndex];
            array[minIndex] = a;
        }
        return array;
    }
}
