using System;
using System.Collections.Generic;
using System.Windows.Forms;
using genetic_algorithm.Classes;

namespace genetic_algorithm
{
    public partial class Form1 : Form
    {
        public List<int> l__i__key; // Список значений, которые загадали



        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            l__i__key = new List<int>(); // Установить cписок значений, которые загадали


            //
            // Указать значения
            //
            l__i__key.Add(1);
            l__i__key.Add(0);
            l__i__key.Add(0);
            l__i__key.Add(1);
            l__i__key.Add(0);
            l__i__key.Add(1);


            string s__key = ""; // Загаданное значение в строковом представлении

            //
            // Сформировать строку загаданного значения
            //
            foreach (int i__item in l__i__key)
            {
                s__key += i__item.ToString();
            }

            txt_key.Text = s__key; // Вывести загаданное значение на форму
        }



        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //
            // Очистить графики от старых значений
            //
            chrt_avg_weight.Series["Avg"].Points.Clear();
            chrt_max_weight.Series["Max"].Points.Clear();


            string s__result = "";               // Результат работы генетического алгоритма                             

            c__population.l__i__key = l__i__key; // Установить в популяции искомые значения


            c__population pop__population = new c__population();


            //
            // Выполнить итерации генетического алгоритма
            //
            for (int i__1 = 0; i__1 < 10; i__1++)
            {
                //
                // Добваить значение среднего веса на график
                //
                chrt_avg_weight.Series["Avg"].Points.AddXY(i__1, pop__population.get_avg_weight());

                //
                // Добваить значение максимального вес на график
                //
                chrt_max_weight.Series["Max"].Points.AddXY(i__1, pop__population.get_best_individual().get_adeptness());


                pop__population.make_cycle(); // Выполнить жизненный цикл
            }


            //
            // Сформировать строку результата
            //
            foreach (int i__item in pop__population.get_best_individual().get_params())
            {
                s__result += i__item.ToString(); // Добавить к строке очередной параметр
            }


            txt_result.Text = s__result; // Вывести результат на форму
        }
    }
}
