using System.Collections.Generic;
using System.Linq;

namespace CSharp.DynamicProgramming;

class MaxSubjects
{
    public static int MaxSubjectsNumber(List<int> answered, List<int> needed, int q)
    {
        HashSet<int> ignored = new();
        List<int> required = new();
        int subjects = 0;

        for (int i = 0; i < needed.Count; i++)
        {
            if (needed.ElementAt(i) > q)
            {
                ignored.Add(i);
            }
            required.Add(needed.ElementAt(i) - answered.ElementAt(i));
        }

        var requiredSorted = required.OrderBy(r => r);

        for (int i = 0; i < needed.Count; i++)
        {
            int min = requiredSorted.ElementAt(0);

            if (q <= 0)
            {
                break;
            }

            if (required.ElementAt(i) != min || ignored.Contains(i))
            {
                continue;
            }

            q -= min;
            subjects += 1;
            requiredSorted.Skip(i);
            i = 0;
        }

        return subjects;
    }
}
