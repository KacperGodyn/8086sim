using Microsoft.Win32;
using System.Security.Cryptography.X509Certificates;

namespace _8086
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> registry = new Dictionary<string, string>();

        string def_reg = "";
        char[] available_characters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                                        'A', 'B', 'C', 'D', 'E', 'F' };
        public bool ValidateStringContainsCharacters(string arr1, char[] arr2, int num_val)
        {
            int number_check = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        number_check++;
                        if (num_val == number_check)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public Form1()
        {
            registry.Add("AL", def_reg);
            registry.Add("AH", def_reg);
            registry.Add("BL", def_reg);
            registry.Add("BH", def_reg);
            registry.Add("CL", def_reg);
            registry.Add("CH", def_reg);
            registry.Add("DL", def_reg);
            registry.Add("DH", def_reg);
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AL_TextChanged(object sender, EventArgs e)
        {
            string name = "AL";
            if (AL.Text.Length == 2)
            {
                bool valid = ValidateStringContainsCharacters(AL.Text, available_characters, 2);
                if (valid)
                {
                    AL.BackColor = Color.Green;
                    registry[name] = AL.Text;
                }
                else
                    AL.BackColor = Color.Red;
            }
            else
                AL.BackColor = Color.Red;
        }
        private void AH_TextChanged(object sender, EventArgs e)
        {
            string name = "AH";
            if (AH.Text.Length == 2)
            {
                bool valid = ValidateStringContainsCharacters(AH.Text, available_characters, 2);
                if (valid)
                {
                    AH.BackColor = Color.Green;
                    registry[name] = AH.Text;
                }
                else
                    AH.BackColor = Color.Red;
            }
            else
                AH.BackColor = Color.Red;
        }
        private void BL_TextChanged(object sender, EventArgs e)
        {
            string name = "BL";
            if (BL.Text.Length == 2)
            {
                bool valid = ValidateStringContainsCharacters(BL.Text, available_characters, 2);
                if (valid)
                {
                    BL.BackColor = Color.Green;
                    registry[name] = BL.Text;
                }
                else
                    BL.BackColor = Color.Red;
            }
            else
                BL.BackColor = Color.Red;
        }
        private void BH_TextChanged(object sender, EventArgs e)
        {
            string name = "BH";
            if (BH.Text.Length == 2)
            {
                bool valid = ValidateStringContainsCharacters(BH.Text, available_characters, 2);
                if (valid)
                {
                    BH.BackColor = Color.Green;
                    registry[name] = BH.Text;
                }
                else
                    BH.BackColor = Color.Red;
            }
            else
                BH.BackColor = Color.Red;
        }
        private void CL_TextChanged(object sender, EventArgs e)
        {
            string name = "CL";
            if (CL.Text.Length == 2)
            {
                bool valid = ValidateStringContainsCharacters(CL.Text, available_characters, 2);
                if (valid)
                {
                    CL.BackColor = Color.Green;
                    registry[name] = CL.Text;
                }
                else
                    CL.BackColor = Color.Red;
            }
            else
                CL.BackColor = Color.Red;
        }
        private void CH_TextChanged(object sender, EventArgs e)
        {
            string name = "CH";
            if (CH.Text.Length == 2)
            {
                bool valid = ValidateStringContainsCharacters(CH.Text, available_characters, 2);
                if (valid)
                {
                    CH.BackColor = Color.Green;
                    registry[name] = CH.Text;
                }
                else
                    CH.BackColor = Color.Red;
            }
            else
                CH.BackColor = Color.Red;
        }
        private void DL_TextChanged(object sender, EventArgs e)
        {
            string name = "DL";
            if (DL.Text.Length == 2)
            {
                bool valid = ValidateStringContainsCharacters(DL.Text, available_characters, 2);
                if (valid)
                {
                    DL.BackColor = Color.Green;
                    registry[name] = DL.Text;
                }
                else
                    DL.BackColor = Color.Red;
            }
            else
                DL.BackColor = Color.Red;
        }
        private void DH_TextChanged(object sender, EventArgs e)
        {
            string name = "DH";
            if (DH.Text.Length == 2)
            {
                bool valid = ValidateStringContainsCharacters(DH.Text, available_characters, 2);
                if (valid)
                {
                    DH.BackColor = Color.Green;
                    registry[name] = DH.Text;
                }
                else
                    DH.BackColor = Color.Red;
            }
            else
                DH.BackColor = Color.Red;
        }
        private string hex2binary(string hexvalue)
        {
            string bin_value = "";
            bin_value = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
            return bin_value;
        }
        private string binary2hex(string binvalue)
        {
            string hexval = "";
            hexval = Convert.ToInt32(binvalue, 2).ToString("X2");
            return hexval;
        }
        private string int2hex(int intvalue)
        {
            string hexval = "";
            hexval = intvalue.ToString("X2");
            return hexval;
        }
        private string fullFillDigits(string toFullFill, int fullFillToLength)
        {
            string fullFilledregistry = "";
            string temp = toFullFill;
            int length = fullFillToLength - toFullFill.Length;
            for (int i = 0; i < length; i++)
            {
                fullFilledregistry += "0";
            }
            fullFilledregistry += temp;
            return fullFilledregistry;
        }
        private void MOV(string from, string to)
        {
            registry[to] = registry[from];
        }
        private void XCHG(string from, string to)
        {
            string temp = registry[to];
            registry[to] = registry[from];
            registry[from] = temp;
        }
        private void NOT(string reg)
        {
            string bin_string = hex2binary(registry[reg]);
            string final_string = "";
            if (bin_string.Length < 8)
            {
                bin_string = fullFillDigits(bin_string, 8);
            }
            for (int i = 0; i < bin_string.Length; i++)
            {
                if (bin_string[i] == '1')
                {
                    final_string += '0';
                }
                else
                {
                    final_string += '1';
                }
            }
            registry[reg] = binary2hex(final_string);
        }
        private void AND(string reg1, string reg2)
        {           
            string bin_string1 = hex2binary(registry[reg1]);
            string bin_string2 = hex2binary(registry[reg2]);
            if (bin_string1.Length < 8)
            {
                bin_string1 = fullFillDigits(bin_string1, 8);
            }
            if (bin_string2.Length < 8)
            {
                bin_string2 = fullFillDigits(bin_string2, 8);
            }
            string final_string = "";
            for (int i = 0; i < bin_string1.Length; i++)
            {
                if (bin_string1[i] == '1' && bin_string2[i] == '1')
                {
                    final_string += "1";
                }
                else
                {
                    final_string += "0";
                }
            }
            registry[reg1] = binary2hex(final_string);
        }
        private void Or(string reg1, string reg2)
        {
            string bin_string1 = hex2binary(registry[reg1]);
            string bin_string2 = hex2binary(registry[reg2]);
            if (bin_string1.Length < 8)
            {
                bin_string1 = fullFillDigits(bin_string1, 8);
            }
            if (bin_string2.Length < 8)
            {
                bin_string2 = fullFillDigits(bin_string2, 8);
            }
            string final_string = "";
            for (int i = 0; i < bin_string1.Length; i++)
            {
                if (bin_string1[i] == '0' && bin_string2[i] == '0')
                {
                    final_string += "0";
                }
                else
                {
                    final_string += "1";
                }
            }
            registry[reg1] = binary2hex(final_string);
        }
        private void NAND(string reg1, string reg2)
        {
            string bin_string1 = hex2binary(registry[reg1]);
            string bin_string2 = hex2binary(registry[reg2]);
            if (bin_string1.Length < 8)
            {
                bin_string1 = fullFillDigits(bin_string1, 8);
            }
            if (bin_string2.Length < 8)
            {
                bin_string2 = fullFillDigits(bin_string2, 8);
            }
            string final_string = "";
            for (int i = 0; i < bin_string1.Length; i++)
            {
                if (bin_string1[i] == '1' && bin_string2[i] == '1')
                {
                    final_string += "0";
                }
                else
                {
                    final_string += "1";
                }
            }
            registry[reg1] = binary2hex(final_string);
        }
        private void NOr(string reg1, string reg2)
        {
            string bin_string1 = hex2binary(registry[reg1]);
            string bin_string2 = hex2binary(registry[reg2]);
            if (bin_string1.Length < 8)
            {
                bin_string1 = fullFillDigits(bin_string1, 8);
            }
            if (bin_string2.Length < 8)
            {
                bin_string2 = fullFillDigits(bin_string2, 8);
            }
            string final_string = "";
            for (int i = 0; i < bin_string1.Length; i++)
            {
                if (bin_string1[i] == '0' && bin_string2[i] == '0')
                {
                    final_string += "1";
                }
                else
                {
                    final_string += "0";
                }
            }
            registry[reg1] = binary2hex(final_string);
        }
        private void XOr(string reg1, string reg2)
        {
            string bin_string1 = hex2binary(registry[reg1]);
            string bin_string2 = hex2binary(registry[reg2]);
            if (bin_string1.Length < 8)
            {
                bin_string1 = fullFillDigits(bin_string1, 8);
            }
            if (bin_string2.Length < 8)
            {
                bin_string2 = fullFillDigits(bin_string2, 8);
            }
            string final_string = "";
            for (int i = 0; i < bin_string1.Length; i++)
            {
                if ((bin_string1[i] == '0' && bin_string2[i] == '0') || (bin_string1[i] == '1' && bin_string2[i] == '1'))
                {
                    final_string += "0";
                }
                else
                {
                    final_string += "1";
                }
            }
            registry[reg1] = binary2hex(final_string);
        }
        private void XNOr(string reg1, string reg2)
        {
            string bin_string1 = hex2binary(registry[reg1]);
            string bin_string2 = hex2binary(registry[reg2]);
            if (bin_string1.Length < 8)
            {
                bin_string1 = fullFillDigits(bin_string1, 8);
            }
            if (bin_string2.Length < 8)
            {
                bin_string2 = fullFillDigits(bin_string2, 8);
            }
            string final_string = "";
            for (int i = 0; i < bin_string1.Length; i++)
            {
                if ((bin_string1[i] == '0' && bin_string2[i] == '0') || (bin_string1[i] == '1' && bin_string2[i] == '1'))
                {
                    final_string += "1";
                }
                else
                {
                    final_string += "0";
                }
            }
            registry[reg1] = binary2hex(final_string);
        }
        private void Inc(string reg)
        {
            if (registry[reg] == "FF") return;
            int integerValue = int.Parse(registry[reg], System.Globalization.NumberStyles.HexNumber);
            integerValue++;
            registry[reg] = int2hex(integerValue);
        }
        private void Dec(string reg)
        {
            if (registry[reg] == "00") return;
            int integerValue = int.Parse(registry[reg], System.Globalization.NumberStyles.HexNumber);
            integerValue--;
            registry[reg] = int2hex(integerValue);
        }
        private void assign()
        {
            AL.Text = registry["AL"];
            AH.Text = registry["AH"];
            BL.Text = registry["BL"];
            BH.Text = registry["BH"];
            CL.Text = registry["CL"];
            CH.Text = registry["CH"];
            DL.Text = registry["DL"];
            DH.Text = registry["DH"];
        }
        private void execute_Click(object sender, EventArgs e)
        {
            string secondregistry = "";
            string currentSelectedFunction = functions.Items[functions.SelectedIndex].ToString();
            string firstregistry = firstreg.Items[firstreg.SelectedIndex].ToString();
            if ((currentSelectedFunction != "NOT") && (currentSelectedFunction != "INC") && (currentSelectedFunction != "DEC"))
            {
                secondregistry = secondreg.Items[secondreg.SelectedIndex].ToString();
            }
            if (currentSelectedFunction == "MOV")
            {
                MOV(firstregistry, secondregistry);
            }
            else if (currentSelectedFunction == "XCHG")
            {
                XCHG(firstregistry, secondregistry);
            }
            else if (currentSelectedFunction == "NOT")
            {
                NOT(firstregistry);
            }
            else if (currentSelectedFunction == "AND")
            {
                AND(firstregistry, secondregistry);
            }
            else if (currentSelectedFunction == "OR")
            {
                Or(firstregistry, secondregistry);
            }
            else if (currentSelectedFunction == "NAND")
            {
                NAND(firstregistry, secondregistry);
            }
            else if (currentSelectedFunction == "NOR")
            {
                NOr(firstregistry, secondregistry);
            }
            else if (currentSelectedFunction == "XOR")
            {
                XOr(firstregistry, secondregistry);
            }
            else if (currentSelectedFunction == "XNOR")
            {
                XNOr(firstregistry, secondregistry);
            }
            else if (currentSelectedFunction == "INC")
            {
                Inc(firstregistry);
            }
            else if (currentSelectedFunction == "DEC")
            {
                Dec(firstregistry);
            }
            assign();
        }
    }
}