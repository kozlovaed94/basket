using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace WindowsFormsApp3
{
    public partial class BasketOfGoods : MetroForm
    {
        public BasketOfGoods()
        {
            InitializeComponent();
        }

        class StackBasket
        {
            //Счетчик выполненного действия
            public int Operation { get; set; }
            //Позиция товара
            public int Count { get; set; }
            //Наименовани товара
            public string Name { get; set; }
            //Цена товара
            public float Cost { get; set; }
            //Количество данного товара в корзине
            public int Num { get; set; }
            //Число изменения товара
            public int NumChange { get; set; }
            //Процент стоимости товара с учетом скидки
            public int Discount { get; set; }
        }

        //Стек операций
        private Stack<StackBasket> StackLine = new Stack<StackBasket>();

        //Стоимость покупки
        float Sum = 0;
        //Скидка корзины
        int dis = 0;
        //Число элементов корзины
        int count = 0;

        private void AddM()
        {
            string name = NameBox.Text;
            float cost = float.Parse(CostBox.Text);
            int num = int.Parse(NumBox.Text);
            StackLine.Push(new StackBasket { Operation = 1, Count = count, NumChange = num });
            NameBox.Clear(); CostBox.Clear(); NumBox.Clear();
            float s = cost * num * (100 - dis) / 100;
            dataGridView1.Rows.Add(name, cost, num, dis, s);
            Sum += s;
            count++;
            BasketCostBox.Text = Sum.ToString();
            BasketDiscountBox.Text = dis.ToString();
        }

        private void AddM(int countf, string namef, float costf, int numf)
        {
            float s = costf * numf * (100 - dis) / 100;
            dataGridView1.Rows.Insert(countf, namef, costf, numf, dis, s);           
            Sum += s;
            count++;
            BasketCostBox.Text = Sum.ToString();
            BasketDiscountBox.Text = dis.ToString();
        }

        private void DelM()
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            StackLine.Push(new StackBasket { Operation = 2, Count = i, Name = dataGridView1[0, i].Value.ToString(), Cost = float.Parse(dataGridView1[1, i].Value.ToString()), Num = int.Parse(dataGridView1[2, i].Value.ToString()), Discount = int.Parse(dataGridView1[3, i].Value.ToString()) });
            Sum -= float.Parse(dataGridView1[4, i].Value.ToString()) * (100 - dis) / 100;
            count--;
            BasketCostBox.Text = Sum.ToString();
            dataGridView1.Rows.RemoveAt(i);
        }

        private void DelM(bool redo, int countf)
        {
            int i = countf;
            if (redo) StackLine.Push(new StackBasket { Operation = 2, Count = i, Name = dataGridView1[0, i].Value.ToString(), Cost = float.Parse(dataGridView1[1, i].Value.ToString()), Num = int.Parse(dataGridView1[2, i].Value.ToString()), Discount = int.Parse(dataGridView1[3, i].Value.ToString()) });
            Sum -= float.Parse(dataGridView1[4, i].Value.ToString()) * (100 - dis) / 100;
            count--;
            BasketCostBox.Text = Sum.ToString();
            dataGridView1.Rows.RemoveAt(i);
        }

        private void Change_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            ChangeNumBox.Text = dataGridView1[2, i].Value.ToString();
        }

        private void ChangeNumber_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Text)
            {
                case ">":
                    ChangeNumBox.Text = (int.Parse(ChangeNumBox.Text) + 1).ToString();
                    break;
                case "<":
                    ChangeNumBox.Text = (int.Parse(ChangeNumBox.Text) - 1).ToString();
                    break;
            }
        }

        private void ChangeNumberM()
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            int delta = int.Parse(ChangeNumBox.Text) - int.Parse(dataGridView1[2, i].Value.ToString());
            StackLine.Push(new StackBasket { Operation = 3, Count = i, NumChange = delta });
            dataGridView1[2, i].Value = ChangeNumBox.Text;
            ChangeNumBox.Clear();
            dataGridView1[4, i].Value = (float.Parse(dataGridView1[4, i].Value.ToString()) + (delta * (100 - int.Parse(dataGridView1[3, i].Value.ToString())) / 100 * float.Parse(dataGridView1[1, i].Value.ToString()))).ToString();
            Sum += delta * (100 - int.Parse(dataGridView1[3, i].Value.ToString())) / 100 * float.Parse(dataGridView1[1, i].Value.ToString());
            BasketCostBox.Text = Sum.ToString();
        }
        private void ChangeNumberM(bool redo, int countf, int numchangef)
        {
            int i = countf;
            int delta = numchangef;
            if (redo) StackLine.Push(new StackBasket { Operation = 3, Count = i, NumChange = delta });
            dataGridView1[2, i].Value = int.Parse(dataGridView1[2, i].Value.ToString()) + delta;
            dataGridView1[4, i].Value = (float.Parse(dataGridView1[4, i].Value.ToString()) + (delta * (100 - int.Parse(dataGridView1[3, i].Value.ToString())) / 100 * float.Parse(dataGridView1[1, i].Value.ToString()))).ToString();
            Sum += delta * (100 - int.Parse(dataGridView1[3, i].Value.ToString())) / 100 * float.Parse(dataGridView1[1, i].Value.ToString());
            BasketCostBox.Text = Sum.ToString();
        }

        private void DiscountM()
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            StackLine.Push(new StackBasket { Operation = 4, Count = i, Discount = int.Parse(CouponeBox.Text) });
            dataGridView1[3, i].Value = int.Parse(dataGridView1[3, i].Value.ToString()) + int.Parse(CouponeBox.Text);
            dataGridView1[4, i].Value = float.Parse(dataGridView1[1, i].Value.ToString()) * int.Parse(dataGridView1[2, i].Value.ToString()) * (100 - int.Parse(dataGridView1[3, i].Value.ToString())) / 100;
            Sum -= (float.Parse(dataGridView1[1, i].Value.ToString()) * int.Parse(dataGridView1[2, i].Value.ToString()) * (int.Parse(CouponeBox.Text) )/ 100 * ((100 - dis) / 100)) ;
            BasketCostBox.Text = Sum.ToString();
            CouponeBox.Clear();
        }

        private void DiscountM(bool redo, int countf, int discountf)
        {
            int i = countf;
            if (redo) StackLine.Push(new StackBasket { Operation = 4, Count = i, Discount = discountf });
            dataGridView1[3, i].Value = int.Parse(dataGridView1[3, i].Value.ToString()) + discountf;
            dataGridView1[4, i].Value = float.Parse(dataGridView1[1, i].Value.ToString()) * int.Parse(dataGridView1[2, i].Value.ToString()) * (100 - int.Parse(dataGridView1[3, i].Value.ToString())) / 100;
            Sum -= (float.Parse(dataGridView1[1, i].Value.ToString()) * int.Parse(dataGridView1[2, i].Value.ToString()) * (discountf) / 100 * ((100 - dis) / 100));
            BasketCostBox.Text = Sum.ToString();
            CouponeBox.Clear();
        }

        private void BasketDiscountM()
        {
            dis = int.Parse(CouponeBox.Text);
            StackLine.Push(new StackBasket { Operation = 5, Discount = dis });            
            for (int i = 0; i < count; i++)
            {               
                Sum -= float.Parse(dataGridView1[4, i].Value.ToString()) * dis / 100;                
            }
            BasketCostBox.Text = Sum.ToString();
            BasketDiscountBox.Text = dis.ToString();
            CouponeBox.Clear();
        }

        private void BasketDiscountM(bool redo, int Discountf)
        {
            dis = int.Parse(BasketDiscountBox.Text.ToString())+ Discountf;
            if (redo) StackLine.Push(new StackBasket { Operation = 5, Discount = Discountf });
            for (int i = 0; i < count; i++)
            {               
                Sum -= float.Parse(dataGridView1[4, i].Value.ToString()) * Discountf / 100;                
            }
            BasketCostBox.Text = Sum.ToString();
            BasketDiscountBox.Text = dis.ToString();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            bool redo = true;
            StackBasket Check = StackLine.Peek();
            switch (Check.Operation)
            {
                case 1:
                    ChangeNumberM(redo, Check.Count, Check.NumChange);
                    break;
                case 2:
                    DelM(redo, Check.Count);
                    break;
                case 3:
                    ChangeNumberM(redo, Check.Count, Check.NumChange);
                    break;
                case 4:
                    DiscountM(redo, Check.Count, Check.Discount);
                    break;
                case 5:
                    BasketDiscountM(redo, Check.Discount);
                    break;
                default:
                    break;
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            bool redo = false;
            StackBasket Check = StackLine.Pop();
            switch (Check.Operation)
            {
                case 1:
                    DelM(redo, Check.Count);
                    break;
                case 2:
                    AddM(Check.Count, Check.Name, Check.Cost, Check.Num);
                    break;
                case 3:
                    ChangeNumberM(redo, Check.Count, -Check.NumChange);
                    break;
                case 4:
                    DiscountM(redo, Check.Count, -Check.Discount);
                    break;
                case 5:
                    BasketDiscountM(redo , -Check.Discount);
                    break;
                default:
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            ChangeNumBox.Text = dataGridView1[i, 2].ToString();
        }

        private void Numerous_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void BasketDiscount_Click(object sender, EventArgs e)
        {
            BasketDiscountM();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            DelM();
        }

        private void ChangeNumber_Click_1(object sender, EventArgs e)
        {
            ChangeNumberM();
        }

        private void Discount_Click(object sender, EventArgs e)
        {
            DiscountM();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddM();
        }

        private void Cheque_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, this.dataGridView1.Width + 100, this.dataGridView1.Height + 100));
            e.Graphics.DrawImage(bmp,10,10);
        }
    }
}
