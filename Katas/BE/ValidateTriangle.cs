using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.BE
{
    public class ValidateTriangle
    {
        public int FindValidTriangles(List<List<int>> triangleList)
        {
            int numTriangles = 0;

            foreach (List<int> triangle in triangleList)
            {
                if (triangle.Count == 0)
                {
                    numTriangles += 0;
                }
                else
                {
                    int firstSum = triangle[0] + triangle[1];
                    int secondSum = triangle[1] + triangle[2];
                    int thirdSum = triangle[2] + triangle[0];

                    if (firstSum > triangle[2] && secondSum > triangle[0] && thirdSum > triangle[1])
                    {
                        numTriangles++;
                    }
                }
            }

            return numTriangles;
        }
    }
}
