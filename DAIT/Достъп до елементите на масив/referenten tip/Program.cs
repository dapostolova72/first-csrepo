﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referenten_tip
{
    class Program
    {
    
            public static void Main()
            {
                int[] nums = { 5 };
                Increment(nums, 15);
                Console.WriteLine(nums[0]);
            }

            private static void Increment(int[] nums, int value)
            {
                nums[0] += value;
            }

        }
    }

