﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsActivity1
{
    public class Logic
    {
        public string[] BubbleSortStrings(string[] list)
        {
            //SET swapMade to TRUE
            bool swapMade = true;
            //SET numComparisons TO sizeOfList
            int numComparisons = list.Length;

            //WHILE swapMade
            while(swapMade)
            {
                //SET swapMade To FALSE
                swapMade = false;

                //FOR i = 0 TO numComparisons – 1
                for (int i = 0; i<numComparisons-1;i++)
                {
                    //IF listElement[i] > listElement[i + 1] THEN
                    if (list[i].CompareTo(list[i+1])>0)
                    {
                        //Swap listElement[i] value with listElement[i + 1]
                        Swap(list, i);

                        //SET swapMade to TRUE
                        swapMade = true;

                    }//END IF

                }//END FOR
                //Decrement numComparisons
                numComparisons--;

            }//END WHILE

            return list;

        }//end bubble sort

        //Swap listElement[i] value with listElement[i + 1]
        private string[] Swap(string[] list, int i)
        {
            string temp = list[i];
            list[i] = list[i + 1];
            list[i + 1] = temp;

            return list;
        }//end of sort method

        public int[] ShellSortingIntegers(int[] list)
        {
            //size – number of elements in list
            int size = list.Length;

            //lastIndex – index position of last element
            int lastIndex = 0;
            //gap -  gap between elements being compared
            int gap = 0;

            //exchanges – records whether an exchange has been made
            bool exchanges = false;

            //lastIndex = size - 1
            lastIndex = size - 1;

            //gap = size DIV 2 integer division
            gap = size / 2;
            do
            {
                do
                {
                    //exchanges = false
                    exchanges = false;
                    //for  top from 0  to lastIndex - gap
                    for (int top=0; top<lastIndex-gap;top++)
                    {
                        //if list[top] >list[top + gap]
                        if (list[top] > list[top + gap])
                        {
                            //CALL swap(list, top, top+gap)
                            Swap(list, top, gap);
                            //exchanges = true
                            exchanges = true;
                        }//end if
                    }// end for 
                } while (exchanges);//while exchanges= true
            //gap = gap DIV 2 
            }while(gap>0);// while gap >0

            return list;

        }//end of Shell Sorting



        private int[] Swap(int[] list,int top, int gap)
        {
            //temp =  list[top]
            int temp = list[top];

            //list[top] = list[top + gap]
            list[top] = list[top + gap];

            //list[top + gap] = temp
            list[top + gap] = temp;

            return list;
        }

        public int[] InsertionSortIntegers(int[] list)
        {
            //size – number of elements in list
            int size = list.Length;
            //local variable: temp – temporary holding variable for first number
            int temp = 0;

            // SET j = 0
            int j = 0;
            // SET temp = 0

            //FOR i = 1 TO size
            for (int i =1;1<size;i++)
            {
                //SET j = i
                j = i;

                //temp = data[i];
                temp = list[i];

                //WHILE j > 0 AND data[j - 1] > temp
                while (j>0 && list[j-1]>temp)
                {
                    //data[j] = data[j - 1]
                    list[j] = list[j - 1];

                    //j = j - 1]
                    j = j - 1;

                }//END WHILE

                //data[j] = temp;
                list[j] = temp;
                
            }//END FOR
            return list;
        }

    }
}
