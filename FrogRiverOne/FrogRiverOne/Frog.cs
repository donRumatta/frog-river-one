namespace FrogRiverOne;

public static class Frog
{
    public static int CalculateJumpTime(int jumpLength, int[] leaves)
    {
        var lengthSum = (1 + jumpLength) * jumpLength / 2;
        
        var storage = new Dictionary<int, bool>();

        for (int i = 0; i < leaves.Length; i++)
        {
            var second = i;
            var position = leaves[i];

            if (storage.ContainsKey(position))
            {
                continue;
            }

            lengthSum -= position;
            if (lengthSum == 0)
            {
                return second;
            }

            storage[position] = true;
        }

        return -1;
    }
}