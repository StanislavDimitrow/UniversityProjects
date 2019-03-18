
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KZ_hill_row
{
    public partial class Form1 : Form
    {
        public string hillResult;
        public string keyWord;
        //private string hillResult;

        public Form1()
        {
            InitializeComponent();
        }

        //func. check is null or empty
        public bool errorCheck(string item)
        {

            if (String.IsNullOrEmpty(item))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // func. check is all bits of the string are letters
        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        // v arr[i] se sudurjat indeksite na plaintext-a.
        public void hillCheck(string item)
        {
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //string hillResult = "";
            int len = item.Length;
            if (item.Length % 2 != 0)
            {
                len = item.Length + 1;
                item = item + "X";
            }

            int[] arr = new int[item.Length];

            int[] key = { 11, 8, 3, 7 };

            int[] mas = new int[item.Length];



            //index-i na plaintext
            for (int i = 0; i < item.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (item[i] == alpha[j]) arr[i] = j;
                }
            }

            //suzdawane na shifriraniq text chrez mod
            //v mas se sudurjat gotovite chisla za proverka po azbukata
            for (int i = 0; i < item.Length; i += 2)
            {
                for (int j = 0; j < 26; j++)
                {
                    mas[i] = (arr[i] * key[0] + arr[i + 1] * key[2]) % 26;
                    mas[i + 1] = (arr[i] * key[1] + arr[i + 1] * key[3]) % 26;
                }
            }

            //tursene na chislata ot mas po azbukata i suzdavane na string
            for (int i = 0; i < item.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (mas[i] == j)
                    {
                        hillResult += alpha[j];
                    }
                }
            }


            lResult.Text = hillResult;

        }

        public string rowTranspos(string plainText, int[] positions)
        {

            int[] keys = positions;
            char[] charArr = plainText.ToCharArray();

            Array.Sort(positions, charArr);

            string temp = string.Empty;

            for (int i = 0; i < charArr.Length; i++)
            {
                temp += charArr[i];
            }

            return temp;
        }

        public int[] getPositions(string key)
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string temp = string.Empty;

            for (int j = 0; j < key.Length; j++)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (alphabet[i] == key[j])
                    {
                        temp += i + " ";
                    }
                }
            }

            int[] result = new int[keyWord.Length];

            var pos = temp.Split(' ').ToArray();

            for (int i = 0; i < pos.Length; i++)
            {
                if (!string.IsNullOrEmpty(pos[i]))
                {
                    result[i] = int.Parse(pos[i]);
                }
            }

            //result = result.OrderBy(x => x).ToArray();
            //int max = 0;
            //for (int i = 0; i < result.Length; i++)
            //{
            //    if (result[i] > max)
            //    {
            //        max
            //        result[i] = 1;
            //    }
            //    else
            //    {
            //        result[i] = i + 1;
            //    }
            //}

            return result;
        }


        private void btnCrypt_Click(object sender, EventArgs e)
        {

            string errorMsg = "Some textboxes are empty. Write down something right!";

            if (errorCheck(tbPlaintext.Text))
            {
                MessageBox.Show(errorMsg);
                lMsgResultHill.Visible = false;
                lHillRowtransp.Visible = false;
                return;
            }
            else if (errorCheck(tbKey.Text))
            {
                MessageBox.Show(errorMsg);
                lMsgResultHill.Visible = false;
                lHillRowtransp.Visible = false;
                return;
            }

            else if (tbKey.Text.Length > 26)
            {
                MessageBox.Show("Key must be less 26 symbols");
                return;
            }



            if (!IsAllLetters(tbPlaintext.Text) || !IsAllLetters(tbKey.Text))
            {
                MessageBox.Show("The textboxes must contains only letters");
                tbPlaintext.Text = "";
                tbKey.Text = "";
                return;
            }
            hillCheck(tbPlaintext.Text);

            keyWord = tbKey.Text;

            int[] nums = getPositions(keyWord);
            nums = nums.OrderBy(x => x).ToArray();

            
            int[] num = { 1, 4, 2, 3 };

            string result = rowTranspos(lResult.Text, num);
            lResult.Text = hillResult;
            lResult2.Text = result;


            lMsgResultHill.Visible = true;
            lHillRowtransp.Visible = true;
            lResult2.Visible = true;
            lResult.Visible = true;

        }

        private void tbPlaintext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void tbKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        //after btnClear is clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPlaintext.Text = "";
            tbKey.Text = "";
            lMsgResultHill.Visible = false;
            lHillRowtransp.Visible = false;
            lResult2.Visible = false;
            lResult.Visible = false;
        }

      
      
    }
    }
