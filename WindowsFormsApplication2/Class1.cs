using System;

public class EAN13
{
    public EAN13()
	{

	}
    public string Encode(string no)
    {
        string head = "101";
        string mid = "01010";
        string[,] set=new string[,]{
            {"0001101","0100111","1110010"},
            {"0011001","0110011","1100110"},
            {"0010011","0011011","1101100"},
            {"0111101","0100001","1000010"},
            {"0100011","0011101","1011100"},
            {"0110001","0111001","1001110"},
            {"0101111","0000101","1010000"},
            {"0111011","0010001","1000100"},
            {"0110111","0001001","1001000"},
            {"0001011","0010111","1110100"}};
        int[,] select = new int[,]{
            {0,0,0,0,0,0},
            {0,0,1,0,1,1},
            {0,0,1,1,0,1},
            {0,0,1,1,1,0},
            {0,1,0,0,1,1},
            {0,1,1,0,0,1},
            {0,1,1,1,0,0},
            {0,1,0,1,0,1},
            {0,1,0,1,1,0},
            {0,1,1,0,1,0},};
        string code = "";
        char[] num = no.ToCharArray();

        code = code + head;
        int selectnum=Convert.ToInt32(num[0]-'0');
        for (int i = 0; i < 6; i++)
        {
            code = code + set[Convert.ToInt32(num[i] - '0'), select[selectnum,i]];
        }
        code = code + mid;
        for (int i = 6; i < 13; i++)
        {
            code = code + set[Convert.ToInt32(num[i] - '0'), 2];  
        }
        code = code + head;

        return code;
    }
}
