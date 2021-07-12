using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBox_CurrencyForBalance.Items.AddRange(Currencies);
            ComboBox_CurrencyForTransaction.Items.AddRange(Currencies);
            ComboBox_CurrencyForBalance.SelectedIndex = 0;
            ComboBox_CurrencyForTransaction.SelectedIndex = 0;
            OutputText_Balance.Text = Account_1.ToString();
        }


        public class Currency
        {
            private string Name;
            private decimal Rate;

            public string EditableName //Доступ к данным вне класса
            {
                get { return Name; }
                set { Name = value; }
            }

            public decimal EditableRate //Доступ к данным вне класса
            {
                get { return Rate; }
                set { Rate = value; }
            }

            public override string ToString()

            {
                return $"{Name}";
            }
        }


        public class Account
        {
            private decimal Balance;
            private Currency AccCurrency;

            public Currency CurrencyDisplay
            {
                set { AccCurrency = value; }
            }


            public Account(decimal InputBalance, Currency InputAccCurency)
            {
                Balance = InputBalance;
                AccCurrency = InputAccCurency;
            }

            public bool Transact(decimal TransactionAmount, Currency InputAccCurrency)
            {
                decimal TransactionResult = Balance + TransactionAmount * InputAccCurrency.EditableRate;

                if(TransactionResult < 0)
                {
                    return false;
                }
                else
                {
                    Balance = TransactionResult;
                }

                return true;
            }

            public override string ToString()

            {
                return $"{Math.Round(Balance / AccCurrency.EditableRate,2)}";
            }
        }


        static readonly Currency[] Currencies = new Currency[3]
        {
            new Currency() { EditableName = "RUR", EditableRate = 1},
            new Currency() { EditableName = "SGD", EditableRate = 57.57M},
            new Currency() { EditableName = "SEK", EditableRate = 9.07M}
        };


        static Account Account_1 = new Account(1000000, Currencies[0]);


        private void Text_AccountValue_Click(object sender, EventArgs e)
        {

        }

        private void Text_Balance_Click(object sender, EventArgs e)
        {

        }

        private void OutputText_Balance_Click(object sender, EventArgs e)
        {

        }

        private void Text_CurrencyBalance_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox_CurrencyForBalance_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account_1.CurrencyDisplay = (Currency)ComboBox_CurrencyForBalance.SelectedItem;
            OutputText_Balance.Text = Account_1.ToString();
        }

        private void Text_Transactions_Click(object sender, EventArgs e)
        {

        }

        private void Text_SumOfTransaction_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_SumOfTransaction_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_CurrencyTransaction_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox_CurrencyForTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_Write_Click(object sender, EventArgs e)
        {
            var Result = decimal.TryParse(TextBox_SumOfTransaction.Text, out decimal TransactionSum);

            if (TransactionSum <= 0 || !Result)
            {
                MessageBox.Show("Операция невозможна: неправильная сумма транзакции");
                return;
            }

            if (!Account_1.Transact(TransactionSum, (Currency)ComboBox_CurrencyForTransaction.SelectedItem))
            {
                { MessageBox.Show("Невозможно выполнить операцию"); };
            }

            OutputText_Balance.Text = Account_1.ToString();
        }

        private void Button_WithDraw_Click(object sender, EventArgs e)
        {
            var Result = decimal.TryParse(TextBox_SumOfTransaction.Text, out decimal TransactionSum);

            if (TransactionSum <= 0 || !Result)
            {
                MessageBox.Show("Операция невозможна: неправильная сумма транзакции");
                return;
            }

            if (!Account_1.Transact(-TransactionSum, (Currency)ComboBox_CurrencyForTransaction.SelectedItem))
            {
                { MessageBox.Show("Невозможно выполнить операцию: на счету недостаточно средств"); };
            }

            OutputText_Balance.Text = Account_1.ToString();
        }
    }
}
