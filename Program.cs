using System;

class Program {
    public class Solutions {

        //Exercício 1 - RoadMap do Neetcode
        //Método que verifica se um array possui números duplicados
        public bool ContainsDuplicate(int[] nums)
        {
            //Cria um HashSet
            HashSet<int> countNums = new HashSet<int>();

            //Percorre o array Nums
            foreach (int num in nums)
            {
                //Como o HashSet só armazena um valor único, ele é inicializado vazio, caso aconteça de aparecer denovo, 
                //retorna True
                if (countNums.Contains(num))
                {
                    return true;
                }
                //Adiciona o num no HashSet
                countNums.Add(num);
            }
            return false;
        }

        //Exercício 2 - RoadMap do NeetCode
        //Verifica se as strings são anagramas
        public bool IsAnagram(string s, string t)
        {
            //Verify if the strings have the same size
            if (s.Length != t.Length)
            {
                return false;
            }

            //Create 2 arrays to save the strings
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();


            //Order the strings from A to Z
            Array.Sort(sArray);
            Array.Sort(tArray);

            //Loop to check if the characters is equal
            for (int j = 0; j < sArray.Length; j++)
            {
                if (sArray[j] != tArray[j])
                {
                    return false;
                }

            }
            //Returns true if all the characters are equals
            return true;
        }

        //Exercício 3 - RoadMap do NeetCode
        //Recebe um array e um integer e verifica se dois números do array podem ser a soma para resultar o inteiro dado
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        result[0] = i;
                        result[1] = j; return result;
                    }
                }
            }
            return result;
        }
    }

}
