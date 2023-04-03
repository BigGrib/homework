 string []slova_spisok= new string [k];  //массив списка слов с повторами
            int []kolvo =new int [k];                  //кол-во повторов слова
 
....там она сравнивает слова и их записывает во временную переменную
 
if (slova[i] != null) //это чтоб не пополнять массив лишними словами
                {
                    slova_spisok[i] = slova[i];
                    kolvo[i] = tempsl; //занесение временной переменной с подсчетом слов в массив
 
                    Console.WriteLine("Слово {0} было использовано {1}", slova[i], tempsl); //это она пишет столько раз.
                    tempsl = 0;
                    slova[i] = null;
 
                 }
            }
            foreach (string sl in slova_spisok)
            { if (sl!=null)
                Console.WriteLine(sl);
            }
 //это выведу массив колво на пробу
 foreach (int kol in kolvo)
                    {
                        Console.WriteLine(kol); 
                    }
            //это у меня получилось 2 массива, теперь их надо слить в один
            //теперь надо их слить в один
 
           string [,] obchak =new string[k,3];
           
               for (int a = 0; a < k; a++)
               {
                   obchak[a, 1] = slova_spisok[a];
                   
                   obchak[a, 2] = Convert.ToString(kolvo[a]);
              
               }
                                          
            foreach (string obch in obchak)
           {
                if(obch!=null & obch!="0")
               Console.WriteLine ("  "+obch);
                
           }