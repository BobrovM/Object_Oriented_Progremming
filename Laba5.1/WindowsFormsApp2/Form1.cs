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
            ComboBox_Account.Items.AddRange(Accounts);
            ComboBox_BaseCurrency.Items.AddRange(Currencies);

            ComboBox_CurrencyForBalance.SelectedIndex = 0;
            ComboBox_CurrencyForTransaction.SelectedIndex = 0;
            ComboBox_BaseCurrency.SelectedIndex = 0;
            ComboBox_Account.SelectedIndex = ChosenAccount;

            OutputText_Balance.Text = Accounts[ChosenAccount].BalanceToString
                (ComboBox_BaseCurrency.SelectedIndex, ComboBox_CurrencyForBalance.SelectedIndex);

            IsInilizationFinished = true;
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
            private int Number;
            private decimal Balance;
            private Currency AccCurrency;

            public Account(int InputNumber, decimal InputBalance, Currency InputAccCurency)
            {
                Balance = InputBalance;
                AccCurrency = InputAccCurency;
                Number = InputNumber;
            }

            //TODO convertation fee
            public bool Transact(decimal TransactionAmount, Currency InputTransCurrency)
            {
                decimal TransactionResult;

                if (AccCurrency.EditableName == InputTransCurrency.EditableName)
                {
                    TransactionResult = Balance + TransactionAmount;
                }
                else
                {
                    TransactionResult = Balance + TransactionAmount * InputTransCurrency.EditableRate / AccCurrency.EditableRate
                        - Math.Abs(TransactionAmount) * InputTransCurrency.EditableRate / AccCurrency.EditableRate * 0.01M;
                }

                //decimal TransactionResult = Balance + TransactionAmount * InputTransCurrency.EditableRate;

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

            public void ChangeCurrency(int NewCurrencyIndex)
            {
                int AccCurrencyIndex = -1;

                for(int Index = 0; Index < Currencies.Length; Index++)
                {
                    if(AccCurrency == Currencies[Index])
                    {
                        AccCurrencyIndex = Index;
                    }
                }

                if(AccCurrencyIndex == -1) { return; }

                Balance = Balance * Currencies[AccCurrencyIndex].EditableRate / Currencies[NewCurrencyIndex].EditableRate * 0.99M;
                AccCurrency = Currencies[NewCurrencyIndex];
            }

            public override string ToString()

            {
                return $"{Number}";
            }

            public string BalanceToString(int BaseCurrencyIndex, int ShowCurrencyIndex)
            {
                return $"{Math.Round(Balance * Currencies[BaseCurrencyIndex].EditableRate / Currencies[ShowCurrencyIndex].EditableRate, 2)}";
            }

            public Currency GetCurrency { get => AccCurrency; }
        }


        static readonly Currency[] Currencies = new Currency[3]
        {
            new Currency() { EditableName = "RUR", EditableRate = 1},
            new Currency() { EditableName = "SGD", EditableRate = 57.57M},
            new Currency() { EditableName = "SEK", EditableRate = 9.07M}
        };


        static Account[] Accounts = new Account[2]
        {
            new Account(1, 1000000, Currencies[0]),
            new Account(2, 1450000, Currencies[0])
        };


        int ChosenAccount = 0;

        bool IsNotBaseCurriencyChangeTransaction = false;
        bool IsInilizationFinished = false;

        private void ComboBox_CurrencyForBalance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsInilizationFinished) { return; };

            OutputText_Balance.Text = Accounts[ChosenAccount].BalanceToString
                (ComboBox_BaseCurrency.SelectedIndex, ComboBox_CurrencyForBalance.SelectedIndex);
        }

        private void Button_Write_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show("Комиссия за конвертацию составляет 1%. Нажав Ок, вы соглашаетесь на взятие коммисии при различных валютах.",
                "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                return;
            }

            var Result = decimal.TryParse(TextBox_SumOfTransaction.Text, out decimal TransactionSum);

            if (TransactionSum <= 0 || !Result)
            {
                MessageBox.Show("Операция невозможна: неправильная сумма транзакции.");
                return;
            }

            int AccGetInd;

            if (ChosenAccount == 0)
            {
                AccGetInd = 1;
            }
            else
            {
                AccGetInd = 0;
            }

            if (!Accounts[ChosenAccount].Transact(TransactionSum, (Currency)ComboBox_CurrencyForTransaction.SelectedItem)||
                !Accounts[AccGetInd].Transact(-TransactionSum, (Currency)ComboBox_CurrencyForTransaction.SelectedItem))
            {
                { MessageBox.Show("Невозможно выполнить операцию, на другом счету недостаточно средств."); };
            }

            OutputText_Balance.Text = Accounts[ChosenAccount].BalanceToString
                (ComboBox_BaseCurrency.SelectedIndex, ComboBox_CurrencyForBalance.SelectedIndex);
        }
        
        //TODO make convertation fee work
        private void Button_WithDraw_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show("Комиссия за конвертацию составляет 1%. Нажав Ок, вы соглашаетесь на взятие коммисии при различных валютах.",
                "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                return;
            }

            var Result = decimal.TryParse(TextBox_SumOfTransaction.Text, out decimal TransactionSum);

            if (TransactionSum <= 0 || !Result)
            {
                MessageBox.Show("Операция невозможна: неправильная сумма транзакции.");
                return;
            }

            int AccGetInd;

            if(ChosenAccount == 0)
            {
                AccGetInd = 1;
            }
            else
            {
                AccGetInd = 0;
            }            

            if (!Accounts[ChosenAccount].Transact(-TransactionSum, (Currency)ComboBox_CurrencyForTransaction.SelectedItem) ||
                !Accounts[AccGetInd].Transact(TransactionSum, (Currency)ComboBox_CurrencyForTransaction.SelectedItem))
            {
                { MessageBox.Show("Невозможно выполнить операцию: на вашем счету недостаточно средств."); };
            }

            OutputText_Balance.Text = Accounts[ChosenAccount].BalanceToString
                (ComboBox_BaseCurrency.SelectedIndex, ComboBox_CurrencyForBalance.SelectedIndex);
        }

        private void ComboBox_BaseCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsInilizationFinished) { return; }
            if (IsNotBaseCurriencyChangeTransaction) { return; }

            if(DialogResult.Cancel == MessageBox.Show("При смене базовой валюты будет взята комиссия за конвертацию в размере 1%!",
                "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                int Index;

                for(Index = 0; Index < Currencies.Length; Index++)
                {
                    if(Accounts[ChosenAccount].GetCurrency == Currencies[Index]) { break; }
                }

                IsNotBaseCurriencyChangeTransaction = true;
                ComboBox_BaseCurrency.SelectedIndex = Index;
                IsNotBaseCurriencyChangeTransaction = false;
                
                return;
            }

            Accounts[ChosenAccount].ChangeCurrency(ComboBox_BaseCurrency.SelectedIndex);
            ComboBox_CurrencyForBalance.SelectedIndex = ComboBox_BaseCurrency.SelectedIndex;
            ComboBox_CurrencyForTransaction.SelectedIndex = ComboBox_BaseCurrency.SelectedIndex;
            OutputText_Balance.Text = Accounts[ChosenAccount].BalanceToString
                (ComboBox_BaseCurrency.SelectedIndex, ComboBox_CurrencyForBalance.SelectedIndex);
        }

        private void ComboBox_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChosenAccount = ComboBox_Account.SelectedIndex;

            int Index;

            for (Index = 0; Index < Currencies.Length; Index++)
            {
                if (Accounts[ChosenAccount].GetCurrency == Currencies[Index]) { break; }
            }

            IsNotBaseCurriencyChangeTransaction = true;
            ComboBox_BaseCurrency.SelectedIndex = Index;
            IsNotBaseCurriencyChangeTransaction = false;

            ComboBox_CurrencyForBalance.SelectedIndex = ComboBox_BaseCurrency.SelectedIndex;
            ComboBox_CurrencyForTransaction.SelectedIndex = ComboBox_BaseCurrency.SelectedIndex;

            OutputText_Balance.Text = Accounts[ChosenAccount].BalanceToString
                (ComboBox_BaseCurrency.SelectedIndex, ComboBox_CurrencyForBalance.SelectedIndex);
        }


        //USELESS
        private void Text_BaseCurrency_Click(object sender, EventArgs e)
        {

        }

        private void Text_Account_Click(object sender, EventArgs e)
        {

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
    }
}
