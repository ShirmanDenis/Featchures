using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffineCryptosystem
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<char, int> alphaBet = new Dictionary<char, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void InitAlphaBet()
        {
            alphaBet.Clear();
            var counter = 0;
            try
            {
                foreach (var ruChar in txBxAlphaBet.Text)
                {
                    alphaBet.Add(ruChar, counter++);
                }
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(@"Такая буква в алфаите уже есть");
            }

            upDownN.Value = alphaBet.Count;
        }

        private void upDownN_ValueChanged(object sender, EventArgs e)
        {
            // b < = n -1
            upDownB.Maximum = upDownN.Value - 1;
        }

        private void upDownA_Validating(object sender, CancelEventArgs e)
        {
            var result = BigInteger.GreatestCommonDivisor((BigInteger) upDownA.Value, (BigInteger) upDownN.Value);

            if (result != 1)
            {
                toolTipNOD.Show("Числа \"a\" и \"n\" должны быть взаимно простыми!", upDownA);
                e.Cancel = true;
            }
            else { toolTipNOD.Hide(upDownA); }
            
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            var a = upDownA.Value;
            var b = upDownB.Value;
            var n = upDownN.Value;

            var encryptTextBuilder = new StringBuilder();
            foreach (var symbol in txBxTextToEncrypt.Text)
            {
                var symbolToEncrypt = char.ToLower(symbol);

                if (!alphaBet.TryGetValue(symbolToEncrypt, out int curIndex))
                {
                    MessageBox.Show($"В алфавите отсутсвует символ {symbolToEncrypt}");
                    return;
                }

                var newCharIndex = (int)(a * curIndex + b) % n;

                var encryptedChar = alphaBet.First(pair => pair.Value == newCharIndex).Key;
                encryptTextBuilder.Append(encryptedChar);
            }
            txBxEncryptResult.Text = encryptTextBuilder.ToString();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            var a = upDownA.Value;
            var b = upDownB.Value;
            var n = upDownN.Value;
            var decryptedTextBuilder = new StringBuilder();
            foreach (var symbol in txBxTextToDecrypt.Text)
            {
                var symbolToDecrypt = char.ToLower(symbol);
                if (!alphaBet.TryGetValue(symbolToDecrypt, out int curIndex))
                {
                    MessageBox.Show($"В алфавите отсутсвует символ {symbolToDecrypt}");
                    return;
                }
                try
                {
                    var newCharIndex = (int)((curIndex - b) * ReverseArg((int)a, (int)n)) % n;
                    if (newCharIndex < 0)
                        newCharIndex = n + newCharIndex;
                    var decryptedChar = alphaBet.First(pair => pair.Value == newCharIndex).Key;
                    decryptedTextBuilder.Append(decryptedChar);
                }
                catch (ArgumentException exception)
                {
                    MessageBox.Show(@"Can't find reverse elem");
                }
            }
            txBxDecryptedText.Text = decryptedTextBuilder.ToString();
        }

        private static int ReverseArg(int a, int m)
        {
            int x, y;
            int g = GCD(a, m, out x, out y);
            if (g != 1)
                throw new ArgumentException();
            return (x % m + m) % m;
        }

        private static int GCD(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            int x1, y1;
            int d = GCD(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        private void txBxAlphaBet_TextChanged(object sender, EventArgs e)
        {
            InitAlphaBet();
            upDownN.Value = alphaBet.Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitAlphaBet();
        }
    }
}
