using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/**
 * Классы генетического алгоритма
 */
namespace genetic_algorithm.Classes
{
    /**
     * Класс популяции
     */
    class c__population
    {

        private List<c__individual> l__individual;    // Список особей в популяции
        private int                 i__individ_count; // Количество особей в популяции 
        private Random              rnd__random;      // Генератор случайных чисел


        public static List<int> l__i__key; // Загаданное значение, которое алгоритм пытается отыскать    



        /**
         * Конструктор
         */
        public c__population()
        {
            l__individual = new List<c__individual>(); // Установить список особей
            rnd__random   = new Random();              // Установить генератор случайных чисел

            i__individ_count = 10; // Установить количество особей в популяции (только четное число)


            //
            // Установить список с вохдными параметрами для создания новой особи
            //        
            List<int> l__i__params = new List<int>(); 


            //
            // Добавить в список особей установленное количество (i__individ_count) особей
            //
            for (int i__1 = 0; i__1 < i__individ_count; i__1++)
            {
                //
                // Заполнить список с входными параметрами
                // (состоит из шести параметров)
                //
                for (int i__2 = 0; i__2 < 6; i__2++)
                {
                    l__i__params.Add(rnd__random.Next(0, 2)); // Добавить в список 0 или 1
                }
                

                l__individual.Add(new c__individual(l__i__params, rnd__random)); // Добавить особь

                l__i__params.Clear(); // Очистить список параметров
            }           
        }



        /**
         * Отбоор
         * 
         * Из популяции удаляются "слабые" особи
         */
        private void selection()
        {
            //
            // Отсортировать список особей по силе (по убыванию)
            //
            l__individual = l__individual.OrderByDescending(o => o.get_adeptness()).ToList();

            //
            // Уменьшить популяцию вдвое, оставив только самых лучших
            //
            l__individual.RemoveRange
                (
                    (int)Math.Round((double)l__individual.Count / 2),
                    (int)Math.Round((double)l__individual.Count / 2)
                );
        }



        /**
         * Скрещивание 
         * 
         * Расширить популяцию в два раза путем скрещивания особей
         */
        private void start_crossing()
        {
            int i__mom_selector; // Индекс индивида в популяции (первый родитель)
            int i__dad_selector; // Индекс индивида в популяции (второй родитель)


            //
            // Создать новых особей (удвоить популяцию)
            //
            for (int i__1 = 0; i__1 < Math.Round((double)i__individ_count / 2); i__1++)
            {
                //
                // Если индексы родителей одинаковы, то перевыбрать индексы
                // Нужны разные особи для скрещивания
                //
                do
                {
                    i__dad_selector = rnd__random.Next(0, i__individ_count); // Выбрать случайного родителя
                    i__mom_selector = rnd__random.Next(0, i__individ_count); // Выбрать случайного родителя                
                }
                while (i__dad_selector == i__mom_selector);

                //
                // Создать пару новых особей
                //
                l__individual.Add(l__individual[i__dad_selector].crossing(l__individual[i__mom_selector]));
                l__individual.Add(l__individual[i__mom_selector].crossing(l__individual[i__dad_selector]));
            }
        }



        /**
         * Мутация
         * 
         * Подвергнуть некоторых особей мутации (случайно изменить их параметры)
         */
        private void start_mutation()
        {
            int i__individ_selector; // Индекс индивида в популяции (для мутации)


            //
            // Некоторое количество раз (размер популяции / 10) вызвать мутацию 
            // (особь может быть подвергнута нескольким мутациям)
            //
            for (int i__1 = 0; i__1 < Math.Round((double)i__individ_count / 10); i__1++)
            {
                i__individ_selector = rnd__random.Next(0, i__individ_count * 2); // Выбрать случайное число 

                l__individual[i__individ_selector].mutation(); // Вызвать у особи мутацию
            }
        }



        /**
         * Выполнить цикл жизни популяции
         */
        public void make_cycle()
        {
            start_crossing(); // Выполнить скрещивание
            start_mutation(); // Выполнить мутацию
            selection();      // Выполнить селекцию
        }



        /**
         * Получить лучшую особь
         * 
         * @return  c__individual  Лучшая особь
         */
        public c__individual get_best_individual()
        {
            return l__individual.First(); // Вернуть первую особь в популяции
        }



        /**
         * Получить средний вес особей в популяции
         * 
         * @return  int  Средний вес
         */
        public int get_avg_weight()
        {
            int i__sum_weight = 0; // Сумма весов п популяции

            foreach (c__individual ind__item in l__individual)
            {
                i__sum_weight += ind__item.get_adeptness(); // Прибавить вес
            }

            return (int)Math.Round(i__sum_weight / (double)i__individ_count); // Вернуть значение среднего веса
        }
    }




    /**
     * Класс особи
     */
    class c__individual
    {

        private int       i__adeptness; // Показатель силы особи в популяции
        private List<int> l__params;    // Список параметров
        private Random    rnd__random;  // Генератор случайных чисел 



        /**
         * Конструктор
         * 
         * @param  List<int>  l__i__param        Список параметров        
         * @param  Random     rnd__input_random  Генератор случайных чисел
         */
        public c__individual (List<int> l__i__param, Random rnd__input_random)
        {
            l__params = new List<int>(); // Устанавливаем входное значение


            foreach (var item in l__i__param)
            {
                l__params.Add(item);
            }

            rnd__random = rnd__input_random; // Установить генератор случайных чисел

            calculate_adeptness(); // Вычислить силу особи                        
        }



        /**
         * Мутация особи
         * 
         * Изменить случайное количество случайных параметров
         * (от одного до трех параметров)
         */
        public void mutation()
        {
            int i__mutation_index; // Индекс параметра который изменится

            //
            // Изменить случайное количество случайных параметров
            //
            for (int i__1 = 0; i__1 < rnd__random.Next(1, 4); i__1++)
            {
                i__mutation_index = rnd__random.Next(0, 6); // Задать случайный индекс параметра

                //
                // Изменяем значение выбранного параметра
                // 
                if (l__params[i__mutation_index] == 0)
                {
                    l__params[i__mutation_index] = 1; // Изменить паранметр на 1
                }
                else
                {
                    l__params[i__mutation_index] = 0; // Изменить паранметр на 0
                }
            }

            calculate_adeptness(); // Вычислить силу особи
        }



        /**
         * Скрещивание особи
         * 
         * @param  c__individual  ind__second_parent  Особь с которой произойдет скрещивание
         * 
         * @return  c__individual  Новая особь
         */
        public c__individual crossing(c__individual ind__second_parent)
        {
            List<int> l__input_params = new List<int>(); // Параметры для новой особи

            
            //
            // Первая половина параметров от первого родителя
            //            
            l__input_params.AddRange(l__params.GetRange(0, 3));

            //
            // Вторая половина параметров от второго родителя
            //            
            l__input_params.AddRange(ind__second_parent.l__params.GetRange(3, 3));


            return new c__individual(l__input_params, rnd__random);                       
        }



       /**
        * Получить показатель силы
        * 
        * @return  int  Показатель силы особи
        */
       public int get_adeptness()
        {
            return i__adeptness;
        }



        /**
         * Вычислить силу особи
         */
        private void calculate_adeptness()
        {
            i__adeptness = 0; // Обнулить значение силы


            //
            // Проверить особь на совпадение с загаданной последовательностью
            //
            for (int i__1 = 0; i__1 < 6; i__1++)
            {
                //
                // Если значения совпадают, то увеличить силу особи
                //
                if (l__params[i__1] == c__population.l__i__key[i__1])
                {
                    i__adeptness++;
                }
            }
        }



        /**
         * Получить список параметров
         * 
         * @return  List<int>  Список параметров особи
         */
        public List<int> get_params()
        {
            return l__params;
        }
    }
}