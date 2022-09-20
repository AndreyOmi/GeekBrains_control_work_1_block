/*
Итоговая контрольная работа по первому блоку обучения 
Исполнитель: Омельченко А.В.
*/

// Определение функции для печати массива строк

void print_array_strings(string[] Input_Array)
   {
    foreach(string element in Input_Array)
          {
           Console.Write(element);
           Console.Write(" ");
          }
   }

// Конец области определения функций

int Goal_words_counter = 0;

Console.Write("Введите массив слов через пробел: ");

string Variables_str = Console.ReadLine();  

string[] words = Variables_str.Split(' ');

/*
Чтобы не использовать модуль коллекций с динамическими массивами
на первом этапе проводится подсчет числа слов, состоящих из трех 
или меньшего числа знаков.
*/

foreach(string word in words)
      {
       if(word.Length <= 3)
        Goal_words_counter++;
      }

if(Goal_words_counter == 0)
 {
  Console.WriteLine();
  Console.WriteLine("Исходный массив не содержит строк, длина которых меньше или равна трём символам!");
 } else 
      {
       /*
        На втором этапе значение количества слов, состоящих из трех 
        или меньшего числа знаков, используется для инициализации
        обычного статического массива слов, который заполняется
        указанными словами.
       */
       
       string[] Goal_words = new string[Goal_words_counter]; 

       int Goal_words_index = 0;

       foreach(string word in words)
             {
              if(word.Length <= 3)
               {
                Goal_words[Goal_words_index] = word;
                Goal_words_index++;
               }
             }

       Console.WriteLine();
       Console.Write("Исходный массив содержит следующие строки, длина которых меньше или равна трём символам: ");
       print_array_strings(Goal_words);
      }